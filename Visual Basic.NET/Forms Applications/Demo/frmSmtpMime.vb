'-----------------------------------------------------------------------
' <copyright file="frmSmtpMime.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------
Imports AxEmail

Public Class frmSmtpMime

    Dim objMail As AxEmail.Message = New AxEmail.Message()
    Dim objSmtpServer As AxEmail.Smtp = New AxEmail.Smtp()
    Dim objConstants As AxEmail.Constants = New AxEmail.Constants()
    Dim objFrmSmtpCreateMime As frmSmtpCreateMime = New frmSmtpCreateMime()

    Private Sub cbAuthentication_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAuthentication.CheckedChanged
        UpdateControls()
    End Sub

    Private Sub cbSecure_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSecure.CheckedChanged
        If (cbSecure.Checked) Then
            txtPort.Text = "465"
        Else
            txtPort.Text = "25"
        End If

        UpdateControls()
    End Sub

    Sub UpdateControls()
        If (cbAuthentication.Checked) Then
            txtAccount.Enabled = True
            txtPassword.Enabled = True
        Else
            txtAccount.Enabled = False
            txtPassword.Enabled = False
        End If
    End Sub

    Private Sub btnLoadMIME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadMIME.Click
        Dim fdlg As System.Windows.Forms.OpenFileDialog

        fdlg = New OpenFileDialog()
        fdlg.Title = "Select Attachment"
        fdlg.InitialDirectory = "C:\\"
        fdlg.Filter = "MIME files (*.mim)|*.*"
        fdlg.FilterIndex = 1
        fdlg.RestoreDirectory = True
        If (fdlg.ShowDialog() <> DialogResult.OK) Then
            Return
        End If

        txtMIMEFile.Text = String.Empty
        txtMIMEContents.Text = String.Empty

        txtMIMEFile.Text = fdlg.FileName

        ' Loads the selected MIME file
        objMail.LoadMIME(fdlg.FileName)
        txtResult.Text = objMail.LastError.ToString + ": " + objMail.GetErrorDescription(objMail.LastError)
        txtLastSmtpResponse.Text = String.Empty
        If (objMail.LastError = 0) Then
            txtMIMEContents.Text = objMail.MessageSource
        End If
    End Sub

    Private Sub btnCreateMIME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateMIME.Click
        ' Loads the MIME creation form.
        If (objFrmSmtpCreateMime.ShowDialog() <> DialogResult.OK) Then
            Return
        End If
        txtMIMEFile.Text = String.Empty
        txtMIMEContents.Text = String.Empty

        txtMIMEFile.Text = objFrmSmtpCreateMime.strMIMEFileName

        ' Loads the newly created MIME file
        objMail.LoadMIME(objFrmSmtpCreateMime.strMIMEFileName)
        txtResult.Text = objMail.LastError.ToString + ": " + objMail.GetErrorDescription(objMail.LastError)
        txtLastSmtpResponse.Text = String.Empty

        If (objMail.LastError = 0) Then
            txtMIMEContents.Text = objMail.MessageSource
        End If
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Dim CurCursor As Cursor = Cursor

        Cursor = Cursors.WaitCursor

        objSmtpServer.Clear()

        objSmtpServer.LogFile = txtLogfile.Text

        ' Set Secure if secure communications is required
        If (cbSecure.Checked) Then
            objSmtpServer.SetSecure(Integer.Parse(txtPort.Text))
            txtResult.Text = objSmtpServer.LastError.ToString + ": " + objSmtpServer.GetErrorDescription(objSmtpServer.LastError)
            If (objSmtpServer.LastError <> 0) Then
                GoTo _EndCtlSend_Click
            End If
        Else
            objSmtpServer.HostPort = Int32.Parse(txtPort.Text)
        End If

        ' Connects to the SMTP Server

        Dim strAccount As String = String.Empty
        Dim strPassword As String = String.Empty
        If (cbAuthentication.Checked) Then
            strAccount = txtAccount.Text
            strPassword = txtPassword.Text
        End If
        objSmtpServer.Connect(txtHost.Text, strAccount, strPassword)
        txtResult.Text = objSmtpServer.LastError.ToString + ": " + objSmtpServer.GetErrorDescription(objSmtpServer.LastError)
        txtLastSmtpResponse.Text = objSmtpServer.LastSmtpResponse

        If (objSmtpServer.LastError = 0) Then
            ' Sends the E-Mail message
            objSmtpServer.Send(objMail)
            txtResult.Text = objSmtpServer.LastError.ToString + ": " + objSmtpServer.GetErrorDescription(objSmtpServer.LastError)
            txtLastSmtpResponse.Text = objSmtpServer.LastSmtpResponse

            'Disconnects the SMTP Server
            objSmtpServer.Disconnect()
        End If
_EndCtlSend_Click:
        Cursor = CurCursor
    End Sub

    Private Sub btnViewLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewLog.Click
        If (System.IO.File.Exists(txtLogfile.Text)) Then
            System.Diagnostics.Process.Start(txtLogfile.Text)
        End If
    End Sub

    Private Sub frmSmtpMime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (txtPort.Text = String.Empty) Then
            txtPort.Text = "25"
        End If

        'Display Auron Email Component Info
        lblInfo.Text = String.Format("Auron Email Component {0}; Build: {1}; Module: {2}", objSmtpServer.Version, objSmtpServer.Build, objSmtpServer.Module)
        
        txtMIMEFile.Text = String.Empty
        txtMIMEContents.Text = String.Empty

        txtResult.Text = String.Empty
        txtLastSmtpResponse.Text = String.Empty

        txtLogfile.Text = System.IO.Path.GetTempPath() + "Smtp.log"

        UpdateControls()
    End Sub
End Class