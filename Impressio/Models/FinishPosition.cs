using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{

  /// <summary>
  /// Positions contained by the finish class
  /// </summary>
  public class FinishPosition : DatabaseObjectBase<FinishPosition>
  {
    #region Columns enum

    public enum Columns
    {
      FkFinishFinishPosition,
      Description,
      Quantity,
      PricePerQuantity,
      PriceTotal,
      CostPerK,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "FinishPositionId"; }
    }

    public override string Table
    {
      get { return "FinishPosition"; }
    }

    public int FkFinishFinishPosition { get; set; }

    public string Description { get; set; }

    public int Quantity { get; set; }

    public int PricePerQuantity { get; set; }

    public int PriceTotal
    {
      get { return Quantity*PricePerQuantity; }
    }

    public bool IsPredefined { get; set; }

    public int CostPerK { get; set; }

    public override List<FinishPosition> Objects
    {
      get { return _finishPositions; }
    }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Description = Database.DatabaseCommand.Reader[Columns.Description.ToString()] as string;
      FkFinishFinishPosition = Database.DatabaseCommand.Reader[Columns.FkFinishFinishPosition.ToString()].GetInt();
      PricePerQuantity = Database.DatabaseCommand.Reader[Columns.PricePerQuantity.ToString()].GetInt();
      Quantity = Database.DatabaseCommand.Reader[Columns.Quantity.ToString()].GetInt();
      CostPerK = Database.DatabaseCommand.Reader[Columns.CostPerK.ToString()].GetInt();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
        {
          {Columns.FkFinishFinishPosition, FkFinishFinishPosition},
          {Columns.Description, Description},
          {Columns.PricePerQuantity, PricePerQuantity},
          {Columns.PriceTotal, PriceTotal},
          {Columns.Quantity, Quantity},
          {Columns.CostPerK, CostPerK},
        };
    }

    private readonly List<FinishPosition> _finishPositions = new List<FinishPosition>();
  }
}