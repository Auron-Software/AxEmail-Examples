//-----------------------------------------------------------------------
// <copyright file="frmpop3.aspx.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------
namespace CSharpDemo
{
    using System;
    using System.IO;
    using AxEmail;

	public partial class frmPop3 : System.Web.UI.Page
	{
		private Pop3 objPop3 = null;
        private AxEmail.Constants objConstants = null;
		
		protected void Page_Load(object sender, EventArgs e)
		{
			objPop3 = new Pop3();
            objConstants = new AxEmail.Constants();
						
			if (!IsPostBack)
			{
                lblInfo.Text = "Module [" + objPop3.Module + "]; Build [" + objPop3.Build + "]";
                txtLogFile.Text = Path.GetTempPath() + "Pop3.log";

			}       
		}
		
		protected void btnSendMessage_Click(object sender, EventArgs e)
		{
            AxEmail.Message objPop3Mail;
			System.Int32 i, numMessages;
			
			lvMessages.Items.Clear();

            objPop3.Clear();

            // A license key is required to unlock this component after the trial period has expired.
            // Assign the LicenseKey property every time a new instance of this component is created (see code below). 
            // Alternatively, the LicenseKey property can be set automatically. This requires the license key to be stored in the registry.
            // For details, see manual, chapter "Product Activation".  
            //
            // objPop3.LicenseKey = "XXXXX-XXXXX-XXXXX";                  

            objPop3.LogFile = txtLogFile.Text;
	
			objPop3.Authentication = objConstants.POP3_AUTH_AUTO;
			
			if (cbSecure.Checked)
				objPop3.SetSecure(995); // 995 is the default secure POP3 port

            if (objPop3.LastError == 0)
            {
                objPop3.Connect(txtHost.Text, txtAccount.Text, txtPassword.Text);
            }

            numMessages = 0;
            if (objPop3.LastError == 0)
            {
                numMessages = objPop3.CountMessages();
            }
			
			if (objPop3.LastError == 0)
			{
				for (i = 1; i <= numMessages; i++)
				{
                    objPop3Mail = (AxEmail.Message)objPop3.GetEmailHeader(i);
					txtResult.Text = objPop3.LastError.ToString() + ": " + objPop3.GetErrorDescription(objPop3.LastError);
					
					if (objPop3.LastError == 0)
					{
						lvMessages.Items.Add(objPop3Mail.Date + "; " + objPop3Mail.FromAddress + "; Subject: " + objPop3Mail.Subject);
					}
				}
			}

            txtResult.Text = objPop3.LastError + ": " + objPop3.GetErrorDescription(objPop3.LastError);
			objPop3.Disconnect();
		}
	}
}
