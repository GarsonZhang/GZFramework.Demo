using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Common
{
    public class ConvertLib
    {
        public static string ToString(object o)
        {
            if (o == null) return string.Empty;
            try
            {
                return o.ToString();
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 将十进制数转换为二进制字符串中1位所表示数的集合，eg:4,返回4 ；5返回 4和1
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static int[] ToBinaryNums(int d)
        {
            string str = ToBinaryReverse(d);
            List<int> lstNum = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '1')
                    lstNum.Add((int)Math.Pow(2, i));
            }
            return lstNum.ToArray();

        }
        /// <summary>
        /// 获得逆向的二进制字符串，配合ReverseStr可返回正确二进制字符串
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static string ToBinaryReverse(int d)
        {
            StringBuilder str = new StringBuilder();
            while (d > 0)
            {
                if (d % 2 == 1)
                    str.Append("1");
                else
                    str.Append("0");

                d = d / 2;
            }
            return str.ToString();
        }
        /// <summary>
        /// 返回逆向字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToReverseStr(string str)
        {
            string s = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                s += str[i];
            }

            return s;
        }

        /// <summary>
        /// 转换为整数
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int ToInt(object o)
        {
            return ToInt(o, 0);
        }

        /// <summary>
        /// 转换为整数
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static int ToInt(object o, int DefultValue)
        {
            if (IsNULL(o)) return DefultValue;
            try
            {
                return (int)Convert.ToDouble(o);
            }
            catch { return DefultValue; }
        }

        /// <summary>
        /// 转换为整数
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static decimal ToDecimal(object o, int DefultValue)
        {
            if (IsNULL(o)) return DefultValue;
            try
            {
                return (decimal)Convert.ToDecimal(o);
            }
            catch { return DefultValue; }
        }

        public static string DateTimeToString(DateTime time, string format)
        {
            return time.ToString(format);
        }

        public static DateTime ToDateTime(object o)
        {
            try
            {
                return Convert.ToDateTime(o);
            }
            catch
            {
                return DateTime.MinValue;
            }
        }


        private static bool IsNULL(object o)
        {
            if (null == o)
                return true;
            if (DBNull.Value == o)
                return true;
            if (String.Empty.Equals(o))
                return true;
            return false;
        }
    }
}
