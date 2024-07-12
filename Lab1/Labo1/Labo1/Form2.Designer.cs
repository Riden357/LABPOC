namespace Labo1
{
    partial class FormPortConfiguration
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
            this.components = new System.ComponentModel.Container();
            this.lbl_PortConfiguration = new System.Windows.Forms.Label();
            this.lbl_Bps = new System.Windows.Forms.Label();
            this.lbl_Db = new System.Windows.Forms.Label();
            this.lbl_Parity = new System.Windows.Forms.Label();
            this.lbl_Sb = new System.Windows.Forms.Label();
            this.cbo_Bps = new System.Windows.Forms.ComboBox();
            this.cbo_Db = new System.Windows.Forms.ComboBox();
            this.cbo_StopBits = new System.Windows.Forms.ComboBox();
            this.cbo_Parity = new System.Windows.Forms.ComboBox();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.cbo_Ports = new System.Windows.Forms.ComboBox();
            this.btn_OpenPort = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_ClosePort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_PortConfiguration
            // 
            this.lbl_PortConfiguration.AutoSize = true;
            this.lbl_PortConfiguration.Location = new System.Drawing.Point(33, 32);
            this.lbl_PortConfiguration.Name = "lbl_PortConfiguration";
            this.lbl_PortConfiguration.Size = new System.Drawing.Size(67, 13);
            this.lbl_PortConfiguration.TabIndex = 0;
            this.lbl_PortConfiguration.Text = "Port Settings";
            // 
            // lbl_Bps
            // 
            this.lbl_Bps.AutoSize = true;
            this.lbl_Bps.Location = new System.Drawing.Point(36, 100);
            this.lbl_Bps.Name = "lbl_Bps";
            this.lbl_Bps.Size = new System.Drawing.Size(86, 13);
            this.lbl_Bps.TabIndex = 1;
            this.lbl_Bps.Text = "Bits per second: ";
            // 
            // lbl_Db
            // 
            this.lbl_Db.AutoSize = true;
            this.lbl_Db.Location = new System.Drawing.Point(39, 139);
            this.lbl_Db.Name = "lbl_Db";
            this.lbl_Db.Size = new System.Drawing.Size(52, 13);
            this.lbl_Db.TabIndex = 2;
            this.lbl_Db.Text = "Data bits:";
            // 
            // lbl_Parity
            // 
            this.lbl_Parity.AutoSize = true;
            this.lbl_Parity.Location = new System.Drawing.Point(39, 220);
            this.lbl_Parity.Name = "lbl_Parity";
            this.lbl_Parity.Size = new System.Drawing.Size(36, 13);
            this.lbl_Parity.TabIndex = 3;
            this.lbl_Parity.Text = "Parity:";
            // 
            // lbl_Sb
            // 
            this.lbl_Sb.AutoSize = true;
            this.lbl_Sb.Location = new System.Drawing.Point(39, 186);
            this.lbl_Sb.Name = "lbl_Sb";
            this.lbl_Sb.Size = new System.Drawing.Size(51, 13);
            this.lbl_Sb.TabIndex = 4;
            this.lbl_Sb.Text = "Stop bits:";
            // 
            // cbo_Bps
            // 
            this.cbo_Bps.FormattingEnabled = true;
            this.cbo_Bps.Items.AddRange(new object[] {
            "9600",
            "14400"});
            this.cbo_Bps.Location = new System.Drawing.Point(125, 100);
            this.cbo_Bps.Name = "cbo_Bps";
            this.cbo_Bps.Size = new System.Drawing.Size(121, 21);
            this.cbo_Bps.TabIndex = 7;
            this.cbo_Bps.Text = "9600";
            // 
            // cbo_Db
            // 
            this.cbo_Db.FormattingEnabled = true;
            this.cbo_Db.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.cbo_Db.Location = new System.Drawing.Point(125, 139);
            this.cbo_Db.Name = "cbo_Db";
            this.cbo_Db.Size = new System.Drawing.Size(121, 21);
            this.cbo_Db.TabIndex = 8;
            this.cbo_Db.Text = "8";
            // 
            // cbo_StopBits
            // 
            this.cbo_StopBits.FormattingEnabled = true;
            this.cbo_StopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cbo_StopBits.Location = new System.Drawing.Point(125, 186);
            this.cbo_StopBits.Name = "cbo_StopBits";
            this.cbo_StopBits.Size = new System.Drawing.Size(121, 21);
            this.cbo_StopBits.TabIndex = 9;
            this.cbo_StopBits.Text = "One";
            // 
            // cbo_Parity
            // 
            this.cbo_Parity.FormattingEnabled = true;
            this.cbo_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbo_Parity.Location = new System.Drawing.Point(125, 220);
            this.cbo_Parity.Name = "cbo_Parity";
            this.cbo_Parity.Size = new System.Drawing.Size(121, 21);
            this.cbo_Parity.TabIndex = 10;
            this.cbo_Parity.Text = "None";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Location = new System.Drawing.Point(39, 66);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(29, 13);
            this.lbl_Port.TabIndex = 12;
            this.lbl_Port.Text = "Port:";
            // 
            // cbo_Ports
            // 
            this.cbo_Ports.FormattingEnabled = true;
            this.cbo_Ports.Location = new System.Drawing.Point(125, 57);
            this.cbo_Ports.Name = "cbo_Ports";
            this.cbo_Ports.Size = new System.Drawing.Size(121, 21);
            this.cbo_Ports.TabIndex = 13;
            // 
            // btn_OpenPort
            // 
            this.btn_OpenPort.Location = new System.Drawing.Point(36, 284);
            this.btn_OpenPort.Name = "btn_OpenPort";
            this.btn_OpenPort.Size = new System.Drawing.Size(75, 23);
            this.btn_OpenPort.TabIndex = 14;
            this.btn_OpenPort.Text = "Open";
            this.btn_OpenPort.UseVisualStyleBackColor = true;
            this.btn_OpenPort.Click += new System.EventHandler(this.btn_OpenPort_Click);
            // 
            // btn_ClosePort
            // 
            this.btn_ClosePort.Location = new System.Drawing.Point(134, 283);
            this.btn_ClosePort.Name = "btn_ClosePort";
            this.btn_ClosePort.Size = new System.Drawing.Size(75, 23);
            this.btn_ClosePort.TabIndex = 15;
            this.btn_ClosePort.Text = "Close";
            this.btn_ClosePort.UseVisualStyleBackColor = true;
            this.btn_ClosePort.Click += new System.EventHandler(this.btn_ClosePort_Click);
            // 
            // FormPortConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 374);
            this.Controls.Add(this.btn_ClosePort);
            this.Controls.Add(this.btn_OpenPort);
            this.Controls.Add(this.cbo_Ports);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.cbo_Parity);
            this.Controls.Add(this.cbo_StopBits);
            this.Controls.Add(this.cbo_Db);
            this.Controls.Add(this.cbo_Bps);
            this.Controls.Add(this.lbl_Sb);
            this.Controls.Add(this.lbl_Parity);
            this.Controls.Add(this.lbl_Db);
            this.Controls.Add(this.lbl_Bps);
            this.Controls.Add(this.lbl_PortConfiguration);
            this.Name = "FormPortConfiguration";
            this.Text = "Port Configuration";
            this.Load += new System.EventHandler(this.form_PortConfiguration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PortConfiguration;
        private System.Windows.Forms.Label lbl_Bps;
        private System.Windows.Forms.Label lbl_Db;
        private System.Windows.Forms.Label lbl_Parity;
        private System.Windows.Forms.Label lbl_Sb;
        private System.Windows.Forms.ComboBox cbo_Bps;
        private System.Windows.Forms.ComboBox cbo_Db;
        private System.Windows.Forms.ComboBox cbo_StopBits;
        private System.Windows.Forms.ComboBox cbo_Parity;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.ComboBox cbo_Ports;
        private System.Windows.Forms.Button btn_OpenPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_ClosePort;
    }
}