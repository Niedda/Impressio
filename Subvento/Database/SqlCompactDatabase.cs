using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Subvento.DatabaseException;
using Subvento.DatabaseObject;

namespace Subvento.Database
{
  internal class SqlCompactDatabase : Database
  {
    public SqlCompactDatabase(DbCommand command, DbConnection connection) : base(command, connection)
    { }

    public override string LastAddedValue
    {
      get { return "SELECT @@Identity"; }
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

    public override bool CheckIfFieldsExist(ref List<string> fields)
    {
      try
      {
        DatabaseCommand.CommandString = "SELECT * FROM INFORMATION_SCHEMA.Columns";
        SetCommand();
        DatabaseCommand.Reader = DatabaseCommand.Command.ExecuteReader();

        while (DatabaseCommand.Reader.Read())
        {
          var field = DatabaseCommand.Reader["column_name"].ToString();

          if (fields.Contains(field))
          {
            fields.Remove(field);
          }
        }
        return fields.Count == 0;
      }
      catch (SqlException exception)
      {
        new ExceptionHandler(exception);
        throw;
      }
      finally
      {
        DatabaseCommand.CloseReader();
      }
    }

    public override string GetTopRows(int rows, string table, string idColumn, bool desc)
    {
      return string.Format("select top({3}) * from {0} order by {1} {2}", GetEscapedTableName(table), idColumn, desc ? "desc" : "asc", rows);
    }

    public override int InsertSql<T>(IDatabaseObject<T> databaseObject)
    {
      try
      {
        var objects = databaseObject.GetObject();

        DatabaseCommand.CommandString = string.Format("Insert into {0} (", GetEscapedTableName(databaseObject.Table));
        
        foreach (var keyValuePair in objects)
        {
          DatabaseCommand.CommandString += string.Format("{0},", keyValuePair.Key);
        }

        DatabaseCommand.CommandString = DatabaseCommand.CommandString.Remove(DatabaseCommand.CommandString.Length - 1, 1);
        DatabaseCommand.CommandString += ") values (";

        foreach (var keyValuePair in objects)
        {
          DatabaseCommand.CommandString += string.Format("@{0},", keyValuePair.Key);
        }

        DatabaseCommand.CommandString = DatabaseCommand.CommandString.Remove(DatabaseCommand.CommandString.Length - 1, 1);
        DatabaseCommand.CommandString += ");";
        SetCommand();

        foreach (var keyValuePair in objects)
        {
          DatabaseCommand.AddParameter(keyValuePair.Key.ToString(), keyValuePair.Value);
        }

        DatabaseCommand.Command.ExecuteNonQuery();

        DatabaseCommand.CommandString = "Select @@Identity as id";
        SetCommand();
        
        return Convert.ToInt32(DatabaseCommand.Command.ExecuteScalar());
      }
      catch (SqlException exception)
      {
        new ExceptionHandler(exception);
        throw;
      }
    }
    
    public override bool UpadatSql<T>(IDatabaseObject<T> databaseObject)
    {
      try
      {
        var objects = databaseObject.GetObject();

        DatabaseCommand.CommandString = string.Format("Update {0} set ", GetEscapedTableName(databaseObject.Table));
        DatabaseCommand.CommandString = objects.Aggregate(DatabaseCommand.CommandString, (current, keyValuePair) => current + string.Format("{0} = @{0},", keyValuePair.Key));
        DatabaseCommand.CommandString = DatabaseCommand.CommandString.Remove(DatabaseCommand.CommandString.Length - 1);
        DatabaseCommand.CommandString += string.Format(" where {0} = @{1};", databaseObject.IdentityColumn, "param1");

        SetCommand();

        DatabaseCommand.AddParameter("param1", databaseObject.Identity);

        foreach (var keyValuePair in objects)
        {
          DatabaseCommand.AddParameter(keyValuePair.Key.ToString(), keyValuePair.Value);
        }

        DatabaseCommand.Command.ExecuteNonQuery();
        
        return true;
      }
      catch (SqlException exception)
      {
        new ExceptionHandler(exception);
        throw;
      }
    }
  }
}