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
    private const string Filename = "Impressio.sdf";

    private const string Password = "admin";

    private readonly string _compactConnectionString = string.Format(@"DataSource='{0}\{1}'; Password='{2}';",
                                                                     PathToDatabase, Filename, Password);

    private SqlCeConnection _connection;

    public SqlCompactDatabase()
    {
      CheckForDatabase();
    }

    public override DbConnection DbConnection
    {
      get { return _connection ?? (_connection = new SqlCeConnection(_compactConnectionString)); }
    }

    public override string LastAddedValue
    {
      get { return "SELECT @@Identity"; }
    }

    private static string PathToDatabase
    {
      get
      {
        if (string.IsNullOrWhiteSpace(Settings.Default.PathToCompactDb))
        {
          var folderDialog = new FolderBrowserDialog();
          DialogResult folderResult = folderDialog.ShowDialog();

          if (folderResult == DialogResult.OK)
          {
            Settings.Default.PathToCompactDb = folderDialog.SelectedPath;
            return folderDialog.SelectedPath;
          }
          return string.Empty;
        }
        return Settings.Default.PathToCompactDb;
      }
      set
      {
        Settings.Default.PathToCompactDb = value;
        Settings.Default.Save();
      }
    }

    private string _pathToScript
    {
      get
      {
        var fileDialog = new OpenFileDialog {Filter = "Sql Compact Script (*.sqlce)|*.sqlce"};
        DialogResult fileResult = fileDialog.ShowDialog();

        if (fileResult == DialogResult.OK)
        {
          return fileDialog.FileName;
        }
        return null;
      }
    }

    public override DbCommand SetCommand()
    {
      Command = new SqlCeCommand(CommandString, (SqlCeConnection) DbConnection);
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
        return ((bool) value) ? "1" : "0";
      }
      return value.ToString();
    }

    public override void AddParameter(string parameter, object value)
    {
      Command.Parameters.Add(new SqlCeParameter(string.Format("@{0}", parameter), value));
    }

    public override int InsertSql(string table, Dictionary<string, string> cols)
    {
      List<KeyValuePair<string, string>> setNull =
        (from a in cols where a.Value == null || string.IsNullOrEmpty(a.Value) select a).ToList();

      try
      {
        foreach (var keyValuePair in setNull)
        {
          cols.Remove(keyValuePair.Key);
        }

        CheckConnection();
        CommandString = "INSERT INTO [" + table + "] ({0}) VALUES ({1})";

        while (cols.Values.Contains(null))
        {
          KeyValuePair<string, string> item = cols.First(c => c.Value == null);
          cols.Remove(item.Key);
        }

        string val = string.Join(",", cols.Keys.ToArray());
        string param = val.Replace("@", "");

        CommandString = string.Format(CommandString, param, val);
        var comm = new SqlCeCommand(CommandString, (SqlCeConnection) DbConnection);

        foreach (var value in cols.Where(c => c.Value != null))
        {
          comm.Parameters.Add(new SqlCeParameter(value.Key, value.Value));
        }
        comm.ExecuteNonQuery();
        comm.CommandText = "SELECT @@IDENTITY";
        return Convert.ToInt32(comm.ExecuteNonQuery());
      }
      catch (Exception exception)
      {
        ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
        return 0;
      }
    }

    public override bool UpdateSql(string table, Dictionary<string, string> cols, string id, string idCol)
    {
      List<KeyValuePair<string, string>> setNull =
        (from a in cols where a.Value == null || string.IsNullOrEmpty(a.Value) select a).ToList();

      try
      {
        CheckConnection();

        foreach (var keyValuePair in setNull)
        {
          cols.Remove(keyValuePair.Key);
        }

        CommandString = string.Format("UPDATE [{0}] SET ", table);
        string app = "{0} = {1},";

        foreach (var col in cols)
        {
          CommandString += string.Format(app, col.Key.Replace("@", ""), col.Key);
        }

        string cm = CommandString.Remove(CommandString.Length - 1, 1);
        app = string.Format(" WHERE {0} = {1}", idCol, id);
        CommandString = cm + app;
        var comm = new SqlCeCommand(CommandString, (SqlCeConnection) DbConnection);

        foreach (var value in cols)
        {
          comm.Parameters.Add(new SqlCeParameter(value.Key, value.Value));
        }
        foreach (var keyValuePair in setNull)
        {
          comm.Parameters.Add(new SqlCeParameter(keyValuePair.Key, DBNull.Value));
        }

        comm.ExecuteNonQuery();
        return true;
      }
      catch (Exception exception)
      {
        ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
        return false;
      }
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

    public bool CheckForDatabase()
    {
      if (!File.Exists(PathToDatabase + @"\" + Filename))
      {
        var database = new SqlCeEngine(_compactConnectionString);
        database.CreateDatabase();

        string scripts = File.ReadAllText(_pathToScript).Replace(Environment.NewLine, " ");
        string[] commands = Regex.Split(scripts, "GO");
        CheckConnection();

        try
        {
          foreach (string command in commands.Where(command => !string.IsNullOrWhiteSpace(command)))
          {
            CommandString = command;
            SetCommand().ExecuteNonQuery();
          }
        }
        catch (Exception exception)
        {
          ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
        }
      }
      return true;
    }
  }
}