namespace Impressio.Models.Log
{
  public interface ILogger
  {
    void WriteToLog(string exception);
  }
}