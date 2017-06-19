using ClothingPSISQLite.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClothingPSISQLite.ModuleManagement
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //GZFramework框架配置
            ClothingPSISQLite.Library.Config.Config.Intentce.Init().LoadDBList();

            //调用系统管理中模块管理功能
            var frm = new ClothingPSISQLite.SystemManagement.frmModuleUpdateEx();
            frm.UserAuthority = GZFramework.UI.Core.FunctionAuthority.All;//设置功能所有权限

            Application.Run(frm);
        }


    }
}
