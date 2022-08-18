using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Collections;

namespace Demo
{
  public partial class frmImap : Form
  {
    private const int IDX_NOTSECURE = 0;
    private const int IDX_SSLTLS = 1;
    private const int IDX_XOAUTH2 = 2;

    private AxEmail.OAuth2 objOAuth2 = new AxEmail.OAuth2();
    private AxEmail.Imap objImap = new AxEmail.Imap();
    private AxEmail.Constants objConstants = new AxEmail.Constants();
    private AxEmail.Message objEmail = null;

    private DateTime dtBearerOrigin = DateTime.Now;
    private string sBearerToken;
    private frmOAuth2Settings objFrmOauth2Settings = new frmOAuth2Settings();
    private bool bNewEmail = false;

    public frmImap()
    {
      InitializeComponent();

      // setup security combobox
      cbxSecurity.Items.Clear();
      cbxSecurity.Items.Add("Not Secure");
      cbxSecurity.Items.Add("SSL/TLS");
      cbxSecurity.Items.Add("XOAUTH2");
      cbxSecurity.SelectedIndex = IDX_SSLTLS;

      // setup email flags
      var dctMailFlags = new Dictionary<String, String>();
      dctMailFlags.Add(objConstants.IMAP_MAIL_FLAG_ANSWERED , objConstants.IMAP_MAIL_FLAG_ANSWERED  );
      dctMailFlags.Add(objConstants.IMAP_MAIL_FLAG_DELETED  , objConstants.IMAP_MAIL_FLAG_DELETED   );
      dctMailFlags.Add(objConstants.IMAP_MAIL_FLAG_DRAFT    , objConstants.IMAP_MAIL_FLAG_DRAFT     );
      dctMailFlags.Add(objConstants.IMAP_MAIL_FLAG_FLAGGED  , objConstants.IMAP_MAIL_FLAG_FLAGGED   );
      dctMailFlags.Add(objConstants.IMAP_MAIL_FLAG_RECENT   , objConstants.IMAP_MAIL_FLAG_RECENT    );
      dctMailFlags.Add(objConstants.IMAP_MAIL_FLAG_SEEN     , objConstants.IMAP_MAIL_FLAG_SEEN      );

      cmbMailFlags.DisplayMember = "Key";
      cmbMailFlags.ValueMember = "Value";
      cmbMailFlags.DataSource = new BindingSource(dctMailFlags, null);
      cmbMailFlags.SelectedValue = (int)objConstants.IPVERSION_4;

      // setup the default log path
      txtLogfile.Text = System.IO.Path.GetTempPath() + "Imap.Log";

      UpdateControls();
    }
    
    private void UpdateControls()
    {
      bool bConnected = objImap.IsConnected();      
      bool bMailboxSelected = tvMailbox.SelectedNode != null;
      bool bMailSelected = objEmail != null;
      bool bExistingMailSelected = lvMail.SelectedItems.Count > 0;
      bool bOAuthSelected = cbxSecurity.SelectedIndex == IDX_XOAUTH2;

      txtHost.Enabled = !bConnected;
      txtPort.Enabled = !bConnected;
      txtAccount.Enabled = !bConnected;
      txtPassword.Enabled = !bConnected;
      cbxSecurity.Enabled = !bConnected;
      btnConnect.Enabled = !bConnected;
      btnDisconnect.Enabled = bConnected;
      
      btnOAuth.Enabled = !bConnected && bOAuthSelected;

      txtLogfile.Enabled = !bConnected;
      btnViewLog.Enabled = true;      

      txtTo.Enabled = bConnected;
      txtSubject.Enabled = bConnected;
      txtFrom.Enabled = bConnected;
      txtBody.Enabled = bConnected;
      txtHtml.Enabled = bConnected;
      cmbMailFlags.Enabled = bConnected;
      lvMail.Enabled = bConnected;
      lvAttachments.Enabled = bConnected;
      btnSet.Enabled = bConnected && bExistingMailSelected;
      btnReset.Enabled = bConnected && bExistingMailSelected;
      btnExpunge.Enabled = bConnected;
      btnRefresh.Enabled = bConnected;

      btnSaveMessage.Enabled = bConnected && bExistingMailSelected;
      btnSaveToMailbox.Enabled = bConnected && bNewEmail;
      btnNewMessage.Enabled = bConnected && bMailboxSelected;
      btnAddAttachment.Enabled = bConnected && bNewEmail;

      tvMailbox.Enabled = bConnected;
      btnCreate.Enabled = bConnected;
      btnRefreshMailbox.Enabled = bConnected;
      btnRename.Enabled = bConnected;
      btnDelete.Enabled = bConnected;
    }

