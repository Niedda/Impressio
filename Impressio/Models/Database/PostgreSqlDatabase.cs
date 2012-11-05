using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using Impressio.Properties;
using Npgsql;

namespace Impressio.Models.Database
{
  public class PostgreSqlDatabase : Database
  {
    private NpgsqlConnection _connection;

    public override DbConnection DbConnection
    {
      get { return _connection ?? (_connection = new NpgsqlConnection(Settings.Default.connectionString)); }
    }

    public override string LastAddedValue
    {
      get { return "SELECT CAST(lastval() AS integer)"; }
    }

    public override DbCommand SetCommand()
    {
      Command = new NpgsqlCommand(CommandString, (NpgsqlConnection) DbConnection);
      return Command;
    }

    public override string GetEscapedTableName(string tableName)
    {
      return string.Format("\"{0}\"", tableName.ToLower());
    }

    public override string ConvertValueToSql(object value)
    {
      if (value is bool)
      {
        return ((bool) value) ? "'1'" : "'0'";
      }

      return value.ToString();
    }

    public override void AddParameter(string parameter, object value)
    {
      Command.Parameters.Add(new NpgsqlParameter(string.Format("@{0}", parameter), value));
    }
  }
}