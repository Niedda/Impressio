using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;

namespace Subvento.Database
{
  internal class SqlServerDatabase : Database
  {
    public SqlServerDatabase(DbCommand command, DbConnection connection)
      : base(command, connection)
    {
    }

    public override string LastAddedValue
    {
      get { return "SELECT SCOPE_IDENTITY();"; }
    }

    public override string GetTopRows(int rows, string table, string idColumn, bool desc)
    {
      return string.Format("select top {3} * from {0} order by {1} {2}", GetEscapedTableName(table), idColumn, desc ? "desc" : "asc", rows);
    }

    public override string GetEscapedTableName(string tableName)
    {
      return string.Format("[dbo].[{0}]", tableName);
    }

    public override string ConvertValueToSql(object value)
    {
      if (value is bool)
      {
        return ((bool)value) ? "1" : "0";
      }

      return value.ToString();
    }

    public override bool CheckIfFieldsExist(ref List<string> fields)
    {
      try
      {
        DatabaseCommand.CommandString = "Select * from syscolumns";
        SetCommand();
        DatabaseCommand.Reader = DatabaseCommand.Command.ExecuteReader();

        while (DatabaseCommand.Reader.Read())
        {
          var field = DatabaseCommand.Reader["name"].ToString();

          if (fields.Contains(field))
          {
            fields.Remove(field);
          }
        }
        return fields.Count == 0;
      }
      catch (SqlException exception)
      {
        ServiceLocator.Instance.ExceptionHandler.LogException(exception);
        return false;
      }
      finally
      {
        DatabaseCommand.CloseReader();
      }
    }
  }
}