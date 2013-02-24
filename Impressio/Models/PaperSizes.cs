using System;
using System.Collections.Generic;
using Impressio.Models.Tools;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public class PaperSizes : DatabaseObjectBase<PaperSizes>
  {
    #region Columns

    public enum Columns
    {
      Width,
      Height,
      Name,
      IsFinishSize,
    }

    #endregion

    public int Width { get; set; }

    public int Height { get; set; }

    public string Size { get { return Width + " x " + Height; } }

    public string Name { get; set; }

    public bool IsFinishSize { get; set; }
    
    public override int Identity { get; set; }

    public override string IdentityColumn { get { return "PaperSizesId"; } }

    public override string Table { get { return "PaperSizes"; } }

    public override List<PaperSizes> Objects { get { return _paperSizes; } }

    public override void SetObject()
    {
      Identity = Database.DatabaseCommand.Reader[IdentityColumn].GetInt();
      Name = Database.DatabaseCommand.Reader[Columns.Name.ToString()] as string;
      Width = Database.DatabaseCommand.Reader[Columns.Width.ToString()].GetInt();
      Height = Database.DatabaseCommand.Reader[Columns.Height.ToString()].GetInt();
      IsFinishSize = (bool)Database.DatabaseCommand.Reader[Columns.IsFinishSize.ToString()];
    }

    public override void ClearObjectList()
    {
      _paperSizes.Clear();
    }

    public override Dictionary<Enum, object> GetObject()
    {
      return new Dictionary<Enum, object>
               {
                 {Columns.Name, Name},
                 {Columns.Width, Width},
                 {Columns.Height, Height},
                 {Columns.IsFinishSize, IsFinishSize},
               };
    }

    private List<PaperSizes> _paperSizes = new List<PaperSizes>();
  }
}
