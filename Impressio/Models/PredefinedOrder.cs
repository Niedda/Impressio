using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Class for handling predefined Orders
  /// </summary>
  public class PredefinedOrder : DatabaseObjectBase<PredefinedOrder>
  {
    #region Columns enum

    public enum Columns
    {
      PredefinedOrderId,
      FkOrderId,
      Pages,
      ColorFront,
      ColorBack,
      Kind,
      Name,
      Quantity,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return Columns.PredefinedOrderId.ToString(); } }

    public override string Table { get { return "PredefinedOrder"; } }

    public int FkOrderId { get; set; }

    public int Pages { get; set; }

    public int ColorFront { get; set; }

    public int ColorBack { get; set; }

    public string Kind { get; set; }

    public string Name { get; set; }

    public int Quantity { get; set; }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.Name.ToString()] as string;
      FkOrderId = Database.DatabaseCommand.Reader[Columns.FkOrderId.ToString()].GetInt();
      Pages = Database.DatabaseCommand.Reader[Columns.Pages.ToString()].GetInt();
      ColorFront = Database.DatabaseCommand.Reader[Columns.ColorFront.ToString()].GetInt();
      ColorBack = Database.DatabaseCommand.Reader[Columns.ColorBack.ToString()].GetInt();
      Kind = Database.DatabaseCommand.Reader[Columns.Kind.ToString()] as string;
      Quantity = Database.DatabaseCommand.Reader[Columns.Quantity.ToString()].GetInt();
    }

    public override void ClearObjectList()
    {
      _predefinedOrders.Clear();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.FkOrderId, FkOrderId},
                 {Columns.Name, Name},
                 {Columns.ColorFront, ColorFront},
                 {Columns.ColorBack, ColorBack},
                 {Columns.Kind, Kind},
                 {Columns.Pages, Pages},
                 {Columns.Quantity, Quantity},
               };
    }
    
    public override List<PredefinedOrder> Objects
    {
      get { return _predefinedOrders; }
    }

    private readonly List<PredefinedOrder> _predefinedOrders = new List<PredefinedOrder>();
  }
}
