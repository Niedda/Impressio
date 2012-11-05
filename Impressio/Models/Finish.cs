using System;
using System.Collections.Generic;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

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

    private readonly FinishPosition _finishPosition = new FinishPosition();

    private readonly List<Finish> _finishes = new List<Finish>();
    private readonly List<Finish> _predefinedFinishes = new List<Finish>();

    public override string IdentityColumn
    {
      get { return "FinishId"; }
    }

    public override string Table
    {
      get { return "Finish"; }
    }

    public string Remark { get; set; }

    public bool IsPredefined { get; set; }

    public override List<Finish> Objects
    {
      get { return _finishes; }
    }

    public List<FinishPosition> FinishPositions
    {
      get { return _finishPosition.LoadObjectList(FinishPosition.Columns.FkFinishFinishPosition, Identity); }
    }

    #region IPosition Members

    public override int Identity { get; set; }

    public int FkOrder { get; set; }

    public int PositionTotal { get; set; }
    public string Name { get; set; }

    public Type Type
    {
      get { return Type.Weiterverarbeitung; }
      set { }
    }

    #endregion

    #region IPredefined<Finish> Members

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

    #endregion

    public override void SetObject()
    {
      Name = Database.Reader["PositionName"] as string;
      FkOrder = Database.Reader["FkFinishOrder"].GetInt();
      IsPredefined = (bool) Database.Reader["IsPredefined"];
      Remark = Database.Reader["Remark"] as string;
      PositionTotal = Database.Reader["PositionTotal"].GetInt();
    }

    public override void SetObjectList()
    {
      var finish = new Finish();
      finish.SetObject();
      _finishes.Add(finish);
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

    private readonly List<FinishPosition> _finishPositions = new List<FinishPosition>();

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

    public int PriceTotal { get; set; }

    public bool IsPredefined { get; set; }

    public override List<FinishPosition> Objects
    {
      get { return _finishPositions; }
    }

    public override void SetObject()
    {
      Description = Database.Reader["Description"] as string;
      FkFinishFinishPosition = Database.Reader["FkFinishFinishPosition"].GetInt();
      Identity = Database.Reader["FinishPositionId"].GetInt();
      IsPredefined = (bool) Database.Reader["IsPredefined"];
      PricePerQuantity = Database.Reader["PricePerQuantity"].GetInt();
      PriceTotal = Database.Reader["PositionTotal"].GetInt();
      Quantity = Database.Reader["Quantity"].GetInt();
    }

    public override void SetObjectList()
    {
      var finishPosition = new FinishPosition();
      finishPosition.SetObject();
      _finishPositions.Add(finishPosition);
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
  }
}