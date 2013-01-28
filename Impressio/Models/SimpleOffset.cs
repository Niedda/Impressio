using System;
using System.Collections.Generic;
using Impressio.Controls;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class SimpleOffset : Position, IDatabaseObject<SimpleOffset>
  {
    #region Columns enum

    public enum Columns
    {
      FkSimpleOffsetOrder,
      IsPredefined,
      PositionName,
      PositionTotal,
      ColorFront,
      ColorBack,
      Pages,
      Width,
      Height,
      Plates,
      FkSimpleOffsetMachine,
      PrintType,
      UsePerVertical,
      UsePerHorizontal,
      FkSimpleOffsetPaper,
      PaperPrice,
      PrintFormatHeight,
      PrintFormatWidth,
      Sheets,
      ColorChanges,
      PaperAddition,
    }

    #endregion

    public override int Identity { get; set; }

    public override string DisplayName { get { return "Einzelblatt Wizard"; } }

    public override int FkOrder { get; set; }

    public override string Name { get; set; }

    public override int PositionTotal { get { return 0; } }

    public override bool IsPredefined { get; set; }

    public string IdentityColumn { get { return "SimpleOffsetId"; } }

    public string Table { get { return "SimpleOffset"; } }

    public int ColorFront { get; set; }

    public int ColorBack { get; set; }

    public int Pages { get; set; }

    public int Width { get; set; }

    public int Height { get; set; }

    public int Plates { get; set; }

    public int FkSimpleOffsetMachine { get; set; }

    public int PrintType { get; set; }

    public int UsePerVertical { get; set; }

    public int UsePerHorizontal { get; set; }

    public int FkSimpleOffsetPaper { get; set; }

    public int PaperPrice { get; set; }

    public int PrintFormatHeight { get; set; }

    public int PrintFormatWidht { get; set; }

    public int ColorChanges { get; set; }

    public int Sheets { get; set; }

    public int PaperAddition { get; set; }

    public List<SimpleOffset> Objects
    {
      get { return _simpleOffsets; }
    }

    public void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      FkOrder = Database.DatabaseCommand.Reader[Columns.FkSimpleOffsetOrder.ToString()].GetInt();
      FkSimpleOffsetMachine = Database.DatabaseCommand.Reader[Columns.FkSimpleOffsetMachine.ToString()].GetInt();
      FkSimpleOffsetPaper = Database.DatabaseCommand.Reader[Columns.FkSimpleOffsetPaper.ToString()].GetInt();
      ColorFront = Database.DatabaseCommand.Reader[Columns.ColorFront.ToString()].GetInt();
      ColorBack = Database.DatabaseCommand.Reader[Columns.ColorBack.ToString()].GetInt();
      Pages = Database.DatabaseCommand.Reader[Columns.Pages.ToString()].GetInt();
      Width = Database.DatabaseCommand.Reader[Columns.Width.ToString()].GetInt();
      Height = Database.DatabaseCommand.Reader[Columns.Height.ToString()].GetInt();
      Plates = Database.DatabaseCommand.Reader[Columns.Plates.ToString()].GetInt();
      PrintType = Database.DatabaseCommand.Reader[Columns.PrintType.ToString()].GetInt();
      UsePerVertical = Database.DatabaseCommand.Reader[Columns.UsePerVertical.ToString()].GetInt();
      UsePerHorizontal = Database.DatabaseCommand.Reader[Columns.UsePerHorizontal.ToString()].GetInt();
      PaperPrice = Database.DatabaseCommand.Reader[Columns.PaperPrice.ToString()].GetInt();
      PrintFormatHeight = Database.DatabaseCommand.Reader[Columns.PrintFormatHeight.ToString()].GetInt();
      PrintFormatWidht = Database.DatabaseCommand.Reader[Columns.PrintFormatWidth.ToString()].GetInt();
      Sheets = Database.DatabaseCommand.Reader[Columns.Sheets.ToString()].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.PositionName.ToString()].ToString();
      IsPredefined = (bool)Database.DatabaseCommand.Reader[Columns.IsPredefined.ToString()];
      ColorChanges = Database.DatabaseCommand.Reader[Columns.ColorChanges.ToString()].GetInt();
      PaperAddition = Database.DatabaseCommand.Reader[Columns.PaperAddition.ToString()].GetInt();
    }

    public void ClearObjectList()
    {
      _simpleOffsets.Clear();
    }

    public Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.ColorBack, ColorBack.SetIntDbNull()},
                 {Columns.ColorFront, ColorFront.SetIntDbNull()},
                 {Columns.ColorChanges, ColorChanges.SetIntDbNull()},
                 {Columns.FkSimpleOffsetMachine, FkSimpleOffsetMachine.SetIntDbNull()},
                 {Columns.FkSimpleOffsetOrder, FkOrder.SetIntDbNull()},
                 {Columns.Height, Height.SetIntDbNull()},
                 {Columns.IsPredefined, IsPredefined},
                 {Columns.Pages, Pages.SetIntDbNull()},
                 {Columns.PaperPrice, PaperPrice.SetIntDbNull()},
                 {Columns.Plates, Plates.SetIntDbNull()},
                 {Columns.PositionName, Name},
                 {Columns.PositionTotal, PositionTotal},
                 {Columns.PrintFormatHeight, PrintFormatHeight.SetIntDbNull()},
                 {Columns.PrintFormatWidth, PrintFormatWidht.SetIntDbNull()},
                 {Columns.PrintType, PrintType.SetIntDbNull()},
                 {Columns.Sheets, Sheets.SetIntDbNull()},
                 {Columns.UsePerHorizontal, UsePerHorizontal.SetIntDbNull()},
                 {Columns.UsePerVertical, UsePerVertical.SetIntDbNull()},
                 {Columns.Width, Width.SetIntDbNull()},
               };
    }

    public override IControl AssignedControl
    {
      get { return new SimpleOffsetControl{SimpleOffset = new SimpleOffset {Identity = Identity}}; }
    }

    public override List<Position> LoadPositions()
    {
      if (FkOrder <= 0)
      {
        throw new InvalidOperationException("Fk Order can not be null");
      }
      return this.LoadObjectList(Columns.FkSimpleOffsetOrder, FkOrder).ConvertAll(conv => (Position)conv);
    }

    public override List<Position> LoadPredefinedPositions()
    {
      return this.LoadObjectList(Columns.IsPredefined, true).ConvertAll(conv => (Position)conv);
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

    //TODO implement
    public override int CopyPosition(int orderId)
    {
      //this.LoadSingleObject();
      //var id = base.CopyPosition(FkOrder);

      //foreach (var dataPosition in DataPositions)
      //{
      //  dataPosition.Identity = 0;
      //  dataPosition.FkDataDataPosition = id;
      //  dataPosition.SaveObject();
      //}
      //return id;
      return 0;
    }

    private List<SimpleOffset> _simpleOffsets = new List<SimpleOffset>();
  }
}
