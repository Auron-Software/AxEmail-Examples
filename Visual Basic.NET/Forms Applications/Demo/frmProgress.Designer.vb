<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgress
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
    Me.lblDetails = New System.Windows.Forms.Label()
    Me.lblAction = New System.Windows.Forms.Label()
    Me.btnStop = New System.Windows.Forms.Button()
    Me.prgProgress = New System.Windows.Forms.ProgressBar()
    Me.SuspendLayout()
    '
    'lblDetails
    '
    Me.lblDetails.AutoSize = True
    Me.lblDetails.Location = New System.Drawing.Point(12, 66)
    Me.lblDetails.Name = "lblDetails"
    Me.lblDetails.Size = New System.Drawing.Size(35, 13)
    Me.lblDetails.TabIndex = 7
    Me.lblDetails.Text = "label2"
    '
    'lblAction
    '
    Me.lblAction.AutoSize = True
    Me.lblAction.Location = New System.Drawing.Point(12, 9)
    Me.lblAction.Name = "lblAction"
    Me.lblAction.Size = New System.Drawing.Size(35, 13)
    Me.lblAction.TabIndex = 6
    Me.lblAction.Text = "label1"
    '
    'btnStop
    '
    Me.btnStop.Location = New System.Drawing.Point(295, 61)
    Me.btnStop.Name = "btnStop"
    Me.btnStop.Size = New System.Drawing.Size(75, 23)
    Me.btnStop.TabIndex = 5
    Me.btnStop.Text = "Stop"
    Me.btnStop.UseVisualStyleBackColor = True
    '
    'prgProgress
    '
    Me.prgProgress.Location = New System.Drawing.Point(12, 28)
    Me.prgProgress.Name = "prgProgress"
    Me.prgProgress.Size = New System.Drawing.Size(358, 23)
    Me.prgProgress.TabIndex = 4
    '
    'frmProgress
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(382, 93)
    Me.ControlBox = False
    Me.Controls.Add(Me.lblDetails)
    Me.Controls.Add(Me.lblAction)
    Me.Controls.Add(Me.btnStop)
    Me.Controls.Add(Me.prgProgress)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmProgress"
    Me.ShowIcon = False
    Me.Text = "frmProgress"
    Me.TopMost = True
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Private WithEvents lblDetails As Label
  Private WithEvents lblAction As Label
  Private WithEvents btnStop As Button
  Private WithEvents prgProgress As ProgressBar
End Class
