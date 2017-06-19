using GZFramework.UI.Dev.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GZFrameworkDemo.Main
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.ApplicationExit += Application_ApplicationExit;
                Application.ThreadException += Application_ThreadException;
                Application.SetCompatibleTextRenderingDefault(false);

                GZFramework.UI.Dev.SplashScreenServer.ShowForm(null);//跳转窗体

                GZFrameworkDemo.Library.Config.Config.Intentce.Init();

                #region 设置默认字体、日期格式、汉化dev

                DevExpress.Utils.AppearanceObject.DefaultFont = new System.Drawing.Font("Tahoma", 12);

                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CHS");//使用DEV汉化资源文件

                //设置程序区域语言设置中日期格式

                System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("zh-CHS");

                System.Globalization.DateTimeFormatInfo di = (System.Globalization.DateTimeFormatInfo)System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.Clone();

                di.DateSeparator = "-";

                di.ShortDatePattern = "yyyy-MM-dd";

                di.LongDatePattern = "yyyy'年'M'月'd'日'";

                di.ShortTimePattern = "H:mm:ss";

                di.LongTimePattern = "H'时'mm'分'ss'秒'";

                ci.DateTimeFormat = di;

                System.Threading.Thread.CurrentThread.CurrentCulture = ci;

                #endregion


                Application.Run(new frmMain());
            }
            catch (Exception e)
            {
            }
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            GZFrameworkDemo.Library.MyClass.ApplicationEx.Exit();
        }
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            GZFramework.UI.Dev.WaiteServer.CloseWaite();
            frmExceptionShow.Show(e.Exception.InnerException ?? e.Exception);
        }
    }
}
