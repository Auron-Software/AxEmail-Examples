'-----------------------------------------------------------------------
' <copyright file="frmDemo.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------
Public Class frmDemo

  Private objFrmLicensing As frmLicensing = New frmLicensing
  Private objFrmSmtp As frmSmtp = New frmSmtp
  Private objFrmPop3 As frmPop3 = New frmPop3
  Private objFrmSmtpMime As frmSmtpMime = New frmSmtpMime
  Private objFrmImap As frmImap = New frmImap

  Private Sub llblUrlSmsToolkit_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblUrlSmsToolkit.LinkClicked
    Process.Start("https://www.auronsoftware.com/products/email-component//")
  End Sub

  Private Sub btnLicensing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLicensing.Click
    objFrmLicensing.ShowDialog()
  End Sub

  Private Sub btnSMTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSMTP.Click
    objFrmSmtp.ShowDialog()
  End Sub

  Private Sub btnPop3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPop3.Click
    objFrmPop3.ShowDialog()
  End Sub

  Private Sub btnSmtpMime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSmtpMime.Click
    objFrmSmtpMime.ShowDialog()
  End Sub

  Private Sub frmDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub btnImap_Click(sender As Object, e As EventArgs) Handles btnImap.Click
    objFrmImap.ShowDialog()
  End Sub
End Class
