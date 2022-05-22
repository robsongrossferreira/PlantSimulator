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

            #endregion
        }

        #region Conexao Opc

        private void btnStartOpc_Click(object sender, EventArgs e)
        {
            try
            {
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
    }
}
