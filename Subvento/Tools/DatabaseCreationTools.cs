using System;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Subvento.DatabaseException;

namespace Subvento.Tools
{
  public static class DatabaseCreationTools
  {
    public static bool CreateNewCompactDatabase(string databaseName)
    {
      var folderDialog = new FolderBrowserDialog { ShowNewFolderButton = true, Description = "Where should the Database be created?" };
      var result = folderDialog.ShowDialog();

      if (result == DialogResult.OK)
      {
        if (!File.Exists(folderDialog.SelectedPath + databaseName + ".sdf"))
        {
          var fileDialog = new OpenFileDialog { Filter = "Sql Compact Script (*.sqlce)|*.sqlce", Title = "Path to the Script for the Database?" };
          var fileResult = fileDialog.ShowDialog();

          if (fileResult == DialogResult.OK)
          {
            var connectionString = String.Format(@"Data Source = '{0}\{1}.sdf'; Persist Security Info = False;",
                                                 folderDialog.SelectedPath, databaseName);
            new SqlCeEngine(connectionString).CreateDatabase();
            var connection = new SqlCeConnection(connectionString);
            connection.Open();
            var scripts = File.ReadAllText(fileDialog.FileName).Replace(Environment.NewLine, " ");
            var commands = Regex.Split(scripts, "GO");

            try
            {
              ServiceLocator.ResetDatabase();

              foreach (var comm in commands.Where(command => !String.IsNullOrWhiteSpace(command)).Select(command => new SqlCeCommand(command, connection)))
              {
                comm.ExecuteNonQuery();
              }

              ServiceLocator.Instance.ConfigFile.SetConnectionString(connectionString);
              ServiceLocator.Instance.ConfigFile.SetDatabaseEngine(ServiceLocator.DatabaseEngine.Compact);

              return true;
            }
            catch (Exception exception)
            {
              DefaultLogger.Instance.WriteToLog(exception + Environment.NewLine);
              return false;
            }
          }
        }
        MessageBox.Show("Datei existiert bereits. Bitte einen anderen Namen geben oder einen anderen Ort wählen.", "Fehler");
      }
      return false;
    }
  }
}
