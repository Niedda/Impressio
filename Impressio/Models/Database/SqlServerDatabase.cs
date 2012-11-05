using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace Impressio.Models.Database
{
  public class SqlServerDatabase : Database
  {
    private SqlConnection _connection;

    public override DbConnection DbConnection
    {
      get { return _connection ?? (_connection = new SqlConnection(ConnectionString)); }
    }

    public override string LastAddedValue
    {
      get { return "SELECT SCOPE_IDENTITY();"; }
    }

    public override DbCommand SetCommand()
    {
      return Command = new SqlCommand(CommandString, (SqlConnection) DbConnection);
    }

    public override void AddParameter(string parameter, object value)
    {
      Command.Parameters.Add(new SqlParameter(string.Format("@{0}", parameter), value));
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
        CommandString = "INSERT INTO dbo.[" + table + "] ({0}) VALUES ({1})";

        while (cols.Values.Contains(null))
        {
          KeyValuePair<string, string> item = cols.First(c => c.Value == null);
          cols.Remove(item.Key);
        }

        string val = string.Join(",", cols.Keys.ToArray());
        string param = val.Replace("@", "");

        CommandString = string.Format(CommandString, param, val);
        var comm = new SqlCommand(CommandString, (SqlConnection) DbConnection);

        foreach (var value in cols.Where(c => c.Value != null))
        {
          comm.Parameters.Add(new SqlParameter(value.Key, value.Value));
        }
        comm.CommandText += "; SELECT SCOPE_IDENTITY();";
        return Convert.ToInt32(comm.ExecuteScalar());
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

        CommandString = string.Format("UPDATE dbo.[{0}] SET ", table);
        string app = "{0} = {1},";

        foreach (var col in cols)
        {
          CommandString += string.Format(app, col.Key.Replace("@", ""), col.Key);
        }

        string cm = CommandString.Remove(CommandString.Length - 1, 1);
        app = string.Format(" WHERE {0} = {1}", idCol, id);
        CommandString = cm + app;
        var comm = new SqlCommand(CommandString, (SqlConnection) DbConnection);

        foreach (var value in cols)
        {
          comm.Parameters.Add(new SqlParameter(value.Key, value.Value));
        }
        foreach (var keyValuePair in setNull)
        {
          comm.Parameters.Add(new SqlParameter(keyValuePair.Key, DBNull.Value));
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

    public override string GetEscapedTableName(string tableName)
    {
      return string.Format("[dbo].[{0}]", tableName);
    }

    public override string ConvertValueToSql(object value)
    {
      if (value is bool)
      {
        return ((bool) value) ? "1" : "0";
      }
      return value.ToString();
    }
  }
}