Public Class frmImap

  Private Const IDX_NOTSECURE As Integer = 0
  Private Const IDX_SSLTLS As Integer = 1
  Private Const IDX_XOAUTH2 As Integer = 2

  Private objImap As AxEmail.Imap = New AxEmail.Imap()
  Private objConstants As AxEmail.Constants = New AxEmail.Constants()
  Private objOAuth2 As AxEmail.OAuth2 = New AxEmail.OAuth2()
  Private objEmail As AxEmail.Message = Nothing
  Private bNewEmail As Boolean = False

  Private sBearerToken As String
  Private dtBearerOrigin As DateTime = DateTime.Now
  Private objFrmOauth2Settings As frmOAuth2Settings = New frmOAuth2Settings()

  Public Sub New()
    MyBase.New
    InitializeComponent()

    ' setup security combobox
    cbxSecurity.Items.Clear()
    cbxSecurity.Items.Add("Not Secure")
    cbxSecurity.Items.Add("SSL/TLS")
    cbxSecurity.Items.Add("XOAUTH2")
    cbxSecurity.SelectedIndex = IDX_SSLTLS

    ' setup email flags
    Dim dctMailFlags = New Dictionary(Of String, String)
    dctMailFlags.Add(Me.objConstants.IMAP_MAIL_FLAG_ANSWERED, Me.objConstants.IMAP_MAIL_FLAG_ANSWERED)
    dctMailFlags.Add(Me.objConstants.IMAP_MAIL_FLAG_DELETED, Me.objConstants.IMAP_MAIL_FLAG_DELETED)
    dctMailFlags.Add(Me.objConstants.IMAP_MAIL_FLAG_DRAFT, Me.objConstants.IMAP_MAIL_FLAG_DRAFT)
    dctMailFlags.Add(Me.objConstants.IMAP_MAIL_FLAG_FLAGGED, Me.objConstants.IMAP_MAIL_FLAG_FLAGGED)
    dctMailFlags.Add(Me.objConstants.IMAP_MAIL_FLAG_RECENT, Me.objConstants.IMAP_MAIL_FLAG_RECENT)
    dctMailFlags.Add(Me.objConstants.IMAP_MAIL_FLAG_SEEN, Me.objConstants.IMAP_MAIL_FLAG_SEEN)
    cmbMailFlags.DisplayMember = "Key"
    cmbMailFlags.ValueMember = "Value"
    cmbMailFlags.DataSource = New BindingSource(dctMailFlags, Nothing)
    cmbMailFlags.SelectedValue = CType(Me.objConstants.IPVERSION_4, Integer)
    ' setup the default log path
    txtLogfile.Text = (System.IO.Path.GetTempPath + "Imap.Log")
    Me.UpdateControls()
  End Sub

  Private Sub UpdateControls()
    Dim bConnected As Boolean = Me.objImap.IsConnected
    Dim bMailboxSelected As Boolean = (Not (tvMailbox.SelectedNode) Is Nothing)
    Dim bMailSelected As Boolean = (Not (Me.objEmail) Is Nothing)
    Dim bExistingMailSelected As Boolean = (lvMail.SelectedItems.Count > 0)
    Dim bOAuthSelected = cbxSecurity.SelectedIndex = IDX_XOAUTH2

    txtHost.Enabled = Not bConnected
    txtPort.Enabled = Not bConnected
    txtAccount.Enabled = Not bConnected
    txtPassword.Enabled = Not bConnected
    btnConnect.Enabled = Not bConnected
    btnDisconnect.Enabled = bConnected
    btnOAuth.Enabled = Not bConnected And bOAuthSelected

    txtLogfile.Enabled = Not bConnected
    btnViewLog.Enabled = True
    txtTo.Enabled = bConnected
    txtSubject.Enabled = bConnected
    txtFrom.Enabled = bConnected
    txtBody.Enabled = bConnected
    txtHtml.Enabled = bConnected
    cmbMailFlags.Enabled = bConnected
    lvMail.Enabled = bConnected
    lvAttachments.Enabled = bConnected
    btnSet.Enabled = (bConnected AndAlso bExistingMailSelected)
    btnReset.Enabled = (bConnected AndAlso bExistingMailSelected)
    btnExpunge.Enabled = bConnected
    btnRefresh.Enabled = bConnected
    btnSaveMessage.Enabled = (bConnected AndAlso bExistingMailSelected)
    btnSaveToMailbox.Enabled = (bConnected AndAlso Me.bNewEmail)
    btnNewMessage.Enabled = (bConnected AndAlso bMailboxSelected)
    btnAddAttachment.Enabled = (bConnected AndAlso Me.bNewEmail)
    tvMailbox.Enabled = bConnected
    btnCreate.Enabled = bConnected
    btnRefreshMailbox.Enabled = bConnected
    btnRename.Enabled = bConnected
    btnDelete.Enabled = bConnected
  End Sub

  Private Sub UpdateResult()
    If objOAuth2.LastError <> 0 Then
      txtResult.Text = objOAuth2.LastError & ", " + objOAuth2.GetErrorDescription(objOAuth2.LastError)
    Else
      txtResult.Text = objImap.LastError & ", " + objImap.GetErrorDescription(objImap.LastError)
    End If

    txtResponse.Text = objImap.LastImapResponse
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
    UpdateResult()
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
    UpdateResult()

    If objOAuth2.LastError = 0 Then
      dtBearerOrigin = DateTime.Now
      sBearerToken = objOAuth2.BearerToken
    End If

    Return objOAuth2.LastError = 0
  End Function

  Private Function RefreshOAuth2BearerToken() As Boolean
    objOAuth2.RefreshBearerToken()
    UpdateResult()
    If objOAuth2.LastError = 0 Then
      dtBearerOrigin = DateTime.Now
      sBearerToken = objOAuth2.BearerToken
    End If
    Return objOAuth2.LastError = 0
  End Function

  Private Sub btnConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConnect.Click
    objImap.LogFile = txtLogfile.Text
    objImap.HostPort = Int32.Parse(txtPort.Text)
    Dim nSecIdx As Integer = cbxSecurity.SelectedIndex
    If nSecIdx <> IDX_NOTSECURE Then objImap.SetSecure(Int32.Parse(txtPort.Text))
    objImap.IpVersion = objConstants.IPVERSION_4

    If nSecIdx = IDX_XOAUTH2 Then

      If sBearerToken = "" Then
        If Not GetOAuth2BearerToken() Then Return
      End If

      Dim tsSpan As TimeSpan = DateTime.Now - dtBearerOrigin

      If tsSpan.TotalSeconds >= objOAuth2.BearerExpInSeconds Then
        If Not RefreshOAuth2BearerToken() Then Return
      End If

      objImap.BearerToken = sBearerToken
    End If

    objImap.Connect(txtHost.Text, txtAccount.Text, txtPassword.Text)
    If objImap.LastError = 0 Then RefreshMailbox()
    UpdateResult()
    UpdateControls()
  End Sub

  Private Sub btnDisconnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDisconnect.Click
    ' disconnect from the remote IMAP server.
    ' by default this will also automatically 'CLOSE' (If a mailbox was selected) and 'LOGOUT' on the IMAP server.
    Me.objImap.Disconnect()
    Me.UpdateResult()
    Me.UpdateControls()
  End Sub

  Private Sub btnViewLog_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnViewLog.Click
    If System.IO.File.Exists(txtLogfile.Text) Then
      System.Diagnostics.Process.Start(txtLogfile.Text)
    End If

  End Sub

  Private Structure ListItem
    Dim sName As String
    Dim sAttributes As String
  End Structure

  Private Sub loadSubnodes(ByVal sReference As String, ByVal oNodes As TreeNodeCollection, ByVal nDepth As Integer, ByVal nMaxDepth As Integer)
    nDepth = (nDepth + 1)
    ' retrieve a list of all mailboxes as the level of the reference.
    ' e.g: '/', '%' will retrieve all mailbox names directly under '/'
    Me.objImap.List(sReference, "%")
    If (Me.objImap.LastError <> 0) Then
      ' failed; return
      Me.UpdateResult()
      Me.UpdateControls()
      Return
    End If

    ' store all the mailbox information we need in a local variable before we recurse into sub mailboxes
    ' because the IMAP component will only store one list at the time.
    Dim vList = New List(Of ListItem)
    Dim nCnt As Integer = Me.objImap.ListCount
    Dim i As Integer = 0
    Do While (i < nCnt)
      Dim obj = New ListItem
      obj.sName = objImap.ListName(i)
      obj.sAttributes = objImap.ListAttributes(i)
      vList.Add(obj)
      i = i + 1
    Loop

    ' add mailboxes to the sub and recurse into mailbox that we suspect may have sub mailboxes
    Dim sSep As String = Me.objImap.HierarchySeparator
    Dim sNewReference As String
    For Each oLi In vList
      sNewReference = (oLi.sName + sSep)
      ' create the new node and it to the list
      Dim objNode = New TreeNode(oLi.sName.Substring((oLi.sName.LastIndexOf(sSep) + 1)))
      objNode.Tag = oLi.sName
      oNodes.Add(objNode)
      ' don't recurse further than max depth
      ' NOTE: A lot of IMAP implementations have the 'CHILDREN' children capability where the mailbox flags indicate
      ' if the mailbox has children or not. We select on the negative (does not say it has no children) 
      ' to recurse to make sure that it also works for IMAP implementations that do not implement the 'CHILDREN' capability
      If ((nDepth < nMaxDepth) _
                  AndAlso Not oLi.sAttributes.Contains(Me.objConstants.IMAP_MBX_FLAG_HASNOCHILDREN)) Then
        Me.loadSubnodes(sNewReference, objNode.Nodes, nDepth, nMaxDepth)
      End If

    Next
  End Sub

  Private Sub RefreshMailbox()
    ' clean the current set of nodes
    tvMailbox.Nodes.Clear()
    ' get the hierarchy separator by retrieving an empty list ""
    ' most servers will return '/' but some server may return '.', '\' or even '' if they do not support nesting mailboxes.
    Me.objImap.List("", "")
    Dim sSep As String = Me.objImap.HierarchySeparator
    Dim sReference As String = ""
    ' fill the treeview for up to 5 levels
    ' NOTE: Either fill only upto a predefined depth or - preferably - fill each level only when requested.
    ' The mail server may link one folder to another folder on a higher level in such a way that there is an endless recursion.      
    Me.loadSubnodes(sReference, tvMailbox.Nodes, 0, 5)
  End Sub

  Private Sub btnRefreshMailbox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefreshMailbox.Click
    Me.RefreshMailbox()
    Me.UpdateResult()
    Me.UpdateControls()
  End Sub

  Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreate.Click
    Dim oNode = tvMailbox.SelectedNode
    Dim sName = Me.objImap.HierarchySeparator
    If (Not (oNode) Is Nothing) Then
      sName = CType(oNode.Tag, String)
    End If

    sName = Interaction.InputBox("Please enter the name of the new mailbox to create:", Me.Text, sName)
    If (sName = "") Then
      Return
    End If

    Me.objImap.Create(sName)
    Me.UpdateResult()

    If (Me.objImap.LastError = 0) Then
      Me.RefreshMailbox()
    End If

    Me.UpdateResult()
    Me.UpdateControls()
  End Sub

  Private Sub btnRename_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRename.Click
    If (tvMailbox.SelectedNode Is Nothing) Then
      Return
    End If

    Dim oNode = tvMailbox.SelectedNode
    Dim sOldName = CType(oNode.Tag, String)
    Dim sNewName As String = Interaction.InputBox("Please enter the new name of the mailbox:", Me.Text, sOldName)
    If (sNewName = "") Then
      Return
    End If

    Me.objImap.Rename(sOldName, sNewName)
    Me.UpdateResult()

    If (Me.objImap.LastError = 0) Then
      Me.RefreshMailbox()
    End If

    Me.UpdateResult()
    Me.UpdateControls()
  End Sub

  Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
    If (tvMailbox.SelectedNode Is Nothing) Then
      Return
    End If

    Dim oNode = tvMailbox.SelectedNode
    Dim sName = CType(oNode.Tag, String)
    If (MessageBox.Show("Are you sure you want to permanently delete the entire mailbox: [" & sName & "]?", Me.Text, MessageBoxButtons.YesNo) = DialogResult.Yes) Then
      Me.objImap.Delete(sName)
      Me.UpdateResult()

      If (Me.objImap.LastError = 0) Then
        Me.RefreshMailbox()
      End If

      Me.UpdateResult()
      Me.UpdateControls()
    End If

  End Sub

  Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
    Me.objImap.Noop()
    lblCount.Text = "[" _
                & Me.objImap.Exists & "] Messages, [" _
                & Me.objImap.Unseen & "] Unseen, [" _
                & Me.objImap.Recent & "] Recent"
    Me.ReloadMail()
    Me.UpdateResult()
    Me.UpdateControls()
  End Sub

  Private Sub SelectMailbox(ByVal sName As String)
    lvMail.Items.Clear()
    ' select the mailbox. The objImap.Exists / objImap.Unseen and objImap.Recent properties are always about 
    ' the mailbox that was last selected.
    Me.objImap.Select(sName)
    lblCount.Text = "[" _
                & Me.objImap.Exists & "] Messages, [" _
                & Me.objImap.Unseen & "] Unseen, [" _
                & Me.objImap.Recent & "] Recent"
  End Sub

  Private Sub ReloadMail()
    ' get all email headers data so we can make a list that's an overview of all mail items in this mailbox. 
    ' also show a progress bar because it can take some time to get all information about hundreds or 
    ' even thousands  of emails.       
    Dim oProgress As frmProgress = New frmProgress("Download message headers...", Me.objImap.Exists)
    oProgress.Show()
    ' fetch actual data from the IMAP server. The FetchMaxNumItemsAtOnce option controls howmany email header
    ' are fetched up front. This number improves performance at the cost of using more memory when fetching a 
    ' large number of items.
    lvMail.Items.Clear()
    Dim nFetched As Integer = 1
    Me.objImap.FetchMaxNumItemsAtOnce = 50
    Dim oEmailMessage = Me.objImap.FetchFirstEmailHeader(Me.objConstants.IMAP_SK_ALL)

    While (Me.objImap.LastError = 0)
      If Not oProgress.DoProgress(nFetched) Then
        Exit While
      End If

      ' if the users closes the progress bar we'll stop gathering more information.
      nFetched = (nFetched + 1)
      Dim lvi = New ListViewItem(oEmailMessage.ImapUID.ToString)
      lvi.Tag = oEmailMessage.ImapUID
      lvi.SubItems.Add(oEmailMessage.Date)
      lvi.SubItems.Add(oEmailMessage.ImapFlags)
      lvi.SubItems.Add((oEmailMessage.Size / 1024) & "kb")
      lvi.SubItems.Add(oEmailMessage.Subject)
      lvMail.Items.Insert(0, lvi)
      oEmailMessage = Me.objImap.FetchNextEmailHeader

    End While

    oProgress.Close()
  End Sub

  Private Sub tvMailbox_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles tvMailbox.AfterSelect
    If (tvMailbox.SelectedNode Is Nothing) Then
      Return
    End If

    Dim oNode = tvMailbox.SelectedNode
    Dim sName = CType(oNode.Tag, String)
    Me.SelectMailbox(sName)
    Me.ReloadMail()
    Me.UpdateResult()
    Me.UpdateControls()
  End Sub

  Private Sub lvMail_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lvMail.SelectedIndexChanged
    If (lvMail.SelectedItems.Count <= 0) Then
      Return
    End If

    Dim uid = CType(lvMail.SelectedItems(0).Tag, Integer)
    Me.bNewEmail = False
    ' fetch a specific email by user id.
    Me.objEmail = Me.objImap.FetchFirstEmail(Me.objConstants.IMAP_SK_UID & " " & uid)
    If (Me.objImap.LastError <> 0) Then
      Me.UpdateResult()
      Me.UpdateControls()
      Return
    End If

    ' set all properties and attachments
    txtFrom.Text = Me.objEmail.FromAddress
    txtTo.Text = Me.objEmail.ToAddress
    txtSubject.Text = Me.objEmail.Subject
    txtBody.Text = Me.objEmail.BodyPlainText
    txtHtml.Text = Me.objEmail.BodyHtml
    tcBody.SelectedTab = tabPlain
    If (txtBody.Text = "") Then
      tcBody.SelectedTab = tabHtml
    End If

    lvAttachments.Items.Clear()
    Dim nNumAttachments As Integer = Me.objEmail.CountAttachments
    Dim i As Integer = 1
    Do While (i <= nNumAttachments)
      Dim lvi = New ListViewItem(Me.objEmail.GetAttachmentName(i))
      lvi.Tag = i
      lvi.SubItems.Add((Me.objEmail.GetAttachmentSize(i) / 1024) & "kb")
      lvAttachments.Items.Add(lvi)
      i = (i + 1)
    Loop

    Me.UpdateResult()
    Me.UpdateControls()
  End Sub

  Private Sub btnSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSet.Click
    If (cmbMailFlags.SelectedItem Is Nothing) Then
      Return
    End If

    If (lvMail.SelectedItems.Count <= 0) Then
      Return
    End If

    Dim sFlag As String = CType(cmbMailFlags.SelectedValue, String)
    Dim nUid As Integer = CType(lvMail.SelectedItems(0).Tag, Integer)
    ' store flag value to email. Not all flag values make sense in every mailbox
    ' the server may reply with 'NO' if it does not make sense.
    Me.objImap.Store(nUid.ToString, sFlag, Me.objConstants.IMAP_STO_ADD)
    Me.UpdateResult()
    Me.UpdateControls()

    If (Me.objImap.LastError = 0) Then
      MessageBox.Show("Message flags updated!" & vbLf & vbLf & "Click 'Refresh' to update the message list and view the change")
    End If

  End Sub

  Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
    If (cmbMailFlags.SelectedItem Is Nothing) Then
      Return
    End If

    If (lvMail.SelectedItems.Count <= 0) Then
      Return
    End If

    Dim sFlag As String = CType(cmbMailFlags.SelectedValue, String)
    Dim nUid As Integer = CType(lvMail.SelectedItems(0).Tag, Integer)
    ' remove flag from email.
    Me.objImap.Store(nUid.ToString, sFlag, Me.objConstants.IMAP_STO_REMOVE)
    Me.UpdateResult()
    Me.UpdateControls()

    If (Me.objImap.LastError = 0) Then
      MessageBox.Show("Message flags updated!" & vbLf & vbLf & "Click 'Refresh' to update the message list and view the change")
    End If

  End Sub

  Private Sub btnExpunge_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExpunge.Click
    ' deletes all emails that where flagged with 'DELETED' 
    Me.objImap.Expunge()
    Me.UpdateResult()
    Me.UpdateControls()
  End Sub

  Private Sub lvAttachments_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lvAttachments.DoubleClick
    If (lvAttachments.SelectedItems.Count < 1) Then
      Return
    End If

    Dim nId As Integer = CType(lvAttachments.SelectedItems(0).Tag, Integer)
    Dim dlg As SaveFileDialog = New SaveFileDialog
    dlg.Title = "Save attachment as..."
    dlg.RestoreDirectory = True
    dlg.FileName = Me.objEmail.GetAttachmentName(nId)
    If (dlg.ShowDialog = DialogResult.OK) Then
      Me.objEmail.SaveAttachment(nId, dlg.FileName)
      Me.UpdateResult()
      Me.UpdateControls()
    End If

  End Sub

  Private Sub btnAddAttachment_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddAttachment.Click
    Dim dlg As OpenFileDialog = New OpenFileDialog
    dlg.Title = "Add attachment"
    dlg.RestoreDirectory = True
    dlg.CheckFileExists = True
    If (dlg.ShowDialog = DialogResult.OK) Then
      Me.objEmail.AddAttachment(dlg.FileName)
      Me.UpdateResult()

      If (Me.objEmail.LastError = 0) Then
        Dim nId As Integer = Me.objEmail.CountAttachments
        Dim oLvi = New ListViewItem(Me.objEmail.GetAttachmentName(nId))
        oLvi.SubItems.Add((Me.objEmail.GetAttachmentSize(nId) / 1024) & "kb")
        oLvi.Tag = nId
        lvAttachments.Items.Add(oLvi)
      End If

      Me.UpdateControls()
    End If

  End Sub

  Private Sub btnClearMessage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNewMessage.Click
    txtTo.Text = ""
    txtSubject.Text = ""
    txtFrom.Text = ""
    txtBody.Text = ""
    txtHtml.Text = ""
    lvAttachments.Items.Clear()

    If (Me.objEmail Is Nothing) Then
      Me.objEmail = New AxEmail.Message
    Else
      Me.objEmail.Clear()
    End If

    Me.bNewEmail = True
    lvMail.SelectedItems.Clear()
    Me.UpdateControls()
  End Sub

  Private Sub btnSaveToMailbox_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveToMailbox.Click
    If (Me.objEmail Is Nothing) Then
      Return
    End If

    If (tvMailbox.SelectedNode Is Nothing) Then
      Return
    End If

    Dim oNode = tvMailbox.SelectedNode
    Dim sName = CType(oNode.Tag, String)
    Me.objEmail.AddTo(txtTo.Text)
    Me.objEmail.FromAddress = txtFrom.Text
    Me.objEmail.Subject = txtSubject.Text
    Me.objEmail.BodyHtml = txtHtml.Text
    Me.objEmail.BodyPlainText = txtBody.Text
    ' Adds an email to the mailbox
    Me.objImap.Append(sName, Me.objEmail)
    Me.bNewEmail = False
    Me.UpdateResult()
    Me.UpdateControls()
    Me.btnClearMessage_Click(Nothing, Nothing)
    If (Me.objImap.LastError = 0) Then
      MessageBox.Show("Message saved to mailbox!" & vbLf & vbLf & "Click 'Refresh' to update the message list and view the change")
    End If

  End Sub

  Private Sub btnSaveMessage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSaveMessage.Click
    If (Me.objEmail Is Nothing) Then
      Return
    End If

    ' save a MIME file. The MIME file is the email in the text based format that a mailserver uses internally to store emails      
    Dim dlg As SaveFileDialog = New SaveFileDialog
    dlg.Title = "Save mime as..."
    dlg.RestoreDirectory = True
    dlg.FileName = Me.objEmail.Subject & ".mime"
    If (dlg.ShowDialog = DialogResult.OK) Then
      Me.objEmail.SaveMIME(dlg.FileName)
      Me.UpdateResult()
      Me.UpdateControls()
    End If

  End Sub

  Private Sub txtHost_TextChanged(sender As Object, e As EventArgs) Handles txtHost.TextChanged
    sBearerToken = "" ' reset bearer token cache
  End Sub

  Private Sub btnOAuth_Click(sender As Object, e As EventArgs) Handles btnOAuth.Click
    objFrmOauth2Settings.ShowDialog()
    sBearerToken = "" ' reset bearer token cache
  End Sub

  Private Sub cbxSecurity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSecurity.SelectedIndexChanged
    Dim nIdx As Integer = cbxSecurity.SelectedIndex

    If nIdx = IDX_NOTSECURE Then
      txtPort.Text = "143"
    ElseIf nIdx = IDX_SSLTLS Then
      txtPort.Text = "993"
    Else
      txtPort.Text = "993"
    End If

    UpdateControls()
  End Sub
End Class