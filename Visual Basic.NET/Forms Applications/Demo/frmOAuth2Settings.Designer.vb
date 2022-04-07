<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOAuth2Settings
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
        Me.label8 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.txtRedirectUrl = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.txtScope = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.txtClientSecret = New System.Windows.Forms.TextBox()
        Me.txtClientID = New System.Windows.Forms.TextBox()
        Me.txtTokenExchangeUrl = New System.Windows.Forms.TextBox()
        Me.txtDeviceCodeUrl = New System.Windows.Forms.TextBox()
        Me.txtAuthCodeUrl = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbxFlow = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.groupBox2.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(6, 74)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(84, 13)
        Me.label8.TabIndex = 5
        Me.label8.Text = "Token Ex. URL:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(7, 22)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(88, 13)
        Me.label6.TabIndex = 3
        Me.label6.Text = "Auth. Code URL:"
        '
        'txtRedirectUrl
        '
        Me.txtRedirectUrl.Location = New System.Drawing.Point(115, 157)
        Me.txtRedirectUrl.Name = "txtRedirectUrl"
        Me.txtRedirectUrl.Size = New System.Drawing.Size(348, 20)
        Me.txtRedirectUrl.TabIndex = 9
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(7, 160)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(75, 13)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Redirect URL:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(7, 134)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(38, 13)
        Me.label4.TabIndex = 7
        Me.label4.Text = "Scope"
        '
        'txtScope
        '
        Me.txtScope.Location = New System.Drawing.Point(115, 131)
        Me.txtScope.Name = "txtScope"
        Me.txtScope.Size = New System.Drawing.Size(348, 20)
        Me.txtScope.TabIndex = 6
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(7, 90)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(70, 13)
        Me.label3.TabIndex = 5
        Me.label3.Text = "Client Secret:"
        '
        'txtClientSecret
        '
        Me.txtClientSecret.Location = New System.Drawing.Point(115, 87)
        Me.txtClientSecret.Name = "txtClientSecret"
        Me.txtClientSecret.Size = New System.Drawing.Size(348, 20)
        Me.txtClientSecret.TabIndex = 4
        '
        'txtClientID
        '
        Me.txtClientID.Location = New System.Drawing.Point(115, 61)
        Me.txtClientID.Name = "txtClientID"
        Me.txtClientID.Size = New System.Drawing.Size(348, 20)
        Me.txtClientID.TabIndex = 3
        '
        'txtTokenExchangeUrl
        '
        Me.txtTokenExchangeUrl.Location = New System.Drawing.Point(115, 71)
        Me.txtTokenExchangeUrl.Name = "txtTokenExchangeUrl"
        Me.txtTokenExchangeUrl.Size = New System.Drawing.Size(348, 20)
        Me.txtTokenExchangeUrl.TabIndex = 13
        '
        'txtDeviceCodeUrl
        '
        Me.txtDeviceCodeUrl.Location = New System.Drawing.Point(115, 45)
        Me.txtDeviceCodeUrl.Name = "txtDeviceCodeUrl"
        Me.txtDeviceCodeUrl.Size = New System.Drawing.Size(348, 20)
        Me.txtDeviceCodeUrl.TabIndex = 12
        '
        'txtAuthCodeUrl
        '
        Me.txtAuthCodeUrl.Location = New System.Drawing.Point(115, 19)
        Me.txtAuthCodeUrl.Name = "txtAuthCodeUrl"
        Me.txtAuthCodeUrl.Size = New System.Drawing.Size(348, 20)
        Me.txtAuthCodeUrl.TabIndex = 11
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(7, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(50, 13)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Client ID:"
        '
        'cbxFlow
        '
        Me.cbxFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFlow.FormattingEnabled = True
        Me.cbxFlow.Location = New System.Drawing.Point(115, 20)
        Me.cbxFlow.Name = "cbxFlow"
        Me.cbxFlow.Size = New System.Drawing.Size(348, 21)
        Me.cbxFlow.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(32, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Flow:"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(7, 48)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(97, 13)
        Me.label7.TabIndex = 4
        Me.label7.Text = "Device Code URL:"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txtTokenExchangeUrl)
        Me.groupBox2.Controls.Add(Me.txtDeviceCodeUrl)
        Me.groupBox2.Controls.Add(Me.txtAuthCodeUrl)
        Me.groupBox2.Controls.Add(Me.label8)
        Me.groupBox2.Controls.Add(Me.label7)
        Me.groupBox2.Controls.Add(Me.label6)
        Me.groupBox2.Location = New System.Drawing.Point(12, 211)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(469, 109)
        Me.groupBox2.TabIndex = 5
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Token URLS"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.txtRedirectUrl)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtScope)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtClientSecret)
        Me.groupBox1.Controls.Add(Me.txtClientID)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.cbxFlow)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(469, 193)
        Me.groupBox1.TabIndex = 4
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Client"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(406, 326)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmOAuth2Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 358)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmOAuth2Settings"
        Me.Text = "OAuth2 Settings"
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents label8 As Label
    Private WithEvents label6 As Label
    Public WithEvents txtRedirectUrl As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Public WithEvents txtScope As TextBox
    Private WithEvents label3 As Label
    Public WithEvents txtClientSecret As TextBox
    Public WithEvents txtClientID As TextBox
    Public WithEvents txtTokenExchangeUrl As TextBox
    Public WithEvents txtDeviceCodeUrl As TextBox
    Public WithEvents txtAuthCodeUrl As TextBox
    Private WithEvents label2 As Label
    Public WithEvents cbxFlow As ComboBox
    Private WithEvents label1 As Label
    Private WithEvents label7 As Label
    Private WithEvents groupBox2 As GroupBox
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents btnClose As Button
End Class
