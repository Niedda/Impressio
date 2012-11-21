using System;
using System.Collections.Generic;
using Subvento.Database;

namespace Subvento.DatabaseObject
{
  /// <summary>
  /// Absract Base Class for DatabaseObjects
  /// </summary>
  /// <typeparam name="T">The Object to handle</typeparam>
  public abstract class DatabaseObjectBase<T> : IDatabaseObject<T>
  {
    public abstract int Identity { get; set; }

    public abstract string IdentityColumn { get; }

    public abstract string Table { get; }

    public abstract void SetObject();
    
    public virtual void ClearObjectList()
    {
      Objects.Clear();
    }

    public abstract Dictionary<Enum, object> GetObject();

    public abstract List<T> Objects { get; }

    public IDatabase Database { get { return ServiceLocator.Instance.Database; } }
  }
}