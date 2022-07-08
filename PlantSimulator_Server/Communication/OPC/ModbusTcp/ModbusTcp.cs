using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using PlantSimulator.Communication.OPC.Forms;
using PlantSimulator_Server;
using PlantSimulatorServer;

namespace PlantSimulatorServer
{
    public class ModbusTcp
    {
        public static void Bt_Connect()
        {
            try
            {
                dispositive = new ModbusClient(FormOPC.IPModbus, FormOPC.PortModBus);
                //dispositive = new ModbusClient("192.168.25.10", 502); //IP e Porta
                dispositive.Connect();
            }
            catch
            {
                MessageBox.Show("TimeOut! Não foi possivel estabelecer conexão com dispositivo PLC, favor checar os parâmetros.");
                throw;
            }
        }
        public static void Bt_Disconnect()
        {
            dispositive.Disconnect();
        }

        public static void read()
        {
            int[] vals = dispositive.ReadInputRegisters(FormOPC.HoldingResgisterInit, 4);
            //int[] vals = dispositive.ReadInputRegisters(0, 4);

            ushort u1 = (ushort)vals[0];
            ushort u2 = (ushort)vals[1];
            ushort u3 = (ushort)vals[2];
            ushort u4 = (ushort)vals[3];

            ushort int1, int2, int3, int4;

            int1 = u1;
            int2 = u2;
            int3 = u3;
            int4 = u4;

            byte[] intBytes1 = BitConverter.GetBytes(int1);
            if (BitConverter.IsLittleEndian) Array.Reverse(intBytes1);
            byte[] result1 = intBytes1;
            byte[] intBytes2 = BitConverter.GetBytes(int2);
            if (BitConverter.IsLittleEndian) Array.Reverse(intBytes2);
            byte[] result2 = intBytes2;
            byte[] intBytes3 = BitConverter.GetBytes(int3);
            if (BitConverter.IsLittleEndian) Array.Reverse(intBytes3);
            byte[] result3 = intBytes3;
            byte[] intBytes4 = BitConverter.GetBytes(int4);
            if (BitConverter.IsLittleEndian) Array.Reverse(intBytes4);
            byte[] result4 = intBytes4;

            byte[] _bytes = new byte[8];
            _bytes[0] = intBytes4[1];
            _bytes[1] = intBytes4[0];
            _bytes[2] = intBytes3[1];
            _bytes[3] = intBytes3[0];
            _bytes[4] = intBytes2[1];
            _bytes[5] = intBytes2[0];
            _bytes[6] = intBytes1[1];
            _bytes[7] = intBytes1[0];
            long l_val = BitConverter.ToInt64(_bytes, 0);

            double _val = BitConverter.Int64BitsToDouble(l_val);

            PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantDischargeValve.Input.Value = _val;

        }

        public static void write()
        {
            double value = PlantSimulatorServer.PlantSimulatorNodeManager.m_Plant1.PlantSimulatorServerS.PlantLevelIndicator.Output.Value;
            byte[] array = BitConverter.GetBytes(value);
            Array.Reverse(array);

            byte[] intBytes1 = new byte[2];
            intBytes1[0] = array[7];
            intBytes1[1] = array[6];
            byte[] intBytes2 = new byte[2];
            intBytes2[0] = array[5];
            intBytes2[1] = array[4];
            byte[] intBytes3 = new byte[2];
            intBytes3[0] = array[3];
            intBytes3[1] = array[2];
            byte[] intBytes4 = new byte[2];
            intBytes4[0] = array[1];
            intBytes4[1] = array[0];

            int[] saida = new int[4];

            saida[3] = BitConverter.ToInt16(intBytes1, 0);
            saida[2] = BitConverter.ToInt16(intBytes2, 0);
            saida[1] = BitConverter.ToInt16(intBytes3, 0);
            saida[0] = BitConverter.ToInt16(intBytes4, 0);

            int[] saida2 = new int[4];
            saida2[3] = Convert.ToInt32(saida[0]);
            saida2[2] = Convert.ToInt32(saida[1]);
            saida2[1] = Convert.ToInt32(saida[2]);
            saida2[0] = Convert.ToInt32(saida[3]);

            dispositive.WriteMultipleRegisters(FormOPC.InputRegisterInit, saida2);
            //dispositive.WriteMultipleRegisters(0, saida2);
        }

        public static ModbusClient dispositive;
    }
}
