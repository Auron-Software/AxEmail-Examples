//-----------------------------------------------------------------------
// <copyright file="frmSmtpCreateMime.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------
namespace Demo
{
    using System;
    using System.Windows.Forms;
    using AxEmail;

    public partial class frmSmtpCreateMime : Form
    {
        private AxEmail.Message objMail = new AxEmail.Message();
        private AxEmail.Constants objConstants = new AxEmail.Constants();
        public string strMIMEFileName = string.Empty;

        public frmSmtpCreateMime()
        {
            InitializeComponent();
        }

        private void frmSmtpCreateMime_Load(object sender, EventArgs e)
        {
            strMIMEFileName = string.Empty;

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
            cbxEncoding.Items.Add("Standard");		// Encoding
            cbxEncoding.Items.Add("UTF8");
            cbxEncoding.SelectedIndex = 0;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog fdlg;

            objMail.Clear();

            // From
            objMail.FromName = txtFromName.Text;
            objMail.FromAddress = txtFromAddress.Text;

            // Subject
            objMail.Subject = txtSubject.Text;

            // Priority
            objMail.Priority = cbxPriority.SelectedIndex + 1;

            // Encoding
            if (cbxEncoding.SelectedIndex == 0)
                objMail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_DEFAULT;
            else
                objMail.Encoding = objConstants.EMAIL_MESSAGE_ENCODING_UTF8;

            // Body
            if (cbxFormat.SelectedIndex == 0)
                objMail.BodyPlainText = txtBody.Text;
            else
                objMail.BodyHtml = txtBody.Text;

            // Add TO recipient(s)
            if (txtToAddress.Text != string.Empty)
            {
                objMail.AddTo(txtToAddress.Text, txtToAddress.Text);
            }

            // Add CC recipient(s)
            if (objMail.LastError == 0 && txtCcAddress.Text != string.Empty)
            {                
                objMail.AddCc(txtCcAddress.Text, txtCcAddress.Text);
            }

            // Add BCC recipient(s)
            if (objMail.LastError == 0 && txtBccAddress.Text != string.Empty)
            {
                objMail.AddBcc(txtBccAddress.Text, txtBccAddress.Text);
            }


            // Add Attachments
            if (objMail.LastError == 0 && txtAttachments.Text != string.Empty)
            {
                objMail.AddAttachment(txtAttachments.Text);
            }

            fdlg = new SaveFileDialog();

            if (objMail.LastError == 0)
            {
                
                fdlg.Title = "Save";
                fdlg.InitialDirectory = "c:\\";
                fdlg.Filter = "MIME Files (*.mim)|*.mim|All files (*.*)|*.*";
                fdlg.FilterIndex = 1;
                fdlg.RestoreDirectory = true;
                if (fdlg.ShowDialog() != DialogResult.OK)
                    return;

                objMail.Encode(); 
            }


            // Save Mime
            if (objMail.LastError == 0)
            {
                objMail.SaveMIME(fdlg.FileName);
                strMIMEFileName = fdlg.FileName;
            }

            if (objMail.LastError != 0)
            {
                MessageBox.Show("SaveMIME failed, result: " + objMail.LastError + " (" + objMail.GetErrorDescription(objMail.LastError) + ")", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();		
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
