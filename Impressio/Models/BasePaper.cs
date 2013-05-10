using Subvento.DatabaseObject;

namespace Impressio.Models
{
  public abstract class BasePaper
  {
    public int PaperPrice { get; set; }

    public int RawQuantity
    {
      get { return (PaperQuantity + PaperAddition) / (UsePerRawHorizontal * UsePerRawVertical); }
    }

    public int PaperQuantity { get; set; }

    public int PaperAddition { get; set; }

    public int PriceAddition { get; set; }

    public int UsePerRawHorizontal { get; set; }

    public int UsePerRawVertical { get; set; }

    public int FkPaper
    {
      set
      {
        if (value > 0 && _fkPaper != value)
        {
          Paper = Paper ?? new Paper();
          Paper.Identity = value;
          Paper.LoadSingleObject();
        }
      }
    }

    public int PaperPriceTotal
    {
      get { return RawQuantity * ((PriceAddition / 100 + 1) * PaperPrice); }
    }

    public bool FlippedUsePerRawPaper { get; set; }

    public Paper Paper { get; set; }

    private int _fkPaper;
  }
}
