using System;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Impressio.Views
{
  public class SplashAppContext : ApplicationContext
  {
    public SplashAppContext(Form mainForm, StartScreen splashForm)
      : base(splashForm)
    {
      _mainForm = mainForm;
      _splashForm = splashForm;
      _splashTimer.Tick += SplashTimeUp;
      _splashTimer.Interval = 1000;
      _splashTimer.Enabled = true;
    }

    private readonly StartScreen _splashForm;

    private Form _mainForm;

    private readonly Timer _splashTimer = new Timer();

    private void SplashTimeUp(object sender, EventArgs e)
    {
      _splashTimer.Enabled = false;
      _splashTimer.Dispose();

      if (_splashForm.CheckConnection())
      {
        if (_splashForm.CheckDatabaseFields())
        {
          MainForm.Close();
          return;
        }
      }
      _mainForm = new StartScreen();
      Application.Exit();
    }

    protected override void OnMainFormClosed(object sender, EventArgs e)
    {
      if (sender is StartScreen)
      {
        MainForm = _mainForm;
        MainForm.Show();
      }
      else if (sender is MainViewRibbon)
      {
        base.OnMainFormClosed(sender, e);
      }
    }
  }
}
