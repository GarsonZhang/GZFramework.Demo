using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GZFramework.UI.Dev.Controls
{
    internal class CheckDesingModel
    {
        /// <summary>
        /// 判断是否处于设计模式
        /// </summary>
        public static bool IsDesingMode
        {
            get
            {
                bool ReturnFlag = false;
                if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                    ReturnFlag = true;
                else if (System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv")
                    ReturnFlag = true;
                return ReturnFlag;
            }
        }
        /// <summary>
        /// 获取是否处于调试模式
        /// </summary>
        public static bool IsDebug
        {
            get
            {
                return !System.Diagnostics.Debugger.IsAttached;
            }
        }
    }
}
