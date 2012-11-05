using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;
using Impressio.Properties;

namespace Impressio.Models.Database
{
  public abstract class Database : IDatabase
  {
    public string ConnectionString
    {
      get { return Settings.Default.connectionString; }
      set
      {
        Settings.Default.connectionString = value;
        Settings.Default.Save();
        DbConnection.Close();
        DbConnection.ConnectionString = Settings.Default.connectionString;
      }
    }

    #region IDatabase Members

    public abstract DbConnection DbConnection { get; }

    public DbCommand Command { get; set; }

    public string CommandString { get; set; }

    public abstract DbCommand SetCommand();

    public DbDataReader Reader { get; set; }

    public abstract string GetEscapedTableName(string tableName);

    public abstract string ConvertValueToSql(object value);

    public abstract string LastAddedValue { get; }

    public void CheckConnection()
    {
      if (DbConnection.State != ConnectionState.Open)
      {
        DbConnection.Open();
      }
    }

    public void CloseReader()
    {
      if (!Reader.IsClosed)
      {
        Reader.Close();
      }
    }

    public abstract int InsertSql(string table, Dictionary<string, string> cols);

    public abstract bool UpdateSql(string table, Dictionary<string, string> cols, string id, string idCol);


    //new Methods

    public virtual void AddParameter(string parameter, object value)
    {
      DbParameter param = Command.CreateParameter();
      param.Value = value;
      param.ParameterName = parameter;
      Command.Parameters.Add(param);
    }

    public virtual int InsertSql<T>(DatabaseObjectBase<T> databaseObject)
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
        CommandString += string.Format("); {0}", LastAddedValue);
        SetCommand();

        foreach (var keyValuePair in objects)
        {
          AddParameter(keyValuePair.Key.ToString(), keyValuePair.Value);
        }
        return Command.ExecuteScalar().GetInt();
      }
      catch (Exception exception)
      {
        ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
        return 0;
      }
    }

    public virtual bool UpadatSql<T>(DatabaseObjectBase<T> databaseObject)
    {
      try
      {
        Dictionary<Enum, object> objects = databaseObject.GetObject();
        CommandString = string.Format("Update {0} set ", GetEscapedTableName(databaseObject.Table));

        foreach (var keyValuePair in objects)
        {
          CommandString += string.Format("{0} = @{0},", keyValuePair.Key);
        }
        CommandString = CommandString.Remove(CommandString.Length - 1);
        CommandString += string.Format(" where {0}Id = @{0}; {1}", databaseObject.Table, LastAddedValue);
        SetCommand();

        AddParameter(databaseObject.Table, databaseObject.Identity);
        foreach (var keyValuePair in objects)
        {
          AddParameter(keyValuePair.Key.ToString(), keyValuePair.Value);
        }
        Command.ExecuteScalar();
        return true;
      }
      catch (Exception exception)
      {
        ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
        return false;
      }
    }

    public virtual bool DeleteSql<T>(DatabaseObjectBase<T> databaseObject)
    {
      try
      {
        CommandString = string.Format("Delete from {0} where {1}Id = @{1}", GetEscapedTableName(databaseObject.Table),
                                      databaseObject.Table);
        SetCommand();
        AddParameter(databaseObject.Table, databaseObject.Identity);
        Command.ExecuteNonQuery();
        return true;
      }
      catch (Exception exception)
      {
        ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
        return false;
      }
    }

    #endregion
  }
}