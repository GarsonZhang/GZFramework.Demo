using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Common
{
    public class INIUserAccound
    {

        static IniFile Ini = new IniFile(AppDomain.CurrentDomain.BaseDirectory + @"\Config\User.Ini");

        const string Session = "UserInfo";
        /// <summary>
        /// 获得用户名
        /// </summary>
        /// <returns></returns>
        public static string GetAccound()
        {
            return Ini.IniReadValue(Session, "Accound");
        }
        /// <summary>
        /// 保存用户名
        /// </summary>
        /// <param name="SkinName"></param>
        public static void SetAccound(string Accound)
        {
            Ini.IniWriteValue(Session, "Accound", Accound);
        }


        /// <summary>
        /// 获得密码
        /// </summary>
        /// <returns></returns>
        public static string GetPwd()
        {
            return Ini.IniReadValue(Session, "Pwd");
        }
        /// <summary>
        /// 保存密码
        /// </summary>
        /// <param name="SkinName"></param>
        public static void SetPwd(string Pwd)
        {
            Ini.IniWriteValue(Session, "Pwd", Pwd);
        }

    }
}
