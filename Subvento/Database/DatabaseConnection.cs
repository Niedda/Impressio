using System;
using System.Data;
using System.Data.Common;

namespace Subvento.Database
{
  internal class DatabaseConnection : IDatabaseConnection
  {
    public DatabaseConnection(DbConnection connection)
    {
      DbConnection = connection;
    }

    public string ConnectionString
    {
      get
      {
        return _connectionString ?? (_connectionString = ServiceLocator.Instance.ConfigFile.ConnectionString);
      }
    }

    public DbConnection DbConnection
    {
      get
      {
        if (string.IsNullOrEmpty(_dbConnection.ConnectionString))
        {
          _dbConnection.ConnectionString = ConnectionString;
        }
        return _dbConnection;
      }
      set { _dbConnection = value; }
    }

    public bool OpenConnection()
    {
      try
      {
        if (DbConnection.State != ConnectionState.Closed)
        {
          DbConnection.Close();
        }
        DbConnection.Open();
        return true;
      }
      catch (Exception exception)
      {
        ServiceLocator.Instance.ExceptionHandler.LogException(exception);
        return false;
      }
    }

    private DbConnection _dbConnection;

    private string _connectionString;
  }
}
