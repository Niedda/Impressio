namespace Subvento.Configuration
{
  public interface IDatabaseConfig
  {
    ServiceLocator.DatabaseEngine DatabaseEngine { get; }

    string ConnectionString { get; }

    bool ExceptionMode { get; }

    bool ExceptionLog { get; }

    bool SuppressException { get; }

    void SetDatabaseEngine(ServiceLocator.DatabaseEngine dbEngine);

    bool SetConnectionString(string connectionString);

    void SetExceptionMode(bool showExecptions);

    void SetExceptionLog(bool logExceptions);
  }
}
