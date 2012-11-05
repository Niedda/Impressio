using System.Collections.Generic;

namespace Impressio.Models
{
  public interface IPredefined<T>
  {
    List<T> PredefinedObjects { get; }
    void LoadPredefined();

    void ClearPredefinedObjects();
  }
}