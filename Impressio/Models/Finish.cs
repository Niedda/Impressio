using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class Finish : DatabaseObjectBase<Finish>, IPosition, IPredefined<Finish>
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

    public override string IdentityColumn { get { return "FinishId"; } }

    public override string Table { get { return "Finish"; } }

    public override int Identity { get; set; }

    public int FkOrder { get; set; }

    public int PositionTotal { get; set; }

    public string Name { get; set; }

    public string Remark { get; set; }

    public bool IsPredefined { get; set; }

    public override List<Finish> Objects
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

    public Type Type
    {
      get { return Type.Weiterverarbeitung; }
      set { }
    }

    public void LoadPredefined()
    {
      var finish = new Finish();
      _predefinedFinishes.AddRange(finish.LoadObjectList(Columns.IsPredefined, true));
    }

    public List<Finish> PredefinedObjects
    {
      get { return _predefinedFinishes; }
    }

    public void ClearPredefinedObjects()
    {
      ClearObjectList();
    }

    public override void SetObject()
    {
      Identity = Database.Reader[IdentityColumn].GetInt();
      Name = Database.Reader[Columns.PositionName.ToString()] as string;
      FkOrder = Database.Reader[Columns.FkFinishOrder.ToString()].GetInt();
      IsPredefined = (bool)Database.Reader[Columns.IsPredefined.ToString()];
      Remark = Database.Reader[Columns.Remark.ToString()] as string;
      PositionTotal = Database.Reader[Columns.PositionTotal.ToString()].GetInt();
    }
    
    public override void ClearObjectList()
    {
      _finishes.Clear();
    }

    public override Dictionary<Enum, object> GetObject()
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

    public int PriceTotal { get; set; }

    public bool IsPredefined { get; set; }

    public override List<FinishPosition> Objects
    {
      get { return _finishPositions; }
    }

    public override void SetObject()
    {
      Identity = Database.Reader[IdentityColumn].GetInt();
      Description = Database.Reader[Columns.Description.ToString()] as string;
      FkFinishFinishPosition = Database.Reader[Columns.FkFinishFinishPosition.ToString()].GetInt();
      PricePerQuantity = Database.Reader[Columns.PricePerQuantity.ToString()].GetInt();
      PriceTotal = Database.Reader[Columns.PriceTotal.ToString()].GetInt();
      Quantity = Database.Reader[Columns.Quantity.ToString()].GetInt();
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