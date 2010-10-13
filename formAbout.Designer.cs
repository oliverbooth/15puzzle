namespace _15puzzle {
  partial class formAbout {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAbout));
      this.labelAbout = new System.Windows.Forms.Label();
      this.buttonClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelAbout
      // 
      this.labelAbout.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelAbout.Location = new System.Drawing.Point(0, 0);
      this.labelAbout.Name = "labelAbout";
      this.labelAbout.Size = new System.Drawing.Size(382, 173);
      this.labelAbout.TabIndex = 0;
      this.labelAbout.Text = resources.GetString("labelAbout.Text");
      this.labelAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // buttonClose
      // 
      this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonClose.Location = new System.Drawing.Point(295, 138);
      this.buttonClose.Name = "buttonClose";
      this.buttonClose.Size = new System.Drawing.Size(75, 23);
      this.buttonClose.TabIndex = 1;
      this.buttonClose.Text = "Close";
      this.buttonClose.UseVisualStyleBackColor = true;
      // 
      // formAbout
      // 
      this.AcceptButton = this.buttonClose;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.buttonClose;
      this.ClientSize = new System.Drawing.Size(382, 173);
      this.Controls.Add(this.buttonClose);
      this.Controls.Add(this.labelAbout);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "formAbout";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "15.NET";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label labelAbout;
    private System.Windows.Forms.Button buttonClose;
  }
}