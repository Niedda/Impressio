using System.IO;
using System.Windows.Forms;
using Impressio.Properties;

namespace Impressio.Models.Log
{
  public class FileLogger : ILogger
  {
    #region ILogger Members

    public void WriteToLog(string exception)
    {
      string logFileName = Settings.Default.logPath + @"\ImpressioLog.txt";

      if (!File.Exists(logFileName))
      {
        File.Create(logFileName);
      }
      if (!File.GetAttributes(logFileName).HasFlag(FileAttributes.ReadOnly))
      {
        var logWriter = new StreamWriter(logFileName);
        logWriter.WriteLine(exception);
        logWriter.Close();
      }

      //if (Settings.Default.exceptionMode)
      //{
      //  MessageBox.Show(exception, "Fehler bei der Ausführung", MessageBoxButtons.OK, MessageBoxIcon.Warning,
      //                  MessageBoxDefaultButton.Button1);
      //}
    }

    #endregion
  }
}