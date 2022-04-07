namespace Demo
{
    partial class frmSmtpCreateMime
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbxEncoding = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAttachments = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.cbxFormat = new System.Windows.Forms.ComboBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtBccAddress = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtFromAddress = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFromName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCcAddress = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtToAddress = new System.Windows.Forms.TextBox();
            this.GroupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(496, 139);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 20);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(20, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "&Bcc:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(378, 337);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 24);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&Save";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbxEncoding
            // 
            this.cbxEncoding.Location = new System.Drawing.Point(280, 110);
            this.cbxEncoding.Name = "cbxEncoding";
            this.cbxEncoding.Size = new System.Drawing.Size(100, 21);
            this.cbxEncoding.TabIndex = 3;
            // 
            // Label10
            // 
            this.Label10.Location = new System.Drawing.Point(384, 113);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(44, 16);
            this.Label10.TabIndex = 8;
            this.Label10.Text = "Prio&rity:";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(20, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "&Cc:";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.btnBrowse);
            this.GroupBox4.Controls.Add(this.txtAttachments);
            this.GroupBox4.Controls.Add(this.label15);
            this.GroupBox4.Controls.Add(this.cbxEncoding);
            this.GroupBox4.Controls.Add(this.label12);
            this.GroupBox4.Controls.Add(this.cbxPriority);
            this.GroupBox4.Controls.Add(this.Label10);
            this.GroupBox4.Controls.Add(this.cbxFormat);
            this.GroupBox4.Controls.Add(this.txtBody);
            this.GroupBox4.Controls.Add(this.txtSubject);
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this.Label7);
            this.GroupBox4.Controls.Add(this.Label8);
            this.GroupBox4.Location = new System.Drawing.Point(12, 164);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(540, 167);
            this.GroupBox4.TabIndex = 2;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Message";
            // 
            // txtAttachments
            // 
            this.txtAttachments.Location = new System.Drawing.Point(109, 139);
            this.txtAttachments.Name = "txtAttachments";
            this.txtAttachments.Size = new System.Drawing.Size(379, 20);
            this.txtAttachments.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(20, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "&Attachment(s):";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(227, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "Char.&set:";
            // 
            // cbxPriority
            // 
            this.cbxPriority.Location = new System.Drawing.Point(424, 110);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(100, 21);
            this.cbxPriority.TabIndex = 4;
            // 
            // cbxFormat
            // 
            this.cbxFormat.Location = new System.Drawing.Point(109, 110);
            this.cbxFormat.Name = "cbxFormat";
            this.cbxFormat.Size = new System.Drawing.Size(100, 21);
            this.cbxFormat.TabIndex = 2;
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(109, 43);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(415, 62);
            this.txtBody.TabIndex = 1;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(109, 19);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(415, 20);
            this.txtSubject.TabIndex = 0;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(20, 45);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(68, 14);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Bod&y:";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(20, 22);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(61, 14);
            this.Label7.TabIndex = 0;
            this.Label7.Text = "S&ubject:";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(20, 113);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(63, 16);
            this.Label8.TabIndex = 4;
            this.Label8.Text = "&Format:";
            // 
            // txtBccAddress
            // 
            this.txtBccAddress.Location = new System.Drawing.Point(109, 65);
            this.txtBccAddress.Name = "txtBccAddress";
            this.txtBccAddress.Size = new System.Drawing.Size(415, 20);
            this.txtBccAddress.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(20, 23);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Sender E-ma&il:";
            // 
            // txtFromAddress
            // 
            this.txtFromAddress.Location = new System.Drawing.Point(109, 19);
            this.txtFromAddress.Name = "txtFromAddress";
            this.txtFromAddress.Size = new System.Drawing.Size(165, 20);
            this.txtFromAddress.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(468, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 24);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFromName
            // 
            this.txtFromName.Location = new System.Drawing.Point(405, 19);
            this.txtFromName.Name = "txtFromName";
            this.txtFromName.Size = new System.Drawing.Size(119, 20);
            this.txtFromName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label3);
            this.groupBox1.Controls.Add(this.txtFromAddress);
            this.groupBox1.Controls.Add(this.txtFromName);
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(280, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(121, 14);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Sender Na&me (optional):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBccAddress);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtCcAddress);
            this.groupBox2.Controls.Add(this.Label4);
            this.groupBox2.Controls.Add(this.txtToAddress);
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipients";
            // 
            // txtCcAddress
            // 
            this.txtCcAddress.Location = new System.Drawing.Point(109, 42);
            this.txtCcAddress.Name = "txtCcAddress";
            this.txtCcAddress.Size = new System.Drawing.Size(415, 20);
            this.txtCcAddress.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(20, 23);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(36, 16);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "&To:";
            // 
            // txtToAddress
            // 
            this.txtToAddress.Location = new System.Drawing.Point(109, 19);
            this.txtToAddress.Name = "txtToAddress";
            this.txtToAddress.Size = new System.Drawing.Size(415, 20);
            this.txtToAddress.TabIndex = 0;
            // 
            // frmSmtpCreateMime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 368);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSmtpCreateMime";
            this.Text = "Create MIME File";
            this.Load += new System.EventHandler(this.frmSmtpCreateMime_Load);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cbxEncoding;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.GroupBox GroupBox4;
        private System.Windows.Forms.TextBox txtAttachments;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.ComboBox cbxPriority;
        internal System.Windows.Forms.ComboBox cbxFormat;
        internal System.Windows.Forms.TextBox txtBody;
        internal System.Windows.Forms.TextBox txtSubject;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtBccAddress;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtFromAddress;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TextBox txtFromName;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtCcAddress;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtToAddress;
    }
}