using System;
using System.Collections.Generic;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

namespace Impressio.Models
{
  public class Offset : DatabaseObjectBase<Offset>, IPosition, IPredefined<Offset>
  {
    #region Columns enum

    public enum Columns
    {
      FkOffsetOrder,
      FkOffsetPaper,
      FkOffsetMachine,
      PaperPricePer,
      PaperAddition,
      PaperQuantity,
      PaperUsePer,
      PositionName,
      PrintQuantity,
      PrintType,
      ColorAmount,
      OffsetQuantity,
      PositionTotal,
      IsPredefined,
    }

    #endregion

    private readonly Machine _machine = new Machine();

    private readonly List<Offset> _offsets = new List<Offset>();
    private readonly Paper _paper = new Paper();
    private readonly List<Offset> _predefinedOffset = new List<Offset>();
    private int _positionTotal;

    public int PaperPricePer { get; set; }

    public int PaperAddition { get; set; }

    public int PaperQuantity { get; set; }

    public int PaperUsePer { get; set; }

    public int PrintType { get; set; }

    public string PrintTypeString
    {
      get
      {
        switch (PrintType)
        {
          case 0:
            return "Einseitig";
          case 1:
            return "Umschlagen";
          case 2:
            return "Umstülpen";
          case 3:
            return "SD/WD";
          default:
            return "";
        }
      }
    }

    public int ColorAmount { get; set; }

    public int OffsetQuantity { get; set; }

    public int PrintQuantity { get; set; }

    public bool IsPredefined { get; set; }

    public override string IdentityColumn
    {
      get { return "OffsetId"; }
    }

    public override string Table
    {
      get { return "Offset"; }
    }

    public int FkOffsetPaper { get; set; }

    public Paper Paper
    {
      get
      {
        if (FkOffsetPaper != 0)
        {
          _paper.Identity = FkOffsetPaper;
          return (Paper) _paper.LoadSingleObject();
        }
        return new Paper();
      }
    }

    public int FkOffsetMachine { get; set; }

    public Machine Machine
    {
      get
      {
        if (FkOffsetMachine != 0)
        {
          _machine.Identity = FkOffsetMachine;
          return (Machine) _machine.LoadSingleObject();
        }
        return new Machine();
      }
    }

    public int PrintTotal
    {
      get
      {
        if (Machine != null)
        {
          int total;
          if (PrintType == 0)
          {
            total = (OffsetQuantity/Machine.Speed*Machine.PricePerHour) +
                    (ColorAmount*(Machine.PlateCost + Machine.PricePerColor));
          }
          else if (PrintType == 1 || PrintType == 2)
          {
            total = (OffsetQuantity/Machine.Speed*Machine.PricePerHour)*2 +
                    (ColorAmount*(Machine.PlateCost + Machine.PricePerColor));
          }
          else
          {
            total = (OffsetQuantity/Machine.Speed*Machine.PricePerHour)*2 +
                    (ColorAmount*(Machine.PlateCost*2 + Machine.PricePerColor));
          }

          return total;
        }
        return 0;
      }
    }

    public int PaperCostTotal
    {
      get { return (PaperPricePer*(PaperAddition + 100)*(PaperQuantity/1000))/100; }
    }

    public override List<Offset> Objects
    {
      get { return _offsets; }
    }

    #region IPosition Members

    public override int Identity { get; set; }

    public string Name { get; set; }

    public int PositionTotal
    {
      get
      {
        _positionTotal = PrintTotal + PaperCostTotal;
        return _positionTotal;
      }
      set { _positionTotal = value; }
    }

    public int FkOrder { get; set; }

    public Type Type
    {
      get { return Type.Offsetdruck; }
      set { }
    }

    #endregion

    #region IPredefined<Offset> Members

    public void LoadPredefined()
    {
      var offset = new Offset();
      _predefinedOffset.AddRange(offset.LoadObjectList(Columns.IsPredefined, true));
    }

    public List<Offset> PredefinedObjects
    {
      get { return _predefinedOffset; }
    }

