
namespace Demo
{
  partial class frmOAuth2Settings
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnClose = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtRedirectUrl = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtScope = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtClientSecret = new System.Windows.Forms.TextBox();
      this.txtClientID = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.cbxFlow = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtTokenExchangeUrl = new System.Windows.Forms.TextBox();
      this.txtDeviceCodeUrl = new System.Windows.Forms.TextBox();
      this.txtAuthCodeUrl = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnClose
      // 
      this.btnClose.Location = new System.Drawing.Point(406, 326);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 0;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtRedirectUrl);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.txtScope);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtClientSecret);
      this.groupBox1.Controls.Add(this.txtClientID);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.cbxFlow);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(469, 193);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Client";
      // 
      // txtRedirectUrl
      // 
      this.txtRedirectUrl.Location = new System.Drawing.Point(115, 157);
      this.txtRedirectUrl.Name = "txtRedirectUrl";
      this.txtRedirectUrl.Size = new System.Drawing.Size(348, 20);
      this.txtRedirectUrl.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(7, 160);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(75, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Redirect URL:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(7, 134);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(38, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Scope";
      // 
      // txtScope
      // 
      this.txtScope.Location = new System.Drawing.Point(115, 131);
      this.txtScope.Name = "txtScope";
      this.txtScope.Size = new System.Drawing.Size(348, 20);
      this.txtScope.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(7, 90);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(70, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Client Secret:";
      // 
      // txtClientSecret
      // 
      this.txtClientSecret.Location = new System.Drawing.Point(115, 87);
      this.txtClientSecret.Name = "txtClientSecret";
      this.txtClientSecret.Size = new System.Drawing.Size(348, 20);
      this.txtClientSecret.TabIndex = 4;
      // 
      // txtClientID
      // 
      this.txtClientID.Location = new System.Drawing.Point(115, 61);
      this.txtClientID.Name = "txtClientID";
      this.txtClientID.Size = new System.Drawing.Size(348, 20);
      this.txtClientID.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Client ID:";
      // 
      // cbxFlow
      // 
      this.cbxFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxFlow.FormattingEnabled = true;
      this.cbxFlow.Location = new System.Drawing.Point(115, 20);
      this.cbxFlow.Name = "cbxFlow";
      this.cbxFlow.Size = new System.Drawing.Size(348, 21);
      this.cbxFlow.TabIndex = 1;
      this.cbxFlow.SelectedIndexChanged += new System.EventHandler(this.cbxFlow_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Flow:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtTokenExchangeUrl);
      this.groupBox2.Controls.Add(this.txtDeviceCodeUrl);
      this.groupBox2.Controls.Add(this.txtAuthCodeUrl);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Location = new System.Drawing.Point(12, 211);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(469, 109);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Token URLS";
      // 
      // txtTokenExchangeUrl
      // 
      this.txtTokenExchangeUrl.Location = new System.Drawing.Point(115, 71);
      this.txtTokenExchangeUrl.Name = "txtTokenExchangeUrl";
      this.txtTokenExchangeUrl.Size = new System.Drawing.Size(348, 20);
      this.txtTokenExchangeUrl.TabIndex = 13;
      // 
      // txtDeviceCodeUrl
      // 
      this.txtDeviceCodeUrl.Location = new System.Drawing.Point(115, 45);
      this.txtDeviceCodeUrl.Name = "txtDeviceCodeUrl";
      this.txtDeviceCodeUrl.Size = new System.Drawing.Size(348, 20);
      this.txtDeviceCodeUrl.TabIndex = 12;
      // 
      // txtAuthCodeUrl
      // 
      this.txtAuthCodeUrl.Location = new System.Drawing.Point(115, 19);
      this.txtAuthCodeUrl.Name = "txtAuthCodeUrl";
      this.txtAuthCodeUrl.Size = new System.Drawing.Size(348, 20);
      this.txtAuthCodeUrl.TabIndex = 11;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(6, 74);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(84, 13);
      this.label8.TabIndex = 5;
      this.label8.Text = "Token Ex. URL:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(7, 48);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(97, 13);
      this.label7.TabIndex = 4;
      this.label7.Text = "Device Code URL:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(7, 22);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(88, 13);
      this.label6.TabIndex = 3;
      this.label6.Text = "Auth. Code URL:";
      // 
      // frmOAuth2Settings
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(493, 360);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnClose);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "frmOAuth2Settings";
      this.Text = "OAuth2 Settings";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    public System.Windows.Forms.TextBox txtRedirectUrl;
    public System.Windows.Forms.TextBox txtScope;
    public System.Windows.Forms.TextBox txtClientSecret;
    public System.Windows.Forms.TextBox txtClientID;
    public System.Windows.Forms.ComboBox cbxFlow;
    public System.Windows.Forms.TextBox txtTokenExchangeUrl;
    public System.Windows.Forms.TextBox txtDeviceCodeUrl;
    public System.Windows.Forms.TextBox txtAuthCodeUrl;
  }
}