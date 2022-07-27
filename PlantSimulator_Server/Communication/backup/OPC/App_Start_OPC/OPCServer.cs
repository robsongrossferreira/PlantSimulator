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
using static PlantSimulator.Communication.OPC.App_Start_OPC.OPCApiConfig;
using PlantSimulator_Server;

namespace PlantSimulator.Communication.OPC.App_Start_OPC
{

    class PlantSimulatorServerNodeManager : CustomNodeManager2
    {
        public PlantSimulatorServerNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        :
       base(server, configuration)//23
        {//24
            SystemContext.NodeIdFactory = this;//25

            // defina um namespace para o modelo de tipo e um nome para nós criados dinamicamente.
            string[] namespaceUrls = new string[2];//26
            namespaceUrls[0] = PlantSimulatorServer.Namespaces.PlantSimulatorServer;//27
            namespaceUrls[1] = PlantSimulatorServer.Namespaces.PlantSimulatorServer + "/Instance";//28
            SetNamespaces(namespaceUrls);//29

            // obtenha a configuração para o gerenciador de nós.
            m_configuration = configuration.ParseExtension<PlantSimulatorServerConfiguration>();//30

            // use padrões adequados se não houver configuração.
            if (m_configuration == null)//31
            {//32
                m_configuration = new PlantSimulatorServerConfiguration();//33
            }//40
        }//41

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "C:/Users/robso/source/repos/PlantSimulator-main/PlantSimulator_Server/Communication/OPC/App_Start_OPC/PlantSimulatorServer.PredefinedNodes.uanodes",
                typeof(PlantSimulatorServerNodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {//44
            lock (Lock)//45
            {//46
                LoadPredefinedNodes(SystemContext, externalReferences);//47

                // encontre o nó Plant Simulator Server 1 não tipado que foi criado quando o modelo foi carregado.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1, NamespaceIndexes[0]), typeof(BaseObjectState));

                // converte o nó não tipado em um nó tipado que pode ser manipulado dentro do servidor.
                m_Plant1 = new PlantSimulatorServer.PlantSimulatorServer1State(null);
                m_Plant1.Create(SystemContext, passiveNode);

                // substitui os nós predefinidos não tipados por suas versões fortemente tipadas.
                AddPredefinedNode(SystemContext, m_Plant1);

                m_Plant1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                m_Plant1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);

                //m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);

            }
        }

        //public void DoSimulation(object state)
        //{
            //m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value = Sistema.saidaTemp;
            //Sistema.entrada = m_Plant1.PlantSimulatorServerS.PlantDischargeValve.Input.Value;
        //}

        private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputArguments,
    IList<object> outputArguments)
        {

            return ServiceResult.Good;
        }

        private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputArguments,
IList<object> outputArguments)
        {

            return ServiceResult.Good;
        }

        private PlantSimulatorServerConfiguration m_configuration;
        public static PlantSimulatorServer.PlantSimulatorServer1State m_Plant1;
        private System.Threading.Timer m_simulationTimer;

    }

    class PlantSimulatorServer1 : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {//19
            Utils.Trace("Creating the Node Managers.");//20

            List<INodeManager> nodeManagers = new List<INodeManager>();//21

            // cria os gerenciadores de nós customizados.
            nodeManagers.Add(new PlantSimulatorServerNodeManager(server, configuration));//22

            // cria gerenciador de nó mestre.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());//42
        }//43

        protected override ServerProperties LoadServerProperties()
        {//9
            ServerProperties properties = new ServerProperties();//10

            properties.ManufacturerName = "UCL - Faculdade do Centro Leste";//11
            properties.ProductName = "PlantSimulatorServer InformationModel Server";//12
            properties.ProductUri = "http://opcfoundation.org/PlantSimulator_Server/InformationModelServer/v1.0";//13
            properties.SoftwareVersion = Utils.GetAssemblySoftwareVersion();//14
            properties.BuildNumber = Utils.GetAssemblyBuildNumber();//15
            properties.BuildDate = Utils.GetAssemblyTimestamp();//16

            // TBD - Todos os aplicativos possuem certificados de software que precisam ser adicionados às propriedades.

            return properties;//17
        }//18
    }
    class OPCServer
    {
        public static bool StatusConnection = false;

        public static ApplicationInstance application = new ApplicationInstance(); //1 antes de start

        public static bool Start()
        {
            try
            {
                StatusConnection = true;
                application.ApplicationType = ApplicationType.Server; //2 depois de start daqui em diante
                application.ConfigSectionName = "PlantSimulatorServer";//3
                if (application.ProcessCommandLine())//4
                {
                    //return;
                    return StatusConnection;
                }

                // verifica se está rodando como um serviço.
                if (!Environment.UserInteractive)//5
                {
                    application.StartAsService(new PlantSimulatorServer1());
                    //return;
                    return StatusConnection;
                }

                // carrega a configuração do aplicativo.
                application.LoadApplicationConfiguration("C:/Users/robso/source/repos/PlantSimulator-main/PlantSimulator_Server/Communication/OPC/App_Start_OPC/PlantSimulator_Server.Config.xml", false).Wait();//6

                // verifica o certificado do aplicativo.
                application.CheckApplicationInstanceCertificate(false, 0).Wait();//7

                // inicia o servidor.
                application.Start(new PlantSimulatorServer1()).Wait();//8
                StatusConnection = true;
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
                    // para o servidor.
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