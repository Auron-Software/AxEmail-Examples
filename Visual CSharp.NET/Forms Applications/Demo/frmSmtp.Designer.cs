namespace Demo
{
    partial class frmSmtp
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
      this.label20 = new System.Windows.Forms.Label();
      this.txtAttachments = new System.Windows.Forms.TextBox();
      this.txtFromName = new System.Windows.Forms.TextBox();
      this.label15 = new System.Windows.Forms.Label();
      this.cbxEncoding = new System.Windows.Forms.ComboBox();
      this.Label3 = new System.Windows.Forms.Label();
      this.btnBrowseAttachment = new System.Windows.Forms.Button();
      this.txtFromAddress = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.txtLastSmtpResponse = new System.Windows.Forms.TextBox();
      this.label18 = new System.Windows.Forms.Label();
      this.btnViewLog = new System.Windows.Forms.Button();
      this.txtLogfile = new System.Windows.Forms.TextBox();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.label14 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.GroupBox1 = new System.Windows.Forms.GroupBox();
      this.btnOAuth = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.cbxSecurity = new System.Windows.Forms.ComboBox();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.label19 = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtAccount = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.txtHost = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.cbxPriority = new System.Windows.Forms.ComboBox();
      this.Label10 = new System.Windows.Forms.Label();
      this.GroupBox4 = new System.Windows.Forms.GroupBox();
      this.cbxFormat = new System.Windows.Forms.ComboBox();
      this.txtBody = new System.Windows.Forms.TextBox();
      this.txtSubject = new System.Windows.Forms.TextBox();
      this.Label6 = new System.Windows.Forms.Label();
      this.Label7 = new System.Windows.Forms.Label();
      this.Label8 = new System.Windows.Forms.Label();
      this.btnSend = new System.Windows.Forms.Button();
      this.txtBccAddress = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label17 = new System.Windows.Forms.Label();
      this.label16 = new System.Windows.Forms.Label();
      this.txtCcAddress = new System.Windows.Forms.TextBox();
      this.Label4 = new System.Windows.Forms.Label();
      this.txtToAddress = new System.Windows.Forms.TextBox();
      this.lblInfo = new System.Windows.Forms.Label();
      this.groupBox3.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label20
      // 
      this.label20.Location = new System.Drawing.Point(336, 117);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(76, 16);
      this.label20.TabIndex = 13;
      this.label20.Text = "&Name:";
      // 
      // txtAttachments
      // 
      this.txtAttachments.Location = new System.Drawing.Point(110, 139);
      this.txtAttachments.Name = "txtAttachments";
      this.txtAttachments.Size = new System.Drawing.Size(420, 20);
      this.txtAttachments.TabIndex = 11;
      // 
      // txtFromName
      // 
      this.txtFromName.Location = new System.Drawing.Point(392, 112);
      this.txtFromName.Name = "txtFromName";
      this.txtFromName.Size = new System.Drawing.Size(174, 20);
      this.txtFromName.TabIndex = 14;
      // 
      // label15
      // 
      this.label15.Location = new System.Drawing.Point(22, 141);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(78, 16);
      this.label15.TabIndex = 10;
      this.label15.Text = "&Attachment(s):";
      // 
      // cbxEncoding
      // 
      this.cbxEncoding.Location = new System.Drawing.Point(285, 110);
      this.cbxEncoding.Name = "cbxEncoding";
      this.cbxEncoding.Size = new System.Drawing.Size(100, 21);
      this.cbxEncoding.TabIndex = 7;
      // 
      // Label3
      // 
      this.Label3.Location = new System.Drawing.Point(22, 116);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(77, 16);
      this.Label3.TabIndex = 11;
      this.Label3.Text = "Sender E-ma&il:";
      // 
      // btnBrowseAttachment
      // 
      this.btnBrowseAttachment.Location = new System.Drawing.Point(536, 138);
      this.btnBrowseAttachment.Name = "btnBrowseAttachment";
      this.btnBrowseAttachment.Size = new System.Drawing.Size(30, 21);
      this.btnBrowseAttachment.TabIndex = 12;
      this.btnBrowseAttachment.Text = "...";
      this.btnBrowseAttachment.Click += new System.EventHandler(this.btnBrowseAttachment_Click);
      // 
      // txtFromAddress
      // 
      this.txtFromAddress.Location = new System.Drawing.Point(110, 113);
      this.txtFromAddress.Name = "txtFromAddress";
      this.txtFromAddress.Size = new System.Drawing.Size(218, 20);
      this.txtFromAddress.TabIndex = 12;
      // 
      // label12
      // 
      this.label12.Location = new System.Drawing.Point(230, 114);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(49, 19);
      this.label12.TabIndex = 6;
      this.label12.Text = "Char.&set:";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.txtLastSmtpResponse);
      this.groupBox3.Controls.Add(this.label18);
      this.groupBox3.Controls.Add(this.btnViewLog);
      this.groupBox3.Controls.Add(this.txtLogfile);
      this.groupBox3.Controls.Add(this.txtResult);
      this.groupBox3.Controls.Add(this.label14);
      this.groupBox3.Controls.Add(this.label13);
      this.groupBox3.Location = new System.Drawing.Point(12, 445);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(572, 107);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Result and Logging";
      // 
      // txtLastSmtpResponse
      // 
      this.txtLastSmtpResponse.Location = new System.Drawing.Point(110, 42);
      this.txtLastSmtpResponse.Multiline = true;
      this.txtLastSmtpResponse.Name = "txtLastSmtpResponse";
      this.txtLastSmtpResponse.ReadOnly = true;
      this.txtLastSmtpResponse.Size = new System.Drawing.Size(456, 32);
      this.txtLastSmtpResponse.TabIndex = 3;
      // 
      // label18
      // 
      this.label18.Location = new System.Drawing.Point(22, 41);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(96, 16);
      this.label18.TabIndex = 2;
      this.label18.Text = "Response:";
      // 
      // btnViewLog
      // 
      this.btnViewLog.Location = new System.Drawing.Point(491, 78);
      this.btnViewLog.Name = "btnViewLog";
      this.btnViewLog.Size = new System.Drawing.Size(75, 23);
      this.btnViewLog.TabIndex = 6;
      this.btnViewLog.Text = "&View";
      this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
      // 
      // txtLogfile
      // 
      this.txtLogfile.Location = new System.Drawing.Point(110, 79);
      this.txtLogfile.Name = "txtLogfile";
      this.txtLogfile.Size = new System.Drawing.Size(375, 20);
      this.txtLogfile.TabIndex = 5;
      // 
      // txtResult
      // 
      this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResult.Location = new System.Drawing.Point(110, 19);
      this.txtResult.Name = "txtResult";
      this.txtResult.ReadOnly = true;
      this.txtResult.Size = new System.Drawing.Size(456, 20);
      this.txtResult.TabIndex = 1;
      // 
      // label14
      // 
      this.label14.Location = new System.Drawing.Point(22, 82);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(70, 16);
      this.label14.TabIndex = 4;
      this.label14.Text = "&Logfile:";
      // 
      // label13
      // 
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(22, 21);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(66, 16);
      this.label13.TabIndex = 0;
      this.label13.Text = "Result:";
      // 
      // GroupBox1
      // 
      this.GroupBox1.Controls.Add(this.btnOAuth);
      this.GroupBox1.Controls.Add(this.label2);
      this.GroupBox1.Controls.Add(this.cbxSecurity);
      this.GroupBox1.Controls.Add(this.txtFromName);
      this.GroupBox1.Controls.Add(this.Label3);
      this.GroupBox1.Controls.Add(this.txtFromAddress);
      this.GroupBox1.Controls.Add(this.txtPort);
      this.GroupBox1.Controls.Add(this.label19);
      this.GroupBox1.Controls.Add(this.txtPassword);
      this.GroupBox1.Controls.Add(this.txtAccount);
      this.GroupBox1.Controls.Add(this.label11);
      this.GroupBox1.Controls.Add(this.label9);
      this.GroupBox1.Controls.Add(this.txtHost);
      this.GroupBox1.Controls.Add(this.Label1);
      this.GroupBox1.Controls.Add(this.label20);
      this.GroupBox1.Location = new System.Drawing.Point(12, 12);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new System.Drawing.Size(572, 143);
      this.GroupBox1.TabIndex = 0;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "SMTP Server";
      // 
      // btnOAuth
      // 
      this.btnOAuth.Location = new System.Drawing.Point(392, 45);
      this.btnOAuth.Name = "btnOAuth";
      this.btnOAuth.Size = new System.Drawing.Size(174, 23);
      this.btnOAuth.TabIndex = 6;
      this.btnOAuth.Text = "OAuth Settings...";
      this.btnOAuth.UseVisualStyleBackColor = true;
      this.btnOAuth.Click += new System.EventHandler(this.btnOAuth_Click);
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(22, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(82, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "&Port:";
      // 
      // cbxSecurity
      // 
      this.cbxSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxSecurity.FormattingEnabled = true;
      this.cbxSecurity.Location = new System.Drawing.Point(392, 18);
      this.cbxSecurity.Name = "cbxSecurity";
      this.cbxSecurity.Size = new System.Drawing.Size(174, 21);
      this.cbxSecurity.TabIndex = 3;
      this.cbxSecurity.SelectedIndexChanged += new System.EventHandler(this.cbxSecurity_SelectedIndexChanged);
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(110, 45);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(55, 20);
      this.txtPort.TabIndex = 5;
      // 
      // label19
      // 
      this.label19.Location = new System.Drawing.Point(336, 21);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(49, 18);
      this.label19.TabIndex = 2;
      this.label19.Text = "&Security:";
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(392, 87);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(174, 20);
      this.txtPassword.TabIndex = 10;
      // 
      // txtAccount
      // 
      this.txtAccount.Location = new System.Drawing.Point(110, 87);
      this.txtAccount.Name = "txtAccount";
      this.txtAccount.Size = new System.Drawing.Size(218, 20);
      this.txtAccount.TabIndex = 8;
      // 
      // label11
      // 
      this.label11.Location = new System.Drawing.Point(336, 90);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(57, 16);
      this.label11.TabIndex = 9;
      this.label11.Text = "Pass&word:";
      // 
      // label9
      // 
      this.label9.Location = new System.Drawing.Point(22, 90);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(50, 16);
      this.label9.TabIndex = 7;
      this.label9.Text = "&Account:";
      // 
      // txtHost
      // 
      this.txtHost.Location = new System.Drawing.Point(110, 19);
      this.txtHost.Name = "txtHost";
      this.txtHost.Size = new System.Drawing.Size(219, 20);
      this.txtHost.TabIndex = 1;
      this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
      // 
      // Label1
      // 
      this.Label1.Location = new System.Drawing.Point(22, 22);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(82, 17);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "H&ost:";
      // 
      // cbxPriority
      // 
      this.cbxPriority.Location = new System.Drawing.Point(450, 110);
      this.cbxPriority.Name = "cbxPriority";
      this.cbxPriority.Size = new System.Drawing.Size(116, 21);
      this.cbxPriority.TabIndex = 9;
      // 
      // Label10
      // 
      this.Label10.Location = new System.Drawing.Point(404, 114);
      this.Label10.Name = "Label10";
      this.Label10.Size = new System.Drawing.Size(44, 16);
      this.Label10.TabIndex = 8;
      this.Label10.Text = "Prio&rity:";
      // 
      // GroupBox4
      // 
      this.GroupBox4.Controls.Add(this.btnBrowseAttachment);
      this.GroupBox4.Controls.Add(this.txtAttachments);
      this.GroupBox4.Controls.Add(this.label15);
      this.GroupBox4.Controls.Add(this.cbxEncoding);
      this.GroupBox4.Controls.Add(this.label12);
      this.GroupBox4.Controls.Add(this.cbxPriority);
      this.GroupBox4.Controls.Add(this.Label10);
      this.GroupBox4.Controls.Add(this.cbxFormat);
      this.GroupBox4.Controls.Add(this.txtBody);
      this.GroupBox4.Controls.Add(this.txtSubject);
      this.GroupBox4.Controls.Add(this.Label6);
      this.GroupBox4.Controls.Add(this.Label7);
      this.GroupBox4.Controls.Add(this.Label8);
      this.GroupBox4.Controls.Add(this.btnSend);
      this.GroupBox4.Location = new System.Drawing.Point(12, 245);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Size = new System.Drawing.Size(572, 194);
      this.GroupBox4.TabIndex = 2;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Message";
      // 
      // cbxFormat
      // 
      this.cbxFormat.Location = new System.Drawing.Point(110, 110);
      this.cbxFormat.Name = "cbxFormat";
      this.cbxFormat.Size = new System.Drawing.Size(100, 21);
      this.cbxFormat.TabIndex = 5;
      // 
      // txtBody
      // 
      this.txtBody.Location = new System.Drawing.Point(110, 43);
      this.txtBody.Multiline = true;
      this.txtBody.Name = "txtBody";
      this.txtBody.Size = new System.Drawing.Size(456, 62);
      this.txtBody.TabIndex = 3;
      // 
      // txtSubject
      // 
      this.txtSubject.Location = new System.Drawing.Point(110, 19);
      this.txtSubject.Name = "txtSubject";
      this.txtSubject.Size = new System.Drawing.Size(456, 20);
      this.txtSubject.TabIndex = 1;
      // 
      // Label6
      // 
      this.Label6.Location = new System.Drawing.Point(22, 45);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(68, 14);
      this.Label6.TabIndex = 2;
      this.Label6.Text = "Bod&y:";
      // 
      // Label7
      // 
      this.Label7.Location = new System.Drawing.Point(22, 22);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(61, 14);
      this.Label7.TabIndex = 0;
      this.Label7.Text = "S&ubject:";
      // 
      // Label8
      // 
      this.Label8.Location = new System.Drawing.Point(22, 114);
      this.Label8.Name = "Label8";
      this.Label8.Size = new System.Drawing.Size(63, 16);
      this.Label8.TabIndex = 4;
      this.Label8.Text = "&Format:";
      // 
      // btnSend
      // 
      this.btnSend.Location = new System.Drawing.Point(110, 165);
      this.btnSend.Name = "btnSend";
      this.btnSend.Size = new System.Drawing.Size(456, 22);
      this.btnSend.TabIndex = 13;
      this.btnSend.Text = "S&end";
      this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
      // 
      // txtBccAddress
      // 
      this.txtBccAddress.Location = new System.Drawing.Point(392, 42);
      this.txtBccAddress.Name = "txtBccAddress";
      this.txtBccAddress.Size = new System.Drawing.Size(174, 20);
      this.txtBccAddress.TabIndex = 5;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtBccAddress);
      this.groupBox2.Controls.Add(this.label17);
      this.groupBox2.Controls.Add(this.label16);
      this.groupBox2.Controls.Add(this.txtCcAddress);
      this.groupBox2.Controls.Add(this.Label4);
      this.groupBox2.Controls.Add(this.txtToAddress);
      this.groupBox2.Location = new System.Drawing.Point(12, 169);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(572, 70);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Recipients";
      // 
      // label17
      // 
      this.label17.Location = new System.Drawing.Point(336, 45);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(29, 16);
      this.label17.TabIndex = 4;
      this.label17.Text = "&Bcc:";
      // 
      // label16
      // 
      this.label16.Location = new System.Drawing.Point(22, 45);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(36, 16);
      this.label16.TabIndex = 2;
      this.label16.Text = "&Cc:";
      // 
      // txtCcAddress
      // 
      this.txtCcAddress.Location = new System.Drawing.Point(110, 42);
      this.txtCcAddress.Name = "txtCcAddress";
      this.txtCcAddress.Size = new System.Drawing.Size(220, 20);
      this.txtCcAddress.TabIndex = 3;
      // 
      // Label4
      // 
      this.Label4.Location = new System.Drawing.Point(22, 23);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(36, 16);
      this.Label4.TabIndex = 0;
      this.Label4.Text = "&To:";
      // 
      // txtToAddress
      // 
      this.txtToAddress.Location = new System.Drawing.Point(110, 19);
      this.txtToAddress.Name = "txtToAddress";
      this.txtToAddress.Size = new System.Drawing.Size(220, 20);
      this.txtToAddress.TabIndex = 1;
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.Location = new System.Drawing.Point(9, 565);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(31, 13);
      this.lblInfo.TabIndex = 45;
      this.lblInfo.Text = "[Info]";
      // 
      // frmSmtp
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(598, 593);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.GroupBox1);
      this.Controls.Add(this.GroupBox4);
      this.Controls.Add(this.groupBox2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmSmtp";
      this.Text = "Auron Email Component - C#.NET SMTP Demo";
      this.Load += new System.EventHandler(this.frmSmtp_Load);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAttachments;
        internal System.Windows.Forms.TextBox txtFromName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxEncoding;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Button btnBrowseAttachment;
        internal System.Windows.Forms.TextBox txtFromAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.TextBox txtLastSmtpResponse;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnViewLog;
        private System.Windows.Forms.TextBox txtLogfile;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtHost;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbxPriority;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.ComboBox cbxFormat;
        internal System.Windows.Forms.TextBox txtBody;
        internal System.Windows.Forms.TextBox txtSubject;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnSend;
        internal System.Windows.Forms.TextBox txtBccAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.TextBox txtCcAddress;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtToAddress;
        private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.ComboBox cbxSecurity;
    internal System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnOAuth;
  }
}