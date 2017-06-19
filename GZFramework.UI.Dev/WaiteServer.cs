using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace GZFramework.UI.Dev
{
    public class WaiteServer
    {
        public static void ShowWaite(Form frm)
        {
            SplashScreenManager.ShowForm(frm, typeof(GZFramework.UI.Dev.GZ_WaitForm1), true, true, false);
        }

        public static void SetWaitFormCaption(string caption)
        {
            SplashScreenManager.Default.SetWaitFormCaption(caption);
        }
        public static void SetWaitFormDescription(string description)
        {
            SplashScreenManager.Default.SetWaitFormDescription(description);
        }
        public static void CloseWaite()
        {
            SplashScreenManager.CloseForm(false);
        }
    }
}
