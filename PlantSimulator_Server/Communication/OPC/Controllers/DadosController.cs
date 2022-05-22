using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantSimulator_Server;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using PlantSimulatorServer;
using PlantSimulator;

//using static PlantSimulatorNodeManager;

namespace PlantSimulatorServer
{
    class DadosController
    {
        public static Dados data = new Dados();

        public string Get(string id)
        {

            MonitoraConexao.ReceiveFlow();

            if (id == "input") return data.Input.ToString();

            if (id == "output")
            {
                PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value = 85;
                return Sistema.saida.ToString();

            }

            else return null;
        }


        public void Post(string input)
        {
            MonitoraConexao.SendFlow();
            input = "1";
            data.RecebeDados(input);

            //PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value = Sistema.saida;
            //Sistema.entrada = PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantDischargeValve.Input.Value; //comentado para testes
            //data.Output = Sistema.Resposta.MalhaAberta(data.Input);
            //Sistema.entrada = 2; //escrito para testes

        }
        
        //public PlantSimulatorServer1State m_Plant2;
    }
}
