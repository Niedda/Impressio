using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// State class for defining order states
  /// </summary>
  public class State : DatabaseObjectBase<State>
  {
    #region Columns enum

    public enum Columns
    {
      StateName,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "StateId"; } }

    public override string Table { get { return "State"; } }

    public string StateName { get; set; }

    public override List<State> Objects
    {
      get { return _states; }
    }

    public bool HasOrders()
    {
      try
      {
        var query = new Query(Order.Columns.FkOrderState, new DatabaseOperator(DatabaseOperator.Operator.Equal), Identity);
        var queryBuilder = new QueryBuilder("Order", query);
        Database.DatabaseCommand.Reader = queryBuilder.GetQuery().ExecuteReader();
        
        while (Database.DatabaseCommand.Reader.Read())
        {
          return true;
        }
        return false;
      }
      catch
      {
        return true;
      }
      finally
      {
        Database.DatabaseCommand.CloseReader();
      }
    }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      StateName = Database.DatabaseCommand.Reader[Columns.StateName.ToString()] as string;
    }

    public override void ClearObjectList()
    {
      _states.Clear();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.StateName, StateName},
               };
    }

    private readonly List<State> _states = new List<State>();
  }
}
