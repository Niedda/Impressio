using System.Collections.Generic;
using System.Data.Common;

namespace Subvento.Database
{
  internal class PostgreSqlDatabase : Database
  {
    public PostgreSqlDatabase(DbCommand command, DbConnection connection) : base(command, connection)
    {
    }

    public override string LastAddedValue
    {
      get { return "SELECT CAST(lastval() AS integer)"; }
    }

    public override string GetTopRows(int rows, string table, string idColumn, bool desc)
    {
      return string.Format("select * from {0} order by {1} {2} limit {3}",GetEscapedTableName(table), idColumn, desc ? "desc" : "asc", rows);
    }

    public override string GetEscapedTableName(string tableName)
    {
      return string.Format("\"{0}\"", tableName.ToLower());
    }

    public override string ConvertValueToSql(object value)
    {
      if (value is bool)
      {
        return ((bool)value) ? "'1'" : "'0'";
      }

      return value.ToString();
    }

    public override bool CheckIfFieldsExist(ref List<string> fields)
    {
      //TODO implement
      throw new System.NotImplementedException();
    }
  }
}