using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Common
{
    public static class CustomerExtensions
    {

        /// <summary>
        /// 获得查重后指定列的字符串集合
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ColumnName"></param>
        /// <param name="Split"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetStrValue(this DataTable dt, string ColumnName)
        {
            return CommonFormatStrTools.GetDataTableColValues(dt, ColumnName);
        }
        


        /// <summary>
        /// 获得指定列查重后组成的字符串[指定分隔符]
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ColumnName"></param>
        /// <param name="Split"></param>
        /// <returns></returns>
        public static string FormatStrValue(this DataTable dt, string ColumnName, string Split)
        {
            return CommonFormatStrTools.GetDataTableColValueFormatStr(dt, ColumnName, Split);
        }

        /// <summary>
        /// 获得指定列查重后组成的字符串[用“,”做为分隔符]
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ColumnName"></param>
        /// <returns></returns>
        public static string FormatStrValue(this DataTable dt, string ColumnName)
        {
            return CommonFormatStrTools.GetDataTableColValueFormatStr(dt, ColumnName, ",");

        }

        /// <summary>
        /// 获得指定列查重后组成的SQL中In格式的字符串
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ColumnName"></param>
        /// <returns></returns>
        public static string FormatInValue(this DataTable dt, string ColumnName)
        {
            return CommonFormatStrTools.GetDataTableColValueFormatIn(dt, ColumnName);
        }

        /// <summary>
        /// 获得指定列查重后组成的字符串[指定分隔符],按指定长度分组
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ColumnName"></param>
        /// <param name="Split"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static IEnumerable<string> FormatGroupStrValue(this DataTable dt, string ColumnName, string Split,int MaxLength)
        {
            return CommonFormatStrTools.GetDataTableColValueFormatGroupStr(dt, ColumnName, Split, MaxLength);
        }
        /// <summary>
        /// 获得指定列查重后组成的字符串[[用“,”做为分隔符],按指定长度分组
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ColumnName"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static IEnumerable<string> FormatGroupStrValue(this DataTable dt, string ColumnName,int MaxLength)
        {
            return CommonFormatStrTools.GetDataTableColValueFormatGroupStr(dt, ColumnName, ",", MaxLength);
        }
        /// <summary>
        /// 获得指定列查重后组成的SQL中In格式的字符串,按指定长度分组
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="ColumnName"></param>
        /// <param name="?"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        public static IEnumerable<string> FormatGroupInValue(this DataTable dt, string ColumnName,int MaxLength)
        {
            return CommonFormatStrTools.GetDataTableColValueFormatGroupIn(dt, ColumnName, MaxLength);
        }



    }

}
