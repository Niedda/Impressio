using System.Collections.Generic;
using System.Data.Common;

namespace Subvento.Database
{
  public interface IDatabaseCommand
  {
    DbCommand Command { get; set; }

    DbDataReader Reader { get; set; }

    string CommandString { get; set; }

    void CloseReader();
    
    void AddParameter(string parameter, object value);

    void AddParameter(Dictionary<string, object> paramterList);
  }
}
