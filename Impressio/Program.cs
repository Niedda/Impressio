﻿using System;
using System.Windows.Forms;
using Impressio.Properties;
using Impressio.Views;

namespace Impressio
{
  internal static class Program
  {
    public static MainViewRibbon MainView;

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
      DevExpress.UserSkins.OfficeSkins.Register();
      DevExpress.UserSkins.BonusSkins.Register();
      DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = Settings.Default.lookAndFeel;
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      var myContext = new SplashAppContext(MainViewRibbon.Instance, new StartScreen());
      Application.Run(myContext);
    }
  }
}