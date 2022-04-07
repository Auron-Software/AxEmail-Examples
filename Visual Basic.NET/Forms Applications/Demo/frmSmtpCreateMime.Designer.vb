<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSmtpCreateMime
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
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFromAddress = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBccAddress = New System.Windows.Forms.TextBox
        Me.txtFromName = New System.Windows.Forms.TextBox
        Me.txtCcAddress = New System.Windows.Forms.TextBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnBrowse = New System.Windows.Forms.Button
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.label17 = New System.Windows.Forms.Label
        Me.label16 = New System.Windows.Forms.Label
        Me.txtToAddress = New System.Windows.Forms.TextBox
        Me.txtAttachments = New System.Windows.Forms.TextBox
        Me.label15 = New System.Windows.Forms.Label
        Me.cbxEncoding = New System.Windows.Forms.ComboBox
        Me.label12 = New System.Windows.Forms.Label
        Me.cbxPriority = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.cbxFormat = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtBody = New System.Windows.Forms.TextBox
        Me.txtSubject = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(468, 337)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 24)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sender E-ma&il:"
        '
        'txtFromAddress
        '
        Me.txtFromAddress.Location = New System.Drawing.Point(109, 19)
        Me.txtFromAddress.Name = "txtFromAddress"
        Me.txtFromAddress.Size = New System.Drawing.Size(165, 20)
        Me.txtFromAddress.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&To:"
        '
        'txtBccAddress
        '
        Me.txtBccAddress.Location = New System.Drawing.Point(109, 65)
        Me.txtBccAddress.Name = "txtBccAddress"
        Me.txtBccAddress.Size = New System.Drawing.Size(415, 20)
        Me.txtBccAddress.TabIndex = 5
        '
        'txtFromName
        '
        Me.txtFromName.Location = New System.Drawing.Point(405, 19)
        Me.txtFromName.Name = "txtFromName"
        Me.txtFromName.Size = New System.Drawing.Size(119, 20)
        Me.txtFromName.TabIndex = 3
        '
        'txtCcAddress
        '
        Me.txtCcAddress.Location = New System.Drawing.Point(109, 42)
        Me.txtCcAddress.Name = "txtCcAddress"
        Me.txtCcAddress.Size = New System.Drawing.Size(415, 20)
        Me.txtCcAddress.TabIndex = 3
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.txtFromAddress)
        Me.groupBox1.Controls.Add(Me.txtFromName)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Location = New System.Drawing.Point(12, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(540, 47)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Sender"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(285, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sender Na&me (optional):"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(496, 140)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(28, 20)
        Me.btnBrowse.TabIndex = 12
        Me.btnBrowse.Text = "..."
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.txtBccAddress)
        Me.groupBox2.Controls.Add(Me.label17)
        Me.groupBox2.Controls.Add(Me.label16)
        Me.groupBox2.Controls.Add(Me.txtCcAddress)
        Me.groupBox2.Controls.Add(Me.Label4)
        Me.groupBox2.Controls.Add(Me.txtToAddress)
        Me.groupBox2.Location = New System.Drawing.Point(12, 65)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(540, 93)
        Me.groupBox2.TabIndex = 1
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Recipients"
        '
        'label17
        '
        Me.label17.Location = New System.Drawing.Point(20, 67)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(36, 16)
        Me.label17.TabIndex = 4
        Me.label17.Text = "&Bcc:"
        '
        'label16
        '
        Me.label16.Location = New System.Drawing.Point(20, 45)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(36, 16)
        Me.label16.TabIndex = 2
        Me.label16.Text = "&Cc:"
        '
        'txtToAddress
        '
        Me.txtToAddress.Location = New System.Drawing.Point(109, 19)
        Me.txtToAddress.Name = "txtToAddress"
        Me.txtToAddress.Size = New System.Drawing.Size(415, 20)
        Me.txtToAddress.TabIndex = 1
        '
        'txtAttachments
        '
        Me.txtAttachments.Location = New System.Drawing.Point(109, 139)
        Me.txtAttachments.Name = "txtAttachments"
        Me.txtAttachments.Size = New System.Drawing.Size(379, 20)
        Me.txtAttachments.TabIndex = 11
        '
        'label15
        '
        Me.label15.Location = New System.Drawing.Point(20, 144)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(78, 16)
        Me.label15.TabIndex = 10
        Me.label15.Text = "&Attachment(s):"
        '
        'cbxEncoding
        '
        Me.cbxEncoding.Location = New System.Drawing.Point(280, 110)
        Me.cbxEncoding.Name = "cbxEncoding"
        Me.cbxEncoding.Size = New System.Drawing.Size(100, 21)
        Me.cbxEncoding.TabIndex = 7
        '
        'label12
        '
        Me.label12.Location = New System.Drawing.Point(227, 115)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(53, 19)
        Me.label12.TabIndex = 6
        Me.label12.Text = "Char.&set:"
        '
        'cbxPriority
        '
        Me.cbxPriority.Location = New System.Drawing.Point(424, 110)
        Me.cbxPriority.Name = "cbxPriority"
        Me.cbxPriority.Size = New System.Drawing.Size(100, 21)
        Me.cbxPriority.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(384, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Prio&rity:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(378, 337)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(84, 24)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "&Save"
        '
        'cbxFormat
        '
        Me.cbxFormat.Location = New System.Drawing.Point(109, 110)
        Me.cbxFormat.Name = "cbxFormat"
        Me.cbxFormat.Size = New System.Drawing.Size(100, 21)
        Me.cbxFormat.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(20, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 14)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Bod&y:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 14)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "S&ubject:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnBrowse)
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
        Me.GroupBox4.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(540, 167)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Message"
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(109, 43)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(415, 62)
        Me.txtBody.TabIndex = 3
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(109, 19)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(415, 20)
        Me.txtSubject.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(20, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 16)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "&Format:"
        '
        'frmSmtpCreateMime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 366)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSmtpCreateMime"
        Me.Text = "Create MIME File"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFromAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBccAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtFromName As System.Windows.Forms.TextBox
    Friend WithEvents txtCcAddress As System.Windows.Forms.TextBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btnBrowse As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents label17 As System.Windows.Forms.Label
    Friend WithEvents label16 As System.Windows.Forms.Label
    Friend WithEvents txtToAddress As System.Windows.Forms.TextBox
    Private WithEvents txtAttachments As System.Windows.Forms.TextBox
    Private WithEvents label15 As System.Windows.Forms.Label
    Private WithEvents cbxEncoding As System.Windows.Forms.ComboBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Friend WithEvents cbxPriority As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cbxFormat As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBody As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
