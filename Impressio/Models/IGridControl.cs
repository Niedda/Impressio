namespace Impressio.Models
{
  /// <summary>
  /// Offers some standard methods for controls with grids
  /// </summary>
  /// <typeparam name="T">Object bound to the Grid</typeparam>
  public interface IGridControl<T>
  {
    /// <summary>
    /// The focused grid row
    /// </summary>
    T FocusedRow { get; }

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