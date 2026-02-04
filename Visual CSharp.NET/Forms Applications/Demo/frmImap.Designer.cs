namespace Demo
{
  partial class frmImap
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImap));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnOAuth = new System.Windows.Forms.Button();
      this.cbxSecurity = new System.Windows.Forms.ComboBox();
      this.label19 = new System.Windows.Forms.Label();
      this.btnDisconnect = new System.Windows.Forms.Button();
      this.btnConnect = new System.Windows.Forms.Button();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.txtPort = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.Password = new System.Windows.Forms.Label();
      this.Account = new System.Windows.Forms.Label();
      this.txtAccount = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtHost = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.tvMailbox = new System.Windows.Forms.TreeView();
      this.btnRename = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnCreate = new System.Windows.Forms.Button();
      this.btnRefreshMailbox = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.btnExpunge = new System.Windows.Forms.Button();
      this.btnReset = new System.Windows.Forms.Button();
      this.lvMail = new System.Windows.Forms.ListView();
      this.chUid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chFlags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.chSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lblCount = new System.Windows.Forms.Label();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.cmbMailFlags = new System.Windows.Forms.ComboBox();
      this.btnSet = new System.Windows.Forms.Button();
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.txtResponse = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.btnViewLog = new System.Windows.Forms.Button();
      this.txtLogfile = new System.Windows.Forms.TextBox();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.Label10 = new System.Windows.Forms.Label();
      this.Label9 = new System.Windows.Forms.Label();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.tcBody = new System.Windows.Forms.TabControl();
      this.tabPlain = new System.Windows.Forms.TabPage();
      this.txtBody = new System.Windows.Forms.TextBox();
      this.tabHtml = new System.Windows.Forms.TabPage();
      this.txtHtml = new System.Windows.Forms.TextBox();
      this.btnNewMessage = new System.Windows.Forms.Button();
      this.btnAddAttachment = new System.Windows.Forms.Button();
      this.btnSaveToMailbox = new System.Windows.Forms.Button();
      this.Label13 = new System.Windows.Forms.Label();
      this.btnSaveMessage = new System.Windows.Forms.Button();
      this.lvAttachments = new System.Windows.Forms.ListView();
      this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.txtSubject = new System.Windows.Forms.TextBox();
      this.txtTo = new System.Windows.Forms.TextBox();
      this.Label8 = new System.Windows.Forms.Label();
      this.Label7 = new System.Windows.Forms.Label();
      this.Label6 = new System.Windows.Forms.Label();
      this.txtFrom = new System.Windows.Forms.TextBox();
      this.Label5 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.tcBody.SuspendLayout();
      this.tabPlain.SuspendLayout();
      this.tabHtml.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnOAuth);
      this.groupBox1.Controls.Add(this.cbxSecurity);
      this.groupBox1.Controls.Add(this.label19);
      this.groupBox1.Controls.Add(this.btnDisconnect);
      this.groupBox1.Controls.Add(this.btnConnect);
      this.groupBox1.Controls.Add(this.txtPassword);
      this.groupBox1.Controls.Add(this.txtPort);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.Password);
      this.groupBox1.Controls.Add(this.Account);
      this.groupBox1.Controls.Add(this.txtAccount);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txtHost);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(691, 80);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Connection";
      // 
      // btnOAuth
      // 
      this.btnOAuth.Location = new System.Drawing.Point(396, 17);
      this.btnOAuth.Name = "btnOAuth";
      this.btnOAuth.Size = new System.Drawing.Size(108, 23);
      this.btnOAuth.TabIndex = 15;
      this.btnOAuth.Text = "OAuth Settings...";
      this.btnOAuth.UseVisualStyleBackColor = true;
      this.btnOAuth.Click += new System.EventHandler(this.btnOAuth_Click);
      // 
      // cbxSecurity
      // 
      this.cbxSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxSecurity.FormattingEnabled = true;
      this.cbxSecurity.Location = new System.Drawing.Point(290, 19);
      this.cbxSecurity.Name = "cbxSecurity";
      this.cbxSecurity.Size = new System.Drawing.Size(100, 21);
      this.cbxSecurity.TabIndex = 14;
      this.cbxSecurity.SelectedIndexChanged += new System.EventHandler(this.cbxSecurity_SelectedIndexChanged);
      // 
      // label19
      // 
      this.label19.Location = new System.Drawing.Point(199, 22);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(49, 18);
      this.label19.TabIndex = 13;
      this.label19.Text = "&Security:";
      // 
      // btnDisconnect
      // 
      this.btnDisconnect.Location = new System.Drawing.Point(608, 47);
      this.btnDisconnect.Name = "btnDisconnect";
      this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
      this.btnDisconnect.TabIndex = 12;
      this.btnDisconnect.Text = "Disconnect";
      this.btnDisconnect.UseVisualStyleBackColor = true;
      this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
      // 
      // btnConnect
      // 
      this.btnConnect.Location = new System.Drawing.Point(527, 47);
      this.btnConnect.Name = "btnConnect";
      this.btnConnect.Size = new System.Drawing.Size(75, 23);
      this.btnConnect.TabIndex = 11;
      this.btnConnect.Text = "Connect";
      this.btnConnect.UseVisualStyleBackColor = true;
      this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(290, 47);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(100, 20);
      this.txtPassword.TabIndex = 10;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // txtPort
      // 
      this.txtPort.Location = new System.Drawing.Point(608, 18);
      this.txtPort.Name = "txtPort";
      this.txtPort.Size = new System.Drawing.Size(75, 20);
      this.txtPort.TabIndex = 3;
      this.txtPort.Text = "993";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(526, 21);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Port:";
      // 
      // Password
      // 
      this.Password.AutoSize = true;
      this.Password.Location = new System.Drawing.Point(199, 49);
      this.Password.Name = "Password";
      this.Password.Size = new System.Drawing.Size(56, 13);
      this.Password.TabIndex = 9;
      this.Password.Text = "Password:";
      // 
      // Account
      // 
      this.Account.AutoSize = true;
      this.Account.Location = new System.Drawing.Point(13, 53);
      this.Account.Name = "Account";
      this.Account.Size = new System.Drawing.Size(50, 13);
      this.Account.TabIndex = 7;
      this.Account.Text = "Account:";
      // 
      // txtAccount
      // 
      this.txtAccount.Location = new System.Drawing.Point(91, 46);
      this.txtAccount.Name = "txtAccount";
      this.txtAccount.Size = new System.Drawing.Size(100, 20);
      this.txtAccount.TabIndex = 8;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Host:";
      // 
      // txtHost
      // 
      this.txtHost.Location = new System.Drawing.Point(91, 19);
      this.txtHost.Name = "txtHost";
      this.txtHost.Size = new System.Drawing.Size(100, 20);
      this.txtHost.TabIndex = 1;
      this.txtHost.Text = "imap.gmail.com";
      this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.tvMailbox);
      this.groupBox2.Controls.Add(this.btnRename);
      this.groupBox2.Controls.Add(this.btnDelete);
      this.groupBox2.Controls.Add(this.btnCreate);
      this.groupBox2.Controls.Add(this.btnRefreshMailbox);
      this.groupBox2.Location = new System.Drawing.Point(12, 98);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(200, 497);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Mailbox";
      // 
      // tvMailbox
      // 
      this.tvMailbox.FullRowSelect = true;
      this.tvMailbox.HideSelection = false;
      this.tvMailbox.Location = new System.Drawing.Point(11, 83);
      this.tvMailbox.Name = "tvMailbox";
      this.tvMailbox.Size = new System.Drawing.Size(178, 402);
      this.tvMailbox.TabIndex = 4;
      this.tvMailbox.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvMailbox_AfterSelect);
      // 
      // btnRename
      // 
      this.btnRename.Location = new System.Drawing.Point(15, 53);
      this.btnRename.Name = "btnRename";
      this.btnRename.Size = new System.Drawing.Size(80, 23);
      this.btnRename.TabIndex = 2;
      this.btnRename.Text = "Rename";
      this.btnRename.UseVisualStyleBackColor = true;
      this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(106, 53);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(80, 23);
      this.btnDelete.TabIndex = 3;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnCreate
      // 
      this.btnCreate.Location = new System.Drawing.Point(106, 24);
      this.btnCreate.Name = "btnCreate";
      this.btnCreate.Size = new System.Drawing.Size(80, 23);
      this.btnCreate.TabIndex = 1;
      this.btnCreate.Text = "Create";
      this.btnCreate.UseVisualStyleBackColor = true;
      this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
      // 
      // btnRefreshMailbox
      // 
      this.btnRefreshMailbox.Location = new System.Drawing.Point(15, 24);
      this.btnRefreshMailbox.Name = "btnRefreshMailbox";
      this.btnRefreshMailbox.Size = new System.Drawing.Size(80, 23);
      this.btnRefreshMailbox.TabIndex = 0;
      this.btnRefreshMailbox.Text = "Refresh";
      this.btnRefreshMailbox.UseVisualStyleBackColor = true;
      this.btnRefreshMailbox.Click += new System.EventHandler(this.btnRefreshMailbox_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.btnExpunge);
      this.groupBox3.Controls.Add(this.btnReset);
      this.groupBox3.Controls.Add(this.lvMail);
      this.groupBox3.Controls.Add(this.lblCount);
      this.groupBox3.Controls.Add(this.btnRefresh);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.cmbMailFlags);
      this.groupBox3.Controls.Add(this.btnSet);
      this.groupBox3.Location = new System.Drawing.Point(218, 98);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(485, 199);
      this.groupBox3.TabIndex = 2;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Email List";
      // 
      // btnExpunge
      // 
      this.btnExpunge.Location = new System.Drawing.Point(320, 24);
      this.btnExpunge.Name = "btnExpunge";
      this.btnExpunge.Size = new System.Drawing.Size(61, 23);
      this.btnExpunge.TabIndex = 4;
      this.btnExpunge.Text = "Expunge";
      this.btnExpunge.UseVisualStyleBackColor = true;
      this.btnExpunge.Click += new System.EventHandler(this.btnExpunge_Click);
      // 
      // btnReset
      // 
      this.btnReset.Location = new System.Drawing.Point(255, 24);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(61, 23);
      this.btnReset.TabIndex = 3;
      this.btnReset.Text = "Reset";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // lvMail
      // 
      this.lvMail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chUid,
            this.chDate,
            this.chFlags,
            this.chSize,
            this.chSubject});
      this.lvMail.FullRowSelect = true;
      this.lvMail.GridLines = true;
      this.lvMail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.lvMail.HideSelection = false;
      this.lvMail.Location = new System.Drawing.Point(11, 53);
      this.lvMail.Name = "lvMail";
      this.lvMail.Size = new System.Drawing.Size(466, 121);
      this.lvMail.TabIndex = 6;
      this.lvMail.UseCompatibleStateImageBehavior = false;
      this.lvMail.View = System.Windows.Forms.View.Details;
      this.lvMail.SelectedIndexChanged += new System.EventHandler(this.lvMail_SelectedIndexChanged);
      // 
      // chUid
      // 
      this.chUid.Text = "Uid";
      this.chUid.Width = 30;
      // 
      // chDate
      // 
      this.chDate.Text = "Date";
      this.chDate.Width = 120;
      // 
      // chFlags
      // 
      this.chFlags.Text = "Flags";
      // 
      // chSize
      // 
      this.chSize.Text = "Size";
      // 
      // chSubject
      // 
      this.chSubject.Text = "Subject";
      this.chSubject.Width = 300;
      // 
      // lblCount
      // 
      this.lblCount.AutoSize = true;
      this.lblCount.Location = new System.Drawing.Point(11, 177);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(45, 13);
      this.lblCount.TabIndex = 7;
      this.lblCount.Text = "lblCount";
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(402, 24);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(75, 23);
      this.btnRefresh.TabIndex = 5;
      this.btnRefresh.Text = "Refresh";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(8, 29);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(52, 13);
      this.label4.TabIndex = 0;
      this.label4.Text = "Mail Flag:";
      // 
      // cmbMailFlags
      // 
      this.cmbMailFlags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMailFlags.FormattingEnabled = true;
      this.cmbMailFlags.Location = new System.Drawing.Point(84, 25);
      this.cmbMailFlags.Name = "cmbMailFlags";
      this.cmbMailFlags.Size = new System.Drawing.Size(100, 21);
      this.cmbMailFlags.TabIndex = 1;
      // 
      // btnSet
      // 
      this.btnSet.Location = new System.Drawing.Point(190, 24);
      this.btnSet.Name = "btnSet";
      this.btnSet.Size = new System.Drawing.Size(61, 23);
      this.btnSet.TabIndex = 2;
      this.btnSet.Text = "Set";
      this.btnSet.UseVisualStyleBackColor = true;
      this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.txtResponse);
      this.groupBox5.Controls.Add(this.label12);
      this.groupBox5.Controls.Add(this.btnViewLog);
      this.groupBox5.Controls.Add(this.txtLogfile);
      this.groupBox5.Controls.Add(this.txtResult);
      this.groupBox5.Controls.Add(this.Label10);
      this.groupBox5.Controls.Add(this.Label9);
      this.groupBox5.Location = new System.Drawing.Point(12, 601);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(691, 110);
      this.groupBox5.TabIndex = 4;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Result and Logging";
      // 
      // txtResponse
      // 
      this.txtResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResponse.Location = new System.Drawing.Point(91, 42);
      this.txtResponse.Multiline = true;
      this.txtResponse.Name = "txtResponse";
      this.txtResponse.ReadOnly = true;
      this.txtResponse.Size = new System.Drawing.Size(594, 33);
      this.txtResponse.TabIndex = 3;
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
      // btnViewLog
      // 
      this.btnViewLog.Location = new System.Drawing.Point(608, 82);
      this.btnViewLog.Name = "btnViewLog";
      this.btnViewLog.Size = new System.Drawing.Size(76, 23);
      this.btnViewLog.TabIndex = 6;
      this.btnViewLog.Text = "&View";
      this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
      // 
      // txtLogfile
      // 
      this.txtLogfile.Location = new System.Drawing.Point(91, 83);
      this.txtLogfile.Name = "txtLogfile";
      this.txtLogfile.Size = new System.Drawing.Size(511, 20);
      this.txtLogfile.TabIndex = 5;
      // 
      // txtResult
      // 
      this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResult.Location = new System.Drawing.Point(91, 19);
      this.txtResult.Name = "txtResult";
      this.txtResult.ReadOnly = true;
      this.txtResult.Size = new System.Drawing.Size(594, 20);
      this.txtResult.TabIndex = 1;
      // 
      // Label10
      // 
      this.Label10.Location = new System.Drawing.Point(16, 86);
      this.Label10.Name = "Label10";
      this.Label10.Size = new System.Drawing.Size(56, 16);
      this.Label10.TabIndex = 4;
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
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.tcBody);
      this.groupBox4.Controls.Add(this.btnNewMessage);
      this.groupBox4.Controls.Add(this.btnAddAttachment);
      this.groupBox4.Controls.Add(this.btnSaveToMailbox);
      this.groupBox4.Controls.Add(this.Label13);
      this.groupBox4.Controls.Add(this.btnSaveMessage);
      this.groupBox4.Controls.Add(this.lvAttachments);
      this.groupBox4.Controls.Add(this.txtSubject);
      this.groupBox4.Controls.Add(this.txtTo);
      this.groupBox4.Controls.Add(this.Label8);
      this.groupBox4.Controls.Add(this.Label7);
      this.groupBox4.Controls.Add(this.Label6);
      this.groupBox4.Controls.Add(this.txtFrom);
      this.groupBox4.Controls.Add(this.Label5);
      this.groupBox4.Controls.Add(this.label11);
      this.groupBox4.Location = new System.Drawing.Point(218, 303);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(485, 292);
      this.groupBox4.TabIndex = 3;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Current Message";
      // 
      // tcBody
      // 
      this.tcBody.Controls.Add(this.tabPlain);
      this.tcBody.Controls.Add(this.tabHtml);
      this.tcBody.Location = new System.Drawing.Point(84, 69);
      this.tcBody.Name = "tcBody";
      this.tcBody.SelectedIndex = 0;
      this.tcBody.Size = new System.Drawing.Size(395, 105);
      this.tcBody.TabIndex = 7;
      // 
      // tabPlain
      // 
      this.tabPlain.Controls.Add(this.txtBody);
      this.tabPlain.Location = new System.Drawing.Point(4, 22);
      this.tabPlain.Name = "tabPlain";
      this.tabPlain.Padding = new System.Windows.Forms.Padding(3);
      this.tabPlain.Size = new System.Drawing.Size(387, 79);
      this.tabPlain.TabIndex = 0;
      this.tabPlain.Text = "Plain";
      this.tabPlain.UseVisualStyleBackColor = true;
      // 
      // txtBody
      // 
      this.txtBody.AcceptsReturn = true;
      this.txtBody.Location = new System.Drawing.Point(0, 0);
      this.txtBody.Multiline = true;
      this.txtBody.Name = "txtBody";
      this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtBody.Size = new System.Drawing.Size(387, 79);
      this.txtBody.TabIndex = 0;
      // 
      // tabHtml
      // 
      this.tabHtml.Controls.Add(this.txtHtml);
      this.tabHtml.Location = new System.Drawing.Point(4, 22);
      this.tabHtml.Name = "tabHtml";
      this.tabHtml.Padding = new System.Windows.Forms.Padding(3);
      this.tabHtml.Size = new System.Drawing.Size(387, 79);
      this.tabHtml.TabIndex = 1;
      this.tabHtml.Text = "HTML";
      this.tabHtml.UseVisualStyleBackColor = true;
      // 
      // txtHtml
      // 
      this.txtHtml.AcceptsReturn = true;
      this.txtHtml.Location = new System.Drawing.Point(0, 0);
      this.txtHtml.Multiline = true;
      this.txtHtml.Name = "txtHtml";
      this.txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtHtml.Size = new System.Drawing.Size(387, 79);
      this.txtHtml.TabIndex = 0;
      // 
      // btnNewMessage
      // 
      this.btnNewMessage.Location = new System.Drawing.Point(84, 260);
      this.btnNewMessage.Name = "btnNewMessage";
      this.btnNewMessage.Size = new System.Drawing.Size(93, 23);
      this.btnNewMessage.TabIndex = 11;
      this.btnNewMessage.Text = "New Message";
      this.btnNewMessage.UseVisualStyleBackColor = true;
      this.btnNewMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
      // 
      // btnAddAttachment
      // 
      this.btnAddAttachment.Location = new System.Drawing.Point(183, 260);
      this.btnAddAttachment.Name = "btnAddAttachment";
      this.btnAddAttachment.Size = new System.Drawing.Size(93, 23);
      this.btnAddAttachment.TabIndex = 12;
      this.btnAddAttachment.Text = "Add Attachment";
      this.btnAddAttachment.UseVisualStyleBackColor = true;
      this.btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click);
      // 
      // btnSaveToMailbox
      // 
      this.btnSaveToMailbox.Location = new System.Drawing.Point(281, 260);
      this.btnSaveToMailbox.Name = "btnSaveToMailbox";
      this.btnSaveToMailbox.Size = new System.Drawing.Size(93, 23);
      this.btnSaveToMailbox.TabIndex = 13;
      this.btnSaveToMailbox.Text = "Save to Mailbox";
      this.btnSaveToMailbox.UseVisualStyleBackColor = true;
      this.btnSaveToMailbox.Click += new System.EventHandler(this.btnSaveToMailbox_Click);
      // 
      // Label13
      // 
      this.Label13.Location = new System.Drawing.Point(6, 201);
      this.Label13.Name = "Label13";
      this.Label13.Size = new System.Drawing.Size(72, 66);
      this.Label13.TabIndex = 10;
      this.Label13.Text = "(Double-click on attachment to save)";
      // 
      // btnSaveMessage
      // 
      this.btnSaveMessage.Location = new System.Drawing.Point(380, 260);
      this.btnSaveMessage.Name = "btnSaveMessage";
      this.btnSaveMessage.Size = new System.Drawing.Size(93, 23);
      this.btnSaveMessage.TabIndex = 14;
      this.btnSaveMessage.Text = "Save MIME...";
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
      this.lvAttachments.Location = new System.Drawing.Point(84, 180);
      this.lvAttachments.Name = "lvAttachments";
      this.lvAttachments.Size = new System.Drawing.Size(393, 74);
      this.lvAttachments.TabIndex = 9;
      this.lvAttachments.UseCompatibleStateImageBehavior = false;
      this.lvAttachments.View = System.Windows.Forms.View.Details;
      this.lvAttachments.DoubleClick += new System.EventHandler(this.lvAttachments_DoubleClick);
      // 
      // colName
      // 
      this.colName.Text = "Name";
      this.colName.Width = 300;
      // 
      // colSize
      // 
      this.colSize.Text = "Size";
      // 
      // txtSubject
      // 
      this.txtSubject.Location = new System.Drawing.Point(84, 43);
      this.txtSubject.Name = "txtSubject";
      this.txtSubject.Size = new System.Drawing.Size(393, 20);
      this.txtSubject.TabIndex = 5;
      // 
      // txtTo
      // 
      this.txtTo.Location = new System.Drawing.Point(302, 18);
      this.txtTo.Name = "txtTo";
      this.txtTo.Size = new System.Drawing.Size(175, 20);
      this.txtTo.TabIndex = 3;
      // 
      // Label8
      // 
      this.Label8.Location = new System.Drawing.Point(8, 181);
      this.Label8.Name = "Label8";
      this.Label8.Size = new System.Drawing.Size(76, 20);
      this.Label8.TabIndex = 8;
      this.Label8.Text = "Attachments:";
      // 
      // Label7
      // 
      this.Label7.Location = new System.Drawing.Point(8, 69);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(36, 20);
      this.Label7.TabIndex = 6;
      this.Label7.Text = "Body:";
      // 
      // Label6
      // 
      this.Label6.Location = new System.Drawing.Point(8, 47);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(44, 20);
      this.Label6.TabIndex = 4;
      this.Label6.Text = "Subject:";
      // 
      // txtFrom
      // 
      this.txtFrom.Location = new System.Drawing.Point(84, 19);
      this.txtFrom.Name = "txtFrom";
      this.txtFrom.Size = new System.Drawing.Size(175, 20);
      this.txtFrom.TabIndex = 1;
      // 
      // Label5
      // 
      this.Label5.Location = new System.Drawing.Point(263, 22);
      this.Label5.Name = "Label5";
      this.Label5.Size = new System.Drawing.Size(28, 20);
      this.Label5.TabIndex = 2;
      this.Label5.Text = "To:";
      // 
      // label11
      // 
      this.label11.Location = new System.Drawing.Point(8, 22);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(48, 20);
      this.label11.TabIndex = 0;
      this.label11.Text = "From:";
      // 
      // frmImap
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(715, 721);
      this.Controls.Add(this.groupBox4);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmImap";
      this.Text = "Auron Email Component - C#.NET IMAP Demo";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.groupBox5.PerformLayout();
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.tcBody.ResumeLayout(false);
      this.tabPlain.ResumeLayout(false);
      this.tabPlain.PerformLayout();
      this.tabHtml.ResumeLayout(false);
      this.tabHtml.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnDisconnect;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.TextBox txtPort;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label Password;
    private System.Windows.Forms.Label Account;
    private System.Windows.Forms.TextBox txtAccount;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtHost;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TreeView tvMailbox;
    private System.Windows.Forms.Button btnRename;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnCreate;
    private System.Windows.Forms.Button btnRefreshMailbox;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmbMailFlags;
    private System.Windows.Forms.Button btnSet;
    internal System.Windows.Forms.GroupBox groupBox5;
    internal System.Windows.Forms.TextBox txtResponse;
    internal System.Windows.Forms.Label label12;
    internal System.Windows.Forms.Button btnViewLog;
    internal System.Windows.Forms.TextBox txtLogfile;
    internal System.Windows.Forms.TextBox txtResult;
    internal System.Windows.Forms.Label Label10;
    internal System.Windows.Forms.Label Label9;
    internal System.Windows.Forms.GroupBox groupBox4;
    internal System.Windows.Forms.Label Label13;
    private System.Windows.Forms.Button btnSaveMessage;
    internal System.Windows.Forms.ListView lvAttachments;
    private System.Windows.Forms.ColumnHeader colName;
    private System.Windows.Forms.ColumnHeader colSize;
    internal System.Windows.Forms.TextBox txtSubject;
    internal System.Windows.Forms.TextBox txtTo;
    internal System.Windows.Forms.Label Label8;
    internal System.Windows.Forms.Label Label7;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.TextBox txtFrom;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Label label11;
    private System.Windows.Forms.Button btnSaveToMailbox;
    private System.Windows.Forms.Button btnNewMessage;
    private System.Windows.Forms.Button btnAddAttachment;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.ListView lvMail;
    private System.Windows.Forms.ColumnHeader chUid;
    private System.Windows.Forms.ColumnHeader chDate;
    private System.Windows.Forms.ColumnHeader chFlags;
    private System.Windows.Forms.ColumnHeader chSize;
    private System.Windows.Forms.ColumnHeader chSubject;
    private System.Windows.Forms.TabControl tcBody;
    private System.Windows.Forms.TabPage tabPlain;
    private System.Windows.Forms.TextBox txtBody;
    private System.Windows.Forms.TabPage tabHtml;
    private System.Windows.Forms.TextBox txtHtml;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnExpunge;
    private System.Windows.Forms.ComboBox cbxSecurity;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Button btnOAuth;
  }
}