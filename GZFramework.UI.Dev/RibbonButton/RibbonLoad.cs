//======================================================================
//        版权所有@GarsonZhang
//        文件名 :RibbonConfig              									
//		  .NET版本：4.0
//        创建人：GarsonZhang  QQ：382237285
//        创建日期：2015-07-04 16:37:42
//        描述 :类
//======================================================================

using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFramework.UI.Dev.RibbonButton
{
    public class RibbonLoad
    {
        private static RibbonPage RibbonPage { get; set; }
        private static RibbonPageGroup RibbonPageGroupOption { get; set; }
        private static RibbonPageGroup RibbonPageGroupDataNav { get; set; }

        internal static string RibbonPageText
        {
            get
            {
                if (RibbonPage == null) return "";
                return RibbonPage.Text;
            }
        }

        internal static string RibbonPageGroupOptionText
        {
            get
            {
                if (RibbonPageGroupOption == null) return "";
                return RibbonPageGroupOption.Text;
            }
        }

        internal static string RibbonPageGroupDataNavText
        {
            get
            {
                if (RibbonPageGroupDataNav == null) return "";
                return RibbonPageGroupDataNav.Text;
            }
        }


        public RibbonLoad(RibbonPage Page, RibbonPageGroup GroupOption, RibbonPageGroup DataNav)
        {
            RibbonPage = Page;
            RibbonPageGroupOption = GroupOption;
            RibbonPageGroupDataNav = DataNav;
        }
    }
}
