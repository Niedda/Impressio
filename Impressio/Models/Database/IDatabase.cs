using System.Collections.Generic;
using System.Data.Common;
using Impressio.Models.Database.DatabaseObject;

namespace Impressio.Models.Database
{
  public interface IDatabase
  {
    DbConnection DbConnection { get; }

    string CommandString { get; set; }

    DbCommand Command { get; set; }

    DbDataReader Reader { get; set; }

    string LastAddedValue { get; }
    DbCommand SetCommand();

    void AddParameter(string parameter, object value);

    void CheckConnection();

    void CloseReader();

    int InsertSql(string table, Dictionary<string, string> cols);

    bool UpdateSql(string table, Dictionary<string, string> cols, string id, string idCol);

    bool UpadatSql<T>(DatabaseObjectBase<T> databaseObject);

    int InsertSql<T>(DatabaseObjectBase<T> databaseObject);

    bool DeleteSql<T>(DatabaseObjectBase<T> databaseObject);

    string GetEscapedTableName(string tableName);

    string ConvertValueToSql(object value);
  }
}