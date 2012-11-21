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

    public bool ExceptionMode { get; internal set; }

    public bool ExceptionLog { get; internal set; }

    public bool SuppressException { get; internal set; }

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

    public void SetExceptionMode(bool showExecptions)
    {
      ExceptionMode = showExecptions;
      this.SaveConfig();
    }

    public void SetExceptionLog(bool logExceptions)
    {
      ExceptionLog = logExceptions;
      this.SaveConfig();
    }

    public void SetSuppressException(bool suppress)
    {
      SuppressException = suppress;
      this.SaveConfig();
    }
  }
}