//======================================================================
//        版权所有@GarsonZhang
//        文件名 :RibbonButtons              									
//		  .NET版本：4.0
//        创建人：GarsonZhang  QQ：382237285
//        创建日期：2015-07-04 17:15:19
//        描述 :类
//======================================================================

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.RibbonButton
{
    public class RibbonCommonButtonsConfig<T, U>
        where T : IRibbonCommonButtons, new()
        where U : IRibbonCommonNavButtons, new()
    {
        public RibbonCommonButtonsConfig()
        {
           RibbonCommonButtons.CommonButtons = new T();
           RibbonCommonButtons.NavButtons = new U();
        }

    }
    public class RibbonCommonButtons
    {
        public static IRibbonCommonButtons CommonButtons { get; set; }
        public static IRibbonCommonNavButtons NavButtons { get; set; }
    }
}
