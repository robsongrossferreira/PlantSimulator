using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlantSimulatorServer;
using PlantSimulator_Server;

using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;

namespace PlantSimulator.Communication.OPC.Forms
{
    public partial class FormOPC : Form
    {
        public FormOPC()
        {
            InitializeComponent();
            #region Initialize FormOpc

            if (OPCServer.StatusConnection)
            {
                txtStatusConnectionOpc.Text = "SERVER ONLINE";
            }
            else
            {
                txtStatusConnectionOpc.Text = "SERVER OFFLINE";
            }

            if (chkHabilitarModBus.Checked == true)
            {
                HabilityModBus = true;
                txtIPModBus.Enabled = true;
                txtPortaModBus.Enabled = true;
                txtRegistroInicalHolding.Enabled = true;
                txtRegistroInicialInput.Enabled = true;
            }
            else
            {
                HabilityModBus = false;
                txtIPModBus.Enabled = false;
                txtPortaModBus.Enabled = false;
                txtRegistroInicalHolding.Enabled = false;
                txtRegistroInicialInput.Enabled = false;
            }

            #endregion
        }

        #region Conexao Opc

        private void btnStartOpc_Click(object sender, EventArgs e)
        {
            try
            {
                HabilityModBus = true; // para testes, remover
                if (HabilityModBus)
                {
                    //IPModbus = txtIPModBus.Text.ToString(); // ao terminar os testes, descomentar
                    //PortModBus = int.Parse(txtPortaModBus.Text); // ao terminar os testes, descomentar
                    //HoldingResgisterInit = int.Parse(txtRegistroInicalHolding.Text); // ao terminar os testes, descomentar
                    //InputRegisterInit = int.Parse(txtRegistroInicialInput.Text); // ao terminar os testes, descomentar

                    IPModbus = "192.168.25.10"; // para testes, remover
                    PortModBus = 502; // para testes, remover
                    HoldingResgisterInit = 0; // para testes, remover
                    InputRegisterInit = 0; // para testes, remover
                }
                OPCServer.Start();
                txtStatusConnectionOpc.Text = "SERVER ONLINE";
                MonitoraConexao.ActiveConnection("opc");
            }
            catch
            {
                txtStatusConnectionOpc.Text = "ERRO DE ATIVAÇÃO";
            }
        }
        private void btnStopOpc_Click(object sender, EventArgs e)
        {
            try
            {
                OPCServer.Stop();
                txtStatusConnectionOpc.Text = "SERVER OFFLINE";
                MonitoraConexao.InactiveConnection("opc");
            }
            catch
            {
                txtStatusConnectionOpc.Text = "ERRO DE DESATIVAÇÃO";
            }
        }
        #endregion

        #region Conexao Modbus
        private void chkHabilitarModBus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHabilitarModBus.Checked == true) {
                HabilityModBus = true;
                txtIPModBus.Enabled = true;
                txtPortaModBus.Enabled = true;
                txtRegistroInicalHolding.Enabled = true;
                txtRegistroInicialInput.Enabled = true;
            }
            else
            {
                HabilityModBus = false;
                txtIPModBus.Enabled = false;
                txtPortaModBus.Enabled = false;
                txtRegistroInicalHolding.Enabled = false;
                txtRegistroInicialInput.Enabled = false;
            }
        }
        public static bool HabilityModBus = false;
        public static string IPModbus;
        public static int PortModBus;
        public static int HoldingResgisterInit;
        public static int InputRegisterInit;
        #endregion
    }
}
