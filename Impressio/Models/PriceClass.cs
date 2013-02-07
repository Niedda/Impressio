using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Subvento.Database;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class PriceClass : DatabaseObjectBase<PriceClass>
  {
    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "PriceClassId"; } }

    public override string Table { get { return "PriceClass"; } }

    public override List<PriceClass> Objects
    {
      get { throw new NotImplementedException(); }
    }

    public override void SetObject()
    {
      throw new NotImplementedException();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      throw new NotImplementedException();
    }
  }
}
