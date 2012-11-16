using DevExpress.XtraGrid.Views.Grid;
using Subvento.DatabaseObject;

namespace Impressio.Models
{
  /// <summary>
  /// Offers some standard methods for controls with grids
  /// </summary>
  public interface IGridControl
  {
    /// <summary>
    /// Delete the selected Row
    /// </summary>
    void DeleteRow();

    /// <summary>
    /// Validate the selected row
    /// </summary>
    /// <returns>True if the row is valid</returns>
    bool ValidateRow();

    /// <summary>
    /// Update the selected row and saves it to the database
    /// </summary>
    void UpdateRow();
  }
}