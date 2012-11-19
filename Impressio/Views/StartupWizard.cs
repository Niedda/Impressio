using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Impressio.Properties;
using Subvento;
using Subvento.Tools;

namespace Impressio.Views
{
  public partial class StartupWizard : XtraForm
  {
    public StartupWizard()
    {
      InitializeComponent();
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
      validateDatabase.Text = "";
      validateDatabase.Update();
      validateDatabase.ForeColor = Color.Gold;
      validateDatabase.Text = "Validierung der Eingaben...";
      validateDatabase.Update();

      if (!ServiceLocator.Instance.Database.Usable())
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

    private void ConnectionStringEditValueChanged(object sender, EventArgs e)
    {
      ServiceLocator.Instance.ConfigFile.SetConnectionString(connectionString.Text);
    }

    private void DatabaseEngineSelectedIndexChanged(object sender, EventArgs e)
    {
      ServiceLocator.Instance.ConfigFile.SetDatabaseEngine((ServiceLocator.DatabaseEngine)Enum.Parse(typeof(ServiceLocator.DatabaseEngine), databaseEngine.Text));
    }

    private void CreateCompactClick(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(compactName.Text))
      {
        XtraMessageBox.Show("Bitte einen Namen vergen.", "Fehler");
        return;
      }
      if (!DatabaseCreationTools.CreateNewCompactDatabase(compactName.Text))
      {
        XtraMessageBox.Show("Fehler bei der Erstellung der Datenbank.", "Fehler");
      }
      else
      {
        connectionString.Text = ServiceLocator.Instance.ConfigFile.ConnectionString;
        databaseEngine.Text = ServiceLocator.Instance.ConfigFile.DatabaseEngine.ToString();
        connectionString.Update();
        databaseEngine.Update();
        validateDatabase.Text = "Compact Datenbank erfolgreich erstellt";
        validateDatabase.ForeColor = Color.Green;
      }
    }

    private void WizardControlFinishClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if(!ServiceLocator.Instance.Database.Usable())
      {
        e.Cancel = true;
        XtraMessageBox.Show("Bitte die Einstellungen überprüfen.", "Fehler");
      }
    }

    private void WelcomeWizardPageEnter(object sender, EventArgs e)
    {
      userEdit.Text = Settings.Default.User;
      logoEdit.Text = Settings.Default.logoImage;
      databaseEngine.Properties.Items.Clear();
      connectionString.Text = ServiceLocator.Instance.ConfigFile.ConnectionString;
      databaseEngine.Properties.Items.AddRange(Enum.GetNames(typeof(ServiceLocator.DatabaseEngine)));
      databaseEngine.Text = ServiceLocator.Instance.ConfigFile.DatabaseEngine.ToString();
    }
  }
}