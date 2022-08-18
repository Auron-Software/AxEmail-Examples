//-----------------------------------------------------------------------
// <copyright file="frmPop3.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------
namespace Demo
{
  using System;
  using System.Windows.Forms;
  using AxEmail;

  public partial class frmPop3 : Form
  {
    private const int IDX_NOTSECURE = 0;
    private const int IDX_SSLTLS = 1;
    private const int IDX_XOAUTH2 = 2;

    private AxEmail.OAuth2 objOAuth2 = new AxEmail.OAuth2();
    private AxEmail.Pop3 objPop3 = new AxEmail.Pop3();
    private AxEmail.Constants objConstants = new AxEmail.Constants();

    private string sBearerToken;
    private DateTime dtBearerOrigin = DateTime.Now;
    private frmOAuth2Settings objFrmOauth2Settings = new frmOAuth2Settings();

    public frmPop3()
    {
      InitializeComponent();

      txtHost.Text = "pop.gmail.com";
    }

    private void frmPop3_Load(object sender, EventArgs e)
    {
      // A license key is required to unlock this component after the trial period has expired.
      // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
      // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
      // For details, see manual, chapter "Product Activation".
      /*
      objPop3Server.LicenseKey = "XXXXX-XXXXX-XXXXX";
      */

      if (txtPort.Text == string.Empty) txtPort.Text = "110";

      cbxSecurity.Items.Clear();
      cbxSecurity.Items.Add("Not Secure");
      cbxSecurity.Items.Add("SSL/TLS");
      cbxSecurity.Items.Add("XOAUTH2");
      cbxSecurity.SelectedIndex = IDX_NOTSECURE;

      //Display Auron Email Component Info
      lblInfo.Text = String.Format("Auron Email Component {0}; Build: {1}; Module: {2}", objPop3.Version, objPop3.Build, objPop3.Module);

      txtLogfile.Text = System.IO.Path.GetTempPath() + "Pop3.log";
      ClearMessageFields();

      UpdateControls();
    }

    private void ClearMessageFields()
    {
      txtSubject.Text = string.Empty;
      txtBody.Text = string.Empty;
      txtFrom.Text = string.Empty;
      txtTo.Text = string.Empty;
      txtResponse.Text = string.Empty;
      lvAttachments.Items.Clear();
    }

    private void UpdateControls()
    {
      bool bConnected = objPop3.IsConnected();
      bool bOAuth2Selected = cbxSecurity.SelectedIndex == IDX_XOAUTH2;

      AxEmail.Message objEMail = null;

      txtHost.Enabled = !bConnected;
      cbxSecurity.Enabled = !bConnected;
      txtPort.Enabled = !bConnected;
      txtAccount.Enabled = !bConnected;
      txtPassword.Enabled = !bConnected;
      btnConnect.Enabled = !bConnected;
      btnDisconnect.Enabled = bConnected;
      btnOAuth.Enabled = !bConnected && bOAuth2Selected;
      lvMessages.Enabled = bConnected;
      lvAttachments.Enabled = bConnected;
      btnList.Enabled = bConnected;
      txtBody.Enabled = bConnected;
      txtSubject.Enabled = bConnected;
      txtTo.Enabled = bConnected;
      txtFrom.Enabled = bConnected;

      if (bConnected
          && lvMessages.SelectedIndices.Count != 0
          && (objEMail = (AxEmail.Message)objPop3.GetEmailMessage(lvMessages.SelectedIndices[0] + 1)) != null)
      {
        btnSaveMessage.Enabled = true;
      }
      else
      {
        btnSaveMessage.Enabled = false;
      }
    }

    private void SetResult(int nResult)
    {
      txtResult.Text = nResult + ": " + objPop3.GetErrorDescription(nResult);
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
      SetResult(objOAuth2.LastError);

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
      SetResult(objOAuth2.LastError);
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
      SetResult(objOAuth2.LastError);
      if (objOAuth2.LastError == 0)
      {
        dtBearerOrigin = DateTime.Now;
        sBearerToken = objOAuth2.BearerToken;
      }
      return objOAuth2.LastError == 0;
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
      Cursor cur = Cursor.Current;

      Cursor.Current = Cursors.WaitCursor;

      lvMessages.Items.Clear();
      ClearMessageFields();

      objPop3.Authentication = objConstants.POP3_AUTH_AUTO;
      objPop3.LogFile = txtLogfile.Text;

      int nSecIdx = cbxSecurity.SelectedIndex;
      if (nSecIdx != IDX_NOTSECURE)
        objPop3.SetSecure(Int32.Parse(txtPort.Text));
      else
        objPop3.HostPort = Int32.Parse(txtPort.Text);

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
        objPop3.BearerToken = sBearerToken;
      }

      // Connects to the POP3 server
      objPop3.Connect(txtHost.Text, txtAccount.Text, txtPassword.Text);
      GetResult();
      UpdateControls();


      Cursor.Current = cur;
    }

    private int GetResult()
    {
      int lResult = 0;

      lResult = objPop3.LastError;

      txtResult.Text = lResult.ToString() + ": " + objPop3.GetErrorDescription(objPop3.LastError);
      txtResponse.Text = objPop3.LastPop3Response;

      return lResult;
    }

