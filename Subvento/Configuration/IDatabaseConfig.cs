namespace Subvento.Configuration
{
  public interface IDatabaseConfig
  {
    ServiceLocator.DatabaseEngine DatabaseEngine { get; }

    string ConnectionString { get; }

    void SetDatabaseEngine(ServiceLocator.DatabaseEngine dbEngine);

    bool SetConnectionString(string connectionString);
  }
}
