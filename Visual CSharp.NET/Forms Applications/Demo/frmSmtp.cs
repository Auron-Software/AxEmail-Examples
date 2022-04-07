//-----------------------------------------------------------------------
// <copyright file="frmSmtp.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------
namespace Demo
{
  using System;
  using System.Windows.Forms;

  public partial class frmSmtp : Form
  {
    private const int IDX_NOTSECURE = 0;
    private const int IDX_SSLTLS = 1;
    private const int IDX_STARTTLS = 2;
    private const int IDX_XOAUTH2 = 3;

    private AxEmail.OAuth2 objOAuth2 = new AxEmail.OAuth2();
    private AxEmail.Message objMail = new AxEmail.Message();
    private AxEmail.Smtp objSmtp = new AxEmail.Smtp();
    private AxEmail.Constants objConstants = new AxEmail.Constants();
    
    private string sBearerToken = "";
    private DateTime dtBearerOrigin = DateTime.Now;

    private frmOAuth2Settings objFrmOauth2Settings = new frmOAuth2Settings();

    public frmSmtp()
    {
      InitializeComponent();

      txtHost.Text = "smtp.gmail.com";
    }

    private void frmSmtp_Load(object sender, EventArgs e)
    {
      // A license key is required to unlock this component after the trial period has expired.
      // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
      // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
      // For details, see manual, chapter "Product Activation".
      /*
      objSmtpServer.LicenseKey = "XXXXX-XXXXX-XXXXX";
      */

      if (txtPort.Text == string.Empty)
      {
        txtPort.Text = "25";
      }

      //Display Auron Email Component Info
      lblInfo.Text = String.Format("Auron Email Component {0}; Build: {1}; Module: {2}", objSmtp.Version, objSmtp.Build, objSmtp.Module);

      cbxSecurity.Items.Clear();
      cbxSecurity.Items.Add("Not Secure");
      cbxSecurity.Items.Add("SSL/TLS");
      cbxSecurity.Items.Add("STARTTLS");
      cbxSecurity.Items.Add("XOAUTH2");
      cbxSecurity.SelectedIndex = IDX_NOTSECURE;

      cbxFormat.Items.Clear();
      cbxFormat.Items.Add("Plain Text");
      cbxFormat.Items.Add("HTML");
      cbxFormat.SelectedIndex = 0;  // Plain Text

      cbxPriority.Items.Clear();
      cbxPriority.Items.Add("Highest Priority");
      cbxPriority.Items.Add("High Priority");
      cbxPriority.Items.Add("Normal Priority");
      cbxPriority.Items.Add("Low Priority");
      cbxPriority.Items.Add("Lowest Priority");
      cbxPriority.SelectedIndex = 2; // Normal Priority

      cbxEncoding.Items.Clear();
      cbxEncoding.Items.Add("Standard");    // Encoding
      cbxEncoding.Items.Add("UTF8");
      cbxEncoding.SelectedIndex = 0;

      txtResult.Text = string.Empty;
      txtLastSmtpResponse.Text = string.Empty;

      txtLogfile.Text = System.IO.Path.GetTempPath() + "Smtp.Log";

      UpdateControls();
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
      } else
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
      return objOAuth2.LastError == 0;
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
      Cursor CurCursor = Cursor;
      Cursor = Cursors.WaitCursor;

      txtResult.Text = txtLastSmtpResponse.Text = "";

      // Mail: Clear (good pratise)
      objMail.Clear();

      // Mail: From
      objMail.FromName = txtFromName.Text;
      objMail.FromAddress = txtFromAddress.Text;

      // Mail: Subject
      objMail.Subject = txtSubject.Text;

      // Mail: Priority
      objMail.Priority = cbxPriority.SelectedIndex + 1;

      // Mail: Encoding
      objMail.Encoding = cbxEncoding.SelectedIndex == 1 ? objConstants.EMAIL_MESSAGE_ENCODING_UTF8 : objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT;

      // Mail: Body
      if (cbxFormat.SelectedIndex == 0)
        objMail.BodyPlainText = txtBody.Text;
      else
        objMail.BodyHtml = txtBody.Text;


