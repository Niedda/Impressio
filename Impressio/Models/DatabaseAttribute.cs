using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impressio.Models
{
  public class DatabaseAttribute : Attribute
  {
    public bool IsNullable { get; set; }

  }

  public class PositionAttribute : Attribute
  {
    
  }
}
