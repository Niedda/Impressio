using Subvento.Tools;

namespace Subvento.Configuration
{
  public class DatabaseConfig : IDatabaseConfig
  {
    internal DatabaseConfig()
    {
      this.LoadConfig();
    }

    public ServiceLocator.DatabaseEngine DatabaseEngine { get; internal set; }

    public string ConnectionString { get; internal set; }

    public void SetDatabaseEngine(ServiceLocator.DatabaseEngine dbEngine)
    {
      DatabaseEngine = dbEngine;
      this.SaveConfig();
    }

    public bool SetConnectionString(string connectionString)
    {
      if (!string.IsNullOrEmpty(connectionString))
      {
        ConnectionString = connectionString;
        this.SaveConfig();
        return true;
      }
      return false;
    }
  }
}