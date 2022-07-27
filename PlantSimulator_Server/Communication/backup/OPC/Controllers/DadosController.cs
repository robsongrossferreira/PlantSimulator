using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlantSimulator.Communication.OPC.Models;
using PlantSimulator_Server;
using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using static PlantSimulator.Communication.OPC.App_Start_OPC.OPCApiConfig;
using static PlantSimulator.Communication.OPC.App_Start_OPC.PlantSimulatorServerNodeManager;

namespace PlantSimulator.Communication.OPC.Controllers
{
    class DadosController
    {
        private static Dados data = new Dados();

        public string Get(string id)
        {

            MonitoraConexao.ReceiveFlow();

            if (id == "input") return data.Input.ToString();

            if (id == "output") return Sistema.saida.ToString();

            else return null;
        }


        public void Post(string input)
        {
            MonitoraConexao.SendFlow();

            data.RecebeDados(input);

            m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value = Sistema.saidaTemp;

            //data.Output = Sistema.Resposta.MalhaAberta(data.Input);

        }
    }
}