      // Mail: TO recipient(s)  
      if (txtToAddress.Text != string.Empty)
        objMail.AddTo(txtToAddress.Text, txtToAddress.Text);

      // Mail: CC recipient(s)  
      if (objMail.LastError == 0 && txtCcAddress.Text != string.Empty)
        objMail.AddCc(txtCcAddress.Text, txtCcAddress.Text);

      // Mail: BCC recipient(s)
      if (objMail.LastError == 0 && txtBccAddress.Text != string.Empty)
        objMail.AddBcc(txtBccAddress.Text, txtBccAddress.Text);

      // Mail: Attachment(s)
      if (objMail.LastError == 0 && txtAttachments.Text != string.Empty)
        objMail.AddAttachment(txtAttachments.Text);

      // Mail: If a function failed then quit
      if (objMail.LastError != 0)
      {
        txtResult.Text = objMail.LastError + ": " + objMail.GetErrorDescription(objMail.LastError);
        Cursor = CurCursor;
        return;
      }

      // Smtp: Clear (good practise)
      objSmtp.Clear();
      objSmtp.LogFile = txtLogfile.Text;

      // Smtp: Set Secure if secure communications is required 
      int nSecIdx = cbxSecurity.SelectedIndex;
      if (nSecIdx == IDX_SSLTLS)
          objSmtp.SetSecure(Int32.Parse(txtPort.Text));
      else
        objSmtp.HostPort = Int32.Parse(txtPort.Text);
      
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
        objSmtp.BearerToken = sBearerToken;
      }

      // Smtp: Connect
      objSmtp.Connect(txtHost.Text, txtAccount.Text, txtPassword.Text);

      // Smtp: Send
      if (objSmtp.LastError == 0)
      {
        // Sends out the E-Mail
        objSmtp.Send(objMail);
      }

      SetResult(objSmtp.LastError);

      // Disconnects the SMTP server
      objSmtp.Disconnect();

      Cursor = CurCursor;
    }

    private void SetResult(int nResult)
    {
      txtResult.Text = nResult + ": " + objSmtp.GetErrorDescription(nResult);
      txtLastSmtpResponse.Text = objSmtp.LastSmtpResponse;
    }

    private void btnBrowseAttachment_Click(object sender, EventArgs e)
    {
      System.Windows.Forms.OpenFileDialog fdlg;

      fdlg = new OpenFileDialog();
      fdlg.Title = "Select Attachment";
      fdlg.InitialDirectory = "C:\\";
      fdlg.Filter = "All files (*.*)|*.*";
      fdlg.FilterIndex = 1;
      fdlg.RestoreDirectory = true;
      fdlg.Multiselect = true;
      if (fdlg.ShowDialog() != DialogResult.OK)
        return;

      foreach (string strFile in fdlg.FileNames)
      {
        if (txtAttachments.Text != string.Empty)
          txtAttachments.Text += "|";
        txtAttachments.Text += strFile;
      }
    }

    private void btnViewLog_Click(object sender, EventArgs e)
    {
      if (System.IO.File.Exists(txtLogfile.Text))
      {
        System.Diagnostics.Process.Start(txtLogfile.Text);
      }
    }

    private void cbAuthentication_CheckedChanged(object sender, EventArgs e)
    {
      UpdateControls();
    }

    private void UpdateControls()
    {
      int nIdx = cbxSecurity.SelectedIndex;
      btnOAuth.Enabled = nIdx == IDX_XOAUTH2;
    }

    private void cbxSecurity_SelectedIndexChanged(object sender, EventArgs e)
    {
      int nIdx = cbxSecurity.SelectedIndex;

      if (nIdx == IDX_NOTSECURE)
        txtPort.Text = "25";
      else if (nIdx == IDX_SSLTLS)
        txtPort.Text = "465";
      else if (nIdx == IDX_STARTTLS)
        txtPort.Text = "587";
      else
        txtPort.Text = "587";

      UpdateControls();
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
  }
}
