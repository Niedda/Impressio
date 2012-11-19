namespace Impressio.Models
{
  public interface IPosition
  {
    int Identity { get; set; }

    string Name { get; set; }

    int FkOrder { get; set; }

    int PositionTotal { get; }

    bool IsPredefined { get; set; }

    Type Type { get; }
  }
}