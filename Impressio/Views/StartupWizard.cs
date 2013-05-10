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

    private void ConnectionStringEditValueChanged(object sender, EventArgs e)
    {
      _isValid = false;
    }

    private void DatabaseEngineSelectedIndexChanged(object sender, EventArgs e)
    {
      _isValid = false;
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
        ServiceLocator.ResetDatabase();
      }
    }

    private void WizardControlFinishClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
      if (!ServiceLocator.Instance.Database.Usable())
      {
        e.Cancel = true;
        XtraMessageBox.Show("Bitte die Einstellungen überprüfen.", "Fehler");
      }
    }

    private void WizardControlNextClick(object sender, DevExpress.XtraWizard.WizardCommandButtonClickEventArgs e)
    {
      userEdit.Text = Settings.Default.User;
      logoEdit.Text = Settings.Default.logoImage;
      databaseEngine.Properties.Items.Clear();
      connectionString.Text = ServiceLocator.Instance.ConfigFile.ConnectionString;
      object[] databases = Enum.GetNames(typeof(ServiceLocator.DatabaseEngine));
      databaseEngine.Properties.Items.AddRange(databases);
      databaseEngine.Text = ServiceLocator.Instance.ConfigFile.DatabaseEngine.ToString();
    }

    private void TestDatabaseClick(object sender, EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      ServiceLocator.Instance.ConfigFile.SetConnectionString(connectionString.Text);
      ServiceLocator.Instance.ConfigFile.SetDatabaseEngine((ServiceLocator.DatabaseEngine)Enum.Parse(typeof(ServiceLocator.DatabaseEngine), databaseEngine.Text));
      _isValid = ServiceLocator.Instance.Database.Usable();

      wizardPageDatabase.AllowNext = _isValid;
      if (_isValid)
      {
        validateDatabase.Text = "Datenbank erfolgreich verbunden";
        validateDatabase.ForeColor = Color.Green;
      }
      else
      {
        validateDatabase.Text = "Fehler bei der Überprüfung der Datenbank";
        validateDatabase.ForeColor = Color.Red;
      }
      Cursor.Current = Cursors.Default;
    }

    private bool _isValid;
  }
}