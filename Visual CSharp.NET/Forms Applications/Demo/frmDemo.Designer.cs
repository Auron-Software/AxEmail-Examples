namespace Demo
{
    partial class frmDemo
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
      this.btnLicensing = new System.Windows.Forms.Button();
      this.Label7 = new System.Windows.Forms.Label();
      this.llblUrlSmsToolkit = new System.Windows.Forms.LinkLabel();
      this.Label6 = new System.Windows.Forms.Label();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.label10 = new System.Windows.Forms.Label();
      this.btnSMTP = new System.Windows.Forms.Button();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.label11 = new System.Windows.Forms.Label();
      this.btnPop3 = new System.Windows.Forms.Button();
      this.groupBox9 = new System.Windows.Forms.GroupBox();
      this.lblSmtpMime = new System.Windows.Forms.Label();
      this.btnSmtpMime = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnImap = new System.Windows.Forms.Button();
      this.groupBox7.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnLicensing
      // 
      this.btnLicensing.Location = new System.Drawing.Point(652, 278);
      this.btnLicensing.Name = "btnLicensing";
      this.btnLicensing.Size = new System.Drawing.Size(152, 23);
      this.btnLicensing.TabIndex = 10;
      this.btnLicensing.Text = "&Licensing...";
      this.btnLicensing.Click += new System.EventHandler(this.btnLicensing_Click);
      // 
      // Label7
      // 
      this.Label7.AutoSize = true;
      this.Label7.Location = new System.Drawing.Point(15, 278);
      this.Label7.Name = "Label7";
      this.Label7.Size = new System.Drawing.Size(437, 13);
      this.Label7.TabIndex = 48;
      this.Label7.Text = "Source code for this application is located in the \'Samples\' folder of the instal" +
    "lation directory.";
      // 
      // llblUrlSmsToolkit
      // 
      this.llblUrlSmsToolkit.Location = new System.Drawing.Point(147, 258);
      this.llblUrlSmsToolkit.Name = "llblUrlSmsToolkit";
      this.llblUrlSmsToolkit.Size = new System.Drawing.Size(192, 16);
      this.llblUrlSmsToolkit.TabIndex = 9;
      this.llblUrlSmsToolkit.TabStop = true;
      this.llblUrlSmsToolkit.Text = "Auron Email Component";
      this.llblUrlSmsToolkit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblUrlSmsToolkit_LinkClicked);
      // 
      // Label6
      // 
      this.Label6.Location = new System.Drawing.Point(15, 258);
      this.Label6.Name = "Label6";
      this.Label6.Size = new System.Drawing.Size(144, 16);
      this.Label6.TabIndex = 46;
      this.Label6.Text = "This demo application uses";
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.label10);
      this.groupBox7.Controls.Add(this.btnSMTP);
      this.groupBox7.Location = new System.Drawing.Point(14, 12);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(398, 113);
      this.groupBox7.TabIndex = 6;
      this.groupBox7.TabStop = false;
      // 
      // label10
      // 
      this.label10.Location = new System.Drawing.Point(174, 19);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(208, 80);
      this.label10.TabIndex = 2;
      this.label10.Text = "Simple Mail Transfer Protocol (SMTP) is an Internet standard for electronic mail " +
    "(e-mail) transmission across Internet Protocol (IP) networks. SMTP is specified " +
    "for outgoing mail transport.";
      // 
      // btnSMTP
      // 
      this.btnSMTP.Location = new System.Drawing.Point(12, 19);
      this.btnSMTP.Name = "btnSMTP";
      this.btnSMTP.Size = new System.Drawing.Size(150, 23);
      this.btnSMTP.TabIndex = 0;
      this.btnSMTP.Text = "SMTP Send";
      this.btnSMTP.UseVisualStyleBackColor = true;
      this.btnSMTP.Click += new System.EventHandler(this.btnSMTP_Click);
      // 
      // groupBox8
      // 
      this.groupBox8.Controls.Add(this.label11);
      this.groupBox8.Controls.Add(this.btnPop3);
      this.groupBox8.Location = new System.Drawing.Point(418, 12);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new System.Drawing.Size(386, 113);
      this.groupBox8.TabIndex = 7;
      this.groupBox8.TabStop = false;
      // 
      // label11
      // 
      this.label11.Location = new System.Drawing.Point(174, 19);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(206, 80);
      this.label11.TabIndex = 2;
      this.label11.Text = "The Post Office Protocol (POP) is an application-layer Internet standard protocol" +
    " used by local e-mail clients to retrieve e-mail from a remote server over a TCP" +
    "/IP connection.";
      // 
      // btnPop3
      // 
      this.btnPop3.Location = new System.Drawing.Point(12, 19);
      this.btnPop3.Name = "btnPop3";
      this.btnPop3.Size = new System.Drawing.Size(150, 23);
      this.btnPop3.TabIndex = 0;
      this.btnPop3.Text = "POP3 Receive";
      this.btnPop3.UseVisualStyleBackColor = true;
      this.btnPop3.Click += new System.EventHandler(this.btnPop3_Click);
      // 
      // groupBox9
      // 
      this.groupBox9.Controls.Add(this.lblSmtpMime);
      this.groupBox9.Controls.Add(this.btnSmtpMime);
      this.groupBox9.Location = new System.Drawing.Point(14, 131);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new System.Drawing.Size(398, 113);
      this.groupBox9.TabIndex = 8;
      this.groupBox9.TabStop = false;
      // 
      // lblSmtpMime
      // 
      this.lblSmtpMime.Location = new System.Drawing.Point(174, 19);
      this.lblSmtpMime.Name = "lblSmtpMime";
      this.lblSmtpMime.Size = new System.Drawing.Size(208, 81);
      this.lblSmtpMime.TabIndex = 2;
      this.lblSmtpMime.Text = "Multipurpose Internet Mail Extensions (MIME) is an Internet standard that extends" +
    " the format of email.";
      // 
      // btnSmtpMime
      // 
      this.btnSmtpMime.Location = new System.Drawing.Point(12, 19);
      this.btnSmtpMime.Name = "btnSmtpMime";
      this.btnSmtpMime.Size = new System.Drawing.Size(150, 23);
      this.btnSmtpMime.TabIndex = 0;
      this.btnSmtpMime.Text = "SMTP Send (MIME)";
      this.btnSmtpMime.UseVisualStyleBackColor = true;
      this.btnSmtpMime.Click += new System.EventHandler(this.btnSmtpMime_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.btnImap);
      this.groupBox1.Location = new System.Drawing.Point(418, 131);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(386, 113);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(174, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(208, 81);
      this.label1.TabIndex = 2;
      this.label1.Text = "The Internet Message Access Protocol is a widely used protocol for accessing and " +
    "maintaining a set of remote mailboxes. This is mostly used by more advanced emai" +
    "l clients.";
      // 
      // btnImap
      // 
      this.btnImap.Location = new System.Drawing.Point(12, 19);
      this.btnImap.Name = "btnImap";
      this.btnImap.Size = new System.Drawing.Size(150, 23);
      this.btnImap.TabIndex = 0;
      this.btnImap.Text = "IMAP Receive";
      this.btnImap.UseVisualStyleBackColor = true;
      this.btnImap.Click += new System.EventHandler(this.btnImap_Click);
      // 
      // frmDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(815, 310);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.groupBox9);
      this.Controls.Add(this.groupBox8);
      this.Controls.Add(this.groupBox7);
      this.Controls.Add(this.btnLicensing);
      this.Controls.Add(this.Label7);
      this.Controls.Add(this.llblUrlSmsToolkit);
      this.Controls.Add(this.Label6);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmDemo";
      this.Text = "Auron Email Component - C# .NET Demo";
      this.groupBox7.ResumeLayout(false);
      this.groupBox8.ResumeLayout(false);
      this.groupBox9.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnLicensing;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.LinkLabel llblUrlSmsToolkit;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox groupBox7;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSMTP;
        internal System.Windows.Forms.GroupBox groupBox8;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnPop3;
        internal System.Windows.Forms.GroupBox groupBox9;
        internal System.Windows.Forms.Label lblSmtpMime;
        private System.Windows.Forms.Button btnSmtpMime;
    internal System.Windows.Forms.GroupBox groupBox1;
    internal System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnImap;
  }
}

