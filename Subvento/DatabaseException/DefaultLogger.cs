using System;
using System.IO;

namespace Subvento.DatabaseException
{
  public class DefaultLogger : IExceptionHandler
  {
    private string Filename
    {
      get
      {
        return "SubventoLogFile.txt";
      }
    }

    public void LogException(Exception exception)
    {
      try
      {
        using (var streamWriter = new StreamWriter(Filename))
        {
          streamWriter.Write(string.Format("{0}{1}{2}{1}", DateTime.Now, Environment.NewLine, exception));
        }
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
