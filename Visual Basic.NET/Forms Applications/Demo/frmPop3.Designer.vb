<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPop3
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.columnFrom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtResponse = New System.Windows.Forms.TextBox()
        Me.label12 = New System.Windows.Forms.Label()
        Me.btnViewLog = New System.Windows.Forms.Button()
        Me.txtLogfile = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnSaveMessage = New System.Windows.Forms.Button()
        Me.label11 = New System.Windows.Forms.Label()
        Me.lvAttachments = New System.Windows.Forms.ListView()
        Me.colName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.btnList = New System.Windows.Forms.Button()
        Me.colSubject = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvMessages = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnOAuth = New System.Windows.Forms.Button()
        Me.cbxSecurity = New System.Windows.Forms.ComboBox()
        Me.label19 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "L&ogfile:"
        '
        'columnFrom
        '
        Me.columnFrom.Text = "From"
        Me.columnFrom.Width = 130
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Res&ult:"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(92, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(202, 14)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "(Double-click on attachment to save)"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(93, 45)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(55, 20)
        Me.txtPort.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtResponse)
        Me.GroupBox4.Controls.Add(Me.label12)
        Me.GroupBox4.Controls.Add(Me.btnViewLog)
        Me.GroupBox4.Controls.Add(Me.txtLogfile)
        Me.GroupBox4.Controls.Add(Me.txtResult)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 554)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(549, 110)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Result and Logging"
        '
        'txtResponse
        '
        Me.txtResponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponse.Location = New System.Drawing.Point(93, 42)
        Me.txtResponse.Multiline = True
        Me.txtResponse.Name = "txtResponse"
        Me.txtResponse.ReadOnly = True
        Me.txtResponse.Size = New System.Drawing.Size(443, 33)
        Me.txtResponse.TabIndex = 3
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(16, 46)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(58, 13)
        Me.label12.TabIndex = 2
        Me.label12.Text = "Response:"
        '
        'btnViewLog
        '
        Me.btnViewLog.Location = New System.Drawing.Point(460, 82)
        Me.btnViewLog.Name = "btnViewLog"
        Me.btnViewLog.Size = New System.Drawing.Size(76, 20)
        Me.btnViewLog.TabIndex = 6
        Me.btnViewLog.Text = "&View"
        '
        'txtLogfile
        '
        Me.txtLogfile.Location = New System.Drawing.Point(92, 82)
        Me.txtLogfile.Name = "txtLogfile"
        Me.txtLogfile.Size = New System.Drawing.Size(359, 20)
        Me.txtLogfile.TabIndex = 5
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(93, 19)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(443, 20)
        Me.txtResult.TabIndex = 1
        '
        'btnSaveMessage
        '
        Me.btnSaveMessage.Location = New System.Drawing.Point(93, 220)
        Me.btnSaveMessage.Name = "btnSaveMessage"
        Me.btnSaveMessage.Size = New System.Drawing.Size(443, 24)
        Me.btnSaveMessage.TabIndex = 11
        Me.btnSaveMessage.Text = "Save &Message As..."
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(16, 48)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(29, 13)
        Me.label11.TabIndex = 2
        Me.label11.Text = "&Port:"
        '
        'lvAttachments
        '
        Me.lvAttachments.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colSize})
        Me.lvAttachments.FullRowSelect = True
        Me.lvAttachments.GridLines = True
        Me.lvAttachments.HideSelection = False
        Me.lvAttachments.Location = New System.Drawing.Point(93, 138)
        Me.lvAttachments.Name = "lvAttachments"
        Me.lvAttachments.Size = New System.Drawing.Size(443, 61)
        Me.lvAttachments.TabIndex = 9
        Me.lvAttachments.UseCompatibleStateImageBehavior = False
        Me.lvAttachments.View = System.Windows.Forms.View.Details
        '
        'colName
        '
        Me.colName.Text = "Name"
        Me.colName.Width = 248
        '
        'colSize
        '
        Me.colSize.Text = "Size (Bytes)"
        Me.colSize.Width = 189
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOAuth)
        Me.GroupBox1.Controls.Add(Me.cbxSecurity)
        Me.GroupBox1.Controls.Add(Me.label19)
        Me.GroupBox1.Controls.Add(Me.txtPort)
        Me.GroupBox1.Controls.Add(Me.label11)
        Me.GroupBox1.Controls.Add(Me.btnDisconnect)
        Me.GroupBox1.Controls.Add(Me.btnConnect)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtAccount)
        Me.GroupBox1.Controls.Add(Me.txtHost)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "POP3 Server"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(314, 110)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(223, 21)
        Me.btnDisconnect.TabIndex = 10
        Me.btnDisconnect.Text = "&Disconnect"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(93, 109)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(209, 21)
        Me.btnConnect.TabIndex = 9
        Me.btnConnect.Text = "&Connect"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(370, 81)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(167, 20)
        Me.txtPassword.TabIndex = 8
        '
        'txtAccount
        '
        Me.txtAccount.Location = New System.Drawing.Point(94, 81)
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.Size = New System.Drawing.Size(208, 20)
        Me.txtAccount.TabIndex = 6
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(94, 19)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(208, 20)
        Me.txtHost.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(311, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Pass&word:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Account:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Host:"
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(93, 68)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.ReadOnly = True
        Me.txtBody.Size = New System.Drawing.Size(443, 64)
        Me.txtBody.TabIndex = 7
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(92, 44)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(444, 20)
        Me.txtSubject.TabIndex = 5
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(338, 19)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.ReadOnly = True
        Me.txtTo.Size = New System.Drawing.Size(198, 20)
        Me.txtTo.TabIndex = 3
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(92, 19)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.ReadOnly = True
        Me.txtFrom.Size = New System.Drawing.Size(197, 20)
        Me.txtFrom.TabIndex = 1
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(93, 102)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(443, 22)
        Me.btnList.TabIndex = 1
        Me.btnList.Text = "&List Messages"
        '
        'colSubject
        '
        Me.colSubject.Text = "Subject"
        Me.colSubject.Width = 130
        '
        'lvMessages
        '
        Me.lvMessages.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.columnFrom, Me.colDate, Me.colSubject})
        Me.lvMessages.FullRowSelect = True
        Me.lvMessages.GridLines = True
        Me.lvMessages.HideSelection = False
        Me.lvMessages.Location = New System.Drawing.Point(93, 19)
        Me.lvMessages.MultiSelect = False
        Me.lvMessages.Name = "lvMessages"
        Me.lvMessages.Size = New System.Drawing.Size(443, 77)
        Me.lvMessages.TabIndex = 0
        Me.lvMessages.UseCompatibleStateImageBehavior = False
        Me.lvMessages.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 30
        '
        'colDate
        '
        Me.colDate.Text = "Date"
        Me.colDate.Width = 130
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Body:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Subject:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Attachments:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(310, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "To:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "From:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnList)
        Me.GroupBox2.Controls.Add(Me.lvMessages)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(549, 131)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Received Messages"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.btnSaveMessage)
        Me.GroupBox3.Controls.Add(Me.lvAttachments)
        Me.GroupBox3.Controls.Add(Me.txtBody)
        Me.GroupBox3.Controls.Add(Me.txtSubject)
        Me.GroupBox3.Controls.Add(Me.txtTo)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtFrom)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 297)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(549, 251)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Current Message"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(12, 677)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(31, 13)
        Me.lblInfo.TabIndex = 4
        Me.lblInfo.Text = "[Info]"
        '
        'btnOAuth
        '
        Me.btnOAuth.Location = New System.Drawing.Point(370, 45)
        Me.btnOAuth.Name = "btnOAuth"
        Me.btnOAuth.Size = New System.Drawing.Size(164, 23)
        Me.btnOAuth.TabIndex = 16
        Me.btnOAuth.Text = "OAuth Settings..."
        Me.btnOAuth.UseVisualStyleBackColor = True
        '
        'cbxSecurity
        '
        Me.cbxSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxSecurity.FormattingEnabled = True
        Me.cbxSecurity.Location = New System.Drawing.Point(370, 18)
        Me.cbxSecurity.Name = "cbxSecurity"
        Me.cbxSecurity.Size = New System.Drawing.Size(164, 21)
        Me.cbxSecurity.TabIndex = 15
        '
        'label19
        '
        Me.label19.Location = New System.Drawing.Point(311, 22)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(49, 18)
        Me.label19.TabIndex = 14
        Me.label19.Text = "&Security:"
        '
        'frmPop3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 700)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPop3"
        Me.Text = "Auron Email Component - VB.NET POP3 Demo"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents columnFrom As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtResponse As System.Windows.Forms.TextBox
    Friend WithEvents label12 As System.Windows.Forms.Label
    Friend WithEvents btnViewLog As System.Windows.Forms.Button
    Friend WithEvents txtLogfile As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Private WithEvents btnSaveMessage As System.Windows.Forms.Button
    Friend WithEvents label11 As System.Windows.Forms.Label
    Friend WithEvents lvAttachments As System.Windows.Forms.ListView
    Private WithEvents colName As System.Windows.Forms.ColumnHeader
    Private WithEvents colSize As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDisconnect As System.Windows.Forms.Button
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtAccount As System.Windows.Forms.TextBox
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBody As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents btnList As System.Windows.Forms.Button
    Friend WithEvents colSubject As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvMessages As System.Windows.Forms.ListView
    Friend WithEvents colDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Private WithEvents btnOAuth As Button
    Private WithEvents cbxSecurity As ComboBox
    Private WithEvents label19 As Label
End Class
