using System;
using System.Windows.Forms;

namespace Subvento.DatabaseException
{
  public class ExceptionHandler : Exception
  {
    public ExceptionHandler(Exception exception)
    {
      if (ServiceLocator.Instance.ConfigFile.ExceptionLog)
      {
        DefaultLogger.Instance.WriteToLog(exception.ToString());
      }
      if (ServiceLocator.Instance.ConfigFile.ExceptionMode)
      {
        MessageBox.Show(string.Format("Unhandled Exception{0}{1}{0}", Environment.NewLine, exception), "Exception");
      }
    }
  }
}
