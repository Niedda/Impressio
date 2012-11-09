using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Impressio.Models;
using Subvento;
using Subvento.Database;

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
      CheckConnection();
      CheckDatabaseFields();
      return true;
    }

    public bool CheckConnection()
    {
      Task = "Connecting to Database...";

      _database.CheckConnection();

      if (_database.DbConnection.State != ConnectionState.Open)
      {
        XtraMessageBox.Show("Fehler beim Versuch mit der Datenbank zu verbinden", "Fehler");
        return false;
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
      listToCheck.AddRange(Enum.GetNames(typeof(Offset.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Order.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Paper.Columns)));
      listToCheck.AddRange(Enum.GetNames(typeof(Print.Columns)));

      return _database.CheckIfFieldsExist(listToCheck);
    }

    private string Task
    {
      set
      {
        task.Text = value;
        task.Update();
      }
    }

    private readonly IDatabase _database = ServiceLocator.Instance.Database;
  }
}
