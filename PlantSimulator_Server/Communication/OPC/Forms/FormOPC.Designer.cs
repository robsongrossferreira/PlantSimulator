
namespace PlantSimulator.Communication.OPC.Forms
{
    partial class FormOPC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpOpcConnection = new System.Windows.Forms.GroupBox();
            this.btnStopOpc = new System.Windows.Forms.Button();
            this.btnStartOpc = new System.Windows.Forms.Button();
            this.txtStatusConnectionOpc = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpOpcConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOpcConnection
            // 
            this.grpOpcConnection.Controls.Add(this.btnStopOpc);
            this.grpOpcConnection.Controls.Add(this.btnStartOpc);
            this.grpOpcConnection.Controls.Add(this.txtStatusConnectionOpc);
            this.grpOpcConnection.Controls.Add(this.textBox1);
            this.grpOpcConnection.Controls.Add(this.label2);
            this.grpOpcConnection.Controls.Add(this.label1);
            this.grpOpcConnection.Location = new System.Drawing.Point(4, 0);
            this.grpOpcConnection.Name = "grpOpcConnection";
            this.grpOpcConnection.Size = new System.Drawing.Size(310, 129);
            this.grpOpcConnection.TabIndex = 0;
            this.grpOpcConnection.TabStop = false;
            this.grpOpcConnection.Text = "Opc";
            // 
            // btnStopOpc
            // 
            this.btnStopOpc.Location = new System.Drawing.Point(233, 92);
            this.btnStopOpc.Name = "btnStopOpc";
            this.btnStopOpc.Size = new System.Drawing.Size(75, 23);
            this.btnStopOpc.TabIndex = 5;
            this.btnStopOpc.Text = "Stop";
            this.btnStopOpc.UseVisualStyleBackColor = true;
            this.btnStopOpc.Click += new System.EventHandler(this.btnStopOpc_Click);
            // 
            // btnStartOpc
            // 
            this.btnStartOpc.Location = new System.Drawing.Point(67, 92);
            this.btnStartOpc.Name = "btnStartOpc";
            this.btnStartOpc.Size = new System.Drawing.Size(75, 23);
            this.btnStartOpc.TabIndex = 4;
            this.btnStartOpc.Text = "Start";
            this.btnStartOpc.UseVisualStyleBackColor = true;
            this.btnStartOpc.Click += new System.EventHandler(this.btnStartOpc_Click);
            // 
            // txtStatusConnectionOpc
            // 
            this.txtStatusConnectionOpc.Location = new System.Drawing.Point(67, 54);
            this.txtStatusConnectionOpc.Name = "txtStatusConnectionOpc";
            this.txtStatusConnectionOpc.Size = new System.Drawing.Size(241, 20);
            this.txtStatusConnectionOpc.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "opc.tcp://localhost:26543/PlantSimulatorServer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server OPC UA Info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Node para escrita do Cliente Controlador: (2;15154)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Node para leitura do Cliente Controlador: (2;15146)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Input da Planta para OPC UA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Output da Planta para OPC UA";
            // 
            // FormOPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 277);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOpcConnection);
            this.Name = "FormOPC";
            this.Text = "FormOPC";
            this.grpOpcConnection.ResumeLayout(false);
            this.grpOpcConnection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOpcConnection;
        private System.Windows.Forms.Button btnStopOpc;
        private System.Windows.Forms.Button btnStartOpc;
        private System.Windows.Forms.TextBox txtStatusConnectionOpc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}