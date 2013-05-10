using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Subvento.DatabaseException;
using Subvento.DatabaseObject;

namespace Subvento.Database
{
  internal abstract class Database : IDatabase
  {
    protected Database(DbCommand command, DbConnection connection)
    {
      DatabaseCommand = new DatabaseCommand(command);
      DatabaseConnection = new DatabaseConnection(connection);
    }

    public IDatabaseConnection DatabaseConnection { get; set; }

    public IDatabaseCommand DatabaseCommand { get; set; }

    public void SetCommand()
    {
      if (DatabaseConnection.OpenConnection())
      {
        DatabaseCommand.Command.Parameters.Clear();
        DatabaseCommand.Command.Connection = DatabaseConnection.DbConnection;
        DatabaseCommand.Command.CommandText = DatabaseCommand.CommandString;
      }
    }

    public bool Usable()
    {
      ServiceLocator.ResetDatabase();
      try
      {
        return DatabaseConnection.OpenConnection();
      }
      catch (Exception)
      {
        return false;
      }
    }

    public abstract string GetEscapedTableName(string tableName);

    public abstract string ConvertValueToSql(object value);

    public abstract bool CheckIfFieldsExist(ref List<string> list);

    public abstract string LastAddedValue { get; }

    public abstract string GetTopRows(int rows, string table, string idColumn, bool desc);

    public virtual int InsertSql<T>(IDatabaseObject<T> databaseObject)
    {
      try
      {
        var objects = databaseObject.GetObject();

        DatabaseCommand.CommandString = string.Format("Insert into {0} (", GetEscapedTableName(databaseObject.Table));
        DatabaseCommand.CommandString = objects.Aggregate(DatabaseCommand.CommandString, (current, keyValuePair) => current + string.Format("{0},", keyValuePair.Key));
        DatabaseCommand.CommandString = DatabaseCommand.CommandString.Remove(DatabaseCommand.CommandString.Length - 1, 1);
        DatabaseCommand.CommandString += ") values (";
        DatabaseCommand.CommandString = objects.Aggregate(DatabaseCommand.CommandString, (current, keyValuePair) => current + string.Format("@{0},", keyValuePair.Key));
        DatabaseCommand.CommandString = DatabaseCommand.CommandString.Remove(DatabaseCommand.CommandString.Length - 1, 1);
        DatabaseCommand.CommandString += string.Format("); {0}", LastAddedValue);

        SetCommand();

        foreach (var keyValuePair in objects)
        {
          DatabaseCommand.AddParameter(keyValuePair.Key.ToString(), keyValuePair.Value);
        }

        return Convert.ToInt32(DatabaseCommand.Command.ExecuteScalar());
      }
      catch (SqlException exception)
      {
        ServiceLocator.Instance.ExceptionHandler.LogException(exception);
        return 0;
      }
    }

    public virtual bool UpadatSql<T>(IDatabaseObject<T> databaseObject)
    {
      try
      {
        var objects = databaseObject.GetObject();

        DatabaseCommand.CommandString = string.Format("Update {0} set ", GetEscapedTableName(databaseObject.Table));
        DatabaseCommand.CommandString = objects.Aggregate(DatabaseCommand.CommandString, (current, keyValuePair) => current + string.Format("{0} = @{0},", keyValuePair.Key));
        DatabaseCommand.CommandString = DatabaseCommand.CommandString.Remove(DatabaseCommand.CommandString.Length - 1);
        DatabaseCommand.CommandString += string.Format(" where {0}Id = @{0}; {1}", databaseObject.Table, LastAddedValue);

        SetCommand();

        DatabaseCommand.AddParameter(databaseObject.Table, databaseObject.Identity);

        foreach (var keyValuePair in objects)
        {
          DatabaseCommand.AddParameter(keyValuePair.Key.ToString(), keyValuePair.Value);
        }

        DatabaseCommand.Command.ExecuteScalar();

        return true;
      }
      catch (SqlException exception)
      {
        ServiceLocator.Instance.ExceptionHandler.LogException(exception);
        return false;
      }
    }

    public virtual bool DeleteSql<T>(IDatabaseObject<T> databaseObject)
    {
      try
      {
        DatabaseCommand.CommandString = string.Format("Delete from {0} where {1}Id = @{1}", GetEscapedTableName(databaseObject.Table), databaseObject.Table);

        SetCommand();

        DatabaseCommand.AddParameter(databaseObject.Table, databaseObject.Identity);
        DatabaseCommand.Command.ExecuteNonQuery();
        return true;
      }
      catch (SqlException exception)
      {
        ServiceLocator.Instance.ExceptionHandler.LogException(exception);
        return false;
      }
    }

    public virtual string GetOperator(DatabaseOperator.Operator databaseOperator)
    {
      switch (databaseOperator)
      {
        case DatabaseOperator.Operator.Equal:
          return " = ";
        case DatabaseOperator.Operator.NotEqualTo:
          return "<>";
        case DatabaseOperator.Operator.LesserThanOrEqual:
          return " <= ";
        case DatabaseOperator.Operator.GreaterThanOrEqual:
          return " >= ";
        case DatabaseOperator.Operator.LessThan:
          return " < ";
        case DatabaseOperator.Operator.GreaterThan:
          return " > ";
        default:
          throw new InvalidEnumArgumentException();
      }
    }

    public virtual string GetQueryLink(DatabaseQueryLink.Link databaseQueryLink)
    {
      switch (databaseQueryLink)
      {
        case DatabaseQueryLink.Link.Or:
          return " or ";
        case DatabaseQueryLink.Link.And:
          return " and ";
        default:
          throw new InvalidEnumArgumentException();
      }
    }

    public virtual string GetJoinOperator(DatabaseJoinOperator.JoinOperator databaseJoinOperator)
    {
      switch (databaseJoinOperator)
      {
        case DatabaseJoinOperator.JoinOperator.InnerJoin:
          return " inner join ";
        case DatabaseJoinOperator.JoinOperator.RightJoin:
          return " right join ";
        case DatabaseJoinOperator.JoinOperator.FullJoin:
          return " full join ";
        case DatabaseJoinOperator.JoinOperator.LeftJoin:
          return " left join ";
        default:
          throw new InvalidEnumArgumentException();
      }
    }

    public virtual string GetStringOperator(DatabaseStringOperator.StringOperator databaseStringOperator)
    {
      switch (databaseStringOperator)
      {
        case DatabaseStringOperator.StringOperator.Like:
          return " like ";
        default:
          throw new InvalidEnumArgumentException();
      }
    }
  }
}