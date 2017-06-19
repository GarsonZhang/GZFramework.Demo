using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Common
{
    public class INIDBConfig
    {

        IniFile Ini = null;
        public INIDBConfig()
        {
            Ini = new IniFile(AppDomain.CurrentDomain.BaseDirectory + @"\Config\System.Ini");
        }

        const string SessionDB = "SystemDB";

        /// <summary>
        /// 获取DBCode
        /// </summary>
        /// <returns></returns>
        public string GetDBCode()
        {
            return Ini.IniReadValue(SessionDB, "DBCode");
        }
        /// <summary>
        /// 保存DBCode
        /// </summary>
        /// <param name="Checked"></param>
        public void SetDBCode(string DBCode)
        {
            Ini.IniWriteValue(SessionDB, "DBCode", DBCode);
        }

        /// <summary>
        /// 获取ConnStr
        /// </summary>
        /// <param name="Checked"></param>
        public string GetConnStr()
        {
            string str = Ini.IniReadValue(SessionDB, "ConnStr");
            //str = Encrypt.DESDecrypt(str, Globals.KeyConnectionStr);
            return str;
        }
        /// <summary>
        /// 保存ConnStr
        /// </summary>
        /// <param name="Checked"></param>
        public void SetConnStr(string ConnStr)
        {
            //ConnStr = Encrypt.DESEncrypt(ConnStr, Globals.KeyConnectionStr);
            Ini.IniWriteValue(SessionDB, "ConnStr", ConnStr);
        }

        /// <summary>
        /// 获取ProviderName
        /// </summary>
        /// <param name="Checked"></param>
        public string GetProviderName()
        {
            return Ini.IniReadValue(SessionDB, "ProviderName");
        }
        /// <summary>
        /// 保存ProviderName
        /// </summary>
        /// <param name="Checked"></param>
        public void SetProviderName(string ProviderName)
        {
            Ini.IniWriteValue(SessionDB, "ProviderName", ProviderName);
        }
        

    }
}
