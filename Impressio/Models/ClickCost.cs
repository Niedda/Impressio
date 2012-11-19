using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
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

    public override string IdentityColumn
    {
      get { return "ClickCostId"; }
    }

    public override string Table
    {
      get { return "ClickCost"; }
    }

    public string Name { get; set; }

    public double Cost { get; set; }

    public override List<ClickCost> Objects
    {
      get { return _clickCosts; }
    }

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
  }
}
