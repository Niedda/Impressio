using System;

namespace Subvento.DatabaseObject
{
  public class Query
  {
    public Query(Enum column, DatabaseOperator databaseOperator, object value)
    {
      Value = value;
      Column = column.ToString();
      Operator = databaseOperator.DependentOperator;
    }

    public Query(Enum column, DatabaseStringOperator databaseOperator, object value)
    {
      Value = value;
      Column = column.ToString();
      Operator = databaseOperator.DependentStringOperator;
    }

    public readonly string Column;

    public readonly string Operator;

    public readonly object Value;
  }
}
