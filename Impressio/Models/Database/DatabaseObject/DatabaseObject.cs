using System;
using System.Collections.Generic;

namespace Impressio.Models.Database.DatabaseObject
{
  /// <summary>
  /// Provides static methods for dealing with DatabaseObjects implement the DatabaseObjectBase Class to use these
  /// </summary>
  public static class DatabaseObject
  {
    public static readonly IDatabase DatabaseInstance = ServiceLocator.Instance.Database;

    /// <summary>Saves a Single Object T into the Database - if the Identity of the Object is set to 0 it will be created</summary>
    /// <returns>true if successful</returns>
    public static bool DeleteObject<T>(this DatabaseObjectBase<T> databaseObject)
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

    /// <summary>Saves a Single Object T into the Database - if the Identity of the Object is set to 0 it will be created</summary>
    /// <returns>The Identity of the Object</returns>
    public static int SaveObject<T>(this DatabaseObjectBase<T> databaseObject)
    {
      if (databaseObject != null)
      {
        if (databaseObject.Identity == 0)
        {
          return DatabaseInstance.InsertSql(databaseObject);
        }
        DatabaseInstance.UpadatSql(databaseObject);
        return databaseObject.Identity;
      }
      return 0;
    }

    /// <summary>Loads a Single Object T from the Database by the ObjectId</summary>
    /// <returns>The loaded Object</returns>
    public static DatabaseObjectBase<T> LoadSingleObject<T>(this DatabaseObjectBase<T> databaseObject)
    {
      if (databaseObject != null)
      {
        try
        {
          DatabaseInstance.CheckConnection();
          DatabaseInstance.CommandString =
            DatabaseInstance.CommandString =
            string.Format("select * from {0} where {1} = @{1}", databaseObject.Table, databaseObject.IdentityColumn);
          DatabaseInstance.SetCommand();
          DatabaseInstance.AddParameter(databaseObject.IdentityColumn, databaseObject.Identity);
          DatabaseInstance.Reader = DatabaseInstance.Command.ExecuteReader();
          DatabaseInstance.Reader.Read();
          databaseObject.SetObject();

          return databaseObject;
        }
        catch (Exception exception)
        {
          ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
          return null;
        }
        finally
        {
          DatabaseInstance.Reader.Close();
        }
      }
      return null;
    }

    /// <summary>Load all Objects of the Type from the Database</summary>
    /// <returns>The List of Objects loaded</returns>
    public static List<T> LoadObjectList<T>(this DatabaseObjectBase<T> databaseObject)
    {
      if (databaseObject != null)
      {
        try
        {
          DatabaseInstance.CheckConnection();
          DatabaseInstance.CommandString = string.Format("select * from {0}",
                                                         DatabaseInstance.GetEscapedTableName(databaseObject.Table));
          DatabaseInstance.Reader = DatabaseInstance.SetCommand().ExecuteReader();

          while (DatabaseInstance.Reader.Read())
          {
            databaseObject.SetObjectList();
          }
          return databaseObject.Objects;
        }
        catch (Exception exception)
        {
          ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
          return new List<T>();
        }
        finally
        {
          DatabaseInstance.Reader.Close();
        }
      }
      return new List<T>();
    }


    /// <summary>Load a List of Object by a Key and Value from the Database</summary>
    /// <returns>The List of Objects loaded</returns>
    public static List<T> LoadObjectList<T>(this DatabaseObjectBase<T> databaseObject, Enum column, object value)
    {
      if (databaseObject != null)
      {
        try
        {
          DatabaseInstance.CheckConnection();
          DatabaseInstance.CommandString = string.Format("select * from {0} where {1} = @{1}",
                                                         DatabaseInstance.GetEscapedTableName(databaseObject.Table),
                                                         column);
          DatabaseInstance.SetCommand();
          DatabaseInstance.AddParameter(column.ToString(), value);
          DatabaseInstance.Reader = DatabaseInstance.Command.ExecuteReader();

          while (DatabaseInstance.Reader.Read())
          {
            databaseObject.SetObjectList();
          }
          return databaseObject.Objects;
        }
        catch (Exception exception)
        {
          ServiceLocator.Instance.Logger.WriteToLog(exception.ToString());
          return new List<T>();
        }
        finally
        {
          DatabaseInstance.Reader.Close();
        }
      }
      return new List<T>();
    }
  }
}