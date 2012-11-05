using System.IO;
using System.Xml.Serialization;

namespace Impressio.Models.Database
{
  [XmlRoot("Database")]
  public class DatabaseConfigValue
  {
    public string DatabaseEngine
    {
      get { return _databaseEngine; }
      set { _databaseEngine = value; }
    }

    public string ConnectionString
    {
      get { return _connectionString; }
      set { _connectionString = value; }
    }

    [XmlAttribute("ConnectionString")]
    private string _connectionString;

    [XmlAttribute("DatabaseEngine")]
    private string _databaseEngine;
  }

  public static class DatabaseConfig
  {
    public static DatabaseConfigValue LoadConfig()
    {
      try
      {
        var serializer = new XmlSerializer(typeof(DatabaseConfigValue));
        _fileStream = new FileStream("DatabaseConfig.xml", FileMode.Open);
        return (DatabaseConfigValue)serializer.Deserialize(_fileStream);
      }
      finally
      {
        _fileStream.Close();
      }
    }

    public static void SaveConfig(this DatabaseConfigValue databaseConfig)
    {
      try
      {
        var serializer = new XmlSerializer(typeof(DatabaseConfigValue));
        _fileStream = new FileStream("DatabaseConfig.xml", FileMode.Create);
        serializer.Serialize(_fileStream, databaseConfig);
      }
      finally
      {
        _fileStream.Close();
      }
    }

    private static FileStream _fileStream;
  }
}
