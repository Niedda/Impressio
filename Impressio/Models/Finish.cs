using System;
using System.Collections.Generic;
using System.Linq;
using Impressio.Controls;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Finish position for postprint costs
  /// </summary>
  public class Finish : Position, IDatabaseObject<Finish>
  {
    #region Columns enum

    public enum Columns
    {
      FkFinishOrder,
      PositionName,
      PositionTotal,
      Remark,
      IsPredefined,
    }

    #endregion

    public string IdentityColumn { get { return "FinishId"; } }

    public string Table { get { return "Finish"; } }

    public override int Identity { get; set; }

    public override string DisplayName { get { return "Weiterverarbeitung"; } }

    public override int FkOrder { get; set; }

    public override int PositionTotal { get { return FinishPositions.Sum(data => data.PriceTotal); } }

    public override string Name { get; set; }

    public string Remark { get; set; }

    public override bool IsPredefined { get; set; }

    public List<Finish> Objects
    {
      get { return _finishes; }
    }

    public List<FinishPosition> FinishPositions
    {
      get
      {
        return _finishPosition ?? (_finishPosition = new FinishPosition().LoadObjectList(FinishPosition.Columns.FkFinishFinishPosition, Identity));
      }
    }

    public override IControl AssignedControl
    {
      get { return new FinishControl { Finish = new Finish { Identity = Identity }, }; }
    }

    public override List<Position> LoadPositions()
    {
      if (FkOrder <= 0)
      {
        throw new InvalidOperationException("Fk Order can not be null");
      }
      return this.LoadObjectList(Columns.FkFinishOrder, FkOrder).ConvertAll(conv => (Position)conv);
    }

    public override List<Position> LoadPredefinedPositions()
    {
      return this.LoadObjectList(Columns.IsPredefined, true).ConvertAll(conv => (Position)conv);
    }

    public override void ClearPredefinedObjects()
    {
      _predefinedFinishes.Clear();
    }

    public override void ClearObjects()
    {
      ClearObjectList();
    }

    public override void DeletePosition()
    {
      this.DeleteObject();
    }

    public override int SavePosition()
    {
      return this.SaveObject();
    }

    public override int CopyPosition(int orderId)
    {
      this.LoadSingleObject();
      var id = base.CopyPosition(FkOrder);

      foreach (var dataPosition in FinishPositions)
      {
        dataPosition.Identity = 0;
        dataPosition.FkFinishFinishPosition = id;
        dataPosition.SaveObject();
      }
      return id;
    }

    public void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.PositionName.ToString()] as string;
      FkOrder = Database.DatabaseCommand.Reader[Columns.FkFinishOrder.ToString()].GetInt();
      IsPredefined = (bool)Database.DatabaseCommand.Reader[Columns.IsPredefined.ToString()];
      Remark = Database.DatabaseCommand.Reader[Columns.Remark.ToString()] as string;
    }

    public void ClearObjectList()
    {
      _finishes.Clear();
    }

    public Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkFinishOrder, FkOrder.SetIntDbNull()},
                 {Columns.Remark, Remark.SetStringDbNull()},
                 {Columns.PositionTotal, PositionTotal},
                 {Columns.PositionName, Name},
                 {Columns.IsPredefined, IsPredefined},
               };
    }

    private List<FinishPosition> _finishPosition;

    private readonly List<Finish> _finishes = new List<Finish>();

    private readonly List<Finish> _predefinedFinishes = new List<Finish>();
  }

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
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "FinishPositionId"; } }

    public override string Table { get { return "FinishPosition"; } }

    public int FkFinishFinishPosition { get; set; }

    public string Description { get; set; }

    public int Quantity { get; set; }

    public int PricePerQuantity { get; set; }

    public int PriceTotal { get { return Quantity * PricePerQuantity; } }

    public bool IsPredefined { get; set; }

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
               };
    }

    private readonly List<FinishPosition> _finishPositions = new List<FinishPosition>();
  }
}