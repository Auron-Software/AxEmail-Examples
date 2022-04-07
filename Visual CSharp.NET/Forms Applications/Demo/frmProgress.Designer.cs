namespace Demo
{
  partial class frmProgress
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
      this.prgProgress = new System.Windows.Forms.ProgressBar();
      this.btnStop = new System.Windows.Forms.Button();
      this.lblAction = new System.Windows.Forms.Label();
      this.lblDetails = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // prgProgress
      // 
      this.prgProgress.Location = new System.Drawing.Point(12, 28);
      this.prgProgress.Name = "prgProgress";
      this.prgProgress.Size = new System.Drawing.Size(358, 23);
      this.prgProgress.TabIndex = 0;
      // 
      // btnStop
      // 
      this.btnStop.Location = new System.Drawing.Point(295, 61);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(75, 23);
      this.btnStop.TabIndex = 1;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // lblAction
      // 
      this.lblAction.AutoSize = true;
      this.lblAction.Location = new System.Drawing.Point(12, 9);
      this.lblAction.Name = "lblAction";
      this.lblAction.Size = new System.Drawing.Size(35, 13);
      this.lblAction.TabIndex = 2;
      this.lblAction.Text = "label1";
      // 
      // lblDetails
      // 
      this.lblDetails.AutoSize = true;
      this.lblDetails.Location = new System.Drawing.Point(12, 66);
      this.lblDetails.Name = "lblDetails";
      this.lblDetails.Size = new System.Drawing.Size(35, 13);
      this.lblDetails.TabIndex = 3;
      this.lblDetails.Text = "label2";
      // 
      // frmProgress
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(382, 93);
      this.ControlBox = false;
      this.Controls.Add(this.lblDetails);
      this.Controls.Add(this.lblAction);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.prgProgress);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmProgress";
      this.ShowIcon = false;
      this.Text = "frmProgress";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar prgProgress;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Label lblAction;
    private System.Windows.Forms.Label lblDetails;
  }
}