    private void btnList_Click(object sender, EventArgs e)
    {
      Cursor cur = Cursor.Current;
      Int32 nMessages;
      Int32 i;
      AxEmail.Message objEMail;
      ListViewItem Item;

      lvMessages.Items.Clear();
      ClearMessageFields();

      Cursor.Current = Cursors.WaitCursor;

      // Counts the messages
      nMessages = objPop3.CountMessages();

      if (GetResult() == 0)
      {
        for (i = 1; i <= nMessages; i++)
        {
          // Gets the Email header for the current message
          objEMail = (AxEmail.Message)objPop3.GetEmailHeader(i);

          if (GetResult() == 0)
          {
            Item = lvMessages.Items.Add(objEMail.ID.ToString());
            Item.SubItems.Add(objEMail.FromAddress);
            Item.SubItems.Add(objEMail.Date);
            Item.SubItems.Add(objEMail.Subject);
          }
        }
      }

      UpdateControls();

      Cursor.Current = cur;
    }

    private void btnDisconnect_Click(object sender, EventArgs e)
    {
      Cursor cur = Cursor.Current;
      Cursor.Current = Cursors.WaitCursor;

      // Disconnects the Pop3 Server
      objPop3.Disconnect();

      lvMessages.Items.Clear();
      ClearMessageFields();

      UpdateControls();

      Cursor.Current = cur;
    }

    private void lvMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
      Cursor cur = Cursor.Current;
      AxEmail.Message objEMail = null;
      Int32 nAttachments;
      Int32 i;
      ListViewItem Item;

      ClearMessageFields();
      btnSaveMessage.Enabled = false;

      Cursor.Current = Cursors.WaitCursor;

      if (lvMessages.SelectedIndices.Count != 0)
      {
        // Gets the selected E-Mail message from the POP3 Server
        objEMail = (AxEmail.Message)objPop3.GetEmailMessage(lvMessages.SelectedIndices[0] + 1);

        if (GetResult() == 0)
        {
          txtSubject.Text = objEMail.Subject.ToString();
          txtBody.Text = objEMail.BodyPlainText == string.Empty ? objEMail.BodyHtml : objEMail.BodyPlainText;
          txtFrom.Text = objEMail.FromAddress.ToString();
          txtTo.Text = objEMail.ToAddress.ToString();
          btnSaveMessage.Enabled = true;

          nAttachments = objEMail.CountAttachments();

          if (nAttachments == 0)
          {
            lvAttachments.Enabled = false;
          }
          else
          {
            lvAttachments.Enabled = true;
          }

          for (i = 1; i <= nAttachments; i++)
          {
            Item = lvAttachments.Items.Add(objEMail.GetAttachmentName(i));
          }
        }
      }

      Cursor.Current = cur;

      UpdateControls();
    }

    private void btnSaveMessage_Click(object sender, EventArgs e)
    {
      AxEmail.Message objEMail = null;
      System.Windows.Forms.SaveFileDialog fdlg;

      if (lvMessages.SelectedIndices.Count != 0)
      {
        // Gets the requested E-Mail message
        if ((objEMail = (AxEmail.Message)objPop3.GetEmailMessage(lvMessages.SelectedIndices[0] + 1)) == null)
          return;

        fdlg = new SaveFileDialog();
        fdlg.Title = "Save";
        fdlg.InitialDirectory = "c:\\";
        fdlg.Filter = "MIME Files (*.mim)|*.mim|All files (*.*)|*.*";
        fdlg.FilterIndex = 1;
        fdlg.RestoreDirectory = true;
        if (fdlg.ShowDialog() != DialogResult.OK)
          return;

        // Saves the requested E-Mail message as an Mime File
        objEMail.SaveMIME(fdlg.FileName);

        txtResult.Text = objEMail.LastError.ToString() + ": " + objEMail.GetErrorDescription(objEMail.LastError);
      }
    }

    private void btnViewLog_Click(object sender, EventArgs e)
    {
      if (System.IO.File.Exists(txtLogfile.Text))
      {
        System.Diagnostics.Process.Start(txtLogfile.Text);
      }
    }

    private void lvAttachments_DoubleClick(object sender, EventArgs e)
    {
      AxEmail.Message objEMail = null;
      System.Windows.Forms.SaveFileDialog fdlg = new SaveFileDialog();

      if (lvMessages.SelectedIndices.Count == 0)
        return;

      if (lvAttachments.SelectedIndices.Count == 0)
        return;

      // Gets the current E-Mail meesage
      if ((objEMail = (AxEmail.Message)objPop3.GetEmailMessage(lvMessages.SelectedIndices[0] + 1)) == null)
        return;

      fdlg.Title = "Save";
      fdlg.InitialDirectory = "c:\\";
      fdlg.Filter = "All files (*.*)|*.*";
      fdlg.FilterIndex = 1;
      fdlg.FileName = lvAttachments.SelectedItems[0].Text;
      fdlg.RestoreDirectory = true;
      if (fdlg.ShowDialog() != DialogResult.OK)
        return;

      // Saves the selected attachment
      objEMail.SaveAttachment(lvAttachments.SelectedIndices[0] + 1, fdlg.FileName);
      txtResult.Text = objEMail.LastError.ToString() + ": " + objEMail.GetErrorDescription(objEMail.LastError);

      if (objEMail.LastError == 0)
        MessageBox.Show("Attachment saved.");
      else
        MessageBox.Show("Failed to save attachment, error " + objEMail.LastError + " (" + objEMail.GetErrorDescription(objEMail.LastError) + ").");
    }

    private void lvAttachments_SelectedIndexChanged(object sender, EventArgs e)
    {

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
        txtPort.Text = "110";
      else if (nIdx == IDX_SSLTLS)
        txtPort.Text = "995";
      else
        txtPort.Text = "995";
      UpdateControls();
    }
  }
}

