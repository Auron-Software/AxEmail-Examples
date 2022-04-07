//-----------------------------------------------------------------------
// <copyright file="frmSmtpMime.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------
namespace Demo
{
    using System;
    using System.Windows.Forms;
    using AxEmail;

    public partial class frmSmtpMime : Form
    {
        private AxEmail.Message objSmtpMail = new AxEmail.Message();
        private Smtp objSmtpServer = new Smtp();
        private AxEmail.Constants objConstants = new AxEmail.Constants();
        private frmSmtpCreateMime objFrmSmtpCreateMime = new frmSmtpCreateMime();

        public frmSmtpMime()
        {
            InitializeComponent();
        }

        private void frmSmtpMime_Load(object sender, EventArgs e)
        {
            if (txtPort.Text == string.Empty) txtPort.Text = "25";

            //Display Auron Email Component Info
            lblInfo.Text = String.Format("Auron Email Component {0}; Build: {1}; Module: {2}", objSmtpServer.Version, objSmtpServer.Build, objSmtpServer.Module);

            txtMIMEFile.Text = string.Empty;
            txtMIMEContents.Text = string.Empty;

            txtResult.Text = string.Empty;
            txtLastSmtpResponse.Text = string.Empty;

            txtLogfile.Text = System.IO.Path.GetTempPath() + "Smtp.log";

            UpdateControls();
        }

        private void UpdateControls()
        {
            if (cbAuthentication.Checked)
            {
                txtAccount.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtAccount.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        private void btnLoadMIME_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fdlg;

            fdlg = new OpenFileDialog();
            fdlg.Title = "Select Attachment";
            fdlg.InitialDirectory = "C:\\";
            fdlg.Filter = "MIME files (*.mim)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() != DialogResult.OK)
                return;

            txtMIMEFile.Text = string.Empty;
            txtMIMEContents.Text = string.Empty;

            txtMIMEFile.Text = fdlg.FileName;

            // Loads the selected MIME file
            objSmtpMail.LoadMIME(fdlg.FileName);
            txtResult.Text = objSmtpMail.LastError + ": " + objSmtpMail.GetErrorDescription(objSmtpMail.LastError);
            txtLastSmtpResponse.Text = string.Empty;
            if (objSmtpMail.LastError == 0)
            {
                txtMIMEContents.Text = objSmtpMail.MessageSource;
            }            
        }

        private void btnCreateMIME_Click(object sender, EventArgs e)
        {
            // Loads the MIME creation form.
            if (objFrmSmtpCreateMime.ShowDialog() != DialogResult.OK)
                return;

            txtMIMEFile.Text = string.Empty;
            txtMIMEContents.Text = string.Empty;

            txtMIMEFile.Text = objFrmSmtpCreateMime.strMIMEFileName;

            // Loads the newly created MIME file
            objSmtpMail.LoadMIME(objFrmSmtpCreateMime.strMIMEFileName);
            txtResult.Text = objSmtpMail.LastError + ": " + objSmtpMail.GetErrorDescription(objSmtpMail.LastError);
            txtLastSmtpResponse.Text = string.Empty;

            if (objSmtpMail.LastError == 0)
            {
                txtMIMEContents.Text = objSmtpMail.MessageSource;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Cursor CurCursor = Cursor;

            Cursor = Cursors.WaitCursor;  

            objSmtpServer.Clear();
            objSmtpServer.LogFile = txtLogfile.Text;

            // Set Secure if secure communications is required
            if (cbSecure.Checked)
            {
                objSmtpServer.SetSecure(Int32.Parse(txtPort.Text));
            }
            else
            {
                objSmtpServer.HostPort = Int32.Parse(txtPort.Text);
            }

            // Connects to the SMTP Server
            if (objSmtpServer.LastError == 0)            {
                
                objSmtpServer.Connect(txtHost.Text, cbAuthentication.Checked ? txtAccount.Text : string.Empty, cbAuthentication.Checked ? txtPassword.Text : string.Empty);
            }

            // Sends the E-Mail message
            if (objSmtpServer.LastError == 0)
            {
                objSmtpServer.Send(objSmtpMail );  
            }

            txtResult.Text = objSmtpServer.LastError + ": " + objSmtpServer.GetErrorDescription(objSmtpServer.LastError);
            txtLastSmtpResponse.Text = objSmtpServer.LastSmtpResponse;

            //Disconnects the SMTP Server
            objSmtpServer.Disconnect();
            Cursor = CurCursor;
        }

        private void btnViewLog_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtLogfile.Text))
            {
                System.Diagnostics.Process.Start(txtLogfile.Text);
            }
        }

        private void cbSecure_CheckedChanged(object sender, EventArgs e)
        {
            txtPort.Text = cbSecure.Checked ? "465" : "25";
            UpdateControls();
        }

        private void cbAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }
    }
}