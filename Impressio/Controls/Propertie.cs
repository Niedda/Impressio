using System;
using System.Windows.Forms;
using Impressio.Models.Database;
using Impressio.Properties;

namespace Impressio.Controls
{
  public partial class Propertie : Models.ControlBase
  {
    public Propertie()
    {
      InitializeComponent();
    }

    private void PropertieControlLoad(object sender, EventArgs e)
    {
      database.Text = Settings.Default.databaseEngine;
      logger.Text = Settings.Default.loggerEngine;
      dbConnectionString.Text = Settings.Default.connectionString;
      user.Text = Settings.Default.User;
      logFolderPath.Text = Settings.Default.logPath;
      pathData.Text = Settings.Default.folderPath;
      exceptionMode.Checked = Settings.Default.exceptionMode;
      pathToCompactDb.Text = Settings.Default.PathToCompactDb;
    }

    private void LogFolderPathEnter(object sender, EventArgs e)
    {
      var result = folderBrowser.ShowDialog();

      if (result == DialogResult.OK)
      {
        Settings.Default.logPath = folderBrowser.SelectedPath;
        logFolderPath.Text = folderBrowser.SelectedPath;
        Settings.Default.Save();
      }
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
    
    private void ExceptionModeCheckedChanged(object sender, EventArgs e)
    {
      Settings.Default.exceptionMode = exceptionMode.Checked;
      Settings.Default.Save();
    }

    private void UserEditValueChanged(object sender, EventArgs e)
    {
      CheckEditor(user);

      if (!ErrorProvider.HasErrors)
      {
        Settings.Default.User = user.Text;
        Settings.Default.Save();
      }
    }

    private void DbConnectionStringEditValueChanged(object sender, EventArgs e)
    {
      if(!string.IsNullOrEmpty(dbConnectionString.Text))
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
      Settings.Default.databaseEngine = database.Text;
      Settings.Default.Save();
    }

    private void LoggerSelectedIndexChanged(object sender, EventArgs e)
    {
      Settings.Default.loggerEngine = logger.Text;
      Settings.Default.Save();
    }

    private void PathToCompactDbEnter(object sender, EventArgs e)
    {
      var result = folderBrowser.ShowDialog();

      if (result == DialogResult.OK)
      {
        Settings.Default.PathToCompactDb = folderBrowser.SelectedPath;
        pathToCompactDb.Text = folderBrowser.SelectedPath;
        Settings.Default.Save();
      }
    }
  }
}
