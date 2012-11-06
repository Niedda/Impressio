using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraNavBar;
using Impressio.Controls;
using Impressio.Models;
using Subvento.DatabaseObject;

namespace Impressio.Views
{
  public partial class PaperView : XtraForm
  {
    public PaperView()
    {
      InitializeComponent();
    }

    private readonly PaperControl _paperControl = new PaperControl();

    private void PaperViewLoad(object sender, EventArgs e)
    {
      mainPanel.Controls.Add(_paperControl);
    }

    private void NavDeletePaperLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      (_paperControl.viewPaper.GetFocusedRow() as Paper).DeleteObject();
      _paperControl.viewPaper.DeleteSelectedRows();
    }

    private void NavImportExcelLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      var result = openExcelDialog.ShowDialog();

      if (result == DialogResult.OK)
      {
        Paper.LoadFromExcel(openExcelDialog.FileName);
        _paperControl.ReloadControl();
      }
    }

    private void NavRefreshLinkClicked(object sender, NavBarLinkEventArgs e)
    {
      _paperControl.ReloadControl();
    }
  }
}