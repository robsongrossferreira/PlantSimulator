using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;
using PlantSimulator_Client;

namespace PlantSimulator.Communication.OPC
{
    class OpcClient
    {
        #region Inicia OPC
        public static int StartOpc()
        {   
            // Set Configuration Client OPC UA
            var config = new ApplicationConfiguration()
            {
                ApplicationName = "PlantSimulatorClient",
                ApplicationUri = Utils.Format(@"urn:{0}:PlantSimulatorClient", System.Net.Dns.GetHostName()),
                ApplicationType = ApplicationType.Client,
                SecurityConfiguration = new SecurityConfiguration
                {
                    // Create new Certificate for Client OPC UA
                    ApplicationCertificate = new CertificateIdentifier { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\MachineDefault", SubjectName = "PlantSimulatorClient" },
                    TrustedIssuerCertificates = new CertificateTrustList { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Certificate Authorities" },
                    TrustedPeerCertificates = new CertificateTrustList { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\UA Applications" },
                    RejectedCertificateStore = new CertificateTrustList { StoreType = @"Directory", StorePath = @"%CommonApplicationData%\OPC Foundation\CertificateStores\RejectedCertificates" },
                    AutoAcceptUntrustedCertificates = true
                },
                TransportConfigurations = new TransportConfigurationCollection(),
                TransportQuotas = new TransportQuotas { OperationTimeout = 15000 },
                ClientConfiguration = new ClientConfiguration { DefaultSessionTimeout = 60000 },
                TraceConfiguration = new TraceConfiguration()
            };

            // Trusted Certificate
            config.Validate(ApplicationType.Client).GetAwaiter().GetResult();
            if (config.SecurityConfiguration.AutoAcceptUntrustedCertificates)
            {
                config.CertificateValidator.CertificateValidation += (s, e) => { e.Accept = (e.Error.StatusCode == StatusCodes.BadCertificateUntrusted); };
            }

            var application = new ApplicationInstance
            {
                ApplicationName = "PlantSimulatorClient",
                ApplicationType = ApplicationType.Client,
                ApplicationConfiguration = config
            };

            // Check Certificate of Server OPC UA
            application.CheckApplicationInstanceCertificate(false, 2048).GetAwaiter().GetResult();
            var selectedEndpoint = CoreClientUtils.SelectEndpoint("opc.tcp://localhost:26543/PlantSimulatorServer/", useSecurity: true);
 
            try
            {
                // Session Create for Server OPC UA
                m_session = Session.Create(config, new ConfiguredEndpoint(null, selectedEndpoint, EndpointConfiguration.Create(config)), false, "", 60000, null, null).GetAwaiter().GetResult();
                return 0;
            }
            catch
            {
                // Session Close for Server OPC UA
                m_session.Dispose();
                m_session.Close();
                return -1;
            }
        }
        #endregion

        #region Ler do Servidor OPC
        public static async Task<string> getOutput(string id)
        {
            try
            {
                // Read value of Node of Server OPC UA
                DataValue Output = m_session.ReadValue("ns=2;i=15146");
                return Output.ToString();
            }
            catch
            {
                return string.Empty;
            }
        }
        #endregion

        #region Escreve no Servidor OPC
        public static async Task<string> postInput(string inputData)
        {

            // build list of attributes to read.
            WriteValueCollection nodesToWrite = new WriteValueCollection();

            // Data Info Node of Server OPC UA
            nodeToWrite = new WriteValue
            {
                NodeId = "ns=2;i=15154",
                AttributeId = Attributes.Value
            };

            //Double value for Write To Server OPC UA;
            valueO = Convert.ToDouble(inputData);

            // using the WrappedValue instead of the Value property because we know the TypeInfo.
            // this makes the assignment more efficient by avoiding reflection to determine type.
            nodeToWrite.Value.WrappedValue = valueO;

            // Add Node for Write
            nodesToWrite.Add(nodeToWrite);

            // override the diagnostic masks (other parameters are set to defaults).
            requestHeader = new RequestHeader
            {
                ReturnDiagnostics = (uint)DiagnosticsMasks.All
            };

            // read the attributes.
            results = null;
            diagnosticInfos = null;

            ResponseHeader responseHeader = m_session.Write(
                requestHeader,
                nodesToWrite,
                out results,
                out diagnosticInfos);

            ClientBase.ValidateResponse(results, nodesToWrite);
            ClientBase.ValidateDiagnosticInfos(diagnosticInfos, nodesToWrite);

            // check status.
            if (StatusCode.IsBad(results[0]))
            {
                // embed the diagnostic information in a exception.
                throw ServiceResultException.Create(results[0], 0, diagnosticInfos, responseHeader.StringTable);
            }
                
            return string.Empty;
        }
        #endregion

        #region Para a comunicação com Servidor OPC
        internal static int StopOpc()
        {
            // Session Close for Server OPC UA
            m_session.Dispose();
            m_session.Close();
            return 0;
        }
        #endregion

        #region Objetos Públicos
        
        // Session OPC UA CLient
        public static Session m_session;

        // Data Info Node of Server OPC UA
        public static WriteValue nodeToWrite;

        // Variable Double Write To Server OPC UA
        public static Double valueO;

        // For override the diagnostic masks (other parameters are set to defaults).
        public static RequestHeader requestHeader;

        // attribute for read.
        public static StatusCodeCollection results;

        // attribute for read.
        public static DiagnosticInfoCollection diagnosticInfos;

        #endregion

    }
}
