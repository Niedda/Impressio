using Impressio.Models.Database;
using Impressio.Models.Log;
using Impressio.Properties;

namespace Impressio.Models
{
  public class ServiceLocator
  {
    private static ServiceLocator _instance;

    public ServiceLocator()
    {
      switch (Settings.Default.databaseEngine)
      {
        case "mssql":
          Database = new SqlServerDatabase();
          break;
        case "posql":
          Database = new PostgreSqlDatabase();
          break;
        case "compact":
          Database = new SqlCompactDatabase();
          break;
      }

      switch (Settings.Default.loggerEngine)
      {
        case "file":
          Logger = new FileLogger();
          break;
        case "database":
          Logger = new DatabaseLogger();
          break;
      }
    }

    public ILogger Logger { get; set; }
    public IDatabase Database { get; set; }

    public static ServiceLocator Instance
    {
      get { return _instance ?? (_instance = new ServiceLocator()); }
    }

    public bool Usable()
    {
      return Logger != null && Database != null;
    }
  }
}