//-----------------------------------------------------------------------
// <copyright file="frmLicensing.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------
namespace Demo
{
    using System;
    using System.Diagnostics;
    using System.Windows.Forms;
    using AxEmail;
    using Microsoft.Win32;

    public partial class frmLicensing : Form
    {
        private frmLicensingSerial objFrmLicensingSerial;
        private Smtp objSmtp;

        public frmLicensing()
        {
            InitializeComponent();

            objFrmLicensingSerial = new frmLicensingSerial();
            objSmtp = new Smtp();
        }

        private void llblUrlSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.auronsoftware.com/knowledge-base/#email-component");
        }

        private void llblMailSupport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:support@auronsoftware.com");
        }

        private void llblUrlOrder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.auronsoftware.com/sales");
        }

        private void llblUrlSales_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.auronsoftware.com/sales");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string strBuffer = string.Empty;

            objFrmLicensingSerial.SerialKey = objSmtp.LicenseKey;

            if (objFrmLicensingSerial.ShowDialog() == DialogResult.OK) 
            {
                string strOldKey = objSmtp.LicenseKey;

                objSmtp.LicenseKey = objFrmLicensingSerial.SerialKey;
                objSmtp.SaveLicenseKey();
                if (objSmtp.LastError != 0)
                {
                    MessageBox.Show(string.Format("SaveLicenseKey failed, error {0} ({1}).", objSmtp.LastError.ToString(), objSmtp.GetErrorDescription(objSmtp.LastError)), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    objSmtp.LicenseKey = strOldKey;
                }

                UpdateLicensingInfo();
            }
        }

        private void frmLicensing_Load(object sender, EventArgs e)
        {
            lblVersion.Text = string.Format("{0}; Build {1}; Module {2}", objSmtp.Version, objSmtp.Build, objSmtp.Module);
            UpdateLicensingInfo();
        }

        private void UpdateLicensingInfo()
        {
            txtLicense.Text = string.Format("{0} ({1})", objSmtp.LicenseStatus, objSmtp.LicenseKey != ""? objSmtp.LicenseKey : "no license key");
        }


    }
}
