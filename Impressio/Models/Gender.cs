using System;
using System.Collections.Generic;
using Impressio.Models.Database.DatabaseObject;
using Impressio.Models.Tools;

namespace Impressio.Models
{
  public class Gender : DatabaseObjectBase<Gender>
  {
    #region Columns enum

    public enum Columns
    {
      Name,
    }

    #endregion

    private readonly List<Gender> _genders = new List<Gender>();

    public override int Identity { get; set; }

    public override string IdentityColumn
    {
      get { return "GenderId"; }
    }

    public override string Table
    {
      get { return "Gender"; }
    }

    public string Name { get; set; }

    public override List<Gender> Objects
    {
      get { return _genders; }
    }

    public override void SetObject()
    {
      Identity = Database.Reader["GenderId"].GetInt();
      Name = Database.Reader["Gender"] as string;
    }

    public override void SetObjectList()
    {
      var gender = new Gender();
      gender.SetObject();
      _genders.Add(gender);
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.Name, Name},
               };
    }
  }
}