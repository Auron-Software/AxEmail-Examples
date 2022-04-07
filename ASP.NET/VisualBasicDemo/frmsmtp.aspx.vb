'-----------------------------------------------------------------------
' <copyright file="frmsmtp.aspx.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------
Imports AxEmail
Imports System.IO

Partial Public Class frmsmtp
	Inherits System.Web.UI.Page

	Private objSmtp As Smtp = New Smtp
    Private objEmail As AxEmail.Message = New AxEmail.Message
    Private objEmailConstants As AxEmail.Constants = New AxEmail.Constants

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		If (Not IsPostBack) Then

			lblInfo.Text = "Build: " & objSmtp.Build & "; Module: " & objSmtp.Module

			ddlPriority.Items.Clear()
			ddlPriority.Items.Add("Highest Priority")
			ddlPriority.Items.Add("High Priority")
			ddlPriority.Items.Add("Normal Priority")
			ddlPriority.Items.Add("Low Priority")
			ddlPriority.Items.Add("Lowest Priority")
			ddlPriority.SelectedIndex = 2	' Normal Priority

			ddlEncoding.Items.Clear()
			ddlEncoding.Items.Add("Standard")	 ' Encoding
			ddlEncoding.Items.Add("UTF8")
            ddlEncoding.SelectedIndex = 0

            txtLogfile.Text = Path.GetTempPath() & "Smtp.log"

		End If
	End Sub

    Protected Sub btnSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSend.Click

        txtResult.Text = ""
        txtLastSmtpResponse.Text = ""


        ' Mail: Clear
        objEmail.Clear()

        ' Mail: From
        objEmail.FromName = txtFromName.Text
        objEmail.FromAddress = txtFromAddress.Text

        ' Mail: Encoding
        If (ddlEncoding.SelectedIndex = 0) Then
            objEmail.Encoding = objEmailConstants.EMAIL_MESSAGE_ENCODING_DEFAULT
        Else
            objEmail.Encoding = objEmailConstants.EMAIL_MESSAGE_ENCODING_UTF8
        End If

        ' Mail: Priority
        objEmail.Priority = ddlPriority.SelectedIndex
        Select Case ddlPriority.SelectedValue
            Case "Highest Priority"
                objEmail.Priority = objEmailConstants.EMAIL_MESSAGE_PRIORITY_HIGHEST
            Case "High Priority"
                objEmail.Priority = objEmailConstants.EMAIL_MESSAGE_PRIORITY_HIGH
            Case "Normal Priority"
                objEmail.Priority = objEmailConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM
            Case "Low Priority"
                objEmail.Priority = objEmailConstants.EMAIL_MESSAGE_PRIORITY_LOW
            Case "Lowest Priority"
                objEmail.Priority = objEmailConstants.EMAIL_MESSAGE_PRIORITY_LOWEST
        End Select

        ' Mail: Subject
        objEmail.Subject = txtSubject.Text

        ' Mail: Body
        objEmail.BodyPlainText = txtPlainBody.Text
        objEmail.BodyHtml = txtHtmlBody.Text

        ' Mail: Add TO recipient(s)
        If (txtToAddress.Text <> String.Empty) Then

            objEmail.AddTo(txtToAddress.Text, txtToAddress.Text)
        End If

        ' Mail: Add CC recipient(s)
        If (objEmail.LastError = 0 And txtCcAddress.Text <> String.Empty) Then

            objEmail.AddCc(txtCcAddress.Text, txtCcAddress.Text)
        End If

        ' Mail: Add BCC recipient(s)
        If (objEmail.LastError = 0 And txtBccAddress.Text <> String.Empty) Then
            objEmail.AddBcc(txtBccAddress.Text, txtBccAddress.Text)
        End If

        ' Mail: On error return
        If (objEmail.LastError <> 0) Then
            txtResult.Text = objEmail.LastError & ": " * objEmail.GetErrorDescription(objEmail.LastError)
            Exit Sub
        End If


        ' Smtp: Clear (good practise)
        objSmtp.Clear()
        
        ' A license key is required to unlock this component after the trial period has expired.
        ' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
        ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
        ' For details, see manual, chapter "Product Activation".  
        '
        ' objSmtp.LicenseKey = "XXXXX-XXXXX-XXXXX"          

        objSmtp.LogFile = txtLogfile.Text

        ' Smtp: Secure
        If (cbSecure.Checked) Then
            objSmtp.SetSecure(465)   ' 465 is the generic secure SMTP port
        End If

        ' Smtp: Connect
        If (objSmtp.LastError = 0) Then
            objSmtp.Connect(txtServer.Text, txtAccount.Text, txtPassword.Text)
        End If

        ' Smtp: Send
        If (objSmtp.LastError = 0) Then
            objSmtp.Send(objEmail)
        End If

        txtResult.Text = objSmtp.LastError & ": " & objSmtp.GetErrorDescription(objSmtp.LastError)
        txtLastSmtpResponse.Text = objSmtp.LastSmtpResponse

        objSmtp.Disconnect()
    End Sub
End Class