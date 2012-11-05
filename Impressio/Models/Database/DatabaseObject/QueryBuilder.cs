using System;
using System.Collections.Generic;
using Impressio.Properties;

namespace Impressio.Models.Database.DatabaseObject
{
  /// <summary>
  /// Use the QueryBuilder to build custom querys vs the database
  /// </summary>
  public class QueryBuilder
  {
    private readonly IDatabase _database = ServiceLocator.Instance.Database;
    private readonly List<string> _joins = new List<string>();
    private readonly List<Query> _queries = new List<Query>();
    private readonly string _table;

    public QueryBuilder(string table, Query query)
    {
      _table = table;
      _queries.Add(query);
    }

    public void AppendQuery(DatabaseBinderAttribute binderAttribute, Query query)
    {
      _queries.Add(query);
    }

    public void AppendJoin(string tableToJoin, DatabaseJoinAttribute joinAttribute, Enum columnToJoin,
                           Enum columnToCompare)
    {
      _joins.Add(string.Format(" {0} {1} on {2} = {3}", joinAttribute.Sign, _database.GetEscapedTableName(tableToJoin),
                               columnToJoin, columnToCompare));
    }

    public void SetQuery()
    {
      _database.CommandString = string.Format("Select * from {0} ", _database.GetEscapedTableName(_table));

      foreach (string join in _joins)
      {
        _database.CommandString += join;
      }

      _database.CommandString += " where ";
      foreach (Query query in _queries)
      {
        _database.CommandString += string.Format(" @{0} {1} {0} ", query.Column, query.Operator);
      }

      _database.SetCommand();

      foreach (Query query in _queries)
      {
        _database.AddParameter(query.Column, query.Value);
      }
    }
  }

  public class Query
  {
    public string Column;

    public string Operator;
    public object Value;

    public Query(Enum column, DatabaseOperatorAttribute databaseOperator, object value)
    {
      Value = value;
      Column = column.ToString();
      Operator = databaseOperator.Sign;
    }
  }

  public static class DatabaseOperator
  {
    public static DatabaseOperatorAttribute Equal
    {
      get
      {
        switch (Settings.Default.databaseEngine)
        {
          case "mssql":
            return new DatabaseOperatorAttribute(" = ");
          case "posql":
            return new DatabaseOperatorAttribute(" = ");
          case "compact":
            return new DatabaseOperatorAttribute(" = ");
          default:
            return new DatabaseOperatorAttribute(" = ");
        }
      }
    }

    public static DatabaseOperatorAttribute Like
    {
      get
      {
        switch (Settings.Default.databaseEngine)
        {
          case "mssql":
            return new DatabaseOperatorAttribute(" like ");
          case "posql":
            return new DatabaseOperatorAttribute(" like ");
          case "compact":
            return new DatabaseOperatorAttribute(" like ");
          default:
            return new DatabaseOperatorAttribute(" like ");
        }
      }
    }
  }

  public static class DatabaseBinder
  {
    public static DatabaseBinderAttribute And
    {
      get
      {
        switch (Settings.Default.databaseEngine)
        {
          case "mssql":
            return new DatabaseBinderAttribute(" and ");
          case "posql":
            return new DatabaseBinderAttribute(" and ");
          case "compact":
            return new DatabaseBinderAttribute(" and ");
          default:
            return new DatabaseBinderAttribute(" and ");
        }
      }
    }

    public static DatabaseBinderAttribute Or
    {
      get
      {
        switch (Settings.Default.databaseEngine)
        {
          case "mssql":
            return new DatabaseBinderAttribute(" or ");
          case "posql":
            return new DatabaseBinderAttribute(" or ");
          case "compact":
            return new DatabaseBinderAttribute(" or ");
          default:
            return new DatabaseBinderAttribute(" or ");
        }
      }
    }
  }

  public static class DatabaseJoin
  {
    public static DatabaseJoinAttribute InnerJoin
    {
      get { return new DatabaseJoinAttribute(" inner join "); }
    }

    public static DatabaseJoinAttribute LeftOuterJoin
    {
      get { return new DatabaseJoinAttribute(" left outer join "); }
    }
  }

  public class DatabaseOperatorAttribute : Attribute
  {
    public readonly string Sign;

    public DatabaseOperatorAttribute(string sign)
    {
      Sign = sign;
    }
  }

  public class DatabaseBinderAttribute : Attribute
  {
    public readonly string Sign;

    public DatabaseBinderAttribute(string sign)
    {
      Sign = sign;
    }
  }

  public class DatabaseJoinAttribute : DatabaseAttribute
  {
    public DatabaseJoinAttribute(string sign) : base(sign)
    {
    }
  }

  public abstract class DatabaseAttribute
  {
    public readonly string Sign;

    protected DatabaseAttribute(string sign)
    {
      Sign = sign;
    }
  }
}