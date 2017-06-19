using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GZFrameworkDemo.Common
{
    /// <summary>
    /// 操作INI文件类    测试信息
    /// </summary>
    public class IniFile
    {
        const int DATA_SIZE = 1024;

        private string _path; //INI档 案 名 
        public string IniPath { get { return _path; } set { _path = value; } }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct STRINGBUFFER
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = DATA_SIZE)]
            public string szText;
        }

        //读写INI文件的API函数 
        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Auto)]
        private static extern int GetPrivateProfileString(string section, string key, string def, out STRINGBUFFER retVal, int size, string filePath);

        //类的构造函数，传递INI档案名 
        public IniFile(string sPath)
        {
            _path = sPath;
            string path = IniPath.Substring(0, IniPath.LastIndexOf("\\"));
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            if (!File.Exists(_path)) CreateIniFile();
        }

        //写INI文件 
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this._path);
        }

        //读取INI文件指定项目的数据 
        public string IniReadValue(string Section, string Key)
        {
            int i;
            STRINGBUFFER RetVal;
            i = GetPrivateProfileString(Section, Key, null, out RetVal, DATA_SIZE, this._path);
            string temp = RetVal.szText;
            return temp.Trim();
        }

        //读取INI文件指定项目的数据 
        public string IniReadValue(string Section, string Key, string defaultValue)
        {
            int i;
            STRINGBUFFER RetVal;
            i = GetPrivateProfileString(Section, Key, null, out RetVal, DATA_SIZE, this._path);
            string temp = RetVal.szText;
            return temp.Trim() == "" ? defaultValue : temp.Trim();
        }

        /// <summary>
        /// 创建INI文件
        /// </summary>
        public void CreateIniFile()
        {
            StreamWriter w = File.CreateText(_path);
            w.Write("");
            w.Flush();
            w.Close();
        }
    }
}
