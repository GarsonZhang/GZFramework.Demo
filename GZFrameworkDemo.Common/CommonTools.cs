using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GZFrameworkDemo.Common
{
    public class CommonTools
    {
        public static string InfoID_GetFullInfoID(string SimpleInfoID)
        {
            if (SimpleInfoID.Length > 6) return SimpleInfoID;
            else
                return 'A' + SimpleInfoID.PadLeft(6, '0');
        }

        public static string InfoID_GetSimpleInfoID(string InfoID)
        {
            Regex re = new Regex(@"[1-9]\d*(\.\d*)?");
            var a = re.Matches(InfoID);
            if (a.Count > 0)
                return a[0].Value;
            else
                return null;
        }
    }
}
