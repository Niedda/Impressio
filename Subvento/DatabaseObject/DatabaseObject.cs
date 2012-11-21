using System;
using System.Collections.Generic;
using System.Data.Common;
using Subvento.Database;
using Subvento.DatabaseException;

namespace Subvento.DatabaseObject
{
  /// <summary>
  /// Provides static methods for dealing with Database Objects - inherit the DatabaseObjectBase Class to use these
  /// </summary>
  public static class DatabaseObject
  {
    /// <summary>Deletes a single object T from the database</summary>
    /// <returns>true if successed</returns>
    public static bool DeleteObject<T>(this IDatabaseObject<T> databaseObject)
    {
      if (databaseObject != null)
      {
        if (databaseObject.Identity != 0)
        {
          DatabaseInstance.DeleteSql(databaseObject);
          return true;
        }
      }
      return false;
    }

    /// <summary>Saves a single object T into the database - if the Identity of the object is set to 0 it will be created otherwise it will be updated</summary>
    /// <returns>The identity of the object</returns>
    public static int SaveObject<T>(this IDatabaseObject<T> databaseObject)
    {
      if (databaseObject != null)
      {
        if (databaseObject.Identity <= 0)
        {
          return DatabaseInstance.InsertSql(databaseObject);
        }
        DatabaseInstance.UpadatSql(databaseObject);
        return databaseObject.Identity;
      }
      return 0;
    }

    /// <summary>Loads a single object T from the database by the identity</summary>
    /// <returns>The loaded object or <c>null</c> if the identity or object is not set</returns>
    public static IDatabaseObject<T> LoadSingleObject<T>(this IDatabaseObject<T> databaseObject) where T : IDatabaseObject<T>, new()
    {
      if (databaseObject == null || databaseObject.Identity == 0) { return null; }

      try
      {
        DatabaseInstance.DatabaseCommand.CommandString = string.Format("select * from {0} where {1} = @{1}", DatabaseInstance.GetEscapedTableName(databaseObject.Table), databaseObject.IdentityColumn);
        DatabaseInstance.SetCommand();
        DatabaseInstance.DatabaseCommand.AddParameter(databaseObject.IdentityColumn, databaseObject.Identity);
        DatabaseInstance.DatabaseCommand.Reader = DatabaseInstance.DatabaseCommand.Command.ExecuteReader();
        DatabaseInstance.DatabaseCommand.Reader.Read();
        databaseObject.SetObject();

        return (T)databaseObject;
      }
      catch (DbException exception)
      {
        new ExceptionHandler(exception);
        throw;
      }
      finally
      {
        DatabaseInstance.DatabaseCommand.CloseReader();
      }
    }

    /// <summary>Load all Objects of the Type from the Database</summary>
    /// <returns>The list of objects loaded or <c>null</c> if the object is not set</returns>
    public static List<T> LoadObjectList<T>(this IDatabaseObject<T> databaseObject) where T : IDatabaseObject<T>, new()
    {
      if (databaseObject == null) { return null; }

      try
      {
        DatabaseInstance.DatabaseCommand.CommandString = string.Format("select * from {0}", DatabaseInstance.GetEscapedTableName(databaseObject.Table));
        DatabaseInstance.SetCommand();
        DatabaseInstance.DatabaseCommand.Reader = DatabaseInstance.DatabaseCommand.Command.ExecuteReader();

        while (DatabaseInstance.DatabaseCommand.Reader.Read())
        {
          var dbObject = new T();
          dbObject.SetObject();
          databaseObject.Objects.Add(dbObject);
        }
        return databaseObject.Objects;
      }
      catch (DbException exception)
      {
        new ExceptionHandler(exception);
        throw;
      }
      finally
      {
        DatabaseInstance.DatabaseCommand.CloseReader();
      }
    }

    /// <summary>Load the top objects of the type from the database</summary>
    /// <param name="maxRows">max rows to select</param>
    /// <param name="desc">by default the rows are ordered desc</param>
    /// <returns>The list of objects loaded or <c>null</c> if the object or maxRows param is not set</returns>
    public static List<T> LoadObjectList<T>(this IDatabaseObject<T> databaseObject, int maxRows, bool desc = true) where T : IDatabaseObject<T>, new()
    {
      if (databaseObject == null || maxRows <= 0) { return null; }

      try
      {
        DatabaseInstance.DatabaseCommand.CommandString = DatabaseInstance.GetTopRows(maxRows, databaseObject.Table, databaseObject.IdentityColumn, desc);
        DatabaseInstance.SetCommand();
        DatabaseInstance.DatabaseCommand.Reader = DatabaseInstance.DatabaseCommand.Command.ExecuteReader();

        while (DatabaseInstance.DatabaseCommand.Reader.Read())
        {
          var dbObject = new T();
          dbObject.SetObject();
          databaseObject.Objects.Add(dbObject);
        }
        return databaseObject.Objects;
      }
      catch (DbException exception)
      {
        new ExceptionHandler(exception);
        throw;
      }
      finally
      {
        DatabaseInstance.DatabaseCommand.CloseReader();
      }
    }

    /// <summary>
    /// Load a list of custom objects by a preseted query
    /// <param name="command">the command to execute</param>
    /// <returns>The list of objects or <c>null</c> if the object or command is not set</returns>
    /// </summary>
    public static List<T> LoadObjectList<T>(this IDatabaseObject<T> databaseObject, DbCommand command) where T : IDatabaseObject<T>, new()
    {
      if (databaseObject == null || command == null) { return null; }

      try
      {
        var result = new List<T>();
        DatabaseInstance.DatabaseCommand.Command = command;
        DatabaseInstance.DatabaseCommand.Reader = DatabaseInstance.DatabaseCommand.Command.ExecuteReader();

        while (DatabaseInstance.DatabaseCommand.Reader.Read())
        {
          var dbObject = new T();
          dbObject.SetObject();
          result.Add(dbObject);
        }
        return result;
      }
      catch (DbException exception)
      {
        new ExceptionHandler(exception);
        throw;
      }
      finally
      {
        DatabaseInstance.DatabaseCommand.CloseReader();
      }
    }

    /// <summary>Load a list of object by a key and value from the database</summary>
    /// <param name="column">The column to compare</param>
    /// <param name="value">The value to compare</param>
    /// <returns>The list of objects or <c>null</c> if the object is not set</returns>
    public static List<T> LoadObjectList<T>(this IDatabaseObject<T> databaseObject, Enum column, object value) where T : IDatabaseObject<T>, new()
    {
      if (databaseObject == null) { return null; }

      try
      {
        DatabaseInstance.DatabaseCommand.CommandString = string.Format("select * from {0} where {1} = @{1}", DatabaseInstance.GetEscapedTableName(databaseObject.Table), column);
        DatabaseInstance.SetCommand();
        DatabaseInstance.DatabaseCommand.AddParameter(column.ToString(), value);
        DatabaseInstance.DatabaseCommand.Reader = DatabaseInstance.DatabaseCommand.Command.ExecuteReader();

        while (DatabaseInstance.DatabaseCommand.Reader.Read())
        {
          var dbObject = new T();
          dbObject.SetObject();
          databaseObject.Objects.Add(dbObject);
        }
        return databaseObject.Objects;
      }
      catch (DbException exception)
      {
        new ExceptionHandler(exception);
        throw;
      }
      finally
      {
        DatabaseInstance.DatabaseCommand.CloseReader();
      }
    }

    private static readonly IDatabase DatabaseInstance = ServiceLocator.Instance.Database;
  }
}