using System;
using System.Collections.Generic;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

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

    private readonly ClickCost _clickCost = new ClickCost();
    private readonly Paper _paper = new Paper();
    private readonly List<Print> _predefinedPrints = new List<Print>();
    private readonly List<Print> _prints = new List<Print>();
    private int _positionTotal;

    public override string IdentityColumn
    {
      get { return "PrintId"; }
    }

    public override string Table
    {
      get { return "Print"; }
    }

    public int FkPrintPaper { get; set; }

    public Paper Paper
    {
      get
      {
        if (FkPrintPaper != 0)
        {
          _paper.Identity = FkPrintPaper;
          return (Paper) _paper.LoadSingleObject();
        }
        return new Paper();
      }
    }

    public int FkPrintClickCost { get; set; }

    public ClickCost ClickCost
    {
      get
      {
        if (FkPrintClickCost != 0)
        {
          _clickCost.Identity = FkPrintClickCost;
          return (ClickCost) _clickCost.LoadSingleObject();
        }
        return new ClickCost();
      }
    }

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
            return "Zweiseitig";
          default:
            return "";
        }
      }
    }

    public int PrintAmount { get; set; }

    public int PaperAmount { get; set; }

    public int PaperAddition { get; set; }

    public int PaperPricePer { get; set; }

    public int PaperUsePer { get; set; }

    public bool IsPredefined { get; set; }

    public decimal? PaperCostTotal
    {
      get { return ((PaperPricePer*(PaperAddition + 100))*(PaperAmount/1000))/100; }
    }

    public decimal? PrintCostTotal
    {
      get
      {
        if (ClickCost != null)
        {
          double total = ClickCost.Cost*PrintAmount;

          if (PrintType == 1)
          {
            return (total*2).GetInt();
          }
          return total.GetInt();
        }
        return null;
      }
    }

    public override List<Print> Objects
    {
      get { return _prints; }
    }

    #region IPosition Members

    public override int Identity { get; set; }
    public string Name { get; set; }

    public int FkOrder { get; set; }

    public int PositionTotal
    {
      get
      {
        if (PrintCostTotal != null && PaperCostTotal != null)
        {
          (PrintCostTotal + PaperCostTotal).GetInt();
        }
        if (PaperCostTotal != null)
        {
          return _positionTotal = PaperCostTotal.GetInt();
        }
        return _positionTotal = PrintCostTotal.GetInt();
      }
      set { _positionTotal = value; }
    }

    public Type Type
    {
      get { return Type.Digitaldruck; }
      set { }
    }

    #endregion

    #region IPredefined<Print> Members

    public void LoadPredefined()
    {
      var prints = new Print();
      prints.LoadObjectList(Columns.IsPredefined, true);
      _predefinedPrints.AddRange(prints.Objects);
    }

    public List<Print> PredefinedObjects
    {
      get { return _predefinedPrints; }
    }

    public void ClearPredefinedObjects()
    {
      _predefinedPrints.Clear();
    }

    #endregion

    public override void SetObject()
    {
      IsPredefined = (bool) Database.Reader["IsPredefined"];
      Identity = (int) Database.Reader["PrintId"];
      FkPrintClickCost = Database.Reader["FkPrintClickCost"].GetInt();
      FkOrder = Database.Reader["FkPrintOrder"].GetInt();
      FkPrintPaper = Database.Reader["FkPrintPaper"].GetInt();
      PrintAmount = Database.Reader["PrintAmount"].GetInt();
      PaperUsePer = Database.Reader["PaperUsePer"].GetInt();
      PaperAddition = Database.Reader["PaperAddition"].GetInt();
      PaperAmount = Database.Reader["PaperAmount"].GetInt();
      PositionTotal = Database.Reader["PositionTotal"].GetInt();
      PaperPricePer = Database.Reader["PaperPrice"].GetInt();
      Name = Database.Reader["PositionName"] as string;
    }

    public override void SetObjectList()
    {
      var print = new Print();
      print.SetObject();
      _prints.Add(print);
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
                 {Columns.PositionTotal, PositionTotal.SetIntDbNull()},
                 {Columns.IsPredefined, IsPredefined},
                 {Columns.PositionName, Name},
                 {Columns.PaperPrice, PaperPricePer.SetIntDbNull()},
                 {Columns.PrintType, PrintType.SetIntDbNull()}
               };
    }

    public override void ClearObjectList()
    {
      _prints.Clear();
    }
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

    private readonly List<ClickCost> _clickCosts = new List<ClickCost>();
    private double _cost;

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "ClickCostId"; }
    }

    public override string Table
    {
      get { return "ClickCost"; }
    }

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

    public override List<ClickCost> Objects
    {
      get { return _clickCosts; }
    }

    public override void SetObject()
    {
      Identity = Database.Reader["ClickCostId"].GetInt();
      Name = Database.Reader["ClickName"] as string;
      Cost = Convert.ToDouble(Database.Reader["ClickCost"]);
    }

    public override void SetObjectList()
    {
      var clickCost = new ClickCost();
      clickCost.SetObject();
      _clickCosts.Add(clickCost);
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
  }
}