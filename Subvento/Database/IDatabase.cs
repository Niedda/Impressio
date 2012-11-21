using System.Collections.Generic;
using Subvento.DatabaseObject;

namespace Subvento.Database
{
  public interface IDatabase
  {
    string LastAddedValue { get; }

    IDatabaseCommand DatabaseCommand { get; set; }

    IDatabaseConnection DatabaseConnection { get; set; }

    void SetCommand();

    bool Usable();

    bool UpadatSql<T>(IDatabaseObject<T> databaseObject);

    int InsertSql<T>(IDatabaseObject<T> databaseObject);

    bool DeleteSql<T>(IDatabaseObject<T> databaseObject);

    string GetEscapedTableName(string tableName);

    string GetTopRows(int rows, string table, string idColumn, bool desc);

    string ConvertValueToSql(object value);

    bool CheckIfFieldsExist(ref List<string> fields);

    string GetOperator(DatabaseOperator.Operator databaseOperator);

    string GetQueryLink(DatabaseQueryLink.Link databaseQueryLink);

    string GetJoinOperator(DatabaseJoinOperator.JoinOperator databaseJoinOperator);

    string GetStringOperator(DatabaseStringOperator.StringOperator databaseStringOperator);
  }
}