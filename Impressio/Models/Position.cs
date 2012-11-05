using System;
using System.Collections.Generic;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

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

    public override List<Position> Objects { get { return _positions; } }

    public void LoadPredefined()
    {
      var position = new Position {Type = Type.Datenaufbereitung};
      _predefinedPositions.AddRange(position.LoadObjectList(Columns.IsPredefined, true));
      position = new Position {Type = Type.Digitaldruck};
      _predefinedPositions.AddRange(position.LoadObjectList(Columns.IsPredefined, true));
      position = new Position {Type = Type.Offsetdruck};
      _predefinedPositions.AddRange(position.LoadObjectList(Columns.IsPredefined, true));
      position = new Position {Type = Type.Weiterverarbeitung};
      _predefinedPositions.AddRange(position.LoadObjectList(Columns.IsPredefined, true));
    }

    public List<Position> PredefinedObjects { get { return _predefinedPositions; } }

    public void ClearPredefinedObjects()
    {
      _predefinedPositions.Clear();
    }

    public override void SetObject()
    {
      Identity = Database.Reader[IdentityColumn].GetInt();
      Name = Database.Reader[Columns.PositionName.ToString()] as string;
      PriceTotal = Database.Reader[Columns.PositionTotal.ToString()].GetInt();
    }

    public override void SetObjectList()
    {
      var position = new Position
                       {
                         Type = Type,
                       };
      position.SetObject();
      _positions.Add(position);
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
          dic.Add(Data.Columns.FkDataOrder, FkOrder);
          break;
        case Type.Offsetdruck:
          dic.Add(Offset.Columns.FkOffsetOrder, FkOrder);
          break;
        case Type.Digitaldruck:
          dic.Add(Print.Columns.FkPrintOrder, FkOrder);
          break;
        case Type.Weiterverarbeitung:
          dic.Add(Finish.Columns.FkFinishOrder, FkOrder);
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