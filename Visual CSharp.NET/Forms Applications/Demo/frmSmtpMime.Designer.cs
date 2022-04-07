namespace Demo
{
    partial class frmSmtpMime
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
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCreateMIME = new System.Windows.Forms.Button();
            this.txtMIMEContents = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoadMIME = new System.Windows.Forms.Button();
            this.txtMIMEFile = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtLastSmtpResponse = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnViewLog = new System.Windows.Forms.Button();
            this.cbSecure = new System.Windows.Forms.CheckBox();
            this.txtLogfile = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAuthentication = new System.Windows.Forms.CheckBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.GroupBox4.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.btnCreateMIME);
            this.GroupBox4.Controls.Add(this.txtMIMEContents);
            this.GroupBox4.Controls.Add(this.label4);
            this.GroupBox4.Controls.Add(this.btnLoadMIME);
            this.GroupBox4.Controls.Add(this.txtMIMEFile);
            this.GroupBox4.Controls.Add(this.label15);
            this.GroupBox4.Controls.Add(this.btnSend);
            this.GroupBox4.Location = new System.Drawing.Point(11, 130);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(561, 239);
            this.GroupBox4.TabIndex = 1;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Message";
            // 
            // btnCreateMIME
            // 
            this.btnCreateMIME.Location = new System.Drawing.Point(481, 19);
            this.btnCreateMIME.Name = "btnCreateMIME";
            this.btnCreateMIME.Size = new System.Drawing.Size(70, 22);
            this.btnCreateMIME.TabIndex = 2;
            this.btnCreateMIME.Text = "&Create...";
            this.btnCreateMIME.Click += new System.EventHandler(this.btnCreateMIME_Click);
            // 
            // txtMIMEContents
            // 
            this.txtMIMEContents.Location = new System.Drawing.Point(110, 47);
            this.txtMIMEContents.Multiline = true;
            this.txtMIMEContents.Name = "txtMIMEContents";
            this.txtMIMEContents.ReadOnly = true;
            this.txtMIMEContents.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMIMEContents.Size = new System.Drawing.Size(441, 152);
            this.txtMIMEContents.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(22, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "MIME Co&ntent:";
            // 
            // btnLoadMIME
            // 
            this.btnLoadMIME.Location = new System.Drawing.Point(400, 19);
            this.btnLoadMIME.Name = "btnLoadMIME";
            this.btnLoadMIME.Size = new System.Drawing.Size(70, 22);
            this.btnLoadMIME.TabIndex = 1;
            this.btnLoadMIME.Text = "Loa&d...";
            this.btnLoadMIME.Click += new System.EventHandler(this.btnLoadMIME_Click);
            // 
            // txtMIMEFile
            // 
            this.txtMIMEFile.Location = new System.Drawing.Point(110, 19);
            this.txtMIMEFile.Name = "txtMIMEFile";
            this.txtMIMEFile.ReadOnly = true;
            this.txtMIMEFile.Size = new System.Drawing.Size(282, 20);
            this.txtMIMEFile.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(22, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "&MIME File:";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(110, 210);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(441, 22);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "S&end";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtLastSmtpResponse
            // 
            this.txtLastSmtpResponse.Location = new System.Drawing.Point(110, 46);
            this.txtLastSmtpResponse.Multiline = true;
            this.txtLastSmtpResponse.Name = "txtLastSmtpResponse";
            this.txtLastSmtpResponse.ReadOnly = true;
            this.txtLastSmtpResponse.Size = new System.Drawing.Size(441, 32);
            this.txtLastSmtpResponse.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(336, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "&Port:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(22, 46);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(78, 16);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Response:";
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(481, 82);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(70, 21);
            this.btnViewLog.TabIndex = 3;
            this.btnViewLog.Text = "&View";
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // cbSecure
            // 
            this.cbSecure.Location = new System.Drawing.Point(110, 44);
            this.cbSecure.Name = "cbSecure";
            this.cbSecure.Size = new System.Drawing.Size(216, 17);
            this.cbSecure.TabIndex = 2;
            this.cbSecure.Text = "Secure Mail Server (SSL/TLS)";
            this.cbSecure.CheckedChanged += new System.EventHandler(this.cbSecure_CheckedChanged);
            // 
            // txtLogfile
            // 
            this.txtLogfile.Location = new System.Drawing.Point(110, 82);
            this.txtLogfile.Name = "txtLogfile";
            this.txtLogfile.Size = new System.Drawing.Size(359, 20);
            this.txtLogfile.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(110, 19);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(441, 20);
            this.txtResult.TabIndex = 0;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(392, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(55, 20);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "25";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(22, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "&Logfile:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtPort);
            this.GroupBox1.Controls.Add(this.label19);
            this.GroupBox1.Controls.Add(this.cbSecure);
            this.GroupBox1.Controls.Add(this.txtPassword);
            this.GroupBox1.Controls.Add(this.txtAccount);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.cbAuthentication);
            this.GroupBox1.Controls.Add(this.txtHost);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(560, 112);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "SMTP Server";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(392, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(177, 84);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(152, 20);
            this.txtAccount.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(336, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Pass&word:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(128, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "&Account:";
            // 
            // cbAuthentication
            // 
            this.cbAuthentication.Location = new System.Drawing.Point(110, 62);
            this.cbAuthentication.Name = "cbAuthentication";
            this.cbAuthentication.Size = new System.Drawing.Size(216, 17);
            this.cbAuthentication.TabIndex = 3;
            this.cbAuthentication.Text = "Server re&quires authentication";
            this.cbAuthentication.CheckedChanged += new System.EventHandler(this.cbAuthentication_CheckedChanged);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(110, 19);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(219, 20);
            this.txtHost.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(22, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "H&ost:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(22, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Result:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLastSmtpResponse);
            this.groupBox3.Controls.Add(this.Label2);
            this.groupBox3.Controls.Add(this.btnViewLog);
            this.groupBox3.Controls.Add(this.txtLogfile);
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(11, 375);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 110);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result and Logging";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(9, 498);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(31, 13);
            this.lblInfo.TabIndex = 46;
            this.lblInfo.Text = "[Info]";
            // 
            // frmSmtpMime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 520);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSmtpMime";
            this.Text = "Auron Email Component - C#.NET SMTP (MIME) Demo";
            this.Load += new System.EventHandler(this.frmSmtpMime_Load);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button btnCreateMIME;
        private System.Windows.Forms.TextBox txtMIMEContents;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnLoadMIME;
        private System.Windows.Forms.TextBox txtMIMEFile;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Button btnSend;
        internal System.Windows.Forms.TextBox txtLastSmtpResponse;
        private System.Windows.Forms.Label label19;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.CheckBox cbSecure;
        private System.Windows.Forms.TextBox txtLogfile;
        private System.Windows.Forms.TextBox txtResult;
        internal System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label14;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbAuthentication;
        internal System.Windows.Forms.TextBox txtHost;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblInfo;
    }
}