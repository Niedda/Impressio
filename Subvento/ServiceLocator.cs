using System;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using Npgsql;
using Subvento.Configuration;
using Subvento.Database;

namespace Subvento
{
  public class ServiceLocator
  {
    private ServiceLocator()
    {
      switch (ConfigFile.DatabaseEngine)
      {
        case DatabaseEngine.Microsoft:
          Database = new SqlServerDatabase(new SqlCommand(), new SqlConnection());
          break;
        case DatabaseEngine.Postgres:
          Database = new PostgreSqlDatabase(new NpgsqlCommand(), new NpgsqlConnection());
          break;
        case DatabaseEngine.Compact:
          Database = new SqlCompactDatabase(new SqlCeCommand(), new SqlCeConnection());
          break;
        default:
          throw new NotSupportedException(string.Format("Database {0} is not supported", ConfigFile.DatabaseEngine));
      }
    }

    public IDatabase Database { get; set; }

    public IDatabaseConfig ConfigFile
    {
      get { return _configFile ?? (_configFile = new DatabaseConfig()); }
    }

    public static ServiceLocator Instance
    {
      get { return _instance ?? (_instance = new ServiceLocator()); }
    }

    public static void ResetDatabase()
    {
      _configFile = new DatabaseConfig();
      _instance = new ServiceLocator();
    }

    public enum DatabaseEngine
    {
      Microsoft,
      Postgres,
      Compact,
    }

    private static DatabaseConfig _configFile;

    private static ServiceLocator _instance;
  }
}