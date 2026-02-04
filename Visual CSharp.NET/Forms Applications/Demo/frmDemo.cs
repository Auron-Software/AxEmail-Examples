//-----------------------------------------------------------------------
// <copyright file="frmDemo.cs" company="Auron">
//     Copyright (c) Auron Software - www.auronsoftware.com
// </copyright>
// <author>Dennis van de Giessen</author>
//-----------------------------------------------------------------------
namespace Demo
{
  using Microsoft.Win32;
  using System;
  using System.Diagnostics;
  using System.IO;
  using System.Windows.Forms;

  public partial class frmDemo : Form
  {
    private frmLicensing objFrmLicensing;
    private frmSmtp objFrmSmtp;
    private frmPop3 objFrmPop3;
    private frmImap objFrmImap;
    private frmSmtpMime objFrmSmtpMime;

    private string sExamplesRoot;

    private string GetInstallRoot()
    {
      const string subKey = @"SOFTWARE\Auron\Email Component";

      try
      {
        using (RegistryKey key = Registry.LocalMachine.OpenSubKey(subKey))
        {
          if (key != null)
          {
            object value = key.GetValue("InstallRoot");
            if (value != null)
            {
              return value.ToString();
            }
          }
        }
      }
      catch
      {
        // do nothing..
      }

      return "";
    }

    public frmDemo()
    {
      var objSmtp = new AxEmail.Smtp();

      InitializeComponent();
      objFrmLicensing = new frmLicensing();
      objFrmSmtp = new frmSmtp();
      objFrmPop3 = new frmPop3();
      objFrmImap = new frmImap();
      objFrmSmtpMime = new frmSmtpMime();
     
      Text = "Auron Email Component - C# .NET Demo - " + objSmtp.Build;
      sExamplesRoot = Path.Combine(new string[] { GetInstallRoot(), "Samples" });
    }

    private void llblUrlEmailToolkit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

    private void btnMoreExamples_Click(object sender, EventArgs e)
    {
      var startInfo = new ProcessStartInfo
      {
        FileName = sExamplesRoot,
        UseShellExecute = true  // Important for .NET Core/.NET 5+ (default is false in newer .NET)
      };
      Process.Start(startInfo);
    }
  }
}
