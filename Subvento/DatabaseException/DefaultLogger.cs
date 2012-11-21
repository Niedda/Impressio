using System;
using System.IO;

namespace Subvento.DatabaseException
{
  public class DefaultLogger
  {
    private DefaultLogger()
    { }

    public static DefaultLogger Instance
    {
      get { return _instance ?? (_instance = new DefaultLogger()); }
    }

    private static DefaultLogger _instance;

    private const string Filename = "SubventoLogFile.txt";

    public virtual void WriteToLog(string message)
    {
      using (var streamWriter = new StreamWriter(Filename))
      {
        streamWriter.Write(string.Format("{0}{1}{2}{1}", DateTime.Now, Environment.NewLine, message));
      }
    }
  }
}
