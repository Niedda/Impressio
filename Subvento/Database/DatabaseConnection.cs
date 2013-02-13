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

        if (DbConnection.State == ConnectionState.Open || DbConnection.State == ConnectionState.Connecting ||
            DbConnection.State == ConnectionState.Fetching || DbConnection.State == ConnectionState.Executing)
        {
          return true;
        }
        DbConnection.Open();
        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    public bool OpenConnection(bool reOpen)
    {
      if (reOpen)
      {

        return OpenConnection();
      }
      return OpenConnection();
    }

    private DbConnection _dbConnection;

    private string _connectionString;
  }
}
