using System;
using System.Collections.Generic;
using Impressio.Controls;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Print position for calculating digital printing jobs
  /// </summary>
  public class Print : Position, IDatabaseObject<Print>
  {
    #region Columns enum

    public enum Columns
    {
      FkPrintOrder,
      FkPrintPaper,
      FkPrintClickCost,
      PaperAmount,
      PaperAddition,
      PaperUsePer,
      PrintAmount,
      PositionTotal,
      IsPredefined,
      PositionName,
      PaperPrice,
      PrintType,
    }

    #endregion

    public string IdentityColumn { get { return "PrintId"; } }

    public string Table { get { return "Print"; } }

    public override int Identity { get; set; }

    public int FkPrintPaper { get; set; }

    public Paper Paper
    {
      get
      {
        if (FkPrintPaper != 0)
        {
          if (_paper == null || _paper.Identity != FkPrintPaper)
          {
            return (_paper = (Paper)new Paper { Identity = FkPrintPaper }.LoadSingleObject());
          }
          return _paper;
        }
        return null;
      }
    }

    public int FkPrintClickCost { get; set; }

    public ClickCost ClickCost
    {
      get
      {
        if (FkPrintClickCost != 0)
        {
          if (_clickCost == null || _clickCost.Identity != FkPrintClickCost)
          {
            return (_clickCost = (ClickCost)new ClickCost { Identity = FkPrintClickCost }.LoadSingleObject());
          }
          return _clickCost;
        }
        return null;
      }
    }

    public int PrintType
    {
      get
      {
        switch (PrintTypeString)
        {
          case "Einseitig":
            return 0;
          case "Zweiseitig":
            return 1;
          default:
            return 0;
        }
      }
      set
      {
        PrintTypeString = value == 0 ? "Einseitig" : "Zweiseitig";
      }
    }

    public string PrintTypeString { get; set; }

    public int PrintAmount { get; set; }

    public int PaperAmount { get; set; }

    public int PaperAddition { get; set; }

    public int PaperPricePer { get; set; }

    public int PaperUsePer { get; set; }

    public override bool IsPredefined { get; set; }

    public override string Name { get; set; }

    public override string DisplayName { get { return "Digitaldruck"; } }

    public override int FkOrder { get; set; }

    public decimal PaperCostTotal
    {
      get
      {
        var paperPrice = ((decimal)PaperPricePer / 1000);
        var addition = (decimal)PaperAddition / 100 + 1;
        return PaperAmount * addition * paperPrice;
      }
    }

    public decimal PrintCostTotal
    {
      get
      {
        decimal total = 0;

        if (ClickCost != null)
        {
          total = (decimal)ClickCost.Cost * PrintAmount;

          if (PrintType == 1)
          {
            return Math.Round(total * 2, 1);
          }
        }
        return Math.Round(total, 1);
      }
    }

    public override int PositionTotal
    {
      get
      {
        return (int)Math.Round(PrintCostTotal + PaperCostTotal, 0);
      }
    }

    public override IControl AssignedControl
    {
      get { return new PrintControl { Print = new Print { Identity = Identity }, }; }
    }

    public override List<Position> LoadPositions()
    {
      if (FkOrder <= 0)
      {
        throw new InvalidOperationException("Fk Order can not be null");
      }
      return this.LoadObjectList(Columns.FkPrintOrder, FkOrder).ConvertAll(conv => (Position)conv);
    }

    public override List<Position> LoadPredefinedPositions()
    {
      return this.LoadObjectList(Columns.IsPredefined, true).ConvertAll(conv => (Position)conv);
    }

    public override void ClearPredefinedObjects()
    {
      _predefinedPrints.Clear();
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

    public List<Print> Objects { get { return _prints; } }

    public void SetObject()
    {
      IsPredefined = (bool)Database.DatabaseCommand.Reader[Columns.IsPredefined.ToString()];
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      FkPrintClickCost = Database.DatabaseCommand.Reader[Columns.FkPrintClickCost.ToString()].GetInt();
      FkOrder = Database.DatabaseCommand.Reader[Columns.FkPrintOrder.ToString()].GetInt();
      FkPrintPaper = Database.DatabaseCommand.Reader[Columns.FkPrintPaper.ToString()].GetInt();
      PrintAmount = Database.DatabaseCommand.Reader[Columns.PrintAmount.ToString()].GetInt();
      PaperUsePer = Database.DatabaseCommand.Reader[Columns.PaperUsePer.ToString()].GetInt();
      PaperAddition = Database.DatabaseCommand.Reader[Columns.PaperAddition.ToString()].GetInt();
      PaperAmount = Database.DatabaseCommand.Reader[Columns.PaperAmount.ToString()].GetInt();
      PaperPricePer = Database.DatabaseCommand.Reader[Columns.PaperPrice.ToString()].GetInt();
      PrintType = Database.DatabaseCommand.Reader[Columns.PrintType.ToString()].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.PositionName.ToString()] as string;
    }

    public Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkPrintOrder, FkOrder.SetIntDbNull()},
                 {Columns.FkPrintPaper, FkPrintPaper.SetIntDbNull()},
                 {Columns.FkPrintClickCost, FkPrintClickCost.SetIntDbNull()},
                 {Columns.PaperAmount, PaperAmount.SetIntDbNull()},
                 {Columns.PaperAddition, PaperAddition.SetIntDbNull()},
                 {Columns.PaperUsePer, PaperUsePer.SetIntDbNull()},
                 {Columns.PrintAmount, PrintAmount.SetIntDbNull()},
                 {Columns.PositionTotal, PositionTotal},
                 {Columns.IsPredefined, IsPredefined},
                 {Columns.PositionName, Name},
                 {Columns.PaperPrice, PaperPricePer.SetIntDbNull()},
                 {Columns.PrintType, PrintType}
               };
    }

    public void ClearObjectList()
    {
      _prints.Clear();
    }

    private ClickCost _clickCost;

    private Paper _paper;

    private readonly List<Print> _predefinedPrints = new List<Print>();

    private readonly List<Print> _prints = new List<Print>();
  }
}