    private void UpdateResult()
    {
      if (objOAuth2.LastError != 0)
        txtResult.Text = objOAuth2.LastError + ", " + objOAuth2.GetErrorDescription(objOAuth2.LastError);
      else
        txtResult.Text = objImap.LastError + ", " + objImap.GetErrorDescription(objImap.LastError);
      txtResponse.Text = objImap.LastImapResponse;
    }

    private bool GetOAuth2BearerToken()
    {
      objOAuth2.LogFile = txtLogfile.Text;

      if (objFrmOauth2Settings.cbxFlow.SelectedIndex == frmOAuth2Settings.IDX_AUTHFLOW)
        objOAuth2.Flow = objConstants.OAUTH2_FLOW_AUTHCODE;
      else
        objOAuth2.Flow = objConstants.OAUTH2_FLOW_DEVICECODE;

      // set all oauth properties
      objOAuth2.ClientID = objFrmOauth2Settings.txtClientID.Text;
      objOAuth2.ClientSecret = objFrmOauth2Settings.txtClientSecret.Text;
      objOAuth2.Scope = objFrmOauth2Settings.txtScope.Text;
      objOAuth2.RedirectUrl = objFrmOauth2Settings.txtRedirectUrl.Text;
      objOAuth2.AuthCodeUrl = objFrmOauth2Settings.txtAuthCodeUrl.Text;
      objOAuth2.DeviceCodeUrl = objFrmOauth2Settings.txtDeviceCodeUrl.Text;
      objOAuth2.TokenExchangeUrl = objFrmOauth2Settings.txtTokenExchangeUrl.Text;

      objOAuth2.Login();
      UpdateResult();

      int nTokenExchangeTimeoutMs = 0;
      if (objOAuth2.LastError != 0) return false;
      if (objOAuth2.Flow == objConstants.OAUTH2_FLOW_DEVICECODE)
      { // show device code!        
        frmShowDeviceCode objFrmShowCode = new frmShowDeviceCode();
        objFrmShowCode.lblUserCode.Text = objOAuth2.UserCode;
        objFrmShowCode.ShowDialog();

        nTokenExchangeTimeoutMs = objOAuth2.UserCodeExpInSeconds * 1000;
      }
      else
        nTokenExchangeTimeoutMs = 120000;

      objOAuth2.WaitForTokens(nTokenExchangeTimeoutMs);
      UpdateResult();
      if (objOAuth2.LastError == 0)
      {
        dtBearerOrigin = DateTime.Now;
        sBearerToken = objOAuth2.BearerToken;
      }

      return objOAuth2.LastError == 0;
    }

    private bool RefreshOAuth2BearerToken()
    {
      objOAuth2.RefreshBearerToken();
      UpdateResult();
      if (objOAuth2.LastError == 0)
      {
        dtBearerOrigin = DateTime.Now;
        sBearerToken = objOAuth2.BearerToken;
      }
      return objOAuth2.LastError == 0;
    }


