namespace sample_3_8 {
  partial class GridUserControl {
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
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
      this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
      this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
      this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
      this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
      this.tablePanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // gridControl1
      // 
      this.tablePanel1.SetColumn(this.gridControl1, 0);
      this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridControl1.Location = new System.Drawing.Point(13, 13);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.tablePanel1.SetRow(this.gridControl1, 0);
      this.tablePanel1.SetRowSpan(this.gridControl1, 5);
      this.gridControl1.Size = new System.Drawing.Size(373, 370);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // gridView1
      // 
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      // 
      // textEdit1
      // 
      this.tablePanel1.SetColumn(this.textEdit1, 1);
      this.textEdit1.Location = new System.Drawing.Point(392, 91);
      this.textEdit1.Name = "textEdit1";
      this.tablePanel1.SetRow(this.textEdit1, 3);
      this.textEdit1.Size = new System.Drawing.Size(194, 20);
      this.textEdit1.TabIndex = 1;
      // 
      // textEdit2
      // 
      this.tablePanel1.SetColumn(this.textEdit2, 1);
      this.textEdit2.Location = new System.Drawing.Point(392, 65);
      this.textEdit2.Name = "textEdit2";
      this.tablePanel1.SetRow(this.textEdit2, 2);
      this.textEdit2.Size = new System.Drawing.Size(194, 20);
      this.textEdit2.TabIndex = 2;
      // 
      // textEdit3
      // 
      this.tablePanel1.SetColumn(this.textEdit3, 1);
      this.textEdit3.Location = new System.Drawing.Point(392, 13);
      this.textEdit3.Name = "textEdit3";
      this.tablePanel1.SetRow(this.textEdit3, 0);
      this.textEdit3.Size = new System.Drawing.Size(194, 20);
      this.textEdit3.TabIndex = 3;
      // 
      // textEdit4
      // 
      this.tablePanel1.SetColumn(this.textEdit4, 1);
      this.textEdit4.Location = new System.Drawing.Point(392, 39);
      this.textEdit4.Name = "textEdit4";
      this.tablePanel1.SetRow(this.textEdit4, 1);
      this.textEdit4.Size = new System.Drawing.Size(194, 20);
      this.textEdit4.TabIndex = 4;
      // 
      // tablePanel1
      // 
      this.tablePanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 47.23F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 200F)});
      this.tablePanel1.Controls.Add(this.textEdit1);
      this.tablePanel1.Controls.Add(this.textEdit2);
      this.tablePanel1.Controls.Add(this.textEdit4);
      this.tablePanel1.Controls.Add(this.textEdit3);
      this.tablePanel1.Controls.Add(this.gridControl1);
      this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tablePanel1.Location = new System.Drawing.Point(0, 0);
      this.tablePanel1.Name = "tablePanel1";
      this.tablePanel1.Padding = new System.Windows.Forms.Padding(10);
      this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 233F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
      this.tablePanel1.Size = new System.Drawing.Size(599, 396);
      this.tablePanel1.TabIndex = 6;
      // 
      // GridUserControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tablePanel1);
      this.Name = "GridUserControl";
      this.Size = new System.Drawing.Size(599, 396);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
      this.tablePanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.XtraEditors.TextEdit textEdit1;
    private DevExpress.XtraEditors.TextEdit textEdit2;
    private DevExpress.XtraEditors.TextEdit textEdit3;
    private DevExpress.XtraEditors.TextEdit textEdit4;
    private DevExpress.Utils.Layout.TablePanel tablePanel1;
  }
}
