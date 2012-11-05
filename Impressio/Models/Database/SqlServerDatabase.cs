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