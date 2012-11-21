namespace Subvento.DatabaseObject
{
  /// <summary>
  /// Basic sql operators provided by the database
  /// </summary>
  public class DatabaseOperator
  {
    public DatabaseOperator(Operator databaseOperator)
    {
      DependentOperator = ServiceLocator.Instance.Database.GetOperator(databaseOperator);
    }

    public enum Operator
    {
      Equal,
      GreaterThan,
      LessThan,
      GreaterThanOrEqual,
      LesserThanOrEqual,
      NotEqualTo,
    }

    public readonly string DependentOperator;
  }

  /// <summary>
  /// Basic link attributes
  /// </summary>
  public class DatabaseQueryLink
  {
    public DatabaseQueryLink(Link link)
    {
      DependentLink = ServiceLocator.Instance.Database.GetQueryLink(link);
    }

    public enum Link
    {
      And,
      Or,
    }

    public readonly string DependentLink;
  }

  /// <summary>
  /// Basic join operators
  /// </summary>
  public class DatabaseJoinOperator
  {
    public DatabaseJoinOperator(JoinOperator joinOperator)
    {
      DependentJoinOperator = ServiceLocator.Instance.Database.GetJoinOperator(joinOperator);
    }

    public enum JoinOperator
    {
      InnerJoin,
      LeftJoin,
      RightJoin,
      FullJoin,
    }

    public readonly string DependentJoinOperator;
  }

  /// <summary>
  /// Basic string operators
  /// </summary>
  public class DatabaseStringOperator
  {
    public DatabaseStringOperator(StringOperator stringOperator)
    {
      DependentStringOperator = ServiceLocator.Instance.Database.GetStringOperator(stringOperator);
    }

    public enum StringOperator
    {
      Like,
    }

    public readonly string DependentStringOperator;
  }
}
