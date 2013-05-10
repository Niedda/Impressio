using System;

namespace Subvento.DatabaseException
{
  public interface IExceptionHandler
  {
    void LogException(Exception exception);
  }
}
