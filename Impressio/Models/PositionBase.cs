using System.Collections.Generic;
using Impressio.Controls;
using Subvento;
using Subvento.Database;

namespace Impressio.Models
{
  /// <summary>
  /// Abstract class for Positions
  /// </summary>
  public abstract class PositionBase : IPosition
  {
    public abstract int Identity { get; set; }

    public abstract string Name { get; set; }

    public abstract string DisplayName { get; set; }

    public abstract int FkOrder { get; set; }

    public abstract int PositionTotal { get; set; }

    public abstract bool IsPredefined { get; set; }

    public abstract int CostPerK { get; set; }

    public abstract IControl AssignedControl { get; }

    public IDatabase Database { get { return ServiceLocator.Instance.Database; } }

    public abstract List<Position> LoadPositions();

    public abstract List<Position> LoadPredefinedPositions();

    public abstract void ClearPredefinedObjects();

    public abstract void ClearObjects();

    public abstract void DeletePosition();

    public abstract int SavePosition();

    public abstract int CopyPosition(int orderId);
  }
}
