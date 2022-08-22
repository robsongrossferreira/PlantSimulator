using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using System.Windows.Forms;
using System.Reflection;
using PlantSimulator_Server;
using PlantSimulatorServer;
using PlantSimulator.Communication.OPC.Forms;

namespace PlantSimulatorServer
{
    class OPCServer
    {
        public static bool StatusConnection = false;

        public static ApplicationInstance application = new ApplicationInstance();

        public static bool Start()
        {
            try
            {
                StatusConnection = true;
                application.ApplicationType = ApplicationType.Server;
                application.ConfigSectionName = "PlantSimulatorServer";
                if (application.ProcessCommandLine())
                {
                    //return;
                    return StatusConnection;
                }

                // verifica se está rodando como um serviço.
                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new PlantSimulatorServerOpc());
                    //return;
                    return StatusConnection;
                }

                // carrega a configuração do aplicativo.
                application.LoadApplicationConfiguration("PlantSimulator_Server.Config.xml", false).Wait();

                // verifica o certificado do aplicativo.
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // inicia o servidor.
                application.Start(new PlantSimulatorServerOpc()).Wait();
                StatusConnection = true;
                //PlantSimulatorServer.Codesys_NetVars.NetConnect();
                if (FormOPC.HabilityModBus == true)
                {
                    PlantSimulatorServer.ModbusTcp.Bt_Connect();
                }
                return StatusConnection;             
            }
            catch (Exception e)
            {
                StatusConnection = false;
                string text = "Exception: " + e.Message;
                if (e.InnerException != null)
                {
                    text += "\r\nInner exception: ";
                    text += e.InnerException.Message;
                }
                return StatusConnection;
            }
        }

        public static bool Stop()
        {
            try
            {  
                if (StatusConnection == true)
                {
                    PlantSimulatorServer.ModbusTcp.Bt_Disconnect();
                    application.Stop();
                    StatusConnection = false;
                }
                return !StatusConnection;
            }
            catch
            {
                StatusConnection = true;
                return !StatusConnection;
            }

        }

    }
}