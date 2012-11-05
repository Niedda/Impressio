using System;
using System.Collections.Generic;

namespace Impressio.Models.Database.DatabaseObject
{
  /// <summary>
  /// Interface for dealing with DatabaseObjects implement the DatabaseObjectBase Class for use
  /// </summary>
  public interface IDatabaseObject<T>
  {
    int Identity { get; set; }

    string IdentityColumn { get; }

    string Table { get; }
    List<T> Objects { get; }

    IDatabase Database { get; }

    void SetObject();

    void SetObjectList();

    void ClearObjectList();

    Dictionary<Enum, object> GetObject();
  }
}