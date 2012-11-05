using System;

namespace Impressio.Models.Log
{
  public class DatabaseLogger : ILogger
  {
    #region ILogger Members

    public void WriteToLog(string exception)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}