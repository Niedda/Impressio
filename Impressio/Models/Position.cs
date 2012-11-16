using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class Position : DatabaseObjectBase<Position>, IPredefined<Position>
  {
    #region Columns enum

    public enum Columns
    {
      PositionName,
      PositionTotal,
      IsPredefined,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get
      {
        switch (Type)
        {
          case Type.Datenaufbereitung:
            return "DataId";
          case Type.Offsetdruck:
            return "OffsetId";
          case Type.Digitaldruck:
            return "PrintId";
          case Type.Weiterverarbeitung:
            return "FinishId";
          default:
            return String.Empty;
        }
      }
    }

    public Enum FkOrderColumn
    {
      get
      {
        switch (Type)
        {
          case Type.Datenaufbereitung:
            return Data.Columns.FkDataOrder;
          case Type.Offsetdruck:
            return Offset.Columns.FkOffsetOrder;
          case Type.Digitaldruck:
            return Print.Columns.FkPrintOrder;
          case Type.Weiterverarbeitung:
            return Finish.Columns.FkFinishOrder;
          default:
            throw new Exception("Fehlerhafter Typ");
        }
      }
    }

    public override string Table
    {
      get
      {
        switch (Type)
        {
          case Type.Datenaufbereitung:
            return "Data";
          case Type.Offsetdruck:
            return "Offset";
          case Type.Digitaldruck:
            return "Print";
          case Type.Weiterverarbeitung:
            return "Finish";
          default:
            return String.Empty;
        }
      }
    }

    public string Name { get; set; }

    public int FkOrder { get; set; }

    public int PriceTotal { get; set; }

    public bool IsPredefined { get; set; }

    public Type Type { get; set; }

    public void LoadPositions()
    {
      //TODO find a better solution
      Position position;

      foreach (var predefinedObject in new Data().LoadObjectList(Data.Columns.FkDataOrder, Identity))
      {
        position = new Position
        {
          Identity = predefinedObject.Identity,
          Type = Type.Datenaufbereitung,
          Name = predefinedObject.Name,
          PriceTotal = predefinedObject.PositionTotal,
        };
        _positions.Add(position);
      }

      foreach (var objects in new Offset().LoadObjectList(Offset.Columns.FkOffsetOrder, Identity))
      {
        position = new Position
        {
          Identity = objects.Identity,
          Type = Type.Offsetdruck,
          Name = objects.Name,
          PriceTotal = objects.PositionTotal
        };
        _positions.Add(position);
      }

      foreach (var objects in new Print().LoadObjectList(Print.Columns.FkPrintOrder, Identity))
      {
        position = new Position
        {
          Identity = objects.Identity,
          Type = Type.Digitaldruck,
          Name = objects.Name,
          PriceTotal = objects.PositionTotal
        };
        _positions.Add(position);
      }

      foreach (var predefinedObject in new Finish().LoadObjectList(Finish.Columns.FkFinishOrder, Identity))
      {
        position = new Position
        {
          Identity = predefinedObject.Identity,
          Type = Type.Weiterverarbeitung,
          Name = predefinedObject.Name,
          PriceTotal = predefinedObject.PositionTotal
        };
        _positions.Add(position);
      }
    }

    public override List<Position> Objects { get { return _positions; } }

    public void LoadPredefined()
    {
      //TODO find a better solution
      Position position;

      var data = new Data();
      data.LoadPredefined();
      foreach (var predefinedObject in data.PredefinedObjects)
      {
        position = new Position
        {
          Identity = predefinedObject.Identity,
          Type = Type.Datenaufbereitung,
          Name = predefinedObject.Name,
          PriceTotal = predefinedObject.PositionTotal
        };
        _predefinedPositions.Add(position);
      }

      var offset = new Offset();
      offset.LoadPredefined();
      foreach (var predefinedObject in offset.PredefinedObjects)
      {
        position = new Position
                    {
                      Identity = predefinedObject.Identity,
                      Type = Type.Offsetdruck,
                      Name = predefinedObject.Name,
                      PriceTotal = predefinedObject.PositionTotal
                    };
        _predefinedPositions.Add(position);
      }

      var print = new Print();
      print.LoadPredefined();
      foreach (var predefinedObject in print.PredefinedObjects)
      {
        position = new Position
        {
          Identity = predefinedObject.Identity,
          Type = Type.Digitaldruck,
          Name = predefinedObject.Name,
          PriceTotal = predefinedObject.PositionTotal
        };
        _predefinedPositions.Add(position);
      }

      var finish = new Finish();
      finish.LoadPredefined();
      foreach (var predefinedObject in finish.PredefinedObjects)
      {
        position = new Position
        {
          Identity = predefinedObject.Identity,
          Type = Type.Weiterverarbeitung,
          Name = predefinedObject.Name,
          PriceTotal = predefinedObject.PositionTotal
        };
        _predefinedPositions.Add(position);
      }
    }

    public List<Position> PredefinedObjects { get { return _predefinedPositions; } }

    public void ClearPredefinedObjects()
    {
      _predefinedPositions.Clear();
    }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.PositionName.ToString()] as string;
      PriceTotal = Database.DatabaseCommand.Reader[Columns.PositionTotal.ToString()].GetInt();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      var dic = new Dictionary<Enum, object>
                  {
                    {Columns.PositionName, Name},
                    {Columns.PositionTotal, PriceTotal},
                    {Columns.IsPredefined, IsPredefined},
                  };
      switch (Type)
      {
        case Type.Datenaufbereitung:
          dic.Add(Data.Columns.FkDataOrder, FkOrder.SetIntDbNull());
          break;
        case Type.Offsetdruck:
          dic.Add(Offset.Columns.FkOffsetOrder, FkOrder.SetIntDbNull());
          break;
        case Type.Digitaldruck:
          dic.Add(Print.Columns.FkPrintOrder, FkOrder.SetIntDbNull());
          break;
        case Type.Weiterverarbeitung:
          dic.Add(Finish.Columns.FkFinishOrder, FkOrder.SetIntDbNull());
          break;
      }

      return dic;
    }

    public override void ClearObjectList()
    {
      _positions.Clear();
    }

    private readonly List<Position> _positions = new List<Position>();

    private readonly List<Position> _predefinedPositions = new List<Position>();
  }

  public enum Type
  {
    Datenaufbereitung,
    Digitaldruck,
    Offsetdruck,
    Weiterverarbeitung,
  }
}