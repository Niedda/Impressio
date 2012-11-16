using System;
using Impressio.Models;

namespace Impressio.Controls
{
  public interface IControlHandler
  {
    IControl ActiveControl { get; set; }

    IControl DetailControl { get; set; }

    bool Validate();

    bool BringDefaultToFront();
    
    void PageChanged(object sender, EventArgs e);
  }
}
