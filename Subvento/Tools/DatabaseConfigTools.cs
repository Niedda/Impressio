using System;
using System.IO;
using System.Xml;
using Subvento.Configuration;

namespace Subvento.Tools
{
  internal static class DatabaseConfigTools
  {
    internal static bool CheckForConfigFile()
    {
      if (!File.Exists(FilePath))
      {
        using (var xmlWriter = new XmlTextWriter(FilePath, null))
        {
          xmlWriter.WriteStartDocument();
          xmlWriter.WriteStartElement("DatabaseConfig");
          xmlWriter.WriteElementString("DatabaseEngine", "MicrosoftSql");
          xmlWriter.WriteElementString("ConnectionString",
                                       "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
          xmlWriter.WriteElementString("ExceptionMode", "true");
          xmlWriter.WriteElementString("ExceptionLog", "true");
          xmlWriter.WriteElementString("SuppressException", "true");
          xmlWriter.WriteEndElement();
          xmlWriter.WriteEndDocument();
          return false;
        }
      }
      return true;
    }

    internal static void LoadConfig(this DatabaseConfig config)
    {
      if (!CheckForConfigFile()) { return; }

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
              case "ExceptionLog":
                xmlReader.MoveToContent();
                config.ExceptionLog = xmlReader.ReadString() == "true";
                break;
              case "ExceptionMode":
                xmlReader.MoveToContent();
                config.ExceptionMode = xmlReader.ReadString() == "true";
                break;
              case "SuppressException":
                xmlReader.MoveToContent();
                config.SuppressException = xmlReader.ReadString() == "true";
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
        xmlWriter.WriteElementString("ExceptionMode", ServiceLocator.Instance.ConfigFile.ExceptionMode.ToString());
        xmlWriter.WriteElementString("ExceptionLog", ServiceLocator.Instance.ConfigFile.ExceptionLog.ToString());
        xmlWriter.WriteElementString("SuppressException", ServiceLocator.Instance.ConfigFile.SuppressException.ToString());
        xmlWriter.WriteEndElement();
        xmlWriter.WriteEndDocument();
      }
    }

    private const string FilePath = "DatabaseConfig.xml";
  }
}
