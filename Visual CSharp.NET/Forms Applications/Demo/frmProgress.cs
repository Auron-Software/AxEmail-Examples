using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
  public partial class frmProgress : Form
  {
    private bool m_bStopped = false;

    public frmProgress(string sTitle, int nMax)
    {
      InitializeComponent();

      this.Text = sTitle;
      lblAction.Text = sTitle;
      lblDetails.Text = "";
      prgProgress.Maximum = nMax;
    }

    public bool DoProgress(int nCurrent, string sDetail = "")
    {
      if (nCurrent > prgProgress.Maximum)
        nCurrent = prgProgress.Maximum;
      prgProgress.Value = nCurrent;
      lblDetails.Text = sDetail;
      Application.DoEvents();
      return !m_bStopped;
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      m_bStopped = true;
    }
  }
}
