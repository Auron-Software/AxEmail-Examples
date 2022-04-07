Imports AxEmail
Imports System.IO

Public Class frmimap
  Inherits System.Web.UI.Page

  Private objImap As Imap = New Imap
  Private objConstants As Constants = New Constants
  Private objEmailConstants As AxEmail.Constants = New AxEmail.Constants

  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    If (Not IsPostBack) Then
      lblInfo.Text = "Module [" & objImap.Module & "]; Build [" & objImap.Build & "]"

      txtLogfile.Text = Path.GetTempPath() & "Imap.log"
    End If
  End Sub

  Protected Sub btnListMessages_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnListMessages.Click
    Dim objImapMail As AxEmail.Message

    lvMessages.Items.Clear()

    objImap.Clear()

    ' A license key is required to unlock this component after the trial period has expired.
    ' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
    ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
    ' For details, see manual, chapter "Product Activation".  
    '
    ' objImap.LicenseKey = "XXXXX-XXXXX-XXXXX"        

    objImap.LogFile = txtLogfile.Text

    If (cbSecure.Checked) Then
      objImap.SetSecure(993)  ' 993 is the default secure POP3 port
    End If

    If (objImap.LastError = 0) Then
      objImap.Connect(txtHost.Text, txtAccount.Text, txtPassword.Text)
    End If

    If (objImap.LastError = 0) Then
      objImapMail = objImap.FetchFirstEmailHeader(objConstants.IMAP_SK_ALL)
      While objImap.LastError = 0
        txtResult.Text = objImap.LastError.ToString() & ": " & objImap.GetErrorDescription(objImap.LastError)

        If (objImap.LastError = 0) Then
          lvMessages.Items.Add(objImapMail.Date + "; " + objImapMail.FromAddress + "; Subject: " + objImapMail.Subject)
        End If

        objImapMail = objImap.FetchNextEmailHeader
      End While
    End If

    txtResult.Text = objImap.LastError.ToString() & ": " & objImap.GetErrorDescription(objImap.LastError)
      objImap.Disconnect()
  End Sub

End Class