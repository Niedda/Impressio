using System;
using System.Collections.Generic;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

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

    private readonly DataPosition _dataPosition = new DataPosition();
    private readonly List<Data> _datas = new List<Data>();
    private readonly List<Data> _predefinedData = new List<Data>();

    public override string IdentityColumn
    {
      get { return "DataId"; }
    }

    public override string Table
    {
      get { return "Data"; }
    }

    public bool IsPredefined { get; set; }

    public string Remark { get; set; }

    public override List<Data> Objects
    {
      get { return _datas; }
    }

    public List<DataPosition> DataPositions
    {
      get { return _dataPosition.LoadObjectList(DataPosition.Columns.FkDataDataPosition, Identity); }
    }

    #region IPosition Members

    public override int Identity { get; set; }

    public int FkOrder { get; set; }
    public string Name { get; set; }

    public int PositionTotal { get; set; }

    public Type Type
    {
      get { return Type.Datenaufbereitung; }
      set { }
    }

    #endregion

    #region IPredefined<Data> Members

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

    #endregion

    public override void SetObject()
    {
      FkOrder = Database.Reader["FkDataOrder"].GetInt();
      Name = Database.Reader["PositionName"] as string;
      PositionTotal = Database.Reader["PositionTotal"].GetInt();
      Remark = Database.Reader["Remark"] as string;
      IsPredefined = (bool) Database.Reader["IsPredefined"];
    }

    public override void SetObjectList()
    {
      var data = new Data();
      data.SetObject();
      _datas.Add(data);
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkDataOrder, FkOrder.ToString()},
                 {Columns.IsPredefined, IsPredefined.ToString()},
                 {Columns.PositionName, Name},
                 {Columns.PositionTotal, PositionTotal.ToString()},
                 {Columns.Remark, Remark},
               };
    }

    public override void ClearObjectList()
    {
      _datas.Clear();
    }
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
      PositionTotal,
    }

    #endregion

    private readonly List<DataPosition> _dataPositions = new List<DataPosition>();
    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "DataPositionId"; }
    }

    public override string Table
    {
      get { return "DataPosition"; }
    }

    public int Quantity { get; set; }

    public int FkDataDataPosition { get; set; }

    public string Description { get; set; }

    public int PricePerQuantity { get; set; }

    public int PositionTotal
    {
      get { return PricePerQuantity*Quantity; }
    }

    public override List<DataPosition> Objects
    {
      get { return _dataPositions; }
    }

    public override void SetObject()
    {
      Description = Database.Reader["Description"] as string;
      FkDataDataPosition = Database.Reader["FkDataDataPosition"].GetInt();
      Quantity = Database.Reader["Quantity"].GetInt();
      PricePerQuantity = Database.Reader["PricePerQuantity"].GetInt();
      Identity = Database.Reader["DataPositionId"].GetInt();
    }

    public override void SetObjectList()
    {
      var dataPosition = new DataPosition();
      dataPosition.SetObject();
      _dataPositions.Add(dataPosition);
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkDataDataPosition, FkDataDataPosition.ToString()},
                 {Columns.Description, Description},
                 {Columns.Quantity, Quantity.ToString()},
                 {Columns.PricePerQuantity, PricePerQuantity.ToString()},
                 {Columns.PositionTotal, PositionTotal.ToString()},
               };
    }

    public override void ClearObjectList()
    {
      _dataPositions.Clear();
    }
  }
}