'-----------------------------------------------------------------------
' <copyright file="frmSmtp.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------
Imports AxEmail

Public Class frmSmtp
  Private Const IDX_NOTSECURE As Integer = 0
  Private Const IDX_SSLTLS As Integer = 1
  Private Const IDX_STARTTLS As Integer = 2
  Private Const IDX_XOAUTH2 As Integer = 3

  Private objMail As AxEmail.Message = New AxEmail.Message()
  Private objSmtpServer As AxEmail.Smtp = New AxEmail.Smtp()
  Private objConstants As AxEmail.Constants = New AxEmail.Constants()

  Private objOAuth2 As AxEmail.OAuth2 = New AxEmail.OAuth2()
  Private sBearerToken As String = ""
  Private dtBearerOrigin As DateTime = DateTime.Now
  Private objFrmOauth2Settings As frmOAuth2Settings = New frmOAuth2Settings()

  Private Sub frmSmtp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    ' A license key is required to unlock this component after the trial period has expired.
    ' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
    ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
    ' For details, see manual, chapter "Product Activation".
    '
    ' objSmtpServer.LicenseKey = "XXXXX-XXXXX-XXXXX"

    If (txtPort.Text = String.Empty) Then
      txtPort.Text = "25"
    End If

    txtHost.Text = "smtp.gmail.com"

    'Display Auron Email Component Info
    lblInfo.Text = String.Format("Auron Email Component {0}; Build: {1}; Module: {2}", objSmtpServer.Version, objSmtpServer.Build, objSmtpServer.Module)

    cbxSecurity.Items.Clear()
    cbxSecurity.Items.Add("Not Secure")
    cbxSecurity.Items.Add("SSL/TLS")
    cbxSecurity.Items.Add("STARTTLS")
    cbxSecurity.Items.Add("XOAUTH2")
    cbxSecurity.SelectedIndex = IDX_NOTSECURE

    cbxFormat.Items.Clear()
    cbxFormat.Items.Add("Plain Text")
    cbxFormat.Items.Add("HTML")
    cbxFormat.SelectedIndex = 0  ' Plain Text

    cbxPriority.Items.Clear()
    cbxPriority.Items.Add("Highest Priority")
    cbxPriority.Items.Add("High Priority")
    cbxPriority.Items.Add("Normal Priority")
    cbxPriority.Items.Add("Low Priority")
    cbxPriority.Items.Add("Lowest Priority")
    cbxPriority.SelectedIndex = 2 '  Normal Priority

    cbxEncoding.Items.Clear()
    cbxEncoding.Items.Add("Standard") ' Encoding
    cbxEncoding.Items.Add("UTF8")
    cbxEncoding.SelectedIndex = 0

    txtResult.Text = String.Empty
    txtLastSmtpResponse.Text = String.Empty

    txtLogfile.Text = System.IO.Path.GetTempPath() + "Smtp.log"

    UpdateControls()
  End Sub

  Private Sub SetResult(ByVal nResult As Integer)
    txtResult.Text = nResult & ": " & objSmtpServer.GetErrorDescription(nResult)
    txtLastSmtpResponse.Text = objSmtpServer.LastSmtpResponse
  End Sub

  Private Function GetOAuth2BearerToken() As Boolean
    objOAuth2.LogFile = txtLogfile.Text

    If objFrmOauth2Settings.cbxFlow.SelectedIndex = frmOAuth2Settings.IDX_AUTHFLOW Then
      objOAuth2.Flow = objConstants.OAUTH2_FLOW_AUTHCODE
    Else
      objOAuth2.Flow = objConstants.OAUTH2_FLOW_DEVICECODE
    End If

    objOAuth2.ClientID = objFrmOauth2Settings.txtClientID.Text
    objOAuth2.ClientSecret = objFrmOauth2Settings.txtClientSecret.Text
    objOAuth2.Scope = objFrmOauth2Settings.txtScope.Text
    objOAuth2.RedirectUrl = objFrmOauth2Settings.txtRedirectUrl.Text
    objOAuth2.AuthCodeUrl = objFrmOauth2Settings.txtAuthCodeUrl.Text
    objOAuth2.DeviceCodeUrl = objFrmOauth2Settings.txtDeviceCodeUrl.Text
    objOAuth2.TokenExchangeUrl = objFrmOauth2Settings.txtTokenExchangeUrl.Text
    objOAuth2.Login()
    SetResult(objOAuth2.LastError)
    Dim nTokenExchangeTimeoutMs As Integer = 0
    If objOAuth2.LastError <> 0 Then Return False

    If objOAuth2.Flow = objConstants.OAUTH2_FLOW_DEVICECODE Then
      Dim objFrmShowCode As frmShowDeviceCode = New frmShowDeviceCode()
      objFrmShowCode.lblUserCode.Text = objOAuth2.UserCode
      objFrmShowCode.ShowDialog()
      nTokenExchangeTimeoutMs = objOAuth2.UserCodeExpInSeconds * 1000
    Else
      nTokenExchangeTimeoutMs = 120000
    End If

    objOAuth2.WaitForTokens(nTokenExchangeTimeoutMs)
    SetResult(objOAuth2.LastError)

    If objOAuth2.LastError = 0 Then
      dtBearerOrigin = DateTime.Now
      sBearerToken = objOAuth2.BearerToken
    End If

    Return objOAuth2.LastError = 0
  End Function

  Private Function RefreshOAuth2BearerToken() As Boolean
    objOAuth2.RefreshBearerToken()
    SetResult(objOAuth2.LastError)
    If objOAuth2.LastError = 0 Then
      dtBearerOrigin = DateTime.Now
      sBearerToken = objOAuth2.BearerToken
    End If
    Return objOAuth2.LastError = 0
  End Function

  Sub UpdateControls()
    Dim nIdx As Integer = cbxSecurity.SelectedIndex
    btnOAuth.Enabled = nIdx = IDX_XOAUTH2
  End Sub

  Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

    Dim CurCursor = Cursor.Current

    Cursor = Cursors.WaitCursor

    txtResult.Text = ""
    txtLastSmtpResponse.Text = ""

    ' Mail: Clear (good pratise)
    objMail.Clear()

    ' Mail: From
    objMail.FromName = txtFromName.Text
    objMail.FromAddress = txtFromAddress.Text

    ' Mail: Subject
    objMail.Subject = txtSubject.Text

    ' Mail: Priority
    objMail.Priority = cbxPriority.SelectedIndex + 1

    ' Mail: Encoding
    If (cbxEncoding.SelectedIndex = 0) Then
      objMail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT
    Else
      objMail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_UTF8
    End If

    ' Mail: Body
    If (cbxFormat.SelectedIndex = 0) Then
      objMail.BodyPlainText = txtBody.Text
    Else
      objMail.BodyHtml = txtBody.Text
    End If

    ' Mail: TO recipient(s)
    If (txtToAddress.Text <> String.Empty) Then
      objMail.AddTo(txtToAddress.Text, txtToAddress.Text)
    End If

    ' Mail: CC recipient(s)
    If (objMail.LastError = 0 And txtCcAddress.Text <> String.Empty) Then
      objMail.AddCc(txtCcAddress.Text, txtCcAddress.Text)
    End If

    ' Mail: BCC recipient(s)
    If (objMail.LastError = 0 And txtBccAddress.Text <> String.Empty) Then
      objMail.AddBcc(txtBccAddress.Text, txtBccAddress.Text)
    End If

    ' Mail: Attachments
    If (objMail.LastError = 0 And txtBccAddress.Text <> String.Empty) Then
      objMail.AddBcc(txtBccAddress.Text, txtBccAddress.Text)
    End If

    ' Mail: Add attachment(s)
    If (txtAttachments.Text <> String.Empty) Then
      objMail.AddAttachment(txtAttachments.Text)
    End If


    ' Mail: If a function failed then quit
    If (objMail.LastError <> 0) Then
      txtResult.Text = objMail.LastError.ToString() & ": " & objMail.GetErrorDescription(objMail.LastError)
      Exit Sub
    End If

    ' Smtp: Clear (good practise)        
    objSmtpServer.Clear()
    objSmtpServer.LogFile = txtLogfile.Text

    Dim nSecIdx As Integer = cbxSecurity.SelectedIndex

    If nSecIdx = IDX_SSLTLS Then
      objSmtpServer.SetSecure(Int32.Parse(txtPort.Text))
    Else
      objSmtpServer.HostPort = Int32.Parse(txtPort.Text)
    End If

    If nSecIdx = IDX_XOAUTH2 Then
      If sBearerToken = "" Then
        If Not GetOAuth2BearerToken() Then Return
      End If

      Dim tsSpan As TimeSpan = DateTime.Now - dtBearerOrigin

      If tsSpan.TotalSeconds >= objOAuth2.BearerExpInSeconds Then
        If Not RefreshOAuth2BearerToken() Then Return
      End If

      objSmtpServer.BearerToken = sBearerToken
    End If

    ' Smtp: Connect
    objSmtpServer.Connect(txtHost.Text, txtAccount.Text, txtPassword.Text)

    ' Smtp: Send
    If (objSmtpServer.LastError = 0) Then
      objSmtpServer.Send(objMail)
    End If

    txtResult.Text = objSmtpServer.LastError.ToString() & ": " & objSmtpServer.GetErrorDescription(objSmtpServer.LastError)
    txtLastSmtpResponse.Text = objSmtpServer.LastSmtpResponse

    ' Smtp: Disconnect
    objSmtpServer.Disconnect()

    Cursor = CurCursor
  End Sub

  Private Sub btnBrowseAttachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseAttachment.Click
    Dim fdlg As System.Windows.Forms.OpenFileDialog = New System.Windows.Forms.OpenFileDialog

    fdlg.Title = "Select Attachment"
    fdlg.InitialDirectory = "C:\\"
    fdlg.Filter = "All files (*.*)|*.*"
    fdlg.FilterIndex = 1
    fdlg.RestoreDirectory = True
    fdlg.Multiselect = True
    If (fdlg.ShowDialog() <> DialogResult.OK) Then
      Return
    End If

    For Each strFile As String In fdlg.FileNames
      If (txtAttachments.Text <> String.Empty) Then
        txtAttachments.Text += "|"
      End If
      txtAttachments.Text += strFile
    Next
  End Sub

  Private Sub btnViewLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewLog.Click
    If (System.IO.File.Exists(txtLogfile.Text)) Then
      System.Diagnostics.Process.Start(txtLogfile.Text)
    End If
  End Sub

  Private Sub cbxSecurity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSecurity.SelectedIndexChanged
    Dim nIdx As Integer = cbxSecurity.SelectedIndex

    If nIdx = IDX_NOTSECURE Then
      txtPort.Text = "25"
    ElseIf nIdx = IDX_SSLTLS Then
      txtPort.Text = "465"
    ElseIf nIdx = IDX_STARTTLS Then
      txtPort.Text = "587"
    Else
      txtPort.Text = "587"
    End If

    UpdateControls()
  End Sub

  Private Sub btnOAuth_Click(sender As Object, e As EventArgs) Handles btnOAuth.Click
    objFrmOauth2Settings.ShowDialog()
    sBearerToken = ""  ' reset bearer token cache
  End Sub

  Private Sub txtHost_TextChanged(sender As Object, e As EventArgs) Handles txtHost.TextChanged
    sBearerToken = ""  ' reset bearer token cache
  End Sub
End Class