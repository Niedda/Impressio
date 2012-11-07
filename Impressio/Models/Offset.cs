using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

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
          if(_paper == null || _paper.Identity == FkOffsetPaper)
          {
            return (_paper = (Paper)new Paper { Identity = FkOffsetPaper, }.LoadSingleObject());
          }
          return _paper;
        }
        return null;
      }
    }

    public int FkOffsetMachine { get; set; }

    public Machine Machine
    {
      get
      {
        if (FkOffsetMachine != 0)
        {
          if(_machine == null || FkOffsetMachine != _machine.Identity)
          {
            return (_machine = (Machine)new Machine { Identity = FkOffsetMachine }.LoadSingleObject());
          }
          return _machine;
        }
        return null;
      }
    }

    public int PrintTotal
    {
      get
      {
        if (Machine != null)
        {
          int total;

          var quantity = (decimal)OffsetQuantity / Machine.Speed * Machine.PricePerHour;

          if (PrintType == 0)
          {
            var color = (decimal)ColorAmount * (Machine.PlateCost + Machine.PricePerColor);
            total = (int)(quantity + color);
            total = (OffsetQuantity / Machine.Speed * Machine.PricePerHour) +
                    (ColorAmount * (Machine.PlateCost + Machine.PricePerColor));
          }
          else if (PrintType == 1 || PrintType == 2)
          {
            var color = (decimal)ColorAmount * (Machine.PlateCost + Machine.PricePerColor);
            total = (int)(2 * quantity + color);
          }
          else
          {
            var color = (decimal)ColorAmount * (Machine.PlateCost * 2 + Machine.PricePerColor);
            total = (int)(2 * quantity + color);
          }

          return total;
        }
        return 0;
      }
    }

    public int PaperCostTotal
    {
      get
      {
        var additon = (decimal)PaperAddition / 100 + 1;
        var quantity = (decimal)PaperQuantity / 1000;
        return (int)(PaperPricePer * quantity * additon);
      }
    }

    public override List<Offset> Objects
    {
      get
      {
        return _offsets;
      }
    }

    public Type Type
    {
      get { return Type.Offsetdruck; }
      set { }
    }

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

    public override void SetObject()
    {
      Identity = Database.Reader[IdentityColumn].GetInt();
      FkOffsetPaper = Database.Reader[Columns.FkOffsetPaper.ToString()].GetInt();
      FkOffsetMachine = Database.Reader[Columns.FkOffsetMachine.ToString()].GetInt();
      PaperAddition = Database.Reader[Columns.PaperAddition.ToString()].GetInt();
      PaperPricePer = Database.Reader[Columns.PaperPricePer.ToString()].GetInt();
      PaperQuantity = Database.Reader[Columns.PaperQuantity.ToString()].GetInt();
      PaperUsePer = Database.Reader[Columns.PaperUsePer.ToString()].GetInt();
      PrintType = Database.Reader[Columns.PrintType.ToString()].GetInt();
      ColorAmount = Database.Reader[Columns.ColorAmount.ToString()].GetInt();
      PrintQuantity = Database.Reader[Columns.PrintQuantity.ToString()].GetInt();
      OffsetQuantity = Database.Reader[Columns.OffsetQuantity.ToString()].GetInt();
      FkOrder = Database.Reader[Columns.FkOffsetOrder.ToString()].GetInt();
      Name = Database.Reader[Columns.PositionName.ToString()] as string;
      PositionTotal = Database.Reader[Columns.PositionTotal.ToString()].GetInt();
      IsPredefined = (bool) Database.Reader[Columns.IsPredefined.ToString()];
      Type = Type.Offsetdruck;
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

    private Machine _machine;

    private readonly List<Offset> _offsets = new List<Offset>();

    private Paper _paper;

    private readonly List<Offset> _predefinedOffset = new List<Offset>();

    private int _positionTotal;
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

    public override string IdentityColumn { get { return "MachineId"; } }

    public override string Table { get { return "Machine"; } }

    public int PricePerColor { get; set; }

    public int Speed { get; set; }

    public int PricePerHour { get; set; }

    public string Name { get; set; }

    public int PlateCost { get; set; }

    public override List<Machine> Objects { get { return _machines; } }

    public override void SetObject()
    {
      Identity = Database.Reader[IdentityColumn].GetInt();
      Name = Database.Reader[Columns.Name.ToString()] as string;
      Speed = Database.Reader[Columns.Speed.ToString()].GetInt();
      PricePerColor = Database.Reader[Columns.PricePerColor.ToString()].GetInt();
      PlateCost = Database.Reader[Columns.PlateCost.ToString()].GetInt();
      PricePerHour = Database.Reader[Columns.PricePerHour.ToString()].GetInt();
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