namespace Demo
{
    partial class frmPop3
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPop3));
      this.columnFrom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnList = new System.Windows.Forms.Button();
      this.lvMessages = new System.Windows.Forms.ListView();
      this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.label12 = new System.Windows.Forms.Label();
      this.txtLogfile = new System.Windows.Forms.TextBox();
      this.txtFrom = new System.Windows.Forms.TextBox();
      this.Label7 = new System.Windows.Forms.Label();
      this.Label6 = new System.Windows.Forms.Label();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.GroupBox2 = new System.Windows.Forms.GroupBox();
      this.txtResponse = new System.Windows.Forms.TextBox();
      this.GroupBox3 = new System.Windows.Forms.GroupBox();
      this.Label13 = new System.Windows.Forms.Label();
      this.btnSaveMessage = new System.Windows.Forms.Button();
      this.lvAttachments = new System.Windows.Forms.ListView();
      this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.txtBody = new System.Windows.Forms.TextBox();
      this.txtSubject = new System.Windows.Forms.TextBox();
      this.txtTo = new System.Windows.Forms.TextBox();
      this.Label8 = new System.Windows.Forms.Label();
      this.Label5 = new System.Windows.Forms.Label();
      this.Label4 = new System.Windows.Forms.Label();
      this.GroupBox4 = new System.Windows.Forms.GroupBox();
      this.btnViewLog = new System.Windows.Forms.Button();
      this.Label10 = new System.Windows.Forms.Label();
      this.Label9 = new System.Windows.Forms.Label();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.GroupBox1 = new System.Windows.Forms.GroupBox();
      this.btnOAuth = new System.Windows.Forms.Button();
      this.cbxSecurity = new System.Windows.Forms.ComboBox();
      this.label19 = new System.Windows.Forms.Label();
      this.btnDisconnect = new System.Windows.Forms.Button();
      this.btnConnect = new System.Windows.Forms.Button();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtAccount = new System.Windows.Forms.TextBox();
      this.txtHost = new System.Windows.Forms.TextBox();
      this.Label3 = new System.Windows.Forms.Label();
      this.Label2 = new System.Windows.Forms.Label();
      this.Label1 = new System.Windows.Forms.Label();
      this.lblInfo = new System.Windows.Forms.Label();
      this.GroupBox2.SuspendLayout();
      this.GroupBox3.SuspendLayout();
      this.GroupBox4.SuspendLayout();
      this.GroupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // columnFrom
      // 
      this.columnFrom.Text = "From";
      this.columnFrom.Width = 130;
      // 
      // btnList
      // 
      this.btnList.Location = new System.Drawing.Point(92, 101);
      this.btnList.Name = "btnList";
      this.btnList.Size = new System.Drawing.Size(441, 22);
      this.btnList.TabIndex = 1;
      this.btnList.Text = "&List Messages";
      this.btnList.Click += new System.EventHandler(this.btnList_Click);
      // 
      // lvMessages
      // 
      this.lvMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.columnFrom,
            this.colDate,
            this.colSubject});
      this.lvMessages.FullRowSelect = true;
      this.lvMessages.GridLines = true;
      this.lvMessages.HideSelection = false;
      this.lvMessages.Location = new System.Drawing.Point(92, 19);
      this.lvMessages.MultiSelect = false;
      this.lvMessages.Name = "lvMessages";
      this.lvMessages.Size = new System.Drawing.Size(441, 77);
      this.lvMessages.TabIndex = 0;
      this.lvMessages.UseCompatibleStateImageBehavior = false;
      this.lvMessages.View = System.Windows.Forms.View.Details;
      this.lvMessages.SelectedIndexChanged += new System.EventHandler(this.lvMessages_SelectedIndexChanged);
      // 
      // colID
      // 
      this.colID.Text = "ID";
      this.colID.Width = 30;
      // 
      // colDate
      // 
      this.colDate.Text = "Date";
      this.colDate.Width = 130;
      // 
      // colSubject
      // 
      this.colSubject.Text = "Subject";
      this.colSubject.Width = 130;
      // 
      // label12
      // 
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(16, 46);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(60, 12);
      this.label12.TabIndex = 2;
      this.label12.Text = "Response:";
      // 
      // txtLogfile
      // 
      this.txtLogfile.Location = new System.Drawing.Point(92, 82);
      this.txtLogfile.Name = "txtLogfile";
      this.txtLogfile.Size = new System.Drawing.Size(359, 20);
      this.txtLogfile.TabIndex = 4;
      // 
      // txtFrom
      // 
      this.txtFrom.Location = new System.Drawing.Point(92, 19);
      this.txtFrom.Name = "txtFrom";
      this.txtFrom.ReadOnly = true;
      this.txtFrom.Size = new System.Drawing.Size(199, 20);
      this.txtFrom.TabIndex = 1;
      // 
      // Label7
      // 
      this.Label7.Location = new System.Drawing.Point(16, 69);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(36, 20);
      this.Label7.TabIndex = 6;
      this.Label7.Text = "Body:";
      // 
      // Label6
      // 
      this.Label6.Location = new System.Drawing.Point(16, 48);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(44, 20);
      this.Label6.TabIndex = 4;
      this.Label6.Text = "Subject:";
      // 
      // txtResult
      // 
      this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResult.Location = new System.Drawing.Point(92, 19);
      this.txtResult.Name = "txtResult";
      this.txtResult.ReadOnly = true;
      this.txtResult.Size = new System.Drawing.Size(441, 20);
      this.txtResult.TabIndex = 1;
      // 
      // GroupBox2
      // 
      this.GroupBox2.Controls.Add(this.btnList);
      this.GroupBox2.Controls.Add(this.lvMessages);
      this.GroupBox2.Location = new System.Drawing.Point(13, 163);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new System.Drawing.Size(549, 130);
      this.GroupBox2.TabIndex = 1;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Received Messages";
      // 
      // txtResponse
      // 
      this.txtResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResponse.Location = new System.Drawing.Point(92, 42);
      this.txtResponse.Multiline = true;
      this.txtResponse.Name = "txtResponse";
      this.txtResponse.ReadOnly = true;
      this.txtResponse.Size = new System.Drawing.Size(441, 33);
      this.txtResponse.TabIndex = 2;
      // 
      // GroupBox3
      // 
      this.GroupBox3.Controls.Add(this.Label13);
      this.GroupBox3.Controls.Add(this.btnSaveMessage);
      this.GroupBox3.Controls.Add(this.lvAttachments);
      this.GroupBox3.Controls.Add(this.txtBody);
      this.GroupBox3.Controls.Add(this.txtSubject);
      this.GroupBox3.Controls.Add(this.txtTo);
      this.GroupBox3.Controls.Add(this.Label8);
      this.GroupBox3.Controls.Add(this.Label7);
      this.GroupBox3.Controls.Add(this.Label6);
      this.GroupBox3.Controls.Add(this.txtFrom);
      this.GroupBox3.Controls.Add(this.Label5);
      this.GroupBox3.Controls.Add(this.Label4);
      this.GroupBox3.Location = new System.Drawing.Point(13, 299);
      this.GroupBox3.Name = "GroupBox3";
      this.GroupBox3.Size = new System.Drawing.Size(549, 254);
      this.GroupBox3.TabIndex = 2;
      this.GroupBox3.TabStop = false;
      this.GroupBox3.Text = "Current Message";
      // 
      // Label13
      // 
      this.Label13.Location = new System.Drawing.Point(92, 205);
      this.Label13.Name = "Label13";
      this.Label13.Size = new System.Drawing.Size(202, 14);
      this.Label13.TabIndex = 10;
      this.Label13.Text = "(Double-click on attachment to save)";
      // 
      // btnSaveMessage
      // 
      this.btnSaveMessage.Location = new System.Drawing.Point(92, 223);
      this.btnSaveMessage.Name = "btnSaveMessage";
      this.btnSaveMessage.Size = new System.Drawing.Size(441, 24);
      this.btnSaveMessage.TabIndex = 11;
      this.btnSaveMessage.Text = "Save &Message As...";
      this.btnSaveMessage.Click += new System.EventHandler(this.btnSaveMessage_Click);
      // 
      // lvAttachments
      // 
      this.lvAttachments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSize});
      this.lvAttachments.FullRowSelect = true;
      this.lvAttachments.GridLines = true;
      this.lvAttachments.HideSelection = false;
      this.lvAttachments.Location = new System.Drawing.Point(92, 138);
      this.lvAttachments.Name = "lvAttachments";
      this.lvAttachments.Size = new System.Drawing.Size(441, 62);
      this.lvAttachments.TabIndex = 9;
      this.lvAttachments.UseCompatibleStateImageBehavior = false;
      this.lvAttachments.View = System.Windows.Forms.View.Details;
      this.lvAttachments.SelectedIndexChanged += new System.EventHandler(this.lvAttachments_SelectedIndexChanged);
      this.lvAttachments.DoubleClick += new System.EventHandler(this.lvAttachments_DoubleClick);
      // 
      // colName
      // 
      this.colName.Text = "Name";
      this.colName.Width = 248;
      // 
      // colSize
      // 
      this.colSize.Text = "Size (Bytes)";
      this.colSize.Width = 189;
      // 
      // txtBody
      // 
      this.txtBody.Location = new System.Drawing.Point(92, 68);
      this.txtBody.Multiline = true;
      this.txtBody.Name = "txtBody";
      this.txtBody.ReadOnly = true;
      this.txtBody.Size = new System.Drawing.Size(441, 64);
      this.txtBody.TabIndex = 7;
      // 
      // txtSubject
      // 
      this.txtSubject.Location = new System.Drawing.Point(92, 44);
      this.txtSubject.Name = "txtSubject";
      this.txtSubject.ReadOnly = true;
      this.txtSubject.Size = new System.Drawing.Size(441, 20);
      this.txtSubject.TabIndex = 5;
      // 
      // txtTo
      // 
      this.txtTo.Location = new System.Drawing.Point(337, 19);
      this.txtTo.Name = "txtTo";
      this.txtTo.ReadOnly = true;
      this.txtTo.Size = new System.Drawing.Size(196, 20);
      this.txtTo.TabIndex = 3;
      // 
      // Label8
      // 
      this.Label8.Location = new System.Drawing.Point(16, 139);
      this.Label8.Name = "Label8";
      this.Label8.Size = new System.Drawing.Size(76, 20);
      this.Label8.TabIndex = 8;
      this.Label8.Text = "Attachments:";
      // 
      // Label5
      // 
      this.Label5.Location = new System.Drawing.Point(310, 22);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(36, 20);
      this.Label5.TabIndex = 2;
      this.Label5.Text = "To:";
      // 
      // Label4
      // 
      this.Label4.Location = new System.Drawing.Point(16, 22);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(48, 20);
      this.Label4.TabIndex = 0;
      this.Label4.Text = "From:";
      // 
      // GroupBox4
      // 
      this.GroupBox4.Controls.Add(this.txtResponse);
      this.GroupBox4.Controls.Add(this.label12);
      this.GroupBox4.Controls.Add(this.btnViewLog);
      this.GroupBox4.Controls.Add(this.txtLogfile);
      this.GroupBox4.Controls.Add(this.txtResult);
      this.GroupBox4.Controls.Add(this.Label10);
      this.GroupBox4.Controls.Add(this.Label9);
      this.GroupBox4.Location = new System.Drawing.Point(13, 559);
      this.GroupBox4.Name = "GroupBox4";
      this.GroupBox4.Size = new System.Drawing.Size(549, 110);
      this.GroupBox4.TabIndex = 4;
      this.GroupBox4.TabStop = false;
      this.GroupBox4.Text = "Result and Logging";
      // 
      // btnViewLog
      // 
      this.btnViewLog.Location = new System.Drawing.Point(457, 82);
      this.btnViewLog.Name = "btnViewLog";
      this.btnViewLog.Size = new System.Drawing.Size(76, 20);
      this.btnViewLog.TabIndex = 5;
      this.btnViewLog.Text = "&View";
      this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
      // 
      // Label10
      // 
      this.Label10.Location = new System.Drawing.Point(16, 86);
      this.Label10.Name = "Label10";
      this.Label10.Size = new System.Drawing.Size(56, 16);
      this.Label10.TabIndex = 3;
      this.Label10.Text = "L&ogfile:";
      // 
      // Label9
      // 
      this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label9.Location = new System.Drawing.Point(16, 23);
      this.Label9.Name = "Label9";
      this.Label9.Size = new System.Drawing.Size(60, 12);
      this.Label9.TabIndex = 0;
      this.Label9.Text = "Res&ult:";
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(96, 45);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(55, 20);
      this.txtPort.TabIndex = 3;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(16, 48);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(29, 13);
      this.label11.TabIndex = 2;
      this.label11.Text = "&Port:";
      // 
      // GroupBox1
      // 
      this.GroupBox1.Controls.Add(this.btnOAuth);
      this.GroupBox1.Controls.Add(this.cbxSecurity);
      this.GroupBox1.Controls.Add(this.label19);
      this.GroupBox1.Controls.Add(this.txtPort);
      this.GroupBox1.Controls.Add(this.label11);
      this.GroupBox1.Controls.Add(this.btnDisconnect);
      this.GroupBox1.Controls.Add(this.btnConnect);
      this.GroupBox1.Controls.Add(this.txtPassword);
      this.GroupBox1.Controls.Add(this.txtAccount);
      this.GroupBox1.Controls.Add(this.txtHost);
      this.GroupBox1.Controls.Add(this.Label3);
      this.GroupBox1.Controls.Add(this.Label2);
      this.GroupBox1.Controls.Add(this.Label1);
      this.GroupBox1.Location = new System.Drawing.Point(12, 12);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new System.Drawing.Size(550, 145);
      this.GroupBox1.TabIndex = 0;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "POP3 Server";
      // 
      // btnOAuth
      // 
      this.btnOAuth.Location = new System.Drawing.Point(370, 46);
      this.btnOAuth.Name = "btnOAuth";
      this.btnOAuth.Size = new System.Drawing.Size(164, 23);
      this.btnOAuth.TabIndex = 13;
      this.btnOAuth.Text = "OAuth Settings...";
      this.btnOAuth.UseVisualStyleBackColor = true;
      this.btnOAuth.Click += new System.EventHandler(this.btnOAuth_Click);
      // 
      // cbxSecurity
      // 
      this.cbxSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxSecurity.FormattingEnabled = true;
      this.cbxSecurity.Location = new System.Drawing.Point(370, 19);
      this.cbxSecurity.Name = "cbxSecurity";
      this.cbxSecurity.Size = new System.Drawing.Size(164, 21);
      this.cbxSecurity.TabIndex = 12;
      this.cbxSecurity.SelectedIndexChanged += new System.EventHandler(this.cbxSecurity_SelectedIndexChanged);
      // 
      // label19
      // 
      this.label19.Location = new System.Drawing.Point(311, 22);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(49, 18);
      this.label19.TabIndex = 11;
      this.label19.Text = "&Security:";
      // 
      // btnDisconnect
      // 
      this.btnDisconnect.Location = new System.Drawing.Point(314, 111);
      this.btnDisconnect.Name = "btnDisconnect";
      this.btnDisconnect.Size = new System.Drawing.Size(220, 21);
      this.btnDisconnect.TabIndex = 10;
      this.btnDisconnect.Text = "&Disconnect";
      this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(96, 111);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(208, 21);
      this.btnConnect.TabIndex = 9;
      this.btnConnect.Text = "&Connect";
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(370, 85);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(164, 20);
      this.txtPassword.TabIndex = 8;
      // 
      // txtAccount
      // 
      this.txtAccount.Location = new System.Drawing.Point(96, 85);
      this.txtAccount.Name = "txtAccount";
      this.txtAccount.Size = new System.Drawing.Size(208, 20);
      this.txtAccount.TabIndex = 6;
      // 
      // txtHost
      // 
      this.txtHost.Location = new System.Drawing.Point(96, 19);
      this.txtHost.Name = "txtHost";
      this.txtHost.Size = new System.Drawing.Size(208, 20);
      this.txtHost.TabIndex = 1;
      this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
      // 
      // Label3
      // 
      this.Label3.Location = new System.Drawing.Point(311, 90);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(80, 16);
      this.Label3.TabIndex = 7;
      this.Label3.Text = "Pass&word:";
      // 
      // Label2
      // 
      this.Label2.Location = new System.Drawing.Point(16, 90);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(80, 16);
      this.Label2.TabIndex = 5;
      this.Label2.Text = "&Account:";
      // 
      // Label1
      // 
      this.Label1.AutoSize = true;
      this.Label1.Location = new System.Drawing.Point(16, 22);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(32, 13);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "&Host:";
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.Location = new System.Drawing.Point(10, 682);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(31, 13);
      this.lblInfo.TabIndex = 43;
      this.lblInfo.Text = "[Info]";
      // 
      // frmPop3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(574, 708);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.GroupBox2);
      this.Controls.Add(this.GroupBox3);
      this.Controls.Add(this.GroupBox4);
      this.Controls.Add(this.GroupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmPop3";
      this.Text = "Auron Email Component - C#.NET POP3 Demo";
      this.Load += new System.EventHandler(this.frmPop3_Load);
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox3.ResumeLayout(false);
      this.GroupBox3.PerformLayout();
      this.GroupBox4.ResumeLayout(false);
      this.GroupBox4.PerformLayout();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ColumnHeader columnFrom;
        internal System.Windows.Forms.Button btnList;
        internal System.Windows.Forms.ListView lvMessages;
        internal System.Windows.Forms.ColumnHeader colDate;
        internal System.Windows.Forms.ColumnHeader colSubject;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtLogfile;
        internal System.Windows.Forms.TextBox txtFrom;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtResult;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtResponse;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Button btnSaveMessage;
        internal System.Windows.Forms.ListView lvAttachments;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSize;
        internal System.Windows.Forms.TextBox txtBody;
        internal System.Windows.Forms.TextBox txtSubject;
        internal System.Windows.Forms.TextBox txtTo;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button btnViewLog;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtPort;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnDisconnect;
        internal System.Windows.Forms.Button btnConnect;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtAccount;
        internal System.Windows.Forms.TextBox txtHost;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ColumnHeader colID;
    private System.Windows.Forms.Button btnOAuth;
    private System.Windows.Forms.ComboBox cbxSecurity;
    private System.Windows.Forms.Label label19;
  }
}