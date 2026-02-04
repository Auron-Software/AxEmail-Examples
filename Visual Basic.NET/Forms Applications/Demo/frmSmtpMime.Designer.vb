<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmtpMime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSmtpMime))
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtLastSmtpResponse = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.cbSecure = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.cbAuthentication = New System.Windows.Forms.CheckBox()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnViewLog = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnCreateMIME = New System.Windows.Forms.Button()
        Me.txtMIMEContents = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.btnLoadMIME = New System.Windows.Forms.Button()
        Me.txtMIMEFile = New System.Windows.Forms.TextBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtLogfile = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.label13 = New System.Windows.Forms.Label()
        Me.label14 = New System.Windows.Forms.Label()
        Me.groupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.groupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(392, 19)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(55, 20)
        Me.txtPort.TabIndex = 3
        Me.txtPort.Text = "25"
        '
        'txtLastSmtpResponse
        '
        Me.txtLastSmtpResponse.Location = New System.Drawing.Point(110, 45)
        Me.txtLastSmtpResponse.Multiline = True
        Me.txtLastSmtpResponse.Name = "txtLastSmtpResponse"
        Me.txtLastSmtpResponse.ReadOnly = True
        Me.txtLastSmtpResponse.Size = New System.Drawing.Size(441, 32)
        Me.txtLastSmtpResponse.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.label19)
        Me.GroupBox1.Controls.Add(Me.cbSecure)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtAccount)
        Me.GroupBox1.Controls.Add(Me.label11)
        Me.GroupBox1.Controls.Add(Me.label9)
        Me.GroupBox1.Controls.Add(Me.cbAuthentication)
        Me.GroupBox1.Controls.Add(Me.txtHost)
        Me.GroupBox1.Controls.Add(Me.label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SMTP Server"
        '
        'label19
        '
        Me.label19.Location = New System.Drawing.Point(336, 22)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(36, 16)
        Me.label19.TabIndex = 2
        Me.label19.Text = "&Port:"
        '
        'cbSecure
        '
        Me.cbSecure.Location = New System.Drawing.Point(110, 44)
        Me.cbSecure.Name = "cbSecure"
        Me.cbSecure.Size = New System.Drawing.Size(216, 17)
        Me.cbSecure.TabIndex = 4
        Me.cbSecure.Text = "Secure Mail Server (SSL/TLS)"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(392, 84)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(158, 20)
        Me.txtPassword.TabIndex = 9
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(177, 84)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(151, 20)
        Me.txtAccount.TabIndex = 7
        '
        'label11
        '
        Me.label11.Location = New System.Drawing.Point(336, 87)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(57, 16)
        Me.label11.TabIndex = 8
        Me.label11.Text = "Pass&word:"
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(128, 87)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(50, 16)
        Me.label9.TabIndex = 6
        Me.label9.Text = "&Account:"
        '
        'cbAuthentication
        '
        Me.cbAuthentication.Location = New System.Drawing.Point(110, 62)
        Me.cbAuthentication.Name = "cbAuthentication"
        Me.cbAuthentication.Size = New System.Drawing.Size(216, 17)
        Me.cbAuthentication.TabIndex = 5
        Me.cbAuthentication.Text = "Server re&quires authentication"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(110, 19)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(219, 20)
        Me.txtHost.TabIndex = 1
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(22, 22)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(70, 16)
        Me.label5.TabIndex = 0
        Me.label5.Text = "H&ost:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Response:"
        '
        'btnViewLog
        '
        Me.btnViewLog.Location = New System.Drawing.Point(504, 83)
        Me.btnViewLog.Name = "btnViewLog"
        Me.btnViewLog.Size = New System.Drawing.Size(47, 21)
        Me.btnViewLog.TabIndex = 6
        Me.btnViewLog.Text = "&View"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnCreateMIME)
        Me.GroupBox4.Controls.Add(Me.txtMIMEContents)
        Me.GroupBox4.Controls.Add(Me.label4)
        Me.GroupBox4.Controls.Add(Me.btnLoadMIME)
        Me.GroupBox4.Controls.Add(Me.txtMIMEFile)
        Me.GroupBox4.Controls.Add(Me.label15)
        Me.GroupBox4.Controls.Add(Me.btnSend)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 130)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(561, 238)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Message"
        '
        'btnCreateMIME
        '
        Me.btnCreateMIME.Location = New System.Drawing.Point(481, 19)
        Me.btnCreateMIME.Name = "btnCreateMIME"
        Me.btnCreateMIME.Size = New System.Drawing.Size(70, 22)
        Me.btnCreateMIME.TabIndex = 3
        Me.btnCreateMIME.Text = "&Create..."
        '
        'txtMIMEContents
        '
        Me.txtMIMEContents.Location = New System.Drawing.Point(110, 47)
        Me.txtMIMEContents.Multiline = True
        Me.txtMIMEContents.Name = "txtMIMEContents"
        Me.txtMIMEContents.ReadOnly = True
        Me.txtMIMEContents.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMIMEContents.Size = New System.Drawing.Size(441, 152)
        Me.txtMIMEContents.TabIndex = 5
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(22, 47)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(80, 16)
        Me.label4.TabIndex = 4
        Me.label4.Text = "MIME Co&ntent:"
        '
        'btnLoadMIME
        '
        Me.btnLoadMIME.Location = New System.Drawing.Point(400, 19)
        Me.btnLoadMIME.Name = "btnLoadMIME"
        Me.btnLoadMIME.Size = New System.Drawing.Size(70, 22)
        Me.btnLoadMIME.TabIndex = 2
        Me.btnLoadMIME.Text = "Loa&d..."
        '
        'txtMIMEFile
        '
        Me.txtMIMEFile.Location = New System.Drawing.Point(110, 19)
        Me.txtMIMEFile.Name = "txtMIMEFile"
        Me.txtMIMEFile.ReadOnly = True
        Me.txtMIMEFile.Size = New System.Drawing.Size(282, 20)
        Me.txtMIMEFile.TabIndex = 1
        '
        'label15
        '
        Me.label15.Location = New System.Drawing.Point(22, 23)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(78, 16)
        Me.label15.TabIndex = 0
        Me.label15.Text = "&MIME File:"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(110, 210)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(441, 22)
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "S&end"
        '
        'txtLogfile
        '
        Me.txtLogfile.Location = New System.Drawing.Point(110, 83)
        Me.txtLogfile.Name = "txtLogfile"
        Me.txtLogfile.Size = New System.Drawing.Size(388, 20)
        Me.txtLogfile.TabIndex = 5
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(110, 19)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(441, 20)
        Me.txtResult.TabIndex = 1
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
        'label14
        '
        Me.label14.Location = New System.Drawing.Point(22, 87)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(70, 16)
        Me.label14.TabIndex = 4
        Me.label14.Text = "&Logfile:"
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.txtLastSmtpResponse)
        Me.groupBox3.Controls.Add(Me.Label2)
        Me.groupBox3.Controls.Add(Me.btnViewLog)
        Me.groupBox3.Controls.Add(Me.txtLogfile)
        Me.groupBox3.Controls.Add(Me.txtResult)
        Me.groupBox3.Controls.Add(Me.label14)
        Me.groupBox3.Controls.Add(Me.label13)
        Me.groupBox3.Location = New System.Drawing.Point(11, 374)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(561, 111)
        Me.groupBox3.TabIndex = 2
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Result and Logging"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(8, 498)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(31, 13)
        Me.lblInfo.TabIndex = 7
        Me.lblInfo.Text = "[Info]"
        '
        'frmSmtpMime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 520)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.groupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSmtpMime"
        Me.Text = "Auron Email Component - VB.NET SMTP (MIME) Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.groupBox3.ResumeLayout(False)
        Me.groupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents txtLastSmtpResponse As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label19 As System.Windows.Forms.Label
    Private WithEvents cbSecure As System.Windows.Forms.CheckBox
    Private WithEvents txtPassword As System.Windows.Forms.TextBox
    Private WithEvents txtAccount As System.Windows.Forms.TextBox
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents cbAuthentication As System.Windows.Forms.CheckBox
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btnViewLog As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCreateMIME As System.Windows.Forms.Button
    Private WithEvents txtMIMEContents As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Friend WithEvents btnLoadMIME As System.Windows.Forms.Button
    Private WithEvents txtMIMEFile As System.Windows.Forms.TextBox
    Private WithEvents label15 As System.Windows.Forms.Label
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Private WithEvents txtLogfile As System.Windows.Forms.TextBox
    Private WithEvents txtResult As System.Windows.Forms.TextBox
    Private WithEvents label13 As System.Windows.Forms.Label
    Private WithEvents label14 As System.Windows.Forms.Label
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
End Class
