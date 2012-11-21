using System.Data;
using System.Data.Common;
using Subvento.DatabaseException;

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
      if (DbConnection.State == ConnectionState.Open || DbConnection.State == ConnectionState.Connecting || DbConnection.State == ConnectionState.Fetching || DbConnection.State == ConnectionState.Executing)
      {
        return true;
      }

      try
      {
        DbConnection.Open();
        return true;
      }
      catch (DbException exception)
      {
        new ExceptionHandler(exception);
        throw;
      }
    }

    public bool OpenConnection(bool reOpen)
    {
      if (reOpen == false)
      {
        return OpenConnection();
      }
      DbConnection.Close();
      return OpenConnection();
    }

    private DbConnection _dbConnection;

    private string _connectionString;
  }
}
