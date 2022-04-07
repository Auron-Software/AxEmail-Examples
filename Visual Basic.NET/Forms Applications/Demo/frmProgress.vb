Public Class frmProgress

  Private m_bStopped As Boolean = False

  Public Sub New(ByVal sTitle As String, ByVal nMax As Integer)
    MyBase.New
    InitializeComponent()
    Me.Text = sTitle
    lblAction.Text = sTitle
    lblDetails.Text = ""
    prgProgress.Maximum = nMax
  End Sub

  Public Function DoProgress(ByVal nCurrent As Integer, Optional ByVal sDetail As String = "") As Boolean
    If (nCurrent > prgProgress.Maximum) Then
      nCurrent = prgProgress.Maximum
    End If

    prgProgress.Value = nCurrent
    lblDetails.Text = sDetail
    Application.DoEvents()
    Return Not Me.m_bStopped
  End Function

  Private Sub btnStop_Click(ByVal sender As Object, ByVal e As EventArgs)
    Me.m_bStopped = True
  End Sub

End Class