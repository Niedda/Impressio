using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class Data : DatabaseObjectBase<Data>, IPosition, IPredefined<Data>
  {
    #region Columns enum

    public enum Columns
    {
      FkDataOrder,
      IsPredefined,
      PositionName,
      PositionTotal,
      Remark,
    }

    #endregion

    public override string IdentityColumn { get { return "DataId"; } }

    public override string Table { get { return "Data"; } }

    public override int Identity { get; set; }

    public int FkOrder { get; set; }

    public string Name { get; set; }

    public int PositionTotal { get; set; }

    public bool IsPredefined { get; set; }

    public string Remark { get; set; }

    public override List<Data> Objects { get { return _datas; } }

    public List<DataPosition> DataPositions
    {
      get
      {
        return _dataPosition ?? (_dataPosition = new DataPosition().LoadObjectList(DataPosition.Columns.FkDataDataPosition, Identity));
      }
    }
    
    public Type Type
    {
      get { return Type.Datenaufbereitung; }
      set { }
    }

    public void LoadPredefined()
    {
      var data = new Data();
      _predefinedData.AddRange(data.LoadObjectList(Columns.IsPredefined, true));
    }

    public List<Data> PredefinedObjects
    {
      get { return _predefinedData; }
    }

    public void ClearPredefinedObjects()
    {
      _predefinedData.Clear();
    }

    public override void SetObject()
    {
      Identity = Database.Reader[IdentityColumn].GetInt();
      FkOrder = Database.Reader[Columns.FkDataOrder.ToString()].GetInt();
      Name = Database.Reader[Columns.PositionName.ToString()] as string;
      PositionTotal = Database.Reader[Columns.PositionTotal.ToString()].GetInt();
      Remark = Database.Reader[Columns.Remark.ToString()] as string;
      IsPredefined = (bool) Database.Reader[Columns.IsPredefined.ToString()];
    }
    
    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkDataOrder, FkOrder.SetIntDbNull()},
                 {Columns.IsPredefined, IsPredefined},
                 {Columns.PositionName, Name},
                 {Columns.PositionTotal, PositionTotal},
                 {Columns.Remark, Remark.SetStringDbNull()},
               };
    }

    public override void ClearObjectList()
    {
      _datas.Clear();
    }

    private List<DataPosition> _dataPosition;

    private readonly List<Data> _datas = new List<Data>();

    private readonly List<Data> _predefinedData = new List<Data>();
  }

  public class DataPosition : DatabaseObjectBase<DataPosition>
  {
    #region Columns enum

    public enum Columns
    {
      FkDataDataPosition,
      Description,
      Quantity,
      PricePerQuantity,
      PriceTotal,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "DataPositionId"; } }

    public override string Table { get { return "DataPosition"; } }

    public int Quantity { get; set; }

    public int FkDataDataPosition { get; set; }

    public string Description { get; set; }

    public int PricePerQuantity { get; set; }

    public int PositionTotal 
    {
      get { return PricePerQuantity*Quantity; }
    }

    public override List<DataPosition> Objects { get { return _dataPositions; } }

    public override void SetObject()
    {
      Description = Database.Reader[Columns.Description.ToString()] as string;
      FkDataDataPosition = Database.Reader[Columns.FkDataDataPosition.ToString()].GetInt();
      Quantity = Database.Reader[Columns.Quantity.ToString()].GetInt();
      PricePerQuantity = Database.Reader[Columns.PricePerQuantity.ToString()].GetInt();
      Identity = Database.Reader[IdentityColumn].GetInt();
    }
    
    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkDataDataPosition, FkDataDataPosition.ToString()},
                 {Columns.Description, Description},
                 {Columns.Quantity, Quantity.ToString()},
                 {Columns.PricePerQuantity, PricePerQuantity.ToString()},
                 {Columns.PriceTotal, PositionTotal.ToString()},
               };
    }

    public override void ClearObjectList()
    {
      _dataPositions.Clear();
    }

    private readonly List<DataPosition> _dataPositions = new List<DataPosition>();
  }
}