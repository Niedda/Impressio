using System.Collections.Generic;
using Impressio.Controls;

namespace Impressio.Models
{
  /// <summary>
  /// Interface for basic Position operations
  /// </summary>
  public interface IPosition
  {
    int Identity { get; set; }

    string Name { get; set; }

    string DisplayName { get; }

    int FkOrder { get; set; }

    int PositionTotal { get; }

    bool IsPredefined { get; set; }

    IControl AssignedControl { get; }

    List<Position> LoadPositions();

    List<Position> LoadPredefinedPositions();

    void ClearPredefinedObjects();

    void ClearObjects();

    void DeletePosition();

    int SavePosition();

    int CopyPosition(int orderId);
  }
}