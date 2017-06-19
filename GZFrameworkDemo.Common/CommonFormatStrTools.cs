using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using GZFrameworkDemo.Common;

namespace GZFrameworkDemo.Common
{
    public sealed class CommonFormatStrTools
    {


        public static string GetDataTableColValueFormatIn(DataTable dt, string ColumnName)
        {
            var v = dt.DefaultView.ToTable(true, ColumnName);
            string rel = string.Empty;
            foreach (DataRow dr in v.Rows)
            {
                if (string.IsNullOrEmpty(rel))
                    rel = GetFormatInValue(ConvertLib.ToString(dr[ColumnName]));
                else rel += "," + GetFormatInValue(ConvertLib.ToString(dr[ColumnName]));
            }
            return rel;
        }

        public static string GetDataTableColValueFormatIn(IEnumerable<string> values)
        {
            string rel = string.Empty;
            foreach (string str in values)
            {
                if (string.IsNullOrEmpty(rel))
                    rel = GetFormatInValue(ConvertLib.ToString(str));
                else rel += "," + GetFormatInValue(ConvertLib.ToString(str));
            }
            return rel;
        }

        public static string FormatValueIn(string str, string separator)
        {
            string rel = "";
            foreach (string s in str.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (String.IsNullOrEmpty(s)) continue;
                if (string.IsNullOrEmpty(rel))
                    rel = GetFormatInValue(s.Trim());
                else rel += "," + GetFormatInValue(s.Trim());
            }
            return rel;


        }
        public static IEnumerable<string> GetDataTableColValueFormatGroupIn(DataTable dt, string ColumnName, int MaxLength)
        {
            var v = dt.DefaultView.ToTable(true, ColumnName);

            List<string> Result = new List<string>();

            string tmp = "", current = "";
            for (int i = 0; i < v.Rows.Count; i++)
            {
                current = GetFormatInValue(ConvertLib.ToString(v.Rows[i][ColumnName]));

                if (tmp.Length + current.Length > MaxLength)
                {
                    Result.Add(tmp);
                    tmp = "";
                }
                tmp += "," + current;
            }
            foreach (string s in Result)
                yield return s.Substring(1);
        }


        public static IEnumerable<string> GetDataTableColValues(DataTable dt, string ColumnName)
        {
            var v = dt.DefaultView.ToTable(true, ColumnName);

            foreach (DataRow dr in v.Rows)
            {
                yield return ConvertLib.ToString(dr[ColumnName]);
            }
        }

        public static string GetDataTableColValueFormatStr(DataTable dt, string ColumnName, string Split)
        {
            var v = dt.DefaultView.ToTable(true, ColumnName);
            string rel = string.Empty;
            foreach (DataRow dr in v.Rows)
            {
                if (string.IsNullOrEmpty(rel))
                    rel = ConvertLib.ToString(dr[ColumnName]);
                else rel += Split + ConvertLib.ToString(dr[ColumnName]);
            }
            return rel;
        }

        public static string GetDataTableColValueFormatStr(IEnumerable<string> strs, string Split)
        {
            string rel = string.Empty;
            foreach (string dr in strs)
            {
                if (string.IsNullOrEmpty(rel))
                    rel = dr;
                else rel += Split + dr;
            }
            return rel;
        }

        public static IEnumerable<string> GetDataTableColValueFormatGroupStr(DataTable dt, string ColumnName, string Split, int MaxLength)
        {
            var v = dt.DefaultView.ToTable(true, ColumnName);


            List<string> Result = new List<string>();

            string tmp = ""; string current = "";
            for (int i = 0; i < v.Rows.Count; i++)
            {
                current = ConvertLib.ToString(v.Rows[i][ColumnName]);
                if (tmp.Length + current.Length > MaxLength)
                {
                    Result.Add(tmp);
                    tmp = "";
                }
                tmp += Split + current;
            }
            if (!String.IsNullOrEmpty(tmp)) Result.Add(tmp);

            foreach (string s in Result)
                yield return s.Substring(Split.Length);
        }
        public static IEnumerable<string> GetDataTableColValueFormatGroupStr(IEnumerable<string> strs, string Split, int MaxLength)
        {
            
            List<string> Result = new List<string>();

            string tmp = "";
            foreach (string current in strs)
            {
                if (tmp.Length + current.Length > MaxLength)
                {
                    Result.Add(tmp);
                    tmp = "";
                }
                tmp += Split + current;
            }
            if (!String.IsNullOrEmpty(tmp)) Result.Add(tmp);

            foreach (string s in Result)
                yield return s.Substring(Split.Length);
        }

        public static string GetFormatInValue(string Value)
        {
            string Str = string.Empty;
            Str += "'" + Value + "'";
            return Str;
        }


    }
}
