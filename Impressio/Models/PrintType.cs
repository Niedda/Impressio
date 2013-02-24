using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impressio.Models
{
  public class PrintType
  {
    public int Identity { get; set; }

    public string Name { get; set; }

    public static List<PrintType> PrintTypes
    {
      get
      {
        return new List<PrintType>
          {
            new PrintType
                {
                  Name = "Einseitig",
                  Identity = 1,
                },
                new PrintType
                  {
                    Name = "Umschlagen",
                    Identity = 2,
                  },
                new PrintType
                  {
                    Name = "Umstülpen",
                    Identity = 3,
                  },     
                new PrintType
                  {
                    Name = "SD / WD",
                    Identity = 4,
                  },
          };
      }
    }
  }
}