    private void btnConnect_Click(object sender, EventArgs e)
    {
      // connect to the remote IMAP server.
      // set the logfile before doing anything else
      objImap.LogFile = txtLogfile.Text;

      // most values that have sensible defaults can be set explicitly as object properties.      
      // if secure is true the initial connection will be secured. If the initial conneciton is not secure
      // connect will always try to promote to a secured connection using STARTTLS capability
      objImap.HostPort = Int32.Parse(txtPort.Text);
      int nSecIdx = cbxSecurity.SelectedIndex;
      if (nSecIdx != IDX_NOTSECURE)
        objImap.SetSecure(Int32.Parse(txtPort.Text));
      objImap.IpVersion = objConstants.IPVERSION_4;

      // only for OAuth authenticiation
      if (nSecIdx == IDX_XOAUTH2)
      { // for OAuth2 we need to have a bearer token so try to obtain one
        if (sBearerToken == "")
        {
          if (!GetOAuth2BearerToken())
            return;
        }

        // if the bearer token has expired then refresh it
        TimeSpan tsSpan = DateTime.Now - dtBearerOrigin;
        if (tsSpan.TotalSeconds >= objOAuth2.BearerExpInSeconds)
        {
          if (!RefreshOAuth2BearerToken())
            return;
        }

        // set the resulting bearer token in the SMTP object
        objImap.BearerToken = sBearerToken;
      }

      // connect to imap server
      objImap.Connect(txtHost.Text, txtAccount.Text, txtPassword.Text);

      // if the connection succeeds refresh the mailbox treeview automatically
      if (objImap.LastError == 0)
        RefreshMailbox();

      UpdateResult();
      UpdateControls();
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
      // disconnect from the remote IMAP server.
      // by default this will also automatically 'CLOSE' (If a mailbox was selected) and 'LOGOUT' on the IMAP server.
      objImap.Disconnect();

      UpdateResult();
      UpdateControls();
    }

    private void btnViewLog_Click(object sender, EventArgs e)
    {
      if (System.IO.File.Exists(txtLogfile.Text))
      {
        System.Diagnostics.Process.Start(txtLogfile.Text);
      }
    }

    private void loadSubnodes(string sReference, TreeNodeCollection oNodes, int nDepth, int nMaxDepth)
    {
      nDepth = nDepth + 1;

      // retrieve a list of all mailboxes as the level of the reference.
      // e.g: '/', '%' will retrieve all mailbox names directly under '/'
      objImap.List(sReference, "%");
      if (objImap.LastError != 0)
      { // failed; return
        UpdateResult();
        UpdateControls();
        return;
      }

      // store all the mailbox information we need in a local variable before we recurse into sub mailboxes
      // because the IMAP component will only store one list at the time.
      var vList = new List<dynamic>();
      int nCnt = objImap.ListCount();
      for (int i = 0; i < nCnt; i++)
        vList.Add(new { sName = objImap.ListName(i), sAttributes = objImap.ListAttributes(i) });

      // add mailboxes to the sub and recurse into mailbox that we suspect may have sub mailboxes
      string sSep = objImap.HierarchySeparator;
      string sNewReference;
      foreach (var oLi in vList)
      {
        sNewReference = oLi.sName + sSep;

        // create the new node and it to the list
        var objNode = new TreeNode(oLi.sName.Substring(oLi.sName.LastIndexOf(sSep) + 1));
        objNode.Tag = oLi.sName;
        oNodes.Add(objNode);

        // don't recurse further than max depth
        // NOTE: A lot of IMAP implementations have the 'CHILDREN' children capability where the mailbox flags indicate
        // if the mailbox has children or not. We select on the negative (does not say it has no children) 
        // to recurse to make sure that it also works for IMAP implementations that do not implement the 'CHILDREN' capability
        if (nDepth < nMaxDepth && !oLi.sAttributes.Contains(objConstants.IMAP_MBX_FLAG_HASNOCHILDREN))
          loadSubnodes(sNewReference, objNode.Nodes, nDepth, nMaxDepth);
      }
    }

