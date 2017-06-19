using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace GZFramework.UI.Dev
{
    public class SplashScreenServer
    {
        public static bool Shown { get; private set; }
        public static void ShowForm(Form frm)
        {
            if (Shown == true) return;
            SplashScreenManager.ShowForm(frm, typeof(GZ_SplashScreen1), true, true);
            Shown = true;
        }
        public static void SendCommand(string lblText, int Position)
        {
            SplashScreenManager.Default.SendCommand(GZ_SplashScreen1.SplashScreenCommand.Setinfo,
                 new Info() { LabelText = lblText, Pos = Position });
        }

        public static void CloseForm()
        {
            if (Shown == false) return;
            SplashScreenManager.CloseForm();
            Shown = false;
        }
    }
}
