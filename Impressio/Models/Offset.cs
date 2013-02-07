using System;
using System.Collections.Generic;
using Impressio.Controls;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Offset Position for calculating offset prints
  /// </summary>
  public class Offset : Position, IDatabaseObject<Offset>
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

    public override string Name { get; set; }

    public override int PositionTotal
    {
      get { return PrintTotal + PaperCostTotal; }
    }

    public override string DisplayName { get { return "Offsetdruck"; } }

    public override int FkOrder { get; set; }

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

    public override bool IsPredefined { get; set; }

    public string IdentityColumn
    {
      get { return "OffsetId"; }
    }

    public string Table
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
          if (_paper == null || _paper.Identity == FkOffsetPaper)
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
          if (_machine == null || FkOffsetMachine != _machine.Identity)
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

    public List<Offset> Objects
    {
      get
      {
        return _offsets;
      }
    }

    public override IControl AssignedControl
    {
      get { return new OffsetControl { Offset = new Offset { Identity = Identity }, }; }
    }

    public override List<Position> LoadPositions()
    {
      if (FkOrder <= 0)
      {
        throw new InvalidOperationException("Fk Order can not be null");
      }
      return this.LoadObjectList(Columns.FkOffsetOrder, FkOrder).ConvertAll(conv => (Position)conv);
    }

    public override List<Position> LoadPredefinedPositions()
    {
      return this.LoadObjectList(Columns.IsPredefined, true).ConvertAll(conv => (Position)conv);
    }

    public override void ClearPredefinedObjects()
    {
      _offsets.Clear();
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

    public void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      FkOffsetPaper = Database.DatabaseCommand.Reader[Columns.FkOffsetPaper.ToString()].GetInt();
      FkOffsetMachine = Database.DatabaseCommand.Reader[Columns.FkOffsetMachine.ToString()].GetInt();
      PaperAddition = Database.DatabaseCommand.Reader[Columns.PaperAddition.ToString()].GetInt();
      PaperPricePer = Database.DatabaseCommand.Reader[Columns.PaperPricePer.ToString()].GetInt();
      PaperQuantity = Database.DatabaseCommand.Reader[Columns.PaperQuantity.ToString()].GetInt();
      PaperUsePer = Database.DatabaseCommand.Reader[Columns.PaperUsePer.ToString()].GetInt();
      PrintType = Database.DatabaseCommand.Reader[Columns.PrintType.ToString()].GetInt();
      ColorAmount = Database.DatabaseCommand.Reader[Columns.ColorAmount.ToString()].GetInt();
      PrintQuantity = Database.DatabaseCommand.Reader[Columns.PrintQuantity.ToString()].GetInt();
      OffsetQuantity = Database.DatabaseCommand.Reader[Columns.OffsetQuantity.ToString()].GetInt();
      FkOrder = Database.DatabaseCommand.Reader[Columns.FkOffsetOrder.ToString()].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.PositionName.ToString()] as string;
      IsPredefined = (bool)Database.DatabaseCommand.Reader[Columns.IsPredefined.ToString()];
    }

    public Dictionary<Enum, object> GetObject()
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

    public void ClearObjectList()
    {
      _offsets.Clear();
    }

    private Machine _machine;

    private readonly List<Offset> _offsets = new List<Offset>();

    private Paper _paper;

    private readonly List<Offset> _predefinedOffset = new List<Offset>();

    private int _positionTotal;
  }
}