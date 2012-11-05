using System;
using System.Windows.Forms;
using Impressio.Models;
using Impressio.Models.Database;
using Impressio.Properties;

namespace Impressio.Controls
{
  public partial class PropertieControl : ControlBase, IControl
  {
    public PropertieControl()
    {
      InitializeComponent();
    }

    public void ReloadControl()
    {
      _isLoaded = false;
      database.Text = Settings.Default.databaseEngine;
      logger.Text = Settings.Default.loggerEngine;
      dbConnectionString.Text = Settings.Default.connectionString;
      user.Text = Settings.Default.User;
      logFolderPath.Text = Settings.Default.logPath;
      pathData.Text = Settings.Default.folderPath;
      exceptionMode.Checked = Settings.Default.exceptionMode;
      _isLoaded = true;
    }

    public bool ValidateControl()
    {
      return !ErrorProvider.HasErrors;
    }

    private bool _isLoaded;

    private void PropertieControlLoad(object sender, EventArgs e)
    {
      ReloadControl();
    }

    private void LogFolderPathEnter(object sender, EventArgs e)
    {
      DialogResult result = folderBrowser.ShowDialog();

      if (result == DialogResult.OK)
      {
        Settings.Default.logPath = folderBrowser.SelectedPath;
        logFolderPath.Text = folderBrowser.SelectedPath;
        Settings.Default.Save();
      }
    }

    private void PathDataEnter(object sender, EventArgs e)
    {
      DialogResult result = folderBrowser.ShowDialog();

      if (result == DialogResult.OK)
      {
        Settings.Default.folderPath = folderBrowser.SelectedPath;
        pathData.Text = folderBrowser.SelectedPath;
        Settings.Default.Save();
      }
    }

    private void ExceptionModeCheckedChanged(object sender, EventArgs e)
    {
      if (_isLoaded)
      {
        Settings.Default.exceptionMode = exceptionMode.Checked;
        Settings.Default.Save();
      }
    }

    private void UserEditValueChanged(object sender, EventArgs e)
    {
      ErrorProvider.ClearErrors();
      CheckEditor(user);

      if (!ErrorProvider.HasErrors)
      {
        Settings.Default.User = user.Text;
        Settings.Default.Save();
      }
    }

    private void DbConnectionStringEditValueChanged(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(dbConnectionString.Text))
      {
        ErrorProvider.ClearErrors();
        Settings.Default.connectionString = dbConnectionString.Text;
        Settings.Default.Save();
      }
      else
      {
        ErrorProvider.SetError(dbConnectionString, "Bitte eine Angabe machen");
      }
    }

    private void DatabaseSelectedIndexChanged(object sender, EventArgs e)
    {
      if(_isLoaded && database.Text == "compact" )
      {
        var compact = new SqlCompactDatabase();

        if(!compact.CreateNewCompactDatabase("myDatabase"))
        {
          ErrorProvider.SetError(database, "Fehler bei der Erstellung der Datenbank");
          database.SelectedIndex = 1;
        }
      }
    }

    private void LoggerSelectedIndexChanged(object sender, EventArgs e)
    {
      Settings.Default.loggerEngine = logger.Text;
      Settings.Default.Save();
    }
  }
}