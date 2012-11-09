using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
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
      _splashTimer.Interval = 3000;
      _splashTimer.Enabled = true;
    }

    private readonly StartScreen _splashForm;

    private readonly Form _mainForm;

    private readonly Timer _splashTimer = new Timer();

    private void SplashTimeUp(object sender, EventArgs e)
    {
      _splashTimer.Enabled = false;
      _splashTimer.Dispose();

      if (!_splashForm.CheckConnection())
      {
        XtraMessageBox.Show("Fehler beim Versuch zur Datenbank zu verbinden.", "Bitte die Einstellungen überprüfen");
        new StartupWizard().ShowDialog();
      }
      if (!_splashForm.CheckDatabaseFields())
      {
        XtraMessageBox.Show("Fehler beim Versuch die Datenbankfelder zu validieren. Versuchen Sie das mitgelieferte Script auf der Datenbank auszuführen.", "Bitte die Datenbank überprüfen");
      }

      MainForm.Close();
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
