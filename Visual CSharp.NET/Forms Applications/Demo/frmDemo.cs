//-----------------------------------------------------------------------
// <copyright file="frmDemo.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------
namespace Demo
{
  using System;
  using System.Diagnostics;
  using System.Windows.Forms;

  public partial class frmDemo : Form
  {
    private frmLicensing objFrmLicensing;
    private frmSmtp objFrmSmtp;
    private frmPop3 objFrmPop3;
    private frmImap objFrmImap;
    private frmSmtpMime objFrmSmtpMime;

    public frmDemo()
    {
      InitializeComponent();
      objFrmLicensing = new frmLicensing();
      objFrmSmtp = new frmSmtp();
      objFrmPop3 = new frmPop3();
      objFrmImap = new frmImap();
      objFrmSmtpMime = new frmSmtpMime();
    }

    private void llblUrlSmsToolkit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start("https://www.auronsoftware.com/products/email-component/");
    }

    private void btnLicensing_Click(object sender, EventArgs e)
    {
      objFrmLicensing.ShowDialog();
    }

    private void btnSMTP_Click(object sender, EventArgs e)
    {
      objFrmSmtp.ShowDialog();
    }

    private void btnPop3_Click(object sender, EventArgs e)
    {
      objFrmPop3.ShowDialog();
    }

    private void btnSmtpMime_Click(object sender, EventArgs e)
    {
      objFrmSmtpMime.ShowDialog();
    }

    private void btnImap_Click(object sender, EventArgs e)
    {
      objFrmImap.ShowDialog();
    }
  }
}
