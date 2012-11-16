using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class Print : DatabaseObjectBase<Print>, IPosition, IPredefined<Print>
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

    public override string IdentityColumn { get { return "PrintId"; } }

    public override string Table { get { return "Print"; } }

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

    public bool IsPredefined { get; set; }

    public string Name { get; set; }

    public int FkOrder { get; set; }

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
        double total = 0;

        if (ClickCost != null)
        {
          total = ClickCost.Cost * PrintAmount;

          if (PrintType == 1)
          {
            return (total * 2).GetInt();
          }
        }
        return total.GetInt();
      }
    }

    public int PositionTotal
    {
      get
      {
        return (PrintCostTotal + PaperCostTotal).GetInt();
      }
    }

    public Type Type
    {
      get { return Type.Digitaldruck; }
      set { }
    }

    public void LoadPredefined()
    {
      var prints = new Print();
      prints.LoadObjectList(Columns.IsPredefined, true);
      _predefinedPrints.AddRange(prints.Objects);
    }

    public List<Print> PredefinedObjects { get { return _predefinedPrints; } }

    public void ClearPredefinedObjects()
    {
      _predefinedPrints.Clear();
    }

    public override List<Print> Objects { get { return _prints; } }

    public override void SetObject()
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

    public override Dictionary<Enum, object> GetObject()
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

    public override void ClearObjectList()
    {
      _prints.Clear();
    }

    private ClickCost _clickCost;

    private Paper _paper;

    private readonly List<Print> _predefinedPrints = new List<Print>();

    private readonly List<Print> _prints = new List<Print>();
  }

  public class ClickCost : DatabaseObjectBase<ClickCost>
  {
    #region Columns enum

    public enum Columns
    {
      ClickCost,
      ClickName,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "ClickCostId"; } }

    public override string Table { get { return "ClickCost"; } }

    public string Name { get; set; }

    public double Cost
    {
      get { return _cost; }
      set
      {
        if (value <= 0.0001 || value >= 5)
        {
          _cost = 0.01;
        }
        else
        {
          _cost = value;
        }
      }
    }

    public override List<ClickCost> Objects { get { return _clickCosts; } }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.ClickName.ToString()] as string;
      Cost = Convert.ToDouble(Database.DatabaseCommand.Reader[Columns.ClickCost.ToString()]);
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.ClickCost, Cost},
                 {Columns.ClickName, Name},
               };
    }

    public override void ClearObjectList()
    {
      _clickCosts.Clear();
    }

    private readonly List<ClickCost> _clickCosts = new List<ClickCost>();

    private double _cost;
  }
}