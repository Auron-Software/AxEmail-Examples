using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
  public partial class frmOAuth2Settings : Form
  {
    public const int IDX_AUTHFLOW = 0;
    public const int IDX_DEVICEFLOW = 1;

    public frmOAuth2Settings()
    {
      InitializeComponent();

      cbxFlow.Items.Add("Authorization Code Flow");
      cbxFlow.Items.Add("Device Code Flow");
      cbxFlow.SelectedIndex = IDX_AUTHFLOW;

      // url must be accessible; set with netsh http; must also be the same URL as specified in cloud console
      txtRedirectUrl.Text = "http://localhost:7999/oauth2test/";
      txtScope.Text = "https://mail.google.com/";
      txtAuthCodeUrl.Text = "https://accounts.google.com/o/oauth2/v2/auth";
      txtDeviceCodeUrl.Text = "https://oauth2.googleapis.com/device/code";
      txtTokenExchangeUrl.Text = "https://oauth2.googleapis.com/token";

      UpdateControls();
    }

    public void UpdateControls()
    {
      int nFlow = cbxFlow.SelectedIndex;
      txtRedirectUrl.Enabled = nFlow == IDX_AUTHFLOW;
      txtDeviceCodeUrl.Enabled = nFlow == IDX_DEVICEFLOW;
      txtAuthCodeUrl.Enabled = nFlow == IDX_AUTHFLOW;
    }

    private void cbxFlow_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateControls();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
