'-----------------------------------------------------------------------
' <copyright file="frmpop3.aspx.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------
Imports AxEmail
Imports System.IO

Partial Public Class frmpop3
	Inherits System.Web.UI.Page

	Private objPop3 As Pop3 = New Pop3
    Private objEmailConstants As AxEmail.Constants = New AxEmail.Constants

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		If (Not IsPostBack) Then
            lblInfo.Text = "Module [" & objPop3.Module & "]; Build [" & objPop3.Build & "]"

            txtLogfile.Text = Path.GetTempPath() & "Pop3.log"
		End If
	End Sub

	Protected Sub btnListMessages_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnListMessages.Click
        Dim objPop3Mail As AxEmail.Message
		Dim i, numMessages As System.Int32

        lvMessages.Items.Clear()

        objPop3.Clear()
        
        ' A license key is required to unlock this component after the trial period has expired.
        ' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
        ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
        ' For details, see manual, chapter "Product Activation".  
        '
        ' objPop3.LicenseKey = "XXXXX-XXXXX-XXXXX"        

        objPop3.LogFile = txtLogfile.Text

		If (cbSecure.Checked) Then
			objPop3.SetSecure(995)	' 995 is the default secure POP3 port
		End If

        If (objPop3.LastError = 0) Then
            objPop3.Authentication = objEmailConstants.POP3_AUTH_AUTO
            objPop3.Connect(txtHost.Text, txtAccount.Text, txtPassword.Text)
        End If

        If (objPop3.LastError = 0) Then
            numMessages = objPop3.CountMessages()
        End If

        If (objPop3.LastError = 0) Then
            For i = 1 To numMessages

                objPop3Mail = objPop3.GetEmailHeader(i)
                txtResult.Text = objPop3.LastError.ToString() & ": " & objPop3.GetErrorDescription(objPop3.LastError)

                If (objPop3.LastError = 0) Then
                    lvMessages.Items.Add(objPop3Mail.Date + "; " + objPop3Mail.FromAddress + "; Subject: " + objPop3Mail.Subject)
                End If
            Next
        End If

        txtResult.Text = objPop3.LastError.ToString() & ": " & objPop3.GetErrorDescription(objPop3.LastError)
        objPop3.Disconnect()
    End Sub
End Class