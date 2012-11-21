using System.Collections.Generic;
using System.Data.Common;

namespace Subvento.Database
{
  internal class DatabaseCommand : IDatabaseCommand
  {
    protected internal DatabaseCommand(DbCommand commandType)
    {
      Command = commandType;
    }

    public DbCommand Command { get; set; }

    public DbDataReader Reader { get; set; }

    public string CommandString { get; set; }
    
    public void CloseReader()
    {
      if (Reader == null)
      {
        return;
      }
      if (!Reader.IsClosed)
      {
        Reader.Close();
      }
    }

    public void AddParameter(string parameter, object value)
    {
      if (CommandString.Contains("@" + parameter))
      {
        var dbParameter = Command.CreateParameter();
        dbParameter.Value = value;
        dbParameter.ParameterName = parameter;
        Command.Parameters.Add(dbParameter);
      }
    }

    public void AddParameter(Dictionary<string, object> paramterList)
    {
      foreach (var paramter in paramterList)
      {
        AddParameter(paramter.Key, paramter.Value);
      }
    }
  }
}
