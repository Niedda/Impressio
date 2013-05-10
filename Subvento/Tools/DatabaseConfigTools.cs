using System;
using System.IO;
using System.Xml;
using Subvento.Configuration;

namespace Subvento.Tools
{
  internal static class DatabaseConfigTools
  {
    private static void CheckForConfigFile()
    {
      if (!File.Exists(FilePath))
      {
        using (var xmlWriter = new XmlTextWriter(FilePath, null))
        {
          xmlWriter.WriteStartDocument();
          xmlWriter.WriteStartElement("DatabaseConfig");
          xmlWriter.WriteElementString("DatabaseEngine", "MicrosoftSql");
          xmlWriter.WriteElementString("ConnectionString", "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
          xmlWriter.WriteEndElement();
          xmlWriter.WriteEndDocument();
        }
      }
    }

    internal static void LoadConfig(this DatabaseConfig config)
    {
      CheckForConfigFile();

      using (var xmlReader = new XmlTextReader(FilePath))
      {
        while (xmlReader.Read())
        {
          if (xmlReader.NodeType == XmlNodeType.Element)
          {
            switch (xmlReader.Name)
            {
              case "ConnectionString":
                config.ConnectionString = xmlReader.ReadString();
                break;
              case "DatabaseEngine":
                xmlReader.MoveToContent();
                ServiceLocator.DatabaseEngine value;
                Enum.TryParse(xmlReader.ReadString(), out value);
                config.DatabaseEngine = value;
                break;
            }
          }
        }
      }
    }

    internal static void SaveConfig(this DatabaseConfig config)
    {
      using (var xmlWriter = new XmlTextWriter(FilePath, null))
      {
        xmlWriter.WriteStartDocument();
        xmlWriter.WriteStartElement("DatabaseConfig");
        xmlWriter.WriteElementString("DatabaseEngine", ServiceLocator.Instance.ConfigFile.DatabaseEngine.ToString());
        xmlWriter.WriteElementString("ConnectionString", ServiceLocator.Instance.ConfigFile.ConnectionString);
        xmlWriter.WriteEndElement();
        xmlWriter.WriteEndDocument();
      }
    }

    private static string FilePath
    {
      get
      {
        return AppDomain.CurrentDomain.BaseDirectory + "DatabaseConfig.xml";
      }
    }
  }
}
