
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtStatusConnectionOpc = new System.Windows.Forms.TextBox();
            this.btnStartOpc = new System.Windows.Forms.Button();
            this.btnStopOpc = new System.Windows.Forms.Button();
            this.grpOpcConnection.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço:";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "opc.tcp://localhost:26543/PlantSimulatorServer";
            // 
            // txtStatusConnectionOpc
            // 
            this.txtStatusConnectionOpc.Location = new System.Drawing.Point(67, 54);
            this.txtStatusConnectionOpc.Name = "txtStatusConnectionOpc";
            this.txtStatusConnectionOpc.Size = new System.Drawing.Size(241, 20);
            this.txtStatusConnectionOpc.TabIndex = 3;
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
            // FormOPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 141);
            this.Controls.Add(this.grpOpcConnection);
            this.Name = "FormOPC";
            this.Text = "FormOPC";
            this.grpOpcConnection.ResumeLayout(false);
            this.grpOpcConnection.PerformLayout();
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
    }
}