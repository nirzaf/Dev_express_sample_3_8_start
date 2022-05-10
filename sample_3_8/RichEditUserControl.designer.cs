namespace sample_3_8 {
  partial class RichEditUserControl {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
      this.SuspendLayout();
      // 
      // richEditControl1
      // 
      this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richEditControl1.Location = new System.Drawing.Point(0, 0);
      this.richEditControl1.Name = "richEditControl1";
      this.richEditControl1.Size = new System.Drawing.Size(420, 322);
      this.richEditControl1.TabIndex = 0;
      this.richEditControl1.Text = "richEditControl1";
      // 
      // RichEditUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.richEditControl1);
      this.Name = "RichEditUserControl";
      this.Size = new System.Drawing.Size(420, 322);
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
  }
}
