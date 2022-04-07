namespace CSharpDemo
{
  using System;
  using System.IO;
  using AxEmail;

  public partial class frmImap : System.Web.UI.Page
  {
    private Imap objImap = null;
    private AxEmail.Constants objConstants = null;

    protected void Page_Load(object sender, EventArgs e)
    {
      objImap = new Imap();
      objConstants = new AxEmail.Constants();

      if (!IsPostBack)
      {
        lblInfo.Text = "Module [" + objImap.Module + "]; Build [" + objImap.Build + "]";
        txtLogFile.Text = Path.GetTempPath() + "Imap.log";

      }
    }

    protected void btnSendMessage_Click(object sender, EventArgs e)
    {
      AxEmail.Message objImapMail;

      lvMessages.Items.Clear();

      objImap.Clear();

      // A license key is required to unlock this component after the trial period has expired.
      // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
      // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
      // For details, see manual, chapter "Product Activation".  
      //
      // objImap.LicenseKey = "XXXXX-XXXXX-XXXXX";                  

      objImap.LogFile = txtLogFile.Text;

      objImap.Authentication = objConstants.IMAP_AUTH_AUTO;

      if (cbSecure.Checked)
        objImap.SetSecure(993); // 993 is the default secure IMAP port

      if (objImap.LastError == 0)
      {
        objImap.Connect(txtHost.Text, txtAccount.Text, txtPassword.Text);
      }
      
      if (objImap.LastError == 0)
      {
        objImapMail = objImap.FetchFirstEmailHeader(objConstants.IMAP_SK_ALL);
        while (objImap.LastError == 0)
        {
          txtResult.Text = objImap.LastError.ToString() + ": " + objImap.GetErrorDescription(objImap.LastError);

          if (objImap.LastError == 0)
          {
            lvMessages.Items.Add(objImapMail.Date + "; " + objImapMail.FromAddress + "; Subject: " + objImapMail.Subject);
          }

          objImapMail = objImap.FetchNextEmailHeader();
        }
      }
      
      txtResult.Text = objImap.LastError + ": " + objImap.GetErrorDescription(objImap.LastError);
      objImap.Disconnect();
    }
  }

}