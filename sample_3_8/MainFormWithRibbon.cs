using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace sample_3_8 {
  public partial class MainFormWithRibbon : DevExpress.XtraBars.Ribbon.RibbonForm {
    public MainFormWithRibbon() {
      InitializeComponent();
    }

    private void accordionControlElement1_Click(object sender, EventArgs e) {
      navigationFrame1.SelectedPage = gridPage;
    }

    private void accordionControlElement2_Click(object sender, EventArgs e) {
      navigationFrame1.SelectedPage = richEditPage;
    }

    private void navigationFrame1_QueryControl(object sender, DevExpress.XtraBars.Navigation.QueryControlEventArgs e) {
      if (e.Page == gridPage)
        e.Control = new GridUserControlWithRibbon();
      else if (e.Page == richEditPage)
        e.Control = new RichEditUserControlWithRibbon();
    }
  }
}