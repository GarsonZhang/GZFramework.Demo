using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFramework.UI.Dev
{
    class Lic
    {
        public static Lic Instance = new Lic();


        private int TrialNum = 0;
        private bool IsLic = false;
        //private string ErrorMsg = "";
        private Lic()
        {
            IsLic = true;
            //if (System.Diagnostics.Debugger.IsAttached)
            //{
            //    IsLic = true;
            //    return;
            //}
            //GZFramework.License.RegisterHelper register = new License.RegisterHelper();
            //IsLic = register.ValidateMachine(License.ProductEnum.GZFramework_UI_Dev, out ErrorMsg);
        }

        public bool ValidateLic()
        {
            if (IsLic == false)
            {
                if (TrialNum >= 20)
                {
                    throw new Exception("未注册GZFrameowk.UI.Dev\r\n请联系作者QQ：382237285,免费获得注册码！！\r\nQQ交流群：288706356");
                }
                TrialNum++;
            }
            return true;
        }
    }
}
