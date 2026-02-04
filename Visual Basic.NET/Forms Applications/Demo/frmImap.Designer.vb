<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImap
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmImap))
        Me.groupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtResponse = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.btnViewLog = New System.Windows.Forms.Button()
        Me.txtLogfile = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExpunge = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lvMail = New System.Windows.Forms.ListView()
        Me.chUid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFlags = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSubject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.groupBox4 = New System.Windows.Forms.GroupBox()
        Me.tcBody = New System.Windows.Forms.TabControl()
        Me.tabPlain = New System.Windows.Forms.TabPage()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.tabHtml = New System.Windows.Forms.TabPage()
        Me.txtHtml = New System.Windows.Forms.TextBox()
        Me.btnNewMessage = New System.Windows.Forms.Button()
        Me.btnAddAttachment = New System.Windows.Forms.Button()
        Me.btnSaveToMailbox = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnSaveMessage = New System.Windows.Forms.Button()
        Me.lvAttachments = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOAuth = New System.Windows.Forms.Button()
        Me.cbxSecurity = New System.Windows.Forms.ComboBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.Account = New System.Windows.Forms.Label()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.tvMailbox = New System.Windows.Forms.TreeView()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnRefreshMailbox = New System.Windows.Forms.Button()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbMailFlags = New System.Windows.Forms.ComboBox()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.groupBox5.SuspendLayout()
        Me.groupBox4.SuspendLayout()
        Me.tcBody.SuspendLayout()
        Me.tabPlain.SuspendLayout()
        Me.tabHtml.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox5
        '
        Me.groupBox5.Controls.Add(Me.txtResponse)
        Me.groupBox5.Controls.Add(Me.label12)
        Me.groupBox5.Controls.Add(Me.btnViewLog)
        Me.groupBox5.Controls.Add(Me.txtLogfile)
        Me.groupBox5.Controls.Add(Me.txtResult)
        Me.groupBox5.Controls.Add(Me.Label10)
        Me.groupBox5.Controls.Add(Me.Label9)
        Me.groupBox5.Location = New System.Drawing.Point(12, 600)
        Me.groupBox5.Name = "groupBox5"
        Me.groupBox5.Size = New System.Drawing.Size(691, 110)
        Me.groupBox5.TabIndex = 4
        Me.groupBox5.TabStop = False
        Me.groupBox5.Text = "Result and Logging"
        '
        'txtResponse
        '
        Me.txtResponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponse.Location = New System.Drawing.Point(91, 42)
        Me.txtResponse.Multiline = True
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.ReadOnly = True
        Me.txtResponse.Size = New System.Drawing.Size(594, 33)
        Me.txtResponse.TabIndex = 3
        '
        'label12
        '
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(16, 46)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(60, 12)
        Me.label12.TabIndex = 2
        Me.label12.Text = "Response:"
        '
        'btnViewLog
        '
        Me.btnViewLog.Location = New System.Drawing.Point(608, 82)
        Me.btnViewLog.Name = "btnViewLog"
        Me.btnViewLog.Size = New System.Drawing.Size(76, 23)
        Me.btnViewLog.TabIndex = 6
        Me.btnViewLog.Text = "&View"
        '
        'txtLogfile
        '
        Me.txtLogfile.Location = New System.Drawing.Point(91, 83)
        Me.txtLogfile.Name = "txtLogfile"
        Me.txtLogfile.Size = New System.Drawing.Size(511, 20)
        Me.txtLogfile.TabIndex = 5
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(91, 19)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(594, 20)
        Me.txtResult.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "L&ogfile:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 12)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Res&ult:"
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(11, 177)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(45, 13)
        Me.lblCount.TabIndex = 7
        Me.lblCount.Text = "lblCount"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(402, 24)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExpunge
        '
        Me.btnExpunge.Location = New System.Drawing.Point(320, 24)
        Me.btnExpunge.Name = "btnExpunge"
        Me.btnExpunge.Size = New System.Drawing.Size(61, 23)
        Me.btnExpunge.TabIndex = 4
        Me.btnExpunge.Text = "Expunge"
        Me.btnExpunge.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(255, 24)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(61, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lvMail
        '
        Me.lvMail.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chUid, Me.chDate, Me.chFlags, Me.chSize, Me.chSubject})
        Me.lvMail.FullRowSelect = True
        Me.lvMail.GridLines = True
        Me.lvMail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvMail.HideSelection = False
        Me.lvMail.Location = New System.Drawing.Point(11, 53)
        Me.lvMail.Name = "lvMail"
        Me.lvMail.Size = New System.Drawing.Size(466, 121)
        Me.lvMail.TabIndex = 6
        Me.lvMail.UseCompatibleStateImageBehavior = False
        Me.lvMail.View = System.Windows.Forms.View.Details
        '
        'chUid
        '
        Me.chUid.Text = "Uid"
        Me.chUid.Width = 30
        '
        'chDate
        '
        Me.chDate.Text = "Date"
        Me.chDate.Width = 120
        '
        'chFlags
        '
        Me.chFlags.Text = "Flags"
        '
        'chSize
        '
        Me.chSize.Text = "Size"
        '
        'chSubject
        '
        Me.chSubject.Text = "Subject"
        Me.chSubject.Width = 300
        '
        'groupBox4
        '
        Me.groupBox4.Controls.Add(Me.tcBody)
        Me.groupBox4.Controls.Add(Me.btnNewMessage)
        Me.groupBox4.Controls.Add(Me.btnAddAttachment)
        Me.groupBox4.Controls.Add(Me.btnSaveToMailbox)
        Me.groupBox4.Controls.Add(Me.Label13)
        Me.groupBox4.Controls.Add(Me.btnSaveMessage)
        Me.groupBox4.Controls.Add(Me.lvAttachments)
        Me.groupBox4.Controls.Add(Me.txtSubject)
        Me.groupBox4.Controls.Add(Me.txtTo)
        Me.groupBox4.Controls.Add(Me.Label8)
        Me.groupBox4.Controls.Add(Me.Label7)
        Me.groupBox4.Controls.Add(Me.Label6)
        Me.groupBox4.Controls.Add(Me.txtFrom)
        Me.groupBox4.Controls.Add(Me.Label5)
        Me.groupBox4.Controls.Add(Me.label11)
        Me.groupBox4.Location = New System.Drawing.Point(218, 302)
        Me.groupBox4.Name = "groupBox4"
        Me.groupBox4.Size = New System.Drawing.Size(485, 292)
        Me.groupBox4.TabIndex = 3
        Me.groupBox4.TabStop = False
        Me.groupBox4.Text = "Current Message"
        '
        'tcBody
        '
        Me.tcBody.Controls.Add(Me.tabPlain)
        Me.tcBody.Controls.Add(Me.tabHtml)
        Me.tcBody.Location = New System.Drawing.Point(84, 69)
        Me.tcBody.Name = "tcBody"
        Me.tcBody.SelectedIndex = 0
        Me.tcBody.Size = New System.Drawing.Size(395, 105)
        Me.tcBody.TabIndex = 7
        '
        'tabPlain
        '
        Me.tabPlain.Controls.Add(Me.txtBody)
        Me.tabPlain.Location = New System.Drawing.Point(4, 22)
        Me.tabPlain.Name = "tabPlain"
        Me.tabPlain.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPlain.Size = New System.Drawing.Size(387, 79)
        Me.tabPlain.TabIndex = 0
        Me.tabPlain.Text = "Plain"
        Me.tabPlain.UseVisualStyleBackColor = True
        '
        'txtBody
        '
        Me.txtBody.AcceptsReturn = True
        Me.txtBody.Location = New System.Drawing.Point(0, 0)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBody.Size = New System.Drawing.Size(387, 79)
        Me.txtBody.TabIndex = 0
        '
        'tabHtml
        '
        Me.tabHtml.Controls.Add(Me.txtHtml)
        Me.tabHtml.Location = New System.Drawing.Point(4, 22)
        Me.tabHtml.Name = "tabHtml"
        Me.tabHtml.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHtml.Size = New System.Drawing.Size(387, 79)
        Me.tabHtml.TabIndex = 1
        Me.tabHtml.Text = "HTML"
        Me.tabHtml.UseVisualStyleBackColor = True
        '
        'txtHtml
        '
        Me.txtHtml.AcceptsReturn = True
        Me.txtHtml.Location = New System.Drawing.Point(0, 0)
        Me.txtHtml.Multiline = True
        Me.txtHtml.Name = "txtHtml"
        Me.txtHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHtml.Size = New System.Drawing.Size(387, 79)
        Me.txtHtml.TabIndex = 0
        '
        'btnNewMessage
        '
        Me.btnNewMessage.Location = New System.Drawing.Point(84, 260)
        Me.btnNewMessage.Name = "btnNewMessage"
        Me.btnNewMessage.Size = New System.Drawing.Size(93, 23)
        Me.btnNewMessage.TabIndex = 11
        Me.btnNewMessage.Text = "New Message"
        Me.btnNewMessage.UseVisualStyleBackColor = True
        '
        'btnAddAttachment
        '
        Me.btnAddAttachment.Location = New System.Drawing.Point(183, 260)
        Me.btnAddAttachment.Name = "btnAddAttachment"
        Me.btnAddAttachment.Size = New System.Drawing.Size(93, 23)
        Me.btnAddAttachment.TabIndex = 12
        Me.btnAddAttachment.Text = "Add Attachment"
        Me.btnAddAttachment.UseVisualStyleBackColor = True
        '
        'btnSaveToMailbox
        '
        Me.btnSaveToMailbox.Location = New System.Drawing.Point(281, 260)
        Me.btnSaveToMailbox.Name = "btnSaveToMailbox"
        Me.btnSaveToMailbox.Size = New System.Drawing.Size(93, 23)
        Me.btnSaveToMailbox.TabIndex = 13
        Me.btnSaveToMailbox.Text = "Save to Mailbox"
        Me.btnSaveToMailbox.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(6, 201)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 66)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "(Double-click on attachment to save)"
        '
        'btnSaveMessage
        '
        Me.btnSaveMessage.Location = New System.Drawing.Point(380, 260)
        Me.btnSaveMessage.Name = "btnSaveMessage"
        Me.btnSaveMessage.Size = New System.Drawing.Size(93, 23)
        Me.btnSaveMessage.TabIndex = 14
        Me.btnSaveMessage.Text = "Save MIME..."
        '
        'lvAttachments
        '
        Me.lvAttachments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colSize})
        Me.lvAttachments.FullRowSelect = True
        Me.lvAttachments.GridLines = True
        Me.lvAttachments.HideSelection = False
        Me.lvAttachments.Location = New System.Drawing.Point(84, 180)
        Me.lvAttachments.Name = "lvAttachments"
        Me.lvAttachments.Size = New System.Drawing.Size(393, 74)
        Me.lvAttachments.TabIndex = 9
        Me.lvAttachments.UseCompatibleStateImageBehavior = False
        Me.lvAttachments.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 300
        '
        'colSize
        '
        Me.colSize.Text = "Size"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(84, 43)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(393, 20)
        Me.txtSubject.TabIndex = 5
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(302, 18)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(175, 20)
        Me.txtTo.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Attachments:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Body:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Subject:"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(84, 19)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(175, 20)
        Me.txtFrom.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(263, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "To:"
        '
        'label11
        '
        Me.label11.Location = New System.Drawing.Point(8, 22)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(48, 20)
        Me.label11.TabIndex = 0
        Me.label11.Text = "From:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(8, 29)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(52, 13)
        Me.label4.TabIndex = 0
        Me.label4.Text = "Mail Flag:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btnOAuth)
        Me.groupBox1.Controls.Add(Me.cbxSecurity)
        Me.groupBox1.Controls.Add(Me.label19)
        Me.groupBox1.Controls.Add(Me.btnDisconnect)
        Me.groupBox1.Controls.Add(Me.btnConnect)
        Me.groupBox1.Controls.Add(Me.txtPassword)
        Me.groupBox1.Controls.Add(Me.txtPort)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.Password)
        Me.groupBox1.Controls.Add(Me.Account)
        Me.groupBox1.Controls.Add(Me.txtAccount)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.txtHost)
        Me.groupBox1.Location = New System.Drawing.Point(12, 11)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(691, 80)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Connection"
        '
        'btnOAuth
        '
        Me.btnOAuth.Location = New System.Drawing.Point(381, 17)
        Me.btnOAuth.Name = "btnOAuth"
        Me.btnOAuth.Size = New System.Drawing.Size(108, 23)
        Me.btnOAuth.TabIndex = 18
        Me.btnOAuth.Text = "OAuth Settings..."
        Me.btnOAuth.UseVisualStyleBackColor = True
        '
        'cbxSecurity
        '
        Me.cbxSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSecurity.FormattingEnabled = True
        Me.cbxSecurity.Location = New System.Drawing.Point(275, 18)
        Me.cbxSecurity.Name = "cbxSecurity"
        Me.cbxSecurity.Size = New System.Drawing.Size(100, 21)
        Me.cbxSecurity.TabIndex = 17
        '
        'label19
        '
        Me.label19.Location = New System.Drawing.Point(199, 22)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(49, 18)
        Me.label19.TabIndex = 16
        Me.label19.Text = "&Security:"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(609, 51)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.btnDisconnect.TabIndex = 12
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(526, 51)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 11
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(275, 46)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(609, 22)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(74, 20)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = "993"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(523, 25)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(29, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Port:"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(199, 52)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(56, 13)
        Me.Password.TabIndex = 9
        Me.Password.Text = "Password:"
        '
        'Account
        '
        Me.Account.AutoSize = True
        Me.Account.Location = New System.Drawing.Point(13, 53)
        Me.Account.Name = "Account"
        Me.Account.Size = New System.Drawing.Size(50, 13)
        Me.Account.TabIndex = 7
        Me.Account.Text = "Account:"
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(91, 46)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(100, 20)
        Me.txtAccount.TabIndex = 8
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Host:"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(91, 19)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(100, 20)
        Me.txtHost.TabIndex = 1
        Me.txtHost.Text = "imap.gmail.com"
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(190, 24)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(61, 23)
        Me.btnSet.TabIndex = 2
        Me.btnSet.Text = "Set"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'tvMailbox
        '
        Me.tvMailbox.FullRowSelect = True
        Me.tvMailbox.HideSelection = False
        Me.tvMailbox.Location = New System.Drawing.Point(11, 83)
        Me.tvMailbox.Name = "tvMailbox"
        Me.tvMailbox.Size = New System.Drawing.Size(178, 402)
        Me.tvMailbox.TabIndex = 4
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(15, 53)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(80, 23)
        Me.btnRename.TabIndex = 2
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(106, 53)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(106, 24)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(80, 23)
        Me.btnCreate.TabIndex = 1
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnRefreshMailbox
        '
        Me.btnRefreshMailbox.Location = New System.Drawing.Point(15, 24)
        Me.btnRefreshMailbox.Name = "btnRefreshMailbox"
        Me.btnRefreshMailbox.Size = New System.Drawing.Size(80, 23)
        Me.btnRefreshMailbox.TabIndex = 0
        Me.btnRefreshMailbox.Text = "Refresh"
        Me.btnRefreshMailbox.UseVisualStyleBackColor = True
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.btnExpunge)
        Me.groupBox3.Controls.Add(Me.btnReset)
        Me.groupBox3.Controls.Add(Me.lvMail)
        Me.groupBox3.Controls.Add(Me.lblCount)
        Me.groupBox3.Controls.Add(Me.btnRefresh)
        Me.groupBox3.Controls.Add(Me.label4)
        Me.groupBox3.Controls.Add(Me.cmbMailFlags)
        Me.groupBox3.Controls.Add(Me.btnSet)
        Me.groupBox3.Location = New System.Drawing.Point(218, 97)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(485, 199)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Email List"
        '
        'cmbMailFlags
        '
        Me.cmbMailFlags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMailFlags.FormattingEnabled = True
        Me.cmbMailFlags.Location = New System.Drawing.Point(84, 25)
        Me.cmbMailFlags.Name = "cmbMailFlags"
        Me.cmbMailFlags.Size = New System.Drawing.Size(100, 21)
        Me.cmbMailFlags.TabIndex = 1
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.tvMailbox)
        Me.groupBox2.Controls.Add(Me.btnRename)
        Me.groupBox2.Controls.Add(Me.btnDelete)
        Me.groupBox2.Controls.Add(Me.btnCreate)
        Me.groupBox2.Controls.Add(Me.btnRefreshMailbox)
        Me.groupBox2.Location = New System.Drawing.Point(12, 97)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(200, 497)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Mailbox"
        '
        'frmImap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 721)
        Me.Controls.Add(Me.groupBox5)
        Me.Controls.Add(Me.groupBox4)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me.groupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmImap"
        Me.Text = "Auron Email Component - VB.NET IMAP Demo"
        Me.groupBox5.ResumeLayout(False)
        Me.groupBox5.PerformLayout()
        Me.groupBox4.ResumeLayout(False)
        Me.groupBox4.PerformLayout()
        Me.tcBody.ResumeLayout(False)
        Me.tabPlain.ResumeLayout(False)
        Me.tabPlain.PerformLayout()
        Me.tabHtml.ResumeLayout(False)
        Me.tabHtml.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents groupBox5 As GroupBox
  Friend WithEvents txtResponse As TextBox
  Friend WithEvents label12 As Label
  Friend WithEvents btnViewLog As Button
  Friend WithEvents txtLogfile As TextBox
  Friend WithEvents txtResult As TextBox
  Friend WithEvents Label10 As Label
  Friend WithEvents Label9 As Label
  Private WithEvents lblCount As Label
  Private WithEvents btnRefresh As Button
  Private WithEvents btnExpunge As Button
  Private WithEvents btnReset As Button
  Private WithEvents lvMail As ListView
  Private WithEvents chUid As ColumnHeader
  Private WithEvents chDate As ColumnHeader
  Private WithEvents chFlags As ColumnHeader
  Private WithEvents chSize As ColumnHeader
  Private WithEvents chSubject As ColumnHeader
  Friend WithEvents groupBox4 As GroupBox
  Private WithEvents tcBody As TabControl
  Private WithEvents tabPlain As TabPage
  Private WithEvents txtBody As TextBox
  Private WithEvents tabHtml As TabPage
  Private WithEvents txtHtml As TextBox
  Private WithEvents btnNewMessage As Button
  Private WithEvents btnAddAttachment As Button
  Private WithEvents btnSaveToMailbox As Button
  Friend WithEvents Label13 As Label
  Private WithEvents btnSaveMessage As Button
  Friend WithEvents lvAttachments As ListView
  Private WithEvents colName As ColumnHeader
  Private WithEvents colSize As ColumnHeader
  Friend WithEvents txtSubject As TextBox
  Friend WithEvents txtTo As TextBox
  Friend WithEvents Label8 As Label
  Friend WithEvents Label7 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents txtFrom As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents label11 As Label
  Private WithEvents label4 As Label
  Private WithEvents groupBox1 As GroupBox
  Private WithEvents btnDisconnect As Button
  Private WithEvents btnConnect As Button
    Private WithEvents txtPassword As TextBox
    Private WithEvents txtPort As TextBox
    Private WithEvents label2 As Label
    Private WithEvents Password As Label
    Private WithEvents Account As Label
    Private WithEvents txtAccount As TextBox
    Private WithEvents label1 As Label
    Private WithEvents txtHost As TextBox
    Private WithEvents btnSet As Button
    Private WithEvents tvMailbox As TreeView
    Private WithEvents btnRename As Button
    Private WithEvents btnDelete As Button
    Private WithEvents btnCreate As Button
    Private WithEvents btnRefreshMailbox As Button
    Private WithEvents groupBox3 As GroupBox
    Private WithEvents cmbMailFlags As ComboBox
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents btnOAuth As Button
    Private WithEvents cbxSecurity As ComboBox
    Private WithEvents label19 As Label
End Class
