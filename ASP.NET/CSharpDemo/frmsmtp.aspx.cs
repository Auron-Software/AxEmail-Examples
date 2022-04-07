//-----------------------------------------------------------------------
// <copyright file="frmsmtp.aspx.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------
namespace CSharpDemo
{
    using System;
    using System.IO;
    using AxEmail;

	public partial class frmsmtp : System.Web.UI.Page
	{
        private AxEmail.Message objEmail = null;
        private AxEmail.Smtp objSmtp = null;
        private AxEmail.Constants objConstants = null;
		
		protected void Page_Load(object sender, EventArgs e)
		{
            objSmtp = new AxEmail.Smtp();
            objEmail = new AxEmail.Message();
            objConstants = new AxEmail.Constants();
			
			if (!IsPostBack)
			{
                lblInfo.Text = "Module [" + objSmtp.Module + "]; Build [" + objSmtp.Build + "]";
								
				ddlPriority.Items.Clear();
				ddlPriority.Items.Add("Highest Priority");
				ddlPriority.Items.Add("High Priority");
				ddlPriority.Items.Add("Normal Priority");
				ddlPriority.Items.Add("Low Priority");
				ddlPriority.Items.Add("Lowest Priority");
				ddlPriority.SelectedIndex = 2; // Normal Priority
				
				ddlEncoding.Items.Clear();
				ddlEncoding.Items.Add("Standard");	// Encoding
				ddlEncoding.Items.Add("UTF8");
				ddlEncoding.SelectedIndex = 0;

                txtLogFile.Text = Path.GetTempPath() + "Smtp.log";
			}
		}
		
		protected void btnSend_Click(object sender, EventArgs e)
		{
            txtResult.Text = "";
            txtLastSmtpResponse.Text = "";

            // Mail: Clear
			objEmail.Clear();
			
            // Mail: From
			objEmail.FromName = txtFromAddress.Text;
			objEmail.FromAddress = txtFromAddress.Text;

            // Mail: Encoding
            if (ddlEncoding.SelectedIndex == 0)
                objEmail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT;
            else
                objEmail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_UTF8;

            // Mail: Priority
            switch (ddlPriority.SelectedValue)
            {
                case "Highest Priority":
                    objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_HIGHEST;
                    break;
                case "High Priority":
                    objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_HIGH;
                    break;
                default:
                case "Normal Priority":
                    objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_MEDIUM;
                    break;
                case "Low Priority":
                    objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_LOW;
                    break;
                case "Lowest Priority":
                    objEmail.Priority = objConstants.EMAIL_MESSAGE_PRIORITY_LOWEST;
                    break;
            }

            // Mail: Subject
            objEmail.Subject = txtSubject.Text;

            // Mail: Body
            objEmail.BodyPlainText = txtPlainBody.Text;
            objEmail.BodyHtml = txtHtmlBody.Text;

            // Mail: To
            if( txtToAddress.Text != string.Empty)
            {
                objEmail.AddTo(txtToAddress.Text, txtToAddress.Text);
            }

            // Mail: Cc
            if( objEmail.LastError == 0 && txtCcAddress.Text != string.Empty)
            {
                objEmail.AddCc(txtCcAddress.Text, txtCcAddress.Text);
            }

            // Mail: Bcc
            if (objEmail.LastError == 0 && txtCcAddress.Text != string.Empty)
            {
                objEmail.AddBcc(txtBccAddress.Text, txtBccAddress.Text);
            }

            // Mail: On error return
            if (objEmail.LastError != 0)
            {
                txtResult.Text = objEmail.LastError + ": " + objEmail.GetErrorDescription(objEmail.LastError);
                return;
            }


            // Smtp: Clear (good practise)
            objSmtp.Clear();

            // A license key is required to unlock this component after the trial period has expired.
            // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
            // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
            // For details, see manual, chapter "Product Activation".  
            //
            // objSmtp.LicenseKey = "XXXXX-XXXXX-XXXXX";                  

            objSmtp.LogFile = txtLogFile.Text;

            // Smtp: Secure
            if (cbSecure.Checked)
            {
                objSmtp.SetSecure(465);   // 465 is the generic secure SMTP port
                txtResult.Text = objSmtp.LastError + ": " + objSmtp.GetErrorDescription(objSmtp.LastError);
                if (objSmtp.LastError != 0)
                    return;
            }

            // Smtp: Connect
            if (objSmtp.LastError == 0)
            {
                objSmtp.Connect(txtServer.Text, txtAccount.Text, txtPassword.Text);
            }

            // Smtp: Send
            if(objSmtp.LastError == 0)
            {
                objSmtp.Send(objEmail);
            }


            txtResult.Text = objSmtp.LastError + ": " + objSmtp.GetErrorDescription(objSmtp.LastError);
            txtLastSmtpResponse.Text = objSmtp.LastSmtpResponse;
           	
			objSmtp.Disconnect();
		}
		
	}
}
