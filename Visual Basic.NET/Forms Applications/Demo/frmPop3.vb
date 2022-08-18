'-----------------------------------------------------------------------
' <copyright file="frmPop3.vb" company="Auron">
'     Copyright (c) Auron Software - www.auronsoftware.com
' </copyright>
' <author>Dennis van de Giessen</author>
'-----------------------------------------------------------------------
Imports AxEmail

Public Class frmPop3

  Private Const IDX_NOTSECURE As Integer = 0
  Private Const IDX_SSLTLS As Integer = 1
  Private Const IDX_XOAUTH2 As Integer = 2

  Private objPop3Server As AxEmail.Pop3 = New AxEmail.Pop3()
  Private objConstants As AxEmail.Constants = New AxEmail.Constants()
  Private objOAuth2 As AxEmail.OAuth2 = New AxEmail.OAuth2()
  Private sBearerToken As String
  Private dtBearerOrigin As DateTime = DateTime.Now
  Private objFrmOauth2Settings As frmOAuth2Settings = New frmOAuth2Settings()


  Private Sub frmPop3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    ' A license key is required to unlock this component after the trial period has expired.
    ' Assign the LicenseKey property every time a new instance of this component is created (see code below). 
    ' Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
    ' For details, see manual, chapter "Product Activation".
    '
    ' objPop3Server.LicenseKey = "XXXXX-XXXXX-XXXXX"

    'Display Auron Email Component Info
    lblInfo.Text = String.Format("Auron Email Component {0}; Build: {1}; Module: {2}", objPop3Server.Version, objPop3Server.Build, objPop3Server.Module)

    txtHost.Text = "pop.gmail.com"

    If (txtPort.Text = String.Empty) Then
      txtPort.Text = "110"
    End If

    cbxSecurity.Items.Clear()
    cbxSecurity.Items.Add("Not Secure")
    cbxSecurity.Items.Add("SSL/TLS")
    cbxSecurity.Items.Add("XOAUTH2")
    cbxSecurity.SelectedIndex = IDX_NOTSECURE

    txtLogfile.Text = System.IO.Path.GetTempPath() + "Pop3.log"
    ClearMessageFields()

    UpdateControls()
  End Sub

  Sub ClearMessageFields()
    txtSubject.Text = String.Empty
    txtBody.Text = String.Empty
    txtFrom.Text = String.Empty
    txtTo.Text = String.Empty
    lvAttachments.Items.Clear()
  End Sub

  Sub UpdateControls()
    Dim bConnected As Boolean = objPop3Server.IsConnected()
    Dim bOAuth2Selected As Boolean = cbxSecurity.SelectedIndex = IDX_XOAUTH2

    Dim objMail As AxEmail.Message = Nothing
    Dim objTemp As Object = Nothing

    txtHost.Enabled = Not bConnected
    txtPort.Enabled = Not bConnected
    txtAccount.Enabled = Not bConnected
    txtPassword.Enabled = Not bConnected
    btnConnect.Enabled = Not bConnected
    btnDisconnect.Enabled = bConnected
    btnOAuth.Enabled = Not bConnected And bOAuth2Selected
    lvMessages.Enabled = bConnected
    lvAttachments.Enabled = bConnected
    btnList.Enabled = bConnected
    txtBody.Enabled = bConnected
    txtSubject.Enabled = bConnected
    txtTo.Enabled = bConnected
    txtFrom.Enabled = bConnected

    If (bConnected And lvMessages.SelectedIndices.Count <> 0) Then
      objTemp = objPop3Server.GetEmailMessage(lvMessages.SelectedIndices(0) + 1)
      If (Not objTemp Is Nothing) Then
        btnSaveMessage.Enabled = True
      Else
        btnSaveMessage.Enabled = False
      End If
    Else
      btnSaveMessage.Enabled = False
    End If

    objMail = objTemp
  End Sub

  Sub SetResult(nResult As Integer)
    txtResult.Text = nResult + ": " + objPop3Server.GetErrorDescription(nResult)
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

  Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click

    Dim cur As Cursor = Cursor.Current

    Cursor.Current = Cursors.WaitCursor

    lvMessages.Items.Clear()
    ClearMessageFields()

    objPop3Server.Authentication = objConstants.POP3_AUTH_AUTO
    objPop3Server.LogFile = txtLogfile.Text

    ' Set Secure if secure communications is required
    Dim nSecIdx As Integer = cbxSecurity.SelectedIndex

    If nSecIdx <> IDX_NOTSECURE Then
      objPop3Server.SetSecure(Int32.Parse(txtPort.Text))
    Else
      objPop3Server.HostPort = Int32.Parse(txtPort.Text)
    End If

    If nSecIdx = IDX_XOAUTH2 Then
      If sBearerToken = "" Then
        If Not GetOAuth2BearerToken() Then Return
      End If

      Dim tsSpan As TimeSpan = DateTime.Now - dtBearerOrigin

      If tsSpan.TotalSeconds >= objOAuth2.BearerExpInSeconds Then
        If Not RefreshOAuth2BearerToken() Then Return
      End If

      objPop3Server.BearerToken = sBearerToken
    End If

    If (GetResult() = 0) Then
      ' Connects to the POP3 server
      objPop3Server.Connect(txtHost.Text, txtAccount.Text, txtPassword.Text)
    End If

    GetResult()

    UpdateControls()
    Cursor.Current = cur
  End Sub

  Function GetResult()

    Dim lResult As Integer = 0

    lResult = objPop3Server.LastError

    txtResult.Text = lResult.ToString() + ": " + objPop3Server.GetErrorDescription(objPop3Server.LastError)
    txtResponse.Text = objPop3Server.LastPop3Response

    Return lResult
  End Function

  Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
    Dim cur As Cursor = Cursor.Current
    Dim nMessages As Integer
    Dim i As Integer
    Dim objMail As AxEmail.Message
    Dim Item As ListViewItem

    lvMessages.Items.Clear()
    ClearMessageFields()

    Cursor.Current = Cursors.WaitCursor

    ' Counts the messages
    nMessages = objPop3Server.CountMessages()

    If (GetResult() = 0) Then
      For i = 1 To nMessages
        ' Gets the Email header for the current message
        objMail = objPop3Server.GetEmailHeader(i)

        If (GetResult() = 0) Then
          Item = lvMessages.Items.Add(objMail.ID.ToString())
          Item.SubItems.Add(objMail.FromAddress)
          Item.SubItems.Add(objMail.Date)
          Item.SubItems.Add(objMail.Subject)
        End If
      Next
    End If

    UpdateControls()

    Cursor.Current = cur
  End Sub

  Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisconnect.Click
    Dim cur As Cursor = Cursor.Current

    Cursor.Current = Cursors.WaitCursor

    objPop3Server.Disconnect()

    lvMessages.Items.Clear()
    ClearMessageFields()

    UpdateControls()

    Cursor.Current = cur
  End Sub

  Private Sub btnSaveMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMessage.Click
    Dim objMail As AxEmail.Message = Nothing
    Dim objTemp As Object = Nothing
    Dim fdlg As System.Windows.Forms.SaveFileDialog

    If (lvMessages.SelectedIndices.Count <> 0) Then

      'Gets the requested E-Mail message
      objTemp = objPop3Server.GetEmailMessage(lvMessages.SelectedIndices(0) + 1)

      If (IsDBNull(objTemp)) Then
        Return
      End If

      objMail = objTemp

      fdlg = New SaveFileDialog()
      fdlg.Title = "Save"
      fdlg.InitialDirectory = "c:\\"
      fdlg.Filter = "MIME Files (*.mim)|*.mim|All files (*.*)|*.*"
      fdlg.FilterIndex = 1
      fdlg.RestoreDirectory = True
      If (fdlg.ShowDialog() <> DialogResult.OK) Then
        Return
      End If

      'Saves the requested E-Mail message as an Mime File
      objMail.SaveMIME(fdlg.FileName)

      txtResult.Text = objMail.LastError.ToString() + ": " + objMail.GetErrorDescription(objMail.LastError)
    End If

  End Sub

  Private Sub btnViewLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewLog.Click
    If (System.IO.File.Exists(txtLogfile.Text)) Then
      System.Diagnostics.Process.Start(txtLogfile.Text)
    End If
  End Sub

  Private Sub lvMessages_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvMessages.SelectedIndexChanged
    Dim cur As Cursor = Cursor.Current
    Dim objMail As AxEmail.Message = Nothing
    Dim objTemp As Object = Nothing
    Dim nAttachments As Integer
    Dim i As Integer
    Dim Item As ListViewItem

    ClearMessageFields()

    Cursor.Current = Cursors.WaitCursor
    btnSaveMessage.Enabled = False

    If (lvMessages.SelectedIndices.Count <> 0) Then

      ' Gets the selected E-Mail message from the POP3 Server
      btnSaveMessage.Enabled = True
      objTemp = objPop3Server.GetEmailMessage(lvMessages.SelectedIndices(0) + 1)
      objMail = objTemp

      If (GetResult() = 0) Then
        txtSubject.Text = objMail.Subject.ToString()
        If (objMail.BodyPlainText.ToString() = String.Empty) Then
          txtBody.Text = objMail.BodyHtml.ToString()
        Else
          txtBody.Text = objMail.BodyPlainText.ToString()
        End If

        txtFrom.Text = objMail.FromAddress.ToString()
        txtTo.Text = objMail.ToAddress.ToString()

        nAttachments = objMail.CountAttachments()

        If (nAttachments = 0 Or objMail.LastError <> 0) Then
          GetResult()
          lvAttachments.Enabled = False
        Else
          lvAttachments.Enabled = True
        End If

        For i = 1 To nAttachments
          Item = lvAttachments.Items.Add(objMail.GetAttachmentName(i))
          If (GetResult() <> 0) Then
            Return
          End If
        Next
      End If
    End If
  End Sub

  Private Sub lvAttachments_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvAttachments.DoubleClick
    Dim objMail As AxEmail.Message = Nothing
    Dim objTemp As Object = Nothing
    Dim fdlg As System.Windows.Forms.SaveFileDialog = New SaveFileDialog()

    If (lvMessages.SelectedIndices.Count = 0) Then
      Return
    End If

    If (lvAttachments.SelectedIndices.Count = 0) Then
      Return
    End If

    ' Gets the current E-Mail meesage
    objTemp = objPop3Server.GetEmailMessage(lvMessages.SelectedIndices(0) + 1)

    If (objTemp Is Nothing) Then
      GetResult()
      Return
    End If

    objMail = objTemp

    fdlg.Title = "Save"
    fdlg.InitialDirectory = "c:\\"
    fdlg.Filter = "All files (*.*)|*.*"
    fdlg.FilterIndex = 1
    fdlg.FileName = lvAttachments.SelectedItems(0).Text
    fdlg.RestoreDirectory = True
    If (fdlg.ShowDialog() <> DialogResult.OK) Then
      Return
    End If

    ' Saves the selected attachment
    objMail.SaveAttachment(lvAttachments.SelectedIndices(0) + 1, fdlg.FileName)
    txtResult.Text = objMail.LastError.ToString() + ": " + objMail.GetErrorDescription(objMail.LastError)

    If (objMail.LastError = 0) Then
      MessageBox.Show("Attachment saved.")
    Else
      MessageBox.Show("Failed to save attachment, error " + objMail.LastError.ToString() + " (" + objMail.GetErrorDescription(objMail.LastError) + ").")
    End If
  End Sub

  Private Sub cbxSecurity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSecurity.SelectedIndexChanged
    Dim nIdx As Integer = cbxSecurity.SelectedIndex

    If nIdx = IDX_NOTSECURE Then
      txtPort.Text = "110"
    ElseIf nIdx = IDX_SSLTLS Then
      txtPort.Text = "995"
    Else
      txtPort.Text = "995"
    End If

    UpdateControls()
  End Sub
End Class