using System.Collections.Generic;

namespace Impressio.Models
{
  /// <summary>
  /// Interface for Positios containing predefined postions
  /// </summary>
  /// <typeparam name="T">Positon type</typeparam>
  public interface IPredefined<T>
  {
    List<T> PredefinedObjects { get; }

    void LoadPredefined();

    void ClearPredefinedObjects();
  }
}