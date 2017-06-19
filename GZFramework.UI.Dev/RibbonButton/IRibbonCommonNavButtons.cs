using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFramework.UI.Dev.RibbonButton
{
    public interface IRibbonCommonNavButtons
    {
        /// <summary>
        /// 移动到第一行
        /// </summary>
        RibbonItemButtonBase btnMoveFirst { get; }
        /// <summary>
        /// 移动到最后一行
        /// </summary>
        RibbonItemButtonBase btnMoveLast { get; }
        /// <summary>
        /// 移动到前一行
        /// </summary>
        RibbonItemButtonBase btnMovePrevious { get; }
        /// <summary>
        /// 移动到下一行
        /// </summary>
        RibbonItemButtonBase btnMoveNext { get; }
    }
}
