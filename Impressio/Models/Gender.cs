using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class Gender : DatabaseObjectBase<Gender>
  {
    #region Columns enum

    public enum Columns
    {
      Gender,
    }

    #endregion
    
    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "GenderId"; } }

    public override string Table { get { return "Gender"; } }

    public string Name { get; set; }

    public override List<Gender> Objects { get { return _genders; } }

    public override void SetObject()
    {
      Identity = Database.Reader[IdentityColumn].GetInt();
      Name = Database.Reader[Columns.Gender.ToString()] as string;
    }
    
    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.Gender, Name},
               };
    }

    private readonly List<Gender> _genders = new List<Gender>();
  }
}