    private void RefreshMailbox()
    {
      // clean the current set of nodes
      tvMailbox.Nodes.Clear();

      // get the hierarchy separator by retrieving an empty list ""
      // most servers will return '/' but some server may return '.', '\' or even '' if they do not support nesting mailboxes.
      objImap.List("", "");
      string sSep = objImap.HierarchySeparator;
      string sReference = "";

      // fill the treeview for up to 5 levels
      // NOTE: Either fill only upto a predefined depth or - preferably - fill each level only when requested.
      // The mail server may link one folder to another folder on a higher level in such a way that there is an endless recursion.      
      loadSubnodes(sReference, tvMailbox.Nodes, 0, 5);
    }

    private void btnRefreshMailbox_Click(object sender, EventArgs e)
    {
      RefreshMailbox();

      UpdateResult();
      UpdateControls();
    }

    private void btnCreate_Click(object sender, EventArgs e)
    {
      var oNode = tvMailbox.SelectedNode;
      var sName = objImap.HierarchySeparator;
      if (oNode != null) sName = (string)oNode.Tag;

      sName = Interaction.InputBox("Please enter the name of the new mailbox to create:", this.Text, sName);
      if (sName == "") return;

      objImap.Create(sName);
      UpdateResult();

      if (objImap.LastError == 0)
        RefreshMailbox();

      UpdateResult();
      UpdateControls();
    }

    private void btnRename_Click(object sender, EventArgs e)
    {
      if (tvMailbox.SelectedNode == null) return;
      var oNode = tvMailbox.SelectedNode;
      var sOldName = (string)oNode.Tag;

      string sNewName = Interaction.InputBox("Please enter the new name of the mailbox:", this.Text, sOldName);
      if (sNewName == "") return;

      objImap.Rename(sOldName, sNewName);
      UpdateResult();

      if (objImap.LastError == 0)
        RefreshMailbox();

      UpdateResult();
      UpdateControls();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      if (tvMailbox.SelectedNode == null) return;
      var oNode = tvMailbox.SelectedNode;
      var sName = (string)oNode.Tag;

      if (MessageBox.Show("Are you sure you want to permanently delete the entire mailbox: [" + sName + "]?", this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        objImap.Delete(sName);
        UpdateResult();

        if (objImap.LastError == 0)
          RefreshMailbox();

        UpdateResult();
        UpdateControls();
      }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      objImap.Noop();
      lblCount.Text = "[" + objImap.Exists + "] Messages, [" + objImap.Unseen + "] Unseen, [" + objImap.Recent + "] Recent";

      ReloadMail();

      UpdateResult();
      UpdateControls();
    }

    private void SelectMailbox(string sName)
    {
      lvMail.Items.Clear();

      // select the mailbox. The objImap.Exists / objImap.Unseen and objImap.Recent properties are always about 
      // the mailbox that was last selected.
      objImap.Select(sName);
      lblCount.Text = "[" + objImap.Exists + "] Messages, [" + objImap.Unseen + "] Unseen, [" + objImap.Recent + "] Recent";
    }

    private void ReloadMail()
    {
      // get all email headers data so we can make a list that's an overview of all mail items in this mailbox. 
      // also show a progress bar because it can take some time to get all information about hundreds or 
      // even thousands  of emails.       
      frmProgress oProgress = new frmProgress("Download message headers...", objImap.Exists);
      oProgress.Show();


      // fetch actual data from the IMAP server. The FetchMaxNumItemsAtOnce option controls howmany email header
      // are fetched up front. This number improves performance at the cost of using more memory when fetching a 
      // large number of items.
      lvMail.Items.Clear();
      int nFetched = 1;
      objImap.FetchMaxNumItemsAtOnce = 50;
      var oEmailMessage = objImap.FetchFirstEmailHeader(objConstants.IMAP_SK_ALL);
      while (objImap.LastError == 0)
      {
        if (!oProgress.DoProgress(nFetched))
          break;  // if the users closes the progress bar we'll stop gathering more information.
        nFetched++;

        var lvi = new ListViewItem(oEmailMessage.ImapUID.ToString());
        lvi.Tag = oEmailMessage.ImapUID;
        lvi.SubItems.Add(oEmailMessage.Date);
        lvi.SubItems.Add(oEmailMessage.ImapFlags);
        lvi.SubItems.Add((oEmailMessage.Size / 1024) + "kb");
        lvi.SubItems.Add(oEmailMessage.Subject);
        lvMail.Items.Insert(0, lvi);

        oEmailMessage = objImap.FetchNextEmailHeader();
      }

      oProgress.Close();
    }

    private void tvMailbox_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (tvMailbox.SelectedNode == null) return;
      var oNode = tvMailbox.SelectedNode;
      var sName = (string)oNode.Tag;
      
      SelectMailbox(sName);
      ReloadMail();

      UpdateResult();
      UpdateControls();
    }

    private void lvMail_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lvMail.SelectedItems.Count <= 0) return;
      var uid = (int)lvMail.SelectedItems[0].Tag;

      bNewEmail = false;

      // fetch a specific email by user id.
      objEmail = objImap.FetchFirstEmail(objConstants.IMAP_SK_UID + " " + uid);
      if (objImap.LastError != 0)
      {
        UpdateResult();
        UpdateControls();
        return;
      }

      // set all properties and attachments
      txtFrom.Text = objEmail.FromAddress;
      txtTo.Text = objEmail.ToAddress;
      txtSubject.Text = objEmail.Subject;
      txtBody.Text = objEmail.BodyPlainText;
      txtHtml.Text = objEmail.BodyHtml;

      tcBody.SelectedTab = tabPlain;
      if (txtBody.Text == "")
        tcBody.SelectedTab = tabHtml;

      lvAttachments.Items.Clear();
      int nNumAttachments = objEmail.CountAttachments();
      for (int i=1;i<=nNumAttachments;i++)
      {
        var lvi = new ListViewItem(objEmail.GetAttachmentName(i));
        lvi.Tag = i;
        lvi.SubItems.Add((objEmail.GetAttachmentSize(i) / 1024) + "kb");
        lvAttachments.Items.Add(lvi);
      }

