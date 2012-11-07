using System.Collections.Generic;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace Impressio.Models
{
  public interface IRibbon
  {
    string RibbonGroupName { get; }

    List<BarButtonItem> Buttons { get; }

    RibbonPageGroup GetRibbon();
  }
}