    public void ClearPredefinedObjects()
    {
      _predefinedOffset.Clear();
    }

    #endregion

    public override void SetObject()
    {
      Identity = Database.Reader["OffsetId"].GetInt();
      FkOffsetPaper = Database.Reader["FkOffsetPaper"].GetInt();
      FkOffsetMachine = Database.Reader["FkOffsetMachine"].GetInt();
      PaperAddition = Database.Reader["PaperAddition"].GetInt();
      PaperPricePer = Database.Reader["PaperPricePer"].GetInt();
      PaperQuantity = Database.Reader["PaperQuantity"].GetInt();
      PaperUsePer = Database.Reader["PaperUsePer"].GetInt();
      PrintType = Database.Reader["PrintType"].GetInt();
      ColorAmount = Database.Reader["ColorAmount"].GetInt();
      PrintQuantity = Database.Reader["PrintQuantity"].GetInt();
      OffsetQuantity = Database.Reader["OffsetQuantity"].GetInt();
      FkOrder = Database.Reader["FkOffsetOrder"].GetInt();
      Name = Database.Reader["PositionName"] as string;
      PositionTotal = Database.Reader["PositionTotal"].GetInt();
      Type = Type.Offsetdruck;
    }

    public override void SetObjectList()
    {
      var offset = new Offset();
      offset.SetObject();
      _offsets.Add(offset);
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkOffsetOrder, FkOrder.SetIntDbNull()},
                 {Columns.FkOffsetPaper, FkOffsetPaper.SetIntDbNull()},
                 {Columns.FkOffsetMachine, FkOffsetMachine.SetIntDbNull()},
                 {Columns.PaperPricePer, PaperPricePer.SetIntDbNull()},
                 {Columns.PaperAddition, PaperAddition.SetIntDbNull()},
                 {Columns.PaperQuantity, PaperQuantity.SetIntDbNull()},
                 {Columns.PaperUsePer, PaperUsePer.SetIntDbNull()},
                 {Columns.PositionName, Name},
                 {Columns.PrintQuantity, PrintQuantity.SetIntDbNull()},
                 {Columns.PrintType, PrintType.SetIntDbNull()},
                 {Columns.ColorAmount, ColorAmount.SetIntDbNull()},
                 {Columns.OffsetQuantity, OffsetQuantity.SetIntDbNull()},
                 {Columns.PositionTotal, PositionTotal.SetIntDbNull()},
                 {Columns.IsPredefined, IsPredefined},
               };
    }

    public override void ClearObjectList()
    {
      _offsets.Clear();
    }
  }

  public class Machine : DatabaseObjectBase<Machine>
  {
    #region Columns enum

    public enum Columns
    {
      Name,
      PlateCost,
      Speed,
      PricePerColor,
      PricePerHour,
    }

    #endregion

    private readonly List<Machine> _machines = new List<Machine>();

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "MachineId"; }
    }

    public override string Table
    {
      get { return "Machine"; }
    }

    public int PricePerColor { get; set; }

    public int Speed { get; set; }

    public int PricePerHour { get; set; }

    public string Name { get; set; }

    public int PlateCost { get; set; }

    public override List<Machine> Objects
    {
      get { return _machines; }
    }

    public override void SetObject()
    {
      Identity = Database.Reader["MachineId"].GetInt();
      Name = Database.Reader["Name"] as string;
      Speed = Database.Reader["Speed"].GetInt();
      PricePerColor = Database.Reader["PricePerColor"].GetInt();
      PlateCost = Database.Reader["PlateCost"].GetInt();
      PricePerHour = Database.Reader["PricePerHour"].GetInt();
    }

    public override void SetObjectList()
    {
      var machine = new Machine();
      machine.SetObject();
      _machines.Add(machine);
    }

    public override void ClearObjectList()
    {
      _machines.Clear();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.Name, Name},
                 {Columns.PlateCost, PlateCost},
                 {Columns.Speed, Speed},
                 {Columns.PricePerColor, PricePerColor},
                 {Columns.PricePerHour, PricePerHour},
               };
    }
  }
}