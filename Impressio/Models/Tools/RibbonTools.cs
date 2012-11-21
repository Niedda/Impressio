using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace Impressio.Models.Tools
{
  public static class RibbonTools
  {
    public static BarButtonItem GetDeleteButton()
    {
      return new BarButtonItem
      {
        Caption = "Löschen",
        LargeGlyph = Properties.Resources.delete,
        LargeWidth = 80,
        ItemShortcut = new BarShortcut(Keys.ShiftKey, Keys.Delete),
        ShortcutKeyDisplayString = "Shift + Delete",
      };
    }

    public static BarButtonItem GetDeleteButton(ItemClickEventHandler handler)
    {
      var button = GetDeleteButton();
      button.ItemClick += handler;
      return button;
    }

    public static BarButtonItem GetRefreshButton()
    {
      return new BarButtonItem
      {
        Caption = "Aktualisieren",
        LargeGlyph = Properties.Resources.refresh,
        LargeWidth = 80,
        ItemShortcut = new BarShortcut(Keys.F5),
        ShortcutKeyDisplayString = "F5",
      };
    }

    public static BarButtonItem GetRefreshButton(ItemClickEventHandler handler)
    {
      var button = GetRefreshButton();
      button.ItemClick += handler;
      return button;
    }

    public static BarButtonItem GetOpenButton()
    {
      return new BarButtonItem
      {
        Caption = "Öffnen",
        LargeGlyph = Properties.Resources.open,
        LargeWidth = 80,
        ItemShortcut = new BarShortcut(Keys.Enter),
        ShortcutKeyDisplayString = "Enter",
      };
    }

    public static BarButtonItem GetOpenButton(ItemClickEventHandler handler)
    {
      var button = GetOpenButton();
      button.ItemClick += handler;
      return button;
    }

    public static BarButtonItem GetPrintButton(string caption)
    {
      return new BarButtonItem
               {
                 Caption = caption,
                 LargeGlyph = Properties.Resources.printglyph,
                 LargeWidth = 80,
                 ItemShortcut = new BarShortcut(Keys.Control, Keys.P),
                 ShortcutKeyDisplayString = "Ctrl + P",
               };
    }

    public static BarButtonItem GetPrintButton(string caption, ItemClickEventHandler handler)
    {
      var button = GetPrintButton(caption);
      button.ItemClick += handler;
      return button;
    }

    public static BarButtonItem GetCustomButton(string caption, System.Drawing.Image glyph)
    {
      return new BarButtonItem
               {
                 Caption = caption,
                 LargeGlyph = glyph,
                 LargeWidth = 80,
               };
    }

    public static BarButtonItem GetCustomButton(string caption, System.Drawing.Image glyph, ItemClickEventHandler handler)
    {
      var button = GetCustomButton(caption, glyph);
      button.ItemClick += handler;
      return button;
    }

    public static RibbonPageGroup GetRibbonGroup(List<BarButtonItem> buttons)
    {
      var group = new RibbonPageGroup();
      group.ItemLinks.AddRange(buttons.ToArray());
      return group;
    }

    public static RibbonPage GetRibbonPage(RibbonPageGroup[] groups, string caption)
    {
      var page = new RibbonPage(caption);
      page.Groups.AddRange(groups);
      return page;
    }

    public static RibbonPage GetSimplePage(List<BarButtonItem> buttons, string caption)
    {
      var group = GetRibbonGroup(buttons);
      var page = new RibbonPage(caption);
      page.Groups.Add(group);
      return page;
    }
  }
}
