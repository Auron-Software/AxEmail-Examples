'-----------------------------------------------------------------------
' <copyright file="frmLicensing.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------
Imports AxEmail
Imports Microsoft.Win32

Public Class frmLicensing

    Dim objFrmLicensingSerial As frmLicensingSerial = New frmLicensingSerial
    Dim objSmtp As Smtp = New Smtp

    Private Sub frmLicensing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblVersion.Text = String.Format("{0}; Build {1}; Module {2}", objSmtp.Version, objSmtp.Build, objSmtp.Module)
        UpdateLicensingInfo()
    End Sub

    Private Sub llblUrlSupport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblUrlSupport.LinkClicked
        Process.Start("https://www.auronsoftware.com/knowledge-base/#email-component")
    End Sub

    Private Sub llblUrlSales_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblUrlSales.LinkClicked
        Process.Start("https://www.auronsoftware.com/sales")
    End Sub

    Private Sub llblUrlOrder_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblUrlOrder.LinkClicked
        Process.Start("https://www.auronsoftware.com/sales")
    End Sub

    Private Sub llblMailSupport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblMailSupport.LinkClicked
        Process.Start("mailto:support@auronsoftware.com")
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Dim strBuffer As String = String.Empty

        objFrmLicensingSerial.SerialKey = objSmtp.LicenseKey

        If (objFrmLicensingSerial.ShowDialog() = DialogResult.OK) Then
            Dim strOldKey As String = objSmtp.LicenseKey

            objSmtp.LicenseKey = objFrmLicensingSerial.SerialKey
            objSmtp.SaveLicenseKey()
            If (objSmtp.LastError <> 0) Then
                MessageBox.Show(String.Format("SaveLicenseKey failed, error {0} ({1}).", objSmtp.LastError.ToString(), objSmtp.GetErrorDescription(objSmtp.LastError)), "License", MessageBoxButtons.OK, MessageBoxIcon.Error)
                objSmtp.LicenseKey = strOldKey
            End If

            UpdateLicensingInfo()
        End If
    End Sub


    Private Sub UpdateLicensingInfo()
        Dim strLicenseKey As String = ""

        If (objSmtp.LicenseKey <> "") Then
            strLicenseKey = objSmtp.LicenseKey
        Else
            strLicenseKey = "no license key"
        End If
        txtLicense.Text = String.Format("{0} ({1})", objSmtp.LicenseStatus, strLicenseKey)
    End Sub

End Class