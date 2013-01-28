using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class UseSimpleOffset : DatabaseObjectBase<UseSimpleOffset>
  {
    #region Columns enum

    public enum Columns
    {
      FkUseSimpleOffset,
      UsePer,
      UseName,
      Quanitity1,
      Quanitity2,
      Quanitity3,
      Quanitity4,
      SheetNumber,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "UseSimpleOffsetId"; } }

    public override string Table { get { return "UseSimpleOffset"; } }

    public string UseName { get; set; }

    public int UsePer { get; set; }

    public int FkUsePerSimpleOffset { get; set; }

    public int Quantity1 { get; set; }

    public int Quantity2 { get; set; }

    public int Quantity3 { get; set; }

    public int Quantity4 { get; set; }

    public int SheetNumber { get; set; }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      UsePer = Database.DatabaseCommand.Reader[Columns.UsePer.ToString()].GetInt();
      UseName = Database.DatabaseCommand.Reader[Columns.UseName.ToString()].ToString();
      FkUsePerSimpleOffset = Database.DatabaseCommand.Reader[Columns.FkUseSimpleOffset.ToString()].GetInt();
      Quantity1 = Database.DatabaseCommand.Reader[Columns.Quanitity1.ToString()].GetInt();
      Quantity2 = Database.DatabaseCommand.Reader[Columns.Quanitity2.ToString()].GetInt();
      Quantity3 = Database.DatabaseCommand.Reader[Columns.Quanitity3.ToString()].GetInt();
      Quantity4 = Database.DatabaseCommand.Reader[Columns.Quanitity4.ToString()].GetInt();
      SheetNumber = Database.DatabaseCommand.Reader[Columns.SheetNumber.ToString()].GetInt();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkUseSimpleOffset, FkUsePerSimpleOffset},
                 {Columns.UseName, UseName},
                 {Columns.UsePer, UsePer},
                 {Columns.Quanitity1, Quantity1},
                 {Columns.Quanitity2, Quantity2.SetIntDbNull()},
                 {Columns.Quanitity3, Quantity3.SetIntDbNull()},
                 {Columns.Quanitity4, Quantity4.SetIntDbNull()},
                 {Columns.SheetNumber, SheetNumber},
               };
    }

    public override List<UseSimpleOffset> Objects
    {
      get { return _useSimpleOffsets; }
    }

    public override void ClearObjectList()
    {
      _useSimpleOffsets.Clear();
    }

    public List<UseSimpleOffset> _useSimpleOffsets = new List<UseSimpleOffset>(); 
  }
}
