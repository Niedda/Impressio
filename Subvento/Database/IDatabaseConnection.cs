using System.Data.Common;

namespace Subvento.Database
{
  public interface IDatabaseConnection
  {
    string ConnectionString { get; }
    
    DbConnection DbConnection { get; set; }
    
    bool OpenConnection();

    bool OpenConnection(bool reOpen);
  }
}
