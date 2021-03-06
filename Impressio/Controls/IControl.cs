﻿using DevExpress.XtraBars;

namespace Impressio.Controls
{
  /// <summary>
  /// Provides some standard methods for controls
  /// </summary>
  public interface IControl : IRibbon
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

    void ReloadControl(object sender, ItemClickEventArgs e);
  }
}