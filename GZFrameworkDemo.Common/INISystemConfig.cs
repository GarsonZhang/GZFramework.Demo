using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Common
{
    public class INISystemConfig
    {

        static IniFile Ini = new IniFile(AppDomain.CurrentDomain.BaseDirectory + @"\Config\System.Ini");

        const string SessionSystem = "SystemConfig";

        /// <summary>
        /// 获得软件标题
        /// </summary>
        /// <returns></returns>
        public static string GetTitle()
        {
            return Ini.IniReadValue(SessionSystem, "Title");
        }

        /// <summary>
        /// 设置软件标题
        /// </summary>
        /// <returns></returns>
        public static void SetTitle(string title)
        {
            Ini.IniWriteValue(SessionSystem, "Title", title);
        }

        /// <summary>
        /// 窗体状态，最大化
        /// </summary>
        /// <returns></returns>
        public static string GetWindowState()
        {
            return Ini.IniReadValue(SessionSystem, "WindowState");
        }
        /// <summary>
        /// 窗体状态，最大化
        /// </summary>
        /// <param name="SkinName"></param>
        public static void SetWindowState(string WindowState)
        {
            Ini.IniWriteValue(SessionSystem, "WindowState", WindowState);
        }

        /// <summary>
        /// 窗体位置
        /// </summary>
        /// <returns></returns>
        public static string GetWindowLocation()
        {
            return Ini.IniReadValue(SessionSystem, "WindowLocation");
        }
        /// <summary>
        /// 窗体位置
        /// </summary>
        /// <param name="SkinName"></param>
        public static void SetWindowLocation(string WindowLocation)
        {
            Ini.IniWriteValue(SessionSystem, "WindowLocation", WindowLocation);
        }


        /// <summary>
        /// 获得皮肤
        /// </summary>
        /// <returns></returns>
        public static string GetSkin()
        {
            return Ini.IniReadValue(SessionSystem, "Skin");
        }
        /// <summary>
        /// 保存皮肤
        /// </summary>
        /// <param name="SkinName"></param>
        public static void SetSkin(string SkinName)
        {
            Ini.IniWriteValue(SessionSystem, "Skin", SkinName);
        }
        /// <summary>
        /// 获得RibbonStyle
        /// </summary>
        /// <returns></returns>
        public static string GetRibbonStyle()
        {
            return Ini.IniReadValue(SessionSystem, "RibbonStyle");
        }
        /// <summary>
        /// 保存RibbonStyle
        /// </summary>
        /// <returns></returns>
        public static void SetRibbonStyle(string StyleName)
        {
            Ini.IniWriteValue(SessionSystem, "RibbonStyle", StyleName);
        }

        /// <summary>
        /// 获取TabFloatOnDoubleClick
        /// </summary>
        /// <returns></returns>
        public static bool GetTabFloatOnDoubleClick()
        {
            return Ini.IniReadValue(SessionSystem, "TabFloatOnDoubleClick") == "Y";
        }
        /// <summary>
        /// 保存TabFloatOnDoubleClick
        /// </summary>
        /// <param name="Checked"></param>
        public static void SetTabFloatOnDoubleClick(bool Checked)
        {
            Ini.IniWriteValue(SessionSystem, "TabFloatOnDoubleClick", Checked == true ? "Y" : "N");
        }

        /// <summary>
        /// 获取TabFloatOnDrag
        /// </summary>
        /// <returns></returns>
        public static bool GetTabFloatOnDrag()
        {
            return Ini.IniReadValue(SessionSystem, "TabFloatOnDrag") == "Y";
        }
        /// <summary>
        /// 保存TabFloatOnDrag
        /// </summary>
        /// <param name="Checked"></param>
        public static void SetTabFloatOnDrag(bool Checked)
        {
            Ini.IniWriteValue(SessionSystem, "TabFloatOnDrag", Checked == true ? "Y" : "N");
        }

        /// <summary>
        /// 获取TabColored
        /// </summary>
        /// <returns></returns>
        public static bool GetTabColored()
        {
            return Ini.IniReadValue(SessionSystem, "TabColored") == "Y";
        }
        /// <summary>
        /// 保存TabColored
        /// </summary>
        /// <param name="Checked"></param>
        public static void SetTabColored(bool Checked)
        {
            Ini.IniWriteValue(SessionSystem, "TabColored", Checked == true ? "Y" : "N");
        }

        /// <summary>
        /// 获取TabHeaderAutoFill
        /// </summary>
        /// <returns></returns>
        public static bool GetTabHeaderAutoFill()
        {
            return Ini.IniReadValue(SessionSystem, "TabHeaderAutoFill") == "Y";
        }
        /// <summary>
        /// 保存TabHeaderAutoFill
        /// </summary>
        /// <param name="Checked"></param>
        public static void SetTabHeaderAutoFill(bool Checked)
        {
            Ini.IniWriteValue(SessionSystem, "TabHeaderAutoFill", Checked == true ? "Y" : "N");
        }



        /// <summary>
        /// 获取TabClosePageButton
        /// </summary>
        /// <returns></returns>
        public static string GetTabClosePageButton()
        {
            return Ini.IniReadValue(SessionSystem, "ClosePageButtonShowMode");
        }
        /// <summary>
        /// 保存TabClosePageButton
        /// </summary>
        /// <param name="Checked"></param>
        public static void SetTabClosePageButton(string Position)
        {
            Ini.IniWriteValue(SessionSystem, "ClosePageButtonShowMode", Position);
        }

        /// <summary>
        /// 获取TabShowPin
        /// </summary>
        /// <returns></returns>
        public static string GetTabShowPin()
        {
            return Ini.IniReadValue(SessionSystem, "TabShowPin");
        }
        /// <summary>
        /// 保存TabShowPin
        /// </summary>
        /// <param name="Checked"></param>
        public static void SetTabShowPin(string Position)
        {
            Ini.IniWriteValue(SessionSystem, "TabShowPin", Position);
        }

        /// <summary>
        /// 获取TabHeaderLocation
        /// </summary>
        /// <returns></returns>
        public static string GetTabHeaderLocation()
        {
            return Ini.IniReadValue(SessionSystem, "TabHeaderLocation");
        }
        /// <summary>
        /// 保存TabHeaderLocation
        /// </summary>
        /// <param name="Checked"></param>
        public static void SetTabHeaderLocation(string Position)
        {
            Ini.IniWriteValue(SessionSystem, "TabHeaderLocation", Position);
        }

        public static void SetTabStrValue(string Key, string Text)
        {
            Ini.IniWriteValue(SessionSystem, Key, Text);
        }
        public static void SetTabStrValue(string Key, bool check)
        {
            Ini.IniWriteValue(SessionSystem, Key, check == true ? "Y" : "N");
        }

        /// <summary>
        /// 获取TabHeaderOrientation
        /// </summary>
        /// <returns></returns>
        public static string GetTabHeaderOrientation()
        {
            return Ini.IniReadValue(SessionSystem, "TabOrientation");
        }
        /// <summary>
        /// 保存TabHeaderOrientation
        /// </summary>
        /// <param name="Checked"></param>
        public static void SetTabHeaderOrientation(string Position)
        {
            Ini.IniWriteValue(SessionSystem, "TabOrientation", Position);
        }

        /// <summary>
        /// 获取TabPageImagePosition
        /// </summary>
        /// <returns></returns>
        public static string GetTabPageImagePosition()
        {
            return Ini.IniReadValue(SessionSystem, "TabPageImagePosition");
        }
        /// <summary>
        /// 保存TabPageImagePosition
        /// </summary>
        /// <param name="Checked"></param>
        public static void SetTabPageImagePosition(string Position)
        {
            Ini.IniWriteValue(SessionSystem, "TabPageImagePosition", Position);
        }



    }

}
