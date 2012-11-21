using System;
using System.Collections.Generic;
using Subvento.DatabaseObject;

namespace Subvento
{
  /// <summary>
  /// Sample for demonstrating how to use the DatabaseObjectBase Class
  /// </summary>
  /// Load a single Sample Person:
  ///   var person = (SamplePerson)new SamplePerson { Identity = id }.LoadSingleObject();
  /// Load a List of all Sample Person:
  ///   var personList = new SamplePerson().LoadObjectList();
  /// Load a List by a key value:
  ///   var personList = new SamplePerson().LoadObjectList(SamplePerson.Columns.FkCompany, value);
  public class SamplePerson : DatabaseObjectBase<SamplePerson>
  {
    #region Columns

    public enum Columns
    {
      Firstname,
      Lastname,
      FkCompany,
    }

    #endregion

    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "SamplePersonId"; } }

    public override string Table { get { return "Person"; } }

    public string Firstname { get; set; }

    public string Lastname { get; set; }

    public int FkCompany { get; set; }

    public override void SetObject()
    {
      Identity = (int)Database.DatabaseCommand.Reader[IdentityColumn];
      Firstname = Database.DatabaseCommand.Reader[Columns.Firstname.ToString()] as string;
      Lastname = Database.DatabaseCommand.Reader[Columns.Lastname.ToString()] as string;
      FkCompany = (int)Database.DatabaseCommand.Reader[Columns.FkCompany.ToString()];
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.Firstname, Firstname},
                 {Columns.Lastname, Lastname},
               };
    }

    public override List<SamplePerson> Objects
    {
      get { return _objects; }
    }

    public override void ClearObjectList()
    {
      _objects.Clear();
    }

    public List<SamplePerson> LoadByFistname(string name)
    {
      var query = new Query(Columns.Firstname, new DatabaseStringOperator(DatabaseStringOperator.StringOperator.Like), name);
      var queryBuiler = new QueryBuilder(Table, query);
      return this.LoadObjectList(queryBuiler.GetQuery());
    }
    
    private readonly List<SamplePerson> _objects = new List<SamplePerson>();
  }
}
