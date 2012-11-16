using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Impressio.Models;
using Impressio.Models.Tools;

namespace Impressio.Controls
{
  public class ControlBase : XtraUserControl, IControl
  {
    public void InitializeBase()
    {
      Dock = DockStyle.Fill;

      Load += ReloadControl;
      Validating += ValidateControl;
    }

    public virtual List<object> EditorsToCheck { get; set; }

    public void CheckEditors()
    {
      if (EditorsToCheck != null)
      {
        foreach (var baseEdit in EditorsToCheck)
        {
          if (baseEdit is TextEdit)
          {
            CheckEditor(baseEdit as TextEdit);
          }
          if (baseEdit is SpinEdit)
          {
            CheckEditor(baseEdit as SpinEdit);
          }
          if (baseEdit is LookUpEdit)
          {
            CheckEditor(baseEdit as LookUpEdit);
          }
          if (baseEdit is SearchLookUpEdit)
          {
            CheckEditor(baseEdit as SearchLookUpEdit);
          }
        }
      }
    }

    public virtual void CheckEditor(TextEdit editor)
    {
      if (string.IsNullOrWhiteSpace(editor.Text))
      {
        ErrorProvider.SetError(editor, "Bitte einen Wert angeben", ErrorType.Warning);
      }
    }

    public virtual void CheckEditor(SpinEdit editor)
    {
      if (editor.Value.GetInt() <= 0)
      {
        ErrorProvider.SetError(editor, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
      }
    }

    public virtual void CheckEditor(LookUpEdit editor)
    {
      if (editor.EditValue.GetInt() <= 0)
      {
        ErrorProvider.SetError(editor, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
      }
    }

    public virtual void CheckEditor(SearchLookUpEdit editor)
    {
      if (editor.EditValue.GetInt() <= 0)
      {
        ErrorProvider.SetError(editor, "Bitte einen gültigen Wert angeben", ErrorType.Warning);
      }
    }

    public virtual void ReloadControl()
    {
      Update();
    }

    public virtual void ReloadControl(object sender, EventArgs e)
    {
      ReloadControl();
    }

    public bool ValidateControl()
    {
      return !ErrorProvider.HasErrors;
    }

    private void ValidateControl(object sender, CancelEventArgs e)
    {
      ValidateControl();
    }

    public virtual RibbonPage RibbonPage
    {
      get { return null; }
    }

    public readonly DXErrorProvider ErrorProvider = new DXErrorProvider();
  }
}