      UpdateResult();
      UpdateControls();
    }

    private void btnSet_Click(object sender, EventArgs e)
    {
      if (cmbMailFlags.SelectedItem == null) return;
      if (lvMail.SelectedItems.Count <= 0) return;

      string sFlag = (string)cmbMailFlags.SelectedValue;
      int nUid = (int)lvMail.SelectedItems[0].Tag;

      // store flag value to email. Not all flag values make sense in every mailbox
      // the server may reply with 'NO' if it does not make sense.
      objImap.Store(nUid.ToString(), sFlag, objConstants.IMAP_STO_ADD);

      UpdateResult();
      UpdateControls();

      if (objImap.LastError == 0)
        MessageBox.Show("Message flags updated!\n\nClick 'Refresh' to update the message list and view the change");
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      if (cmbMailFlags.SelectedItem == null) return;
      if (lvMail.SelectedItems.Count <= 0) return;

      string sFlag = (string)cmbMailFlags.SelectedValue;
      int nUid = (int)lvMail.SelectedItems[0].Tag;

      // remove flag from email.
      objImap.Store(nUid.ToString(), sFlag, objConstants.IMAP_STO_REMOVE);

      UpdateResult();
      UpdateControls();

      if (objImap.LastError == 0)
        MessageBox.Show("Message flags updated!\n\nClick 'Refresh' to update the message list and view the change");
    }

    private void btnExpunge_Click(object sender, EventArgs e)
    {
      // deletes all emails that where flagged with 'DELETED' 
      objImap.Expunge();

      UpdateResult();
      UpdateControls();
    }

    private void lvAttachments_DoubleClick(object sender, EventArgs e)
    {
      if (lvAttachments.SelectedItems.Count < 1) return;

      int nId = (int)lvAttachments.SelectedItems[0].Tag;
      
      SaveFileDialog dlg = new SaveFileDialog();
      dlg.Title = "Save attachment as...";
      dlg.RestoreDirectory = true;
      dlg.FileName = objEmail.GetAttachmentName(nId);
      if (dlg.ShowDialog() == DialogResult.OK)
      {
        objEmail.SaveAttachment(nId, dlg.FileName);
        UpdateResult();
        UpdateControls();
      }
    }

    private void btnAddAttachment_Click(object sender, EventArgs e)
    {
      OpenFileDialog dlg = new OpenFileDialog();
      dlg.Title = "Add attachment";
      dlg.RestoreDirectory = true;
      dlg.CheckFileExists = true;
      if (dlg.ShowDialog() == DialogResult.OK)
      {
        objEmail.AddAttachment(dlg.FileName);
        UpdateResult();

        if (objEmail.LastError == 0)
        {
          int nId = objEmail.CountAttachments();
          var oLvi = new ListViewItem(objEmail.GetAttachmentName(nId));
          oLvi.SubItems.Add((objEmail.GetAttachmentSize(nId) / 1024) + "kb");
          oLvi.Tag = nId;
          lvAttachments.Items.Add(oLvi);
        }

        UpdateControls();
      }
    }

    private void btnClearMessage_Click(object sender, EventArgs e)
    {      
      txtTo.Text = "";
      txtSubject.Text = "";
      txtFrom.Text = "";
      txtBody.Text = "";
      txtHtml.Text = "";
      lvAttachments.Items.Clear();

      if (objEmail == null)
        objEmail = new AxEmail.Message();
      else
        objEmail.Clear();

      bNewEmail = true;

      lvMail.SelectedItems.Clear();

      UpdateControls();
    }

    private void btnSaveToMailbox_Click(object sender, EventArgs e)
    {
      if (objEmail == null) return;
      if (tvMailbox.SelectedNode == null) return;

      var oNode = tvMailbox.SelectedNode;
      var sName = (string)oNode.Tag;
      
      objEmail.AddTo(txtTo.Text);
      objEmail.FromAddress = txtFrom.Text;
      objEmail.Subject = txtSubject.Text;
      objEmail.BodyHtml = txtHtml.Text;
      objEmail.BodyPlainText = txtBody.Text;

      // Adds an email to the mailbox
      objImap.Append(sName, objEmail);

      bNewEmail = false;

      UpdateResult();
      UpdateControls();

      btnClearMessage_Click(null, null);

      if (objImap.LastError == 0)
        MessageBox.Show("Message saved to mailbox!\n\nClick 'Refresh' to update the message list and view the change");
    }

    private void btnSaveMessage_Click(object sender, EventArgs e)
    {
      if (objEmail == null) return;

      // save a MIME file. The MIME file is the email in the text based format that a mailserver uses internally to store emails      
      SaveFileDialog dlg = new SaveFileDialog();
      dlg.Title = "Save mime as...";
      dlg.RestoreDirectory = true;
      dlg.FileName = objEmail.Subject + ".mime";
      if (dlg.ShowDialog() == DialogResult.OK)
      {
        objEmail.SaveMIME(dlg.FileName);
        UpdateResult();
        UpdateControls();
      }

    }

    private void btnOAuth_Click(object sender, EventArgs e)
    {
      objFrmOauth2Settings.ShowDialog();
      sBearerToken = ""; // reset bearer token cache
    }

    private void txtHost_TextChanged(object sender, EventArgs e)
    {
      sBearerToken = ""; // reset bearer token cache
    }

    private void cbxSecurity_SelectedIndexChanged(object sender, EventArgs e)
    {
      int nIdx = cbxSecurity.SelectedIndex;
      if (nIdx == IDX_NOTSECURE)
        txtPort.Text = "143";
      else if (nIdx == IDX_SSLTLS)
        txtPort.Text = "993";
      else
        txtPort.Text = "993";
      UpdateControls();
    }
  }

}
