using System;
using System.Drawing;
using System.Windows.Forms;
using Impressio.Properties;
using Subvento;
using Subvento.Tools;

namespace Impressio.Controls
{
  public partial class PropertieControl : ControlBase
  {
    public PropertieControl()
    {
      InitializeComponent();
      InitializeBase();
    }

    public override void ReloadControl()
    {
      database.Properties.Items.AddRange(Enum.GetNames(typeof(ServiceLocator.DatabaseEngine)));
      database.Text = ServiceLocator.Instance.ConfigFile.DatabaseEngine.ToString();
      dbConnectionString.Text = ServiceLocator.Instance.ConfigFile.ConnectionString;
      user.Text = Settings.Default.User;
      pathData.Text = Settings.Default.folderPath;
      lookAndFeel.Text = Settings.Default.lookAndFeel;
      logoEdit.Text = Settings.Default.logoImage;
    }

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
      ErrorProvider.SetError(user, string.IsNullOrEmpty(user.Text) ? "Bitte einen Namen vergeben." : "");
    }

    private void DbConnectionStringEditValueChanged(object sender, EventArgs e)
    {
      ServiceLocator.Instance.ConfigFile.SetConnectionString(dbConnectionString.Text);
    }

    private void DatabaseSelectedIndexChanged(object sender, EventArgs e)
    {
      ServiceLocator.Instance.ConfigFile.SetDatabaseEngine((ServiceLocator.DatabaseEngine)Enum.Parse(typeof(ServiceLocator.DatabaseEngine), database.Text));
    }

    private void CheckDatabaseSettingClick(object sender, EventArgs e)
    {
      ServiceLocator.ResetDatabase();

      if (ServiceLocator.Instance.Database.Usable())
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
        DatabaseCreationTools.CreateNewCompactDatabase(compactName.Text);
        ReloadControl();
        ServiceLocator.ResetDatabase();
        ErrorProvider.SetError(compactName, "");
      }
      else
      {
        ErrorProvider.SetError(compactName, "Bitte einen Namen für die Datenbank wählen.");
      }
    }

    private void PropertieControlValidating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      e.Cancel = !ValidateControl();
    }

    private void LookAndFeelSelectedIndexChanged(object sender, EventArgs e)
    {
      Settings.Default.lookAndFeel = lookAndFeel.Text;
      Settings.Default.Save();
      DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = Settings.Default.lookAndFeel;
    }

    private void LogoEditEnter(object sender, EventArgs e)
    {
      var result = openFileDialog.ShowDialog();

      if (result == DialogResult.OK)
      {
        Settings.Default.logoImage = openFileDialog.FileName;
        logoEdit.Text = openFileDialog.FileName;
        Settings.Default.Save();
      }
    }
  }
}