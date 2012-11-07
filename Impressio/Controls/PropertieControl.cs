using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using Impressio.Models;
using Impressio.Properties;
using Subvento;
using Subvento.Configuration;
using Subvento.Database;

namespace Impressio.Controls
{
  public partial class PropertieControl : XtraUserControl, IControl
  {
    public PropertieControl()
    {
      InitializeComponent();
      Dock = DockStyle.Fill;
    }

    public void ReloadControl()
    {
      database.Text = ServiceLocator.ConfigFile.DatabaseEngine;
      dbConnectionString.Text = ServiceLocator.ConfigFile.ConnectionString;
      user.Text = Settings.Default.User;
      pathData.Text = Settings.Default.folderPath;
    }

    public bool ValidateControl()
    {
      return !_errorProvider.HasErrors;
    }

    private readonly DXErrorProvider _errorProvider = new DXErrorProvider();

    private void PropertieControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void PathDataEnter(object sender, EventArgs e)
    {
      var result = folderBrowser.ShowDialog();

      if (result == DialogResult.OK)
      {
        Settings.Default.folderPath = folderBrowser.SelectedPath;
        pathData.Text = folderBrowser.SelectedPath;
        Settings.Default.Save();
      }
    }

    private void UserEditValueChanged(object sender, EventArgs e)
    {
      _errorProvider.SetError(user, string.IsNullOrEmpty(user.Text) ? "Bitte einen Namen vergeben." : "");
    }

    private void DbConnectionStringEditValueChanged(object sender, EventArgs e)
    {
      ServiceLocator.ConfigFile.ConnectionString = dbConnectionString.Text;
      ServiceLocator.ConfigFile.SaveConfig();
    }

    private void DatabaseSelectedIndexChanged(object sender, EventArgs e)
    {
      ServiceLocator.ConfigFile.DatabaseEngine = database.Text;
      ServiceLocator.ConfigFile.SaveConfig();
    }

    private void CheckDatabaseSettingClick(object sender, EventArgs e)
    {
      ServiceLocator.ResetDatabase();

      if (ServiceLocator.Instance.Usable())
      {
        databaseCheckResult.Text = "Datenbank erfolgreich überprüft.";
        databaseCheckResult.ForeColor = Color.Green;
      }
      else
      {
        databaseCheckResult.Text = "Fehler bei der Überprüfung.";
        databaseCheckResult.ForeColor = Color.Red;
      }
    }

    private void CreateCompactDbClick(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(compactName.Text))
      {
        SqlCompactDatabase.CreateNewCompactDatabase(compactName.Text);
        ReloadControl();
        ServiceLocator.ResetDatabase();
        _errorProvider.SetError(compactName, "");
      }
      else
      {
        _errorProvider.SetError(compactName, "Bitte einen Namen für die Datenbank wählen.");
      }
    }

    private void PropertieControlValidating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }
  }
}