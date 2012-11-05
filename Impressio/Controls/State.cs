using DevExpress.XtraEditors.Controls;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models;

namespace Impressio.Controls
{
  public partial class State : Models.ControlBase
  {
    public State()
    {
      InitializeComponent();
    }


    private readonly Models.State _state = new Models.State();

    private void StateControlLoad(object sender, System.EventArgs e)
    {
      stateBindingSource.DataSource = _state.LoadObjectList();
    }

    private void ViewStateInvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
    {
      e.ExceptionMode = ExceptionMode.NoAction;
    }

    private void ViewStateRowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
    {
      (e.Row as Models.State).SaveObject();
    }

    private void ViewStateValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
    {
      CheckColumn(colStateName);
      e.Valid = !viewState.HasColumnErrors;
    }
  }
}
