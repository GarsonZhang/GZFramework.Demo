using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Common
{
    public class Globals
    {
        /// <summary>
        /// 返回路径(不包含最后的\)，格式：D:\Debug
        /// </summary>
        public static string BaseDirectory
        {
            get
            {
                //return AppDomain.CurrentDomain.BaseDirectory;//包含最后的\
                return System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
                
            }
        }

        public const string KeyConnectionStr = "GZFramew";
    }
}
