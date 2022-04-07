<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmtp
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
        Me.cbxFormat = New System.Windows.Forms.ComboBox()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxPriority = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnBrowseAttachment = New System.Windows.Forms.Button()
        Me.txtAttachments = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.cbxEncoding = New System.Windows.Forms.ComboBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtBccAddress = New System.Windows.Forms.TextBox()
        Me.label17 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.label16 = New System.Windows.Forms.Label()
        Me.txtCcAddress = New System.Windows.Forms.TextBox()
        Me.txtToAddress = New System.Windows.Forms.TextBox()
        Me.label20 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFromName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFromAddress = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtLastSmtpResponse = New System.Windows.Forms.TextBox()
        Me.label18 = New System.Windows.Forms.Label()
        Me.btnViewLog = New System.Windows.Forms.Button()
        Me.txtLogfile = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.label14 = New System.Windows.Forms.Label()
        Me.label13 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnOAuth = New System.Windows.Forms.Button()
        Me.cbxSecurity = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxFormat
        '
        Me.cbxFormat.Location = New System.Drawing.Point(110, 110)
        Me.cbxFormat.Name = "cbxFormat"
        Me.cbxFormat.Size = New System.Drawing.Size(100, 21)
        Me.cbxFormat.TabIndex = 5
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(110, 43)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(455, 62)
        Me.txtBody.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(22, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 14)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Bod&y:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(22, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&To:"
        '
        'cbxPriority
        '
        Me.cbxPriority.Location = New System.Drawing.Point(450, 110)
        Me.cbxPriority.Name = "cbxPriority"
        Me.cbxPriority.Size = New System.Drawing.Size(115, 21)
        Me.cbxPriority.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(404, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Prio&rity:"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(110, 19)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(455, 20)
        Me.txtSubject.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnBrowseAttachment)
        Me.GroupBox4.Controls.Add(Me.txtAttachments)
        Me.GroupBox4.Controls.Add(Me.label15)
        Me.GroupBox4.Controls.Add(Me.cbxEncoding)
        Me.GroupBox4.Controls.Add(Me.label12)
        Me.GroupBox4.Controls.Add(Me.cbxPriority)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.cbxFormat)
        Me.GroupBox4.Controls.Add(Me.txtBody)
        Me.GroupBox4.Controls.Add(Me.txtSubject)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.btnSend)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 247)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(572, 195)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Message"
        '
        'btnBrowseAttachment
        '
        Me.btnBrowseAttachment.Location = New System.Drawing.Point(535, 139)
        Me.btnBrowseAttachment.Name = "btnBrowseAttachment"
        Me.btnBrowseAttachment.Size = New System.Drawing.Size(30, 19)
        Me.btnBrowseAttachment.TabIndex = 12
        Me.btnBrowseAttachment.Text = "..."
        '
        'txtAttachments
        '
        Me.txtAttachments.Location = New System.Drawing.Point(110, 139)
        Me.txtAttachments.Name = "txtAttachments"
        Me.txtAttachments.Size = New System.Drawing.Size(419, 20)
        Me.txtAttachments.TabIndex = 11
        '
        'label15
        '
        Me.label15.Location = New System.Drawing.Point(22, 142)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(78, 16)
        Me.label15.TabIndex = 10
        Me.label15.Text = "&Attachment(s):"
        '
        'cbxEncoding
        '
        Me.cbxEncoding.Location = New System.Drawing.Point(285, 110)
        Me.cbxEncoding.Name = "cbxEncoding"
        Me.cbxEncoding.Size = New System.Drawing.Size(100, 21)
        Me.cbxEncoding.TabIndex = 7
        '
        'label12
        '
        Me.label12.Location = New System.Drawing.Point(230, 115)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(49, 19)
        Me.label12.TabIndex = 6
        Me.label12.Text = "Char.&set:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(22, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "S&ubject:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(22, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "&Format:"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(110, 165)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(455, 22)
        Me.btnSend.TabIndex = 13
        Me.btnSend.Text = "S&end"
        '
        'txtBccAddress
        '
        Me.txtBccAddress.Location = New System.Drawing.Point(392, 42)
        Me.txtBccAddress.Name = "txtBccAddress"
        Me.txtBccAddress.Size = New System.Drawing.Size(173, 20)
        Me.txtBccAddress.TabIndex = 5
        '
        'label17
        '
        Me.label17.Location = New System.Drawing.Point(336, 45)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(29, 16)
        Me.label17.TabIndex = 4
        Me.label17.Text = "&Bcc:"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txtBccAddress)
        Me.groupBox2.Controls.Add(Me.label17)
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.Controls.Add(Me.txtCcAddress)
        Me.groupBox2.Controls.Add(Me.Label4)
        Me.groupBox2.Controls.Add(Me.txtToAddress)
        Me.groupBox2.Location = New System.Drawing.Point(12, 171)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(572, 70)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Recipients"
        '
        'label16
        '
        Me.label16.Location = New System.Drawing.Point(22, 45)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(36, 16)
        Me.label16.TabIndex = 2
        Me.label16.Text = "&Cc:"
        '
        'txtCcAddress
        '
        Me.txtCcAddress.Location = New System.Drawing.Point(110, 42)
        Me.txtCcAddress.Name = "txtCcAddress"
        Me.txtCcAddress.Size = New System.Drawing.Size(220, 20)
        Me.txtCcAddress.TabIndex = 3
        '
        'txtToAddress
        '
        Me.txtToAddress.Location = New System.Drawing.Point(110, 19)
        Me.txtToAddress.Name = "txtToAddress"
        Me.txtToAddress.Size = New System.Drawing.Size(220, 20)
        Me.txtToAddress.TabIndex = 1
        '
        'label20
        '
        Me.label20.Location = New System.Drawing.Point(336, 120)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(76, 16)
        Me.label20.TabIndex = 12
        Me.label20.Text = "&Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOAuth)
        Me.GroupBox1.Controls.Add(Me.cbxSecurity)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFromName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtFromAddress)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.label19)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtAccount)
        Me.GroupBox1.Controls.Add(Me.label11)
        Me.GroupBox1.Controls.Add(Me.label9)
        Me.GroupBox1.Controls.Add(Me.txtHost)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.label20)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(572, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SMTP Server"
        '
        'txtFromName
        '
        Me.txtFromName.Location = New System.Drawing.Point(392, 116)
        Me.txtFromName.Name = "txtFromName"
        Me.txtFromName.Size = New System.Drawing.Size(173, 20)
        Me.txtFromName.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Sender E-ma&il:"
        '
        'txtFromAddress
        '
        Me.txtFromAddress.Location = New System.Drawing.Point(110, 117)
        Me.txtFromAddress.Name = "txtFromAddress"
        Me.txtFromAddress.Size = New System.Drawing.Size(218, 20)
        Me.txtFromAddress.TabIndex = 11
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(110, 45)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(55, 20)
        Me.txtPort.TabIndex = 3
        '
        'label19
        '
        Me.label19.Location = New System.Drawing.Point(22, 48)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(36, 16)
        Me.label19.TabIndex = 2
        Me.label19.Text = "&Port:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(392, 90)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(173, 20)
        Me.txtPassword.TabIndex = 9
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(110, 91)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(218, 20)
        Me.txtAccount.TabIndex = 7
        '
        'label11
        '
        Me.label11.Location = New System.Drawing.Point(334, 94)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(57, 16)
        Me.label11.TabIndex = 8
        Me.label11.Text = "Pass&word:"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(22, 94)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(50, 16)
        Me.label9.TabIndex = 6
        Me.label9.Text = "&Account:"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(110, 19)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(219, 20)
        Me.txtHost.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "H&ost:"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtLastSmtpResponse)
        Me.groupBox3.Controls.Add(Me.label18)
        Me.groupBox3.Controls.Add(Me.btnViewLog)
        Me.groupBox3.Controls.Add(Me.txtLogfile)
        Me.groupBox3.Controls.Add(Me.txtResult)
        Me.groupBox3.Controls.Add(Me.label14)
        Me.groupBox3.Controls.Add(Me.label13)
        Me.groupBox3.Location = New System.Drawing.Point(12, 448)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(571, 109)
        Me.groupBox3.TabIndex = 3
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Result and Logging"
        '
        'txtLastSmtpResponse
        '
        Me.txtLastSmtpResponse.Location = New System.Drawing.Point(110, 42)
        Me.txtLastSmtpResponse.Multiline = True
        Me.txtLastSmtpResponse.Name = "txtLastSmtpResponse"
        Me.txtLastSmtpResponse.ReadOnly = True
        Me.txtLastSmtpResponse.Size = New System.Drawing.Size(455, 32)
        Me.txtLastSmtpResponse.TabIndex = 3
        '
        'label18
        '
        Me.label18.Location = New System.Drawing.Point(22, 42)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(96, 16)
        Me.label18.TabIndex = 2
        Me.label18.Text = "Response:"
        '
        'btnViewLog
        '
        Me.btnViewLog.Location = New System.Drawing.Point(516, 80)
        Me.btnViewLog.Name = "btnViewLog"
        Me.btnViewLog.Size = New System.Drawing.Size(49, 21)
        Me.btnViewLog.TabIndex = 6
        Me.btnViewLog.Text = "&View"
        '
        'txtLogfile
        '
        Me.txtLogfile.Location = New System.Drawing.Point(110, 79)
        Me.txtLogfile.Name = "txtLogfile"
        Me.txtLogfile.Size = New System.Drawing.Size(400, 20)
        Me.txtLogfile.TabIndex = 5
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(110, 19)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(455, 20)
        Me.txtResult.TabIndex = 1
        '
        'label14
        '
        Me.label14.Location = New System.Drawing.Point(22, 82)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(70, 16)
        Me.label14.TabIndex = 4
        Me.label14.Text = "&Logfile:"
        '
        'label13
        '
        Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(22, 22)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(66, 16)
        Me.label13.TabIndex = 0
        Me.label13.Text = "Result:"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(9, 570)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(31, 13)
        Me.lblInfo.TabIndex = 6
        Me.lblInfo.Text = "[Info]"
        '
        'btnOAuth
        '
        Me.btnOAuth.Location = New System.Drawing.Point(391, 44)
        Me.btnOAuth.Name = "btnOAuth"
        Me.btnOAuth.Size = New System.Drawing.Size(174, 23)
        Me.btnOAuth.TabIndex = 16
        Me.btnOAuth.Text = "OAuth Settings..."
        Me.btnOAuth.UseVisualStyleBackColor = True
        '
        'cbxSecurity
        '
        Me.cbxSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSecurity.FormattingEnabled = True
        Me.cbxSecurity.Location = New System.Drawing.Point(391, 17)
        Me.cbxSecurity.Name = "cbxSecurity"
        Me.cbxSecurity.Size = New System.Drawing.Size(174, 21)
        Me.cbxSecurity.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(336, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "&Security:"
        '
        'frmSmtp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 593)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSmtp"
        Me.Text = "Auron Email Component - VB.NET SMTP Demo"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxFormat As System.Windows.Forms.ComboBox
    Friend WithEvents txtBody As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxPriority As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents btnBrowseAttachment As System.Windows.Forms.Button
    Private WithEvents txtAttachments As System.Windows.Forms.TextBox
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents cbxEncoding As System.Windows.Forms.ComboBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents txtBccAddress As System.Windows.Forms.TextBox
    Friend WithEvents label17 As System.Windows.Forms.Label
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents label16 As System.Windows.Forms.Label
    Friend WithEvents txtCcAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtToAddress As System.Windows.Forms.TextBox
    Friend WithEvents label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFromName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFromAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents txtAccount As System.Windows.Forms.TextBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastSmtpResponse As System.Windows.Forms.TextBox
    Friend WithEvents label18 As System.Windows.Forms.Label
    Private WithEvents btnViewLog As System.Windows.Forms.Button
    Private WithEvents txtLogfile As System.Windows.Forms.TextBox
    Private WithEvents txtResult As System.Windows.Forms.TextBox
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Private WithEvents btnOAuth As Button
    Private WithEvents cbxSecurity As ComboBox
    Private WithEvents Label2 As Label
End Class
