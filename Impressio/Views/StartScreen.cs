using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Impressio.Models;
using Subvento;

namespace Impressio.Views
{
  public partial class StartScreen : Form
  {
    public StartScreen()
    {
      InitializeComponent();
      Task = "Loading...";
    }

    public bool MainValidate()
    {
      if (CheckConnection())
      {
        CheckDatabaseFields();
      }
      return true;
    }

    public bool CheckConnection()
    {
      Task = "Connecting to Database...";

      if (!ServiceLocator.Instance.Database.Usable())
      {
        Hide();
        var result = new StartupWizard().ShowDialog();

        if(result == DialogResult.Cancel)
        {
          return false;
        }
      }
      return true;
    }

    public bool CheckDatabaseFields()
    {
      Task = "Validating Databasefields...";

      var listToCheck = new List<string>(Enum.GetNames(typeof(Client.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Company.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Address.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Data.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Delivery.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Description.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Finish.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Gender.Columns)));
      //listToCheck.AddRange(Enum.GetNames(typeof(Offset.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Order.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Paper.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Print.Columns)));

      if (!ServiceLocator.Instance.Database.CheckIfFieldsExist(ref listToCheck))
      {
        var message = listToCheck.Aggregate("Failed to retrieve the following fields:", (current, field) => current + string.Format("{0}{1}", Environment.NewLine, field));
        XtraMessageBox.Show(message, "Fehler");
        return false;
      }
      return true;
    }

    private string Task
    {
      set
      {
        task.Text = value;
        task.Update();
      }
    }
  }
}
