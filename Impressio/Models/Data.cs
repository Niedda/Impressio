using System;
using System.Collections.Generic;
using System.Linq;
using Impressio.Controls;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Data Position class for premedia costs
  /// </summary>
  public class Data : Position, IDatabaseObject<Data>
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

    public string IdentityColumn { get { return "DataId"; } }

    public string Table { get { return "Data"; } }

    public override int Identity { get; set; }

    public override string DisplayName { get { return "Datenaufbereitung"; } }

    public override int FkOrder { get; set; }

    public override string Name { get; set; }

    public override int PositionTotal
    {
      get { return DataPositions.Sum(data => data.PositionTotal); }
    }

    public override bool IsPredefined { get; set; }

    public string Remark { get; set; }

    public List<Data> Objects { get { return _datas; } }

    public List<Data> PredefinedObjects
    {
      get { return _predefinedData; }
    }
    
    public List<DataPosition> DataPositions
    {
      get
      {
        return _dataPosition ?? (_dataPosition = new DataPosition().LoadObjectList(DataPosition.Columns.FkDataDataPosition, Identity));
      }
    }

    public override IControl AssignedControl
    {
      get { return new DataControl { Data = new Data { Identity = Identity }, }; }
    }

    public override List<Position> LoadPositions()
    {
      if (FkOrder <= 0)
      {
        throw new InvalidOperationException("Fk Order can not be null");
      }
      return this.LoadObjectList(Columns.FkDataOrder, FkOrder).ConvertAll(conv => (Position)conv);
    }

    public override List<Position> LoadPredefinedPositions()
    {
      return this.LoadObjectList(Columns.IsPredefined, true).ConvertAll(conv => (Position)conv);
    }

    public override void ClearPredefinedObjects()
    {
      _predefinedData.Clear();
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
      
      foreach (var dataPosition in DataPositions)
      {
        dataPosition.Identity = 0;
        dataPosition.FkDataDataPosition = id;
        dataPosition.SaveObject();
      }
      return id;
    }

    public void ClearObjectList()
    {
      _datas.Clear();
    }

    public void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      FkOrder = Database.DatabaseCommand.Reader[Columns.FkDataOrder.ToString()].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.PositionName.ToString()] as string;
      Remark = Database.DatabaseCommand.Reader[Columns.Remark.ToString()] as string;
      IsPredefined = (bool)Database.DatabaseCommand.Reader[Columns.IsPredefined.ToString()];
    }

    public Dictionary<Enum, object> GetObject()
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

    private List<DataPosition> _dataPosition;

    private readonly List<Data> _datas = new List<Data>();

    private readonly List<Data> _predefinedData = new List<Data>();
  }

  /// <summary>
  /// Positions contained by the data class
  /// </summary>
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
      get { return PricePerQuantity * Quantity; }
    }

    public override List<DataPosition> Objects { get { return _dataPositions; } }

    public override void SetObject()
    {
      Description = Database.DatabaseCommand.Reader[Columns.Description.ToString()] as string;
      FkDataDataPosition = Database.DatabaseCommand.Reader[Columns.FkDataDataPosition.ToString()].GetInt();
      Quantity = Database.DatabaseCommand.Reader[Columns.Quantity.ToString()].GetInt();
      PricePerQuantity = Database.DatabaseCommand.Reader[Columns.PricePerQuantity.ToString()].GetInt();
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
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