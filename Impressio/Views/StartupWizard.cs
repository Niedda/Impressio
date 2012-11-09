using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Impressio.Properties;
using Subvento;
using Subvento.Configuration;
using Subvento.Database;

namespace Impressio.Views
{
  public partial class StartupWizard : XtraForm
  {
    public StartupWizard()
    {
      InitializeComponent();
    }

    private void WizardPagePersonalInformationEnter(object sender, EventArgs e)
    {
      userEdit.Text = Settings.Default.User;
      logoEdit.Text = Settings.Default.logoImage;
    }

    private void LogoEditEnter(object sender, EventArgs e)
    {
      var fileDialog = new OpenFileDialog();
      var result = fileDialog.ShowDialog();

      if (result == DialogResult.OK)
      {
        logoEdit.Text = fileDialog.FileName;
        Settings.Default.Save();
      }
    }

    private void UserEditEditValueChanged(object sender, EventArgs e)
    {
      Settings.Default.User = userEdit.Text;
      Settings.Default.Save();
    }

    private void WizardPageDatabasePageValidating(object sender, DevExpress.XtraWizard.WizardPageValidatingEventArgs e)
    {
      ServiceLocator.ResetDatabase();

      if (!ServiceLocator.Instance.Usable())
      {
        validateDatabase.Text = "Fehler bei der Überprüfung der Datenbank";
        validateDatabase.ForeColor = Color.Red;
        e.Valid = false;
      }
      else
      {
        validateDatabase.Text = "Datenbank erfolgreich verbunden";
        validateDatabase.ForeColor = Color.Green;
      }
    }

    private void WizardPageDatabaseEnter(object sender, EventArgs e)
    {
      connectionString.Text = ServiceLocator.ConfigFile.ConnectionString;
      databaseEngine.Text = ServiceLocator.ConfigFile.DatabaseEngine;
    }

    private void ConnectionStringEditValueChanged(object sender, EventArgs e)
    {
      ServiceLocator.ConfigFile.ConnectionString = connectionString.Text;
      ServiceLocator.ConfigFile.SaveConfig();
    }

    private void DatabaseEngineSelectedIndexChanged(object sender, EventArgs e)
    {
      ServiceLocator.ConfigFile.DatabaseEngine = databaseEngine.Text;
      ServiceLocator.ConfigFile.SaveConfig();
    }

    private void CreateCompactClick(object sender, EventArgs e)
    {
      if(string.IsNullOrEmpty(compactName.Text))
      {
        XtraMessageBox.Show("Bitte einen Namen vergen.", "Fehler");
        return;
      }
      if(!SqlCompactDatabase.CreateNewCompactDatabase(compactName.Text))
      {
        XtraMessageBox.Show("Fehler bei der Erstellung der Datenbank.", "Fehler");
      }
      else
      {
        connectionString.Text = ServiceLocator.ConfigFile.ConnectionString;
        databaseEngine.Text = ServiceLocator.ConfigFile.DatabaseEngine;
        connectionString.Update();
        databaseEngine.Update();
        validateDatabase.Text = "Compact Datenbank erfolgreich erstellt";
        validateDatabase.ForeColor = Color.Green;
      }
    }
  }
}