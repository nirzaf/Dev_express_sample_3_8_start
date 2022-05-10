namespace sample_3_8 {
  partial class MainFormWithRibbon {
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormWithRibbon));
      this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
      this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
      this.gridPage = new DevExpress.XtraBars.Navigation.NavigationPage();
      this.richEditPage = new DevExpress.XtraBars.Navigation.NavigationPage();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
      this.navigationFrame1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ribbonControl1
      // 
      this.ribbonControl1.ExpandCollapseItem.Id = 0;
      this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1});
      this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
      this.ribbonControl1.MaxItemId = 2;
      this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
      this.ribbonControl1.Name = "ribbonControl1";
      this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbonControl1.Size = new System.Drawing.Size(874, 162);
      this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
      // 
      // barButtonItem1
      // 
      this.barButtonItem1.Caption = "Main Form Feature";
      this.barButtonItem1.Id = 1;
      this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
      this.barButtonItem1.Name = "barButtonItem1";
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "Main";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "Tools";
      // 
      // ribbonStatusBar1
      // 
      this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 614);
      this.ribbonStatusBar1.Name = "ribbonStatusBar1";
      this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
      this.ribbonStatusBar1.Size = new System.Drawing.Size(874, 22);
      // 
      // ribbonPage2
      // 
      this.ribbonPage2.Name = "ribbonPage2";
      this.ribbonPage2.Text = "ribbonPage2";
      // 
      // accordionControl1
      // 
      this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
      this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2});
      this.accordionControl1.Location = new System.Drawing.Point(0, 162);
      this.accordionControl1.Name = "accordionControl1";
      this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
      this.accordionControl1.Size = new System.Drawing.Size(209, 452);
      this.accordionControl1.TabIndex = 2;
      this.accordionControl1.Text = "accordionControl1";
      this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
      // 
      // accordionControlElement1
      // 
      this.accordionControlElement1.Name = "accordionControlElement1";
      this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement1.Text = "Grid";
      this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
      // 
      // accordionControlElement2
      // 
      this.accordionControlElement2.Name = "accordionControlElement2";
      this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement2.Text = "Rich Edit";
      this.accordionControlElement2.Click += new System.EventHandler(this.accordionControlElement2_Click);
      // 
      // navigationFrame1
      // 
      this.navigationFrame1.Controls.Add(this.gridPage);
      this.navigationFrame1.Controls.Add(this.richEditPage);
      this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.navigationFrame1.Location = new System.Drawing.Point(209, 162);
      this.navigationFrame1.Name = "navigationFrame1";
      this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.gridPage,
            this.richEditPage});
      this.navigationFrame1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
      this.navigationFrame1.SelectedPage = this.gridPage;
      this.navigationFrame1.Size = new System.Drawing.Size(665, 452);
      this.navigationFrame1.TabIndex = 3;
      this.navigationFrame1.Text = "navigationFrame1";
      this.navigationFrame1.QueryControl += new DevExpress.XtraBars.Navigation.QueryControlEventHandler(this.navigationFrame1_QueryControl);
      // 
      // gridPage
      // 
      this.gridPage.Name = "gridPage";
      this.gridPage.Size = new System.Drawing.Size(665, 452);
      // 
      // richEditPage
      // 
      this.richEditPage.Name = "richEditPage";
      this.richEditPage.Size = new System.Drawing.Size(665, 452);
      // 
      // MainFormWithRibbon
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(874, 636);
      this.Controls.Add(this.navigationFrame1);
      this.Controls.Add(this.accordionControl1);
      this.Controls.Add(this.ribbonStatusBar1);
      this.Controls.Add(this.ribbonControl1);
      this.Name = "MainFormWithRibbon";
      this.Ribbon = this.ribbonControl1;
      this.StatusBar = this.ribbonStatusBar1;
      this.Text = "MainFormWithRibbon";
      ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
      this.navigationFrame1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
    private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
    private DevExpress.XtraBars.Navigation.NavigationPage gridPage;
    private DevExpress.XtraBars.Navigation.NavigationPage richEditPage;
  }
}