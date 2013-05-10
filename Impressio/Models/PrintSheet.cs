using System;
using System.Collections.Generic;
using System.Drawing;
using Impressio.Models.Tools;
using Subvento;
using Subvento.Database;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Contains the basic parameter which every print-sheet contains
  /// </summary>
  public class PrintSheet : BasePaper, IDatabaseObject<PrintSheet>
  {
    #region Columns

    public enum Columns
    {
      FkPrintSheetBooklet,
      FkPrintSheetMachine,
      FkPrintSheetPaper,
      Quantity,
      UsePerHorizontal,
      UsePerVertical,
      FinishSizeW,
      FinishSizeH,
      PrintSizeW,
      PrintSizeH,
      PrintType,
      ColorFront,
      ColorBack,
      FlippedUsePerSheet,
      EasySetup,
      DifficultSetup,
      PaperQuantity,
      PaperAddition,
      PriceAddition,
      UsePerRawHorizontal,
      UsePerRawVertical,
      FlippedUsePerRawPaper,
      PaperPrice,
    }

    #endregion

    public int Identity { get; set; }

    public int FkPrintSheetBooklet { get; set; }

    public string IdentityColumn { get; private set; }

    public string Table { get; private set; }

    public IDatabase Database { get { return ServiceLocator.Instance.Database; } }

    public int Quantity { get; set; }

    public int UsePerHorizontal { get; set; }

    public int UsePerVertical { get; set; }

    public int FinishSizeW { get; set; }

    public int FinishSizeH { get; set; }

    public string FinishSize { get { return FinishSizeW + " x " + FinishSizeH; } }

    public int PrintSizeW { get; set; }

    public int PrintSizeH { get; set; }

    public string PrintSize { get { return PrintSizeW + " x " + PrintSizeH; } }

    public int FkPrintType { get; set; }

    public PrintType PrintType { get { return PrintType.GetPrintType(FkPrintType); } }

    public int ColorFront { get; set; }

    public int ColorBack { get; set; }

    public int FkMachine
    {
      set
      {
        if (value != _fkMachine && _fkMachine > 0)
        {
          Machine = Machine ?? new Machine();
          Machine.Identity = value;
          Machine.LoadSingleObject();
        }
      }
    }

    public Machine Machine { get; set; }

    public int PlateSetupQuantity
    {
      get
      {
        switch (PrintType.Identity)
        {
          case 1:
            return ColorFront;
          case 4:
            return ColorFront + ColorBack;
          default:
            return ColorFront > ColorBack ? ColorFront : ColorBack;
        }
      }
    }

    public bool FlippedUsePerSheet { get; set; }

    public bool EasySetup { get; set; }

    public bool DifficultSetup { get; set; }

    public int PrintCostTotal
    {
      get
      {
        if (Machine != null && Paper != null)
        {
          switch (FkPrintType)
          {
            case 1:
              return (((Quantity / (UsePerHorizontal / UsePerVertical)) * ColorFront) / Machine.Speed) * Machine.PricePerHour;
            case 4:
              return (((Quantity / (UsePerHorizontal / UsePerVertical)) * (ColorFront + ColorBack)) / Machine.Speed) * Machine.PricePerHour;
            default:
              var colors = ColorFront > ColorBack ? ColorFront : ColorBack;
              return (((Quantity / (UsePerHorizontal / UsePerVertical)) * (colors)) / Machine.Speed) * Machine.PricePerHour;
          }
        }
        return 0;
      }
    }

    public int SetupCostTotal
    {
      get
      {
        return Machine != null ? (EasySetup ? Machine.EasySetup : DifficultSetup ? Machine.DifficultSetup : 0) * Machine.PricePerHour / 60 : 0;
      }
    }

    public int PlateCost
    {
      get { return Machine != null ? PlateSetupQuantity * Machine.PlateCost : 0; }
    }

    public int PlateSetupCostTotal
    {
      get
      {
        return Machine != null ? (PlateSetupQuantity * Machine.PlateSetup) * (Machine.PricePerHour / 60) : 0;
      }
    }

    public List<PrintSheet> Objects { get { return _printSheets; } }

    public void DrawSheet(Graphics graphics)
    {
      Drawing.Draw(graphics, PrintSizeW, PrintSizeH, FinishSizeW, FinishSizeH, UsePerVertical, UsePerHorizontal, FlippedUsePerSheet);
    }

    public void DrawRawPaper(Graphics graphics)
    {
      Drawing.Draw(graphics, Paper.SizeW, Paper.SizeH, PrintSizeW, PrintSizeH, UsePerRawVertical, UsePerRawHorizontal, false, false);
    }

    public bool IsUsePerSheetValid()
    {
      var comp1 = (PrintSizeW / FinishSizeW) * (PrintSizeH / FinishSizeH);
      var comp2 = (PrintSizeH / FinishSizeW) * (PrintSizeW / FinishSizeH);
      return UsePerHorizontal + UsePerVertical < comp1 || UsePerHorizontal + UsePerVertical < comp2;
    }

    public bool IsUsePerRawPaperValid()
    {
      var comp1 = (Paper.SizeW / PrintSizeW) * (Paper.SizeH / PrintSizeH);
      var comp2 = (Paper.SizeH / PrintSizeW) * (Paper.SizeW / PrintSizeH);
      return UsePerRawVertical + UsePerRawHorizontal < comp1 || UsePerRawHorizontal + UsePerRawVertical < comp2;
    }

    public int GetBestUseRawPaper()
    {
      var comp1 = (Paper.SizeW / PrintSizeW) * (Paper.SizeH / PrintSizeH);
      var comp2 = (Paper.SizeW / PrintSizeH) * (Paper.SizeH / PrintSizeW);
      return comp1 > comp2 ? comp1 : comp2;
    }

    public int GetBestUseSheet()
    {
      var comp1 = (PrintSizeW / FinishSizeW) * (PrintSizeH / FinishSizeH);
      var comp2 = (PrintSizeW / FinishSizeH) * (PrintSizeH / FinishSizeW);
      return comp1 > comp2 ? comp1 : comp2;
    }

    public int GetKiloPrice()
    {
      var paperKilo = ((1000 / (UsePerVertical * UsePerHorizontal)) / (UsePerRawHorizontal * UsePerRawVertical)) * PaperPrice;
      var printKilo = 0;
      if (Machine != null && Paper != null)
      {
        switch (FkPrintType)
        {
          case 1:
            printKilo = (((1000 / (UsePerVertical * UsePerHorizontal)) * ColorFront) / Machine.Speed) * Machine.PricePerHour;
            break;
          case 4:
            printKilo = (((1000 / (UsePerVertical * UsePerHorizontal)) * (ColorFront + ColorBack)) / Machine.Speed) * Machine.PricePerHour;
            break;
          default:
            var colors = ColorFront > ColorBack ? ColorFront : ColorBack;
            printKilo = (((1000 / (UsePerVertical * UsePerHorizontal)) * (colors)) / Machine.Speed) * Machine.PricePerHour;
            break;
        }
      }
      return printKilo + paperKilo;
    }

    public void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      FkPrintSheetBooklet = Database.DatabaseCommand.Reader[Columns.FkPrintSheetPaper.ToString()].GetInt();
      FkPaper = Database.DatabaseCommand.Reader[Columns.FkPrintSheetPaper.ToString()].GetInt();
      FkMachine = Database.DatabaseCommand.Reader[Columns.FkPrintSheetMachine.ToString()].GetInt();
      PaperPrice = Database.DatabaseCommand.Reader[Columns.PaperPrice.ToString()].GetInt();
      PaperQuantity = Database.DatabaseCommand.Reader[Columns.PaperQuantity.ToString()].GetInt();
      UsePerRawHorizontal = Database.DatabaseCommand.Reader[Columns.UsePerRawHorizontal.ToString()].GetInt();
      UsePerRawVertical = Database.DatabaseCommand.Reader[Columns.UsePerRawVertical.ToString()].GetInt();
      PaperAddition = Database.DatabaseCommand.Reader[Columns.PaperAddition.ToString()].GetInt();
      PriceAddition = Database.DatabaseCommand.Reader[Columns.PriceAddition.ToString()].GetInt();
      FkPrintType = Database.DatabaseCommand.Reader[Columns.PrintType.ToString()].GetInt();
      EasySetup = (bool)Database.DatabaseCommand.Reader[Columns.EasySetup.ToString()];
      DifficultSetup = (bool)Database.DatabaseCommand.Reader[Columns.DifficultSetup.ToString()];
      PaperQuantity = Database.DatabaseCommand.Reader[Columns.PaperQuantity.ToString()].GetInt();
      UsePerHorizontal = Database.DatabaseCommand.Reader[Columns.UsePerHorizontal.ToString()].GetInt();
      UsePerVertical = Database.DatabaseCommand.Reader[Columns.UsePerVertical.ToString()].GetInt();
      Quantity = Database.DatabaseCommand.Reader[Columns.Quantity.ToString()].GetInt();
      FinishSizeW = Database.DatabaseCommand.Reader[Columns.FinishSizeW.ToString()].GetInt();
      FinishSizeH = Database.DatabaseCommand.Reader[Columns.FinishSizeH.ToString()].GetInt();
      ColorFront = Database.DatabaseCommand.Reader[Columns.ColorFront.ToString()].GetInt();
      ColorBack = Database.DatabaseCommand.Reader[Columns.ColorBack.ToString()].GetInt();
      PrintSizeW = Database.DatabaseCommand.Reader[Columns.PrintSizeW.ToString()].GetInt();
      PrintSizeH = Database.DatabaseCommand.Reader[Columns.PrintSizeH.ToString()].GetInt();
      PaperAddition = Database.DatabaseCommand.Reader[Columns.PaperAddition.ToString()].GetInt();
      FlippedUsePerSheet = (bool)Database.DatabaseCommand.Reader[Columns.FlippedUsePerSheet.ToString()];
      FlippedUsePerRawPaper = (bool)Database.DatabaseCommand.Reader[Columns.FlippedUsePerRawPaper.ToString()];
    }

    public void ClearObjectList()
    {
      _printSheets.Clear();
    }

    public Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkPrintSheetBooklet, FkPrintSheetBooklet.SetIntDbNull()},
                 {Columns.FkPrintSheetPaper, Paper.Identity.SetIntDbNull()},
                 {Columns.FkPrintSheetMachine, Machine.Identity.SetIntDbNull()},

                 {Columns.PaperPrice, PaperPrice.SetIntDbNull()},
                 {Columns.PaperQuantity, PaperQuantity.SetIntDbNull()},
                 {Columns.UsePerRawHorizontal, UsePerRawHorizontal.SetIntDbNull()},
                 {Columns.UsePerRawVertical, UsePerRawVertical.SetIntDbNull()},
                 {Columns.PaperAddition, PaperAddition.SetIntDbNull()},
                 {Columns.PriceAddition, PriceAddition.SetIntDbNull()},
                 {Columns.PrintType, PrintType.Identity.SetIntDbNull()},
                 {Columns.EasySetup, EasySetup},
                 {Columns.DifficultSetup, DifficultSetup},
                 {Columns.PrintType, FkPrintType.SetIntDbNull()},
                 {Columns.UsePerHorizontal, UsePerHorizontal.SetIntDbNull()},
                 {Columns.UsePerVertical, UsePerVertical.SetIntDbNull()},
                 {Columns.FinishSizeW, FinishSizeW.SetIntDbNull()},
                 {Columns.FinishSizeH, FinishSizeH.SetIntDbNull()},
                 {Columns.Quantity, Quantity.SetIntDbNull()},
                 {Columns.ColorBack, ColorBack.SetIntDbNull()},
                 {Columns.ColorFront, ColorFront.SetIntDbNull()},
                 {Columns.PrintSizeW, PrintSizeW.SetIntDbNull()},
                 {Columns.PrintSizeH, PrintSizeH.SetIntDbNull()},
                 {Columns.PaperAddition, PaperAddition.SetIntDbNull()},
                 {Columns.FlippedUsePerSheet, FlippedUsePerSheet},
                 {Columns.FlippedUsePerRawPaper, FlippedUsePerRawPaper},
               };
    }

    private int _fkMachine;

    private readonly List<PrintSheet> _printSheets = new List<PrintSheet>();

    private readonly Machine _machine = new Machine();
  }
}
