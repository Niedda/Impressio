using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;
using Impressio.Properties;

namespace Impressio.Models.Database
{
  internal class SqlCompactDatabase : Database
  {
    private SqlCeConnection _connection;

    public override DbConnection DbConnection
    {
      get { return _connection ?? (_connection = new SqlCeConnection(ConnectionString)); }
    }

    public override string LastAddedValue
    {
      get { return "SELECT @@Identity"; }
    }

    public override DbCommand SetCommand()
    {
      Command = new SqlCeCommand(CommandString, (SqlCeConnection)DbConnection);
      return Command;
    }

    public override string GetEscapedTableName(string tableName)
    {
      return string.Format("[{0}]", tableName);
    }

    public override string ConvertValueToSql(object value)
    {
      if (value is bool)
      {
        return ((bool)value) ? "1" : "0";
      }
      return value.ToString();
    }

    public override void AddParameter(string parameter, object value)
    {
      Command.Parameters.Add(new SqlCeParameter(string.Format("@{0}", parameter), value));
    }

    public override int InsertSql<T>(DatabaseObjectBase<T> databaseObject)
    {
      try
      {
        CommandString = string.Format("Insert into {0} (", GetEscapedTableName(databaseObject.Table));
        Dictionary<Enum, object> objects = databaseObject.GetObject();

        foreach (var keyValuePair in objects)
        {
          CommandString += string.Format("{0},", keyValuePair.Key);
        }
        CommandString = CommandString.Remove(CommandString.Length - 1, 1);
        CommandString += ") values (";

        foreach (var keyValuePair in objects)
        {
          CommandString += string.Format("@{0},", keyValuePair.Key);
        }
        CommandString = CommandString.Remove(CommandString.Length - 1, 1);
        CommandString += ");";
        SetCommand();

        foreach (var keyValuePair in objects)
        {
          AddParameter(keyValuePair.Key.ToString(), keyValuePair.Value);
        }
        Command.ExecuteNonQuery();
        CommandString = LastAddedValue;
        return SetCommand().ExecuteNonQuery().GetInt();
      }
      catch (Exception exception)
      {
        ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
        return 0;
      }
    }
    
    public bool CreateNewCompactDatabase(string databaseName)
    {
      var folderDialog = new FolderBrowserDialog { ShowNewFolderButton = true,Description = "Wo soll die Datenbank gespeichert werden?"};
      var result = folderDialog.ShowDialog();

      if (result == DialogResult.OK)
      {
        var fileDialog = new OpenFileDialog { Filter = "Sql Compact Script (*.sqlce)|*.sqlce", Title = "Pfad zum Script"};
        var fileResult = fileDialog.ShowDialog();

        if (fileResult == DialogResult.OK)
        {
          Settings.Default.connectionString = string.Format(@"Data Source = '{0}\{1}.sdf'; Persist Security Info = False;", folderDialog.SelectedPath, databaseName);
          new SqlCeEngine(Settings.Default.connectionString).CreateDatabase();
          string scripts = File.ReadAllText(fileDialog.FileName).Replace(Environment.NewLine, " ");
          string[] commands = Regex.Split(scripts, "GO");

          try
          {
            CheckConnection();

            foreach (var command in commands.Where(command => !string.IsNullOrWhiteSpace(command)))
            {
              CommandString = command;
              SetCommand().ExecuteNonQuery();
            }
            return true;
          }
          catch (Exception exception)
          {
            ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
            return false;
          }
        }
      }
      return false;
    }
  }
}