using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodesysNetVars;
using PlantSimulator_Server;
using PlantSimulatorServer;
using System.Runtime;
using System.Windows.Forms;

namespace PlantSimulatorServer
{
    class Codesys_NetVars
    {
        public static void NetRead()
        {
            SRCodesysNetVars SRCodesysNetVars = new SRCodesysNetVars();

            SRCodesysNetVars.CobID = 2;

            SRCodesysNetVars.IPAdress = "192.168.25.10";

            SRCodesysNetVars.Port = 1213;

            //codesys.CobID = 2;

            //codesys.IPAdress = "192.168.25.20";

            //codesys.Port = 1217;

            SRCodesysNetVars.dataTypeCollection.Add(new CDataTypeCollection(DataTypes.realtype));
            //SRCodesysNetVars.dataTypeCollection.Add(new CDataTypeCollection(DataTypes.realtype));
            //codesys.dataTypeCollection.Add(new CDataTypeCollection(DataTypes.realtype));
            //codesys.dataTypeCollection.Add(new CDataTypeCollection(DataTypes.booltype));
            //codesys.dataTypeCollection.Add(new CDataTypeCollection(DataTypes.inttype));
            //codesys.dataTypeCollection.Add(new CDataTypeCollection(DataTypes.dinttype));

            try
            {
                ArrayList readValues = SRCodesysNetVars.ReadValues();
                //ArrayList readValues = codesys.ReadValues();

                readValues = SRCodesysNetVars.ReadValues();
                //readValues = codesys.ReadValues();

                //string receiver = readValues[0].ToString();
                receiver = readValues[0].ToString();

                PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantDischargeValve.Input.Value = double.Parse(receiver);

                SRCodesysNetVars.disconnect();

            } catch
            {
                DialogResult dr = MessageBox.Show("Falha ao ler a variavel em Codesys!!!");
            }
        }

        public static void NetWrite()
        {

            
            SRCodesysNetVars SRCodesysNetVars = new SRCodesysNetVars();

            SRCodesysNetVars.CobID = 2;

            SRCodesysNetVars.IPAdress = "192.168.25.10";

            //codesysR.Port = 1217;

            //codesys.CobID = 2;

            //codesys.IPAdress = "192.168.25.20";

            //SRCodesysNetVars.Port = 1217;

            
            PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value = 3.54;
            PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantDischargeValve.Input.Value = 5.83;

            CDataTypeCollection item = new CDataTypeCollection(0.123, DataTypes.realtype)
            {
                VariableName = "X",
                SendValue = PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value
            };
            SRCodesysNetVars.dataTypeCollection.Add(item);

            //SRCodesysNetVars.dataTypeCollection.Add(new CDataTypeCollection(Convert.ToDecimal(PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value), CodesysNetVars.DataTypes.realtype));
            //SRCodesysNetVars.dataTypeCollection.Add(new CDataTypeCollection(Convert.ToInt32("5"), CodesysNetVars.DataTypes.inttype));
            //SRCodesysNetVars.dataTypeCollection.Add(new CDataTypeCollection(Convert.ToInt64("2"), CodesysNetVars.DataTypes.dinttype));
            //SRCodesysNetVars.dataTypeCollection.Add(new CDataTypeCollection(Convert.ToBoolean("True"), CodesysNetVars.DataTypes.booltype));
            //codesys.dataTypeCollection.Add(new CDataTypeCollection(PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value, CodesysNetVars.DataTypes.realtype));
            //codesysW.CreateGVLFile("C:/Users/robso/source/repos/PlantSimulator-main/PlantSimulator_Server/GVLFile.GVL");
            SRCodesysNetVars.CreateGVLFile("C:\\Users\\robso\\source\\repos\\PlantSimulator-main\\PlantSimulator_Server\\GVLFile.GVL2");
            //codesys.CreateGVLFile("C:/Users/robso/source/repos/PlantSimulator-main/PlantSimulator_Server/GVLFile.GVL");
            //SRCodesysNetVars.NumberOfTags = 5;
            
                //SRCodesysNetVars.SendValues();
            try
            {
                //SRCodesysNetVars.connect();

                SRCodesysNetVars.SendValues();
                //codesys.SendValues();

                SRCodesysNetVars.disconnect();

            }
            catch
            {
                DialogResult dr = MessageBox.Show("Falha ao escrever a variavel em Codesys!!!");
            }
        }

        public static void NetConnect()
        {   
            codesys.CobID = 2;

            codesys.IPAdress = "192.168.25.10";

            codesys.Port = 1217;

            try
            {
                codesys.connect();
            }
            
            catch
            {
                DialogResult dr = MessageBox.Show("Falha ao conectar em Codesys!!!");
            }
        }

        public static SRCodesysNetVars codesys = new SRCodesysNetVars();

        //public static ArrayList readValues;

        public static string receiver;

    }
}
