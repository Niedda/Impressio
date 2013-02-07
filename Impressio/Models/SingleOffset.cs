using System;
using System.Collections.Generic;
using Impressio.Controls;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class SingleOffset : Position, IDatabaseObject<SingleOffset>
  {
    #region Columns enum

    public enum Columns
    {
      FkSingleOffsetOrder,
      FkSingleOffsetPaper,
      FkSingleOffsetMachine,
      FkSingleOffsetPriceClass,
      EasyColorQuantity,
      DifficultColorQuantity,
      EasySetup,
      DifficultSetup,
      PaperPrice,
      PaperQuantity,
      PrintType,
      PlateQuantity,
      UsePerVertical,
      UsePerHorizontal,
      PaperUsePer,
      IsPredefined,
      PositionName,
      PositionTotal,
    }

    #endregion

    public override int Identity { get; set; }

    public override string Name { get; set; }

    public override int PositionTotal
    {
      get { return 0; }
    }

    public override string DisplayName { get { return "Einfacher Wizard"; } }

    public override int FkOrder { get; set; }

    public int FkPaper { get; set; }

    public int FkMachine { get; set; }

    public int FkPriceClass { get; set; }

    public int PlateQuantity { get; set; }

    public int UsePerVertical { get; set; }

    public int UsePerHorizontal { get; set; }

    public int PaperPrice { get; set; }

    public int EasyColorChange { get; set; }

    public int DifficultColorChange { get; set; }

    public bool EasySetup { get; set; }

    public bool DifficultSetup { get; set; }

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
    
    public override bool IsPredefined { get; set; }

    public string IdentityColumn
    {
      get { return "SingleOffsetId"; }
    }

    public string Table
    {
      get { return "SingleOffset"; }
    }

    public Paper Paper
    {
      get
      {
        if (FkPaper != 0)
        {
          if (_paper == null || _paper.Identity == FkPaper)
          {
            return (_paper = (Paper)new Paper { Identity = FkPaper, }.LoadSingleObject());
          }
          return _paper;
        }
        return null;
      }
    }

    public Machine Machine
    {
      get
      {
        if (FkMachine != 0)
        {
          if (_machine == null || FkMachine != _machine.Identity)
          {
            return (_machine = (Machine)new Machine { Identity = FkMachine }.LoadSingleObject());
          }
          return _machine;
        }
        return null;
      }
    }

    public List<SingleOffset> Objects
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
      return this.LoadObjectList(Columns.FkSingleOffsetOrder, FkOrder).ConvertAll(conv => (Position)conv);
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
      FkPaper = Database.DatabaseCommand.Reader[Columns.FkSingleOffsetPaper.ToString()].GetInt();
      FkMachine = Database.DatabaseCommand.Reader[Columns.FkSingleOffsetMachine.ToString()].GetInt();
      FkPriceClass = Database.DatabaseCommand.Reader[Columns.FkSingleOffsetPriceClass.ToString()].GetInt();
      PaperPrice = Database.DatabaseCommand.Reader[Columns.PaperPrice.ToString()].GetInt();
      PaperQuantity = Database.DatabaseCommand.Reader[Columns.PaperQuantity.ToString()].GetInt();
      PaperUsePer = Database.DatabaseCommand.Reader[Columns.PaperUsePer.ToString()].GetInt();
      PrintType = Database.DatabaseCommand.Reader[Columns.PrintType.ToString()].GetInt();
      EasyColorChange = Database.DatabaseCommand.Reader[Columns.EasyColorQuantity.ToString()].GetInt();
      DifficultColorChange = Database.DatabaseCommand.Reader[Columns.DifficultColorQuantity.ToString()].GetInt();
      EasySetup = (bool)Database.DatabaseCommand.Reader[Columns.EasySetup.ToString()];
      DifficultSetup = (bool)Database.DatabaseCommand.Reader[Columns.DifficultSetup.ToString()];
      FkOrder = Database.DatabaseCommand.Reader[Columns.FkSingleOffsetOrder.ToString()].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.PositionName.ToString()] as string;
      IsPredefined = (bool)Database.DatabaseCommand.Reader[Columns.IsPredefined.ToString()];
      PaperQuantity = Database.DatabaseCommand.Reader[Columns.PaperQuantity.ToString()].GetInt();
      UsePerHorizontal = Database.DatabaseCommand.Reader[Columns.UsePerHorizontal.ToString()].GetInt();
      UsePerVertical = Database.DatabaseCommand.Reader[Columns.UsePerVertical.ToString()].GetInt();
      PlateQuantity = Database.DatabaseCommand.Reader[Columns.PlateQuantity.ToString()].GetInt();
      PositionTotal = Database.DatabaseCommand.Reader[Columns.PositionTotal.ToString()].GetInt();
    }

    public Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkSingleOffsetOrder, FkOrder.SetIntDbNull()},
                 {Columns.FkSingleOffsetPaper, FkPaper.SetIntDbNull()},
                 {Columns.FkSingleOffsetMachine, FkMachine.SetIntDbNull()},
                 {Columns.FkSingleOffsetPriceClass, FkPriceClass.SetIntDbNull()},
                 {Columns.PaperPrice, PaperPrice.SetIntDbNull()},
                 {Columns.PaperQuantity, PaperQuantity.SetIntDbNull()},
                 {Columns.PaperUsePer, PaperUsePer.SetIntDbNull()},
                 {Columns.PositionName, Name},
                 {Columns.EasyColorQuantity, EasyColorChange.SetIntDbNull()},
                 {Columns.DifficultColorQuantity, DifficultColorChange.SetIntDbNull()},
                 {Columns.EasySetup, EasySetup},
                 {Columns.DifficultSetup, DifficultSetup},
                 {Columns.PrintType, PrintType.SetIntDbNull()},
                 {Columns.UsePerHorizontal, UsePerHorizontal.SetIntDbNull()},
                 {Columns.UsePerVertical, UsePerVertical.SetIntDbNull()},
                 {Columns.PositionTotal, PositionTotal.SetIntDbNull()},
                 {Columns.IsPredefined, IsPredefined},
                 {Columns.PlateQuantity, PlateQuantity.SetIntDbNull()},
                 {Columns.PositionTotal, PositionTotal},
               };
    }

    public void ClearObjectList()
    {
      _offsets.Clear();
    }

    private Machine _machine;

    private readonly List<SingleOffset> _offsets = new List<SingleOffset>();

    private Paper _paper;

    private readonly List<SingleOffset> _predefinedOffset = new List<SingleOffset>();

    private int _positionTotal;
  }
}
