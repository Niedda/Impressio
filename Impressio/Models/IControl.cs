namespace Impressio.Models
{
  /// <summary>
  /// Provides some standard methods for controls
  /// </summary>
  public interface IControl
  {
    /// <summary>
    /// Reload the control from the database
    /// </summary>
    void ReloadControl();

    /// <summary>
    /// Validates the control
    /// </summary>
    /// <returns>True if the control is valid and can be closed</returns>
    bool ValidateControl();
  }
}