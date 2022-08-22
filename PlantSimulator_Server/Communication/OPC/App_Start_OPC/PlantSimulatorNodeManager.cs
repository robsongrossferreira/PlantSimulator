using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PlantSimulator_Server;
using PlantSimulator;
using System.Threading;
using System.Diagnostics;

namespace PlantSimulatorServer
{
    class PlantSimulatorNodeManager : CustomNodeManager2
    {
        public PlantSimulatorNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        :
       base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;

            // set one namespace for the type model and one names for dynamically created nodes.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = PlantSimulatorServer.Namespaces.PlantSimulatorServer;
            namespaceUrls[1] = PlantSimulatorServer.Namespaces.PlantSimulatorServer + "/Instance";
            SetNamespaces(namespaceUrls);

            // get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<PlantSimulatorServerConfiguration>();

            // use suitable defaults if no configuration exists.
            if (m_configuration == null)
            {
                m_configuration = new PlantSimulatorServerConfiguration();
            }
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                 "PlantSimulatorServer.PredefinedNodes.uanodes",
                typeof(PlantSimulatorNodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                // find the untyped Batch Plant 1 node that was created when the model was loaded.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(PlantSimulatorServer.Objects.PlantSimulatorServer1, NamespaceIndexes[0]), typeof(BaseObjectState));

                // convert the untyped node to a typed node that can be manipulated within the server.
                m_Plant1 = new PlantSimulatorServer1State(null);
                m_Plant1.Create(SystemContext, passiveNode);

                // replaces the untyped predefined nodes with their strongly typed versions.
                AddPredefinedNode(SystemContext, m_Plant1);

                m_Plant1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                m_Plant1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);

                //m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 100, 100);

            }
        }
        //public void DoSimulation(object state)
        //{
            //if (Sistema.saida != m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value)
            //{
                //m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value = Sistema.saida;
                //MonitoraConexao.SendFlow();
            //}
            //if (Sistema.entrada != m_Plant1.PlantSimulatorServerS.PlantDischargeValve.Input.Value)
            //{
                //Sistema.entrada = m_Plant1.PlantSimulatorServerS.PlantDischargeValve.Input.Value;
                //MonitoraConexao.ReceiveFlow();
            //}
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

        public PlantSimulatorServerConfiguration m_configuration;
        public static PlantSimulatorServer1State m_Plant1;
        //public System.Threading.Timer m_simulationTimer;
    }
}
