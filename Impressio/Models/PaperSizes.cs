using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impressio.Models
{
  public class PaperSizes
  {
    public int Width { get; set; }

    public int Height { get; set; }

    public string Size { get { return Width + " x " + Height; } }

    public string Name { get; set; }

    public static List<PaperSizes> GetEndSizes()
    {
      return new List<PaperSizes>
               {
                 new PaperSizes{Name = "A1", Height = 594, Width = 841},
                 new PaperSizes{Name = "A2", Height = 420, Width = 594},
                 new PaperSizes{Name = "A3", Height = 297, Width = 420},
                 new PaperSizes{Name = "A4", Height = 210, Width = 297},
                 new PaperSizes{Name = "A5", Height = 148, Width = 210},
                 new PaperSizes{Name = "A6", Height = 105, Width = 210},
                 new PaperSizes{Name = "A7", Height = 74, Width = 105},
                 new PaperSizes{Name = "VK", Height = 55, Width = 85},
                 new PaperSizes{Name = "C4", Height = 229, Width = 324},
                 new PaperSizes{Name = "C5", Height = 162, Width = 229},
               };
    }

    public static List<PaperSizes> GetPrintSizes()
    {
      return new List<PaperSizes>
               {
                 new PaperSizes{Name = "SRA4", Height = 225, Width = 320},
                 new PaperSizes{Name = "SRA3", Height = 320, Width = 450},
                 new PaperSizes{Name = "", Height = 320, Width = 460},
                 new PaperSizes{Name = "", Height = 350, Width = 500},
                 new PaperSizes{Name = "", Height = 460, Width = 640},
                 new PaperSizes{Name = "", Height = 500, Width = 700},
               };
    }
  }
}
