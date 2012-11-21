using System;
using System.Collections.Generic;
using System.Data.Common;
using Subvento.Database;

namespace Subvento.DatabaseObject
{
  /// <summary>
  /// Use the QueryBuilder to build basic custom querys vs the database
  /// </summary>
  public class QueryBuilder
  {
    public QueryBuilder(string table, Query query)
    {
      _table = table;
      _queries.Add(query);
    }

    public void AppendQuery(DatabaseQueryLink linkAttribute, Query query)
    {
      _queries.Add(query);
    }
    
    public void AppendJoin(string tableToJoin, DatabaseJoinOperator joinAttribute, Enum columnToJoin, Enum columnToCompare)
    {
      _joins.Add(string.Format(" {0} {1} on {2} = {3}", joinAttribute.DependentJoinOperator, _database.GetEscapedTableName(tableToJoin), columnToJoin, columnToCompare));
    }

    public DbCommand GetQuery()
    {
      _database.DatabaseCommand.CommandString = string.Format("Select * from {0} ", _database.GetEscapedTableName(_table));

      foreach (var join in _joins)
      {
        _database.DatabaseCommand.CommandString += join;
      }

      _database.DatabaseCommand.CommandString += " where ";
      foreach (var query in _queries)
      {
        _database.DatabaseCommand.CommandString += string.Format(" {0} {1} @{0} ", query.Column, query.Operator);
      }

      _database.SetCommand();

      foreach (var query in _queries)
      {
        _database.DatabaseCommand.AddParameter(query.Column, query.Value);
      }

      return _database.DatabaseCommand.Command;
    }

    private readonly string _table;

    private readonly IDatabase _database = ServiceLocator.Instance.Database;

    private readonly List<string> _joins = new List<string>();

    private readonly List<Query> _queries = new List<Query>();
  }
}