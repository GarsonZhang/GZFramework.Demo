using GZFramework.UI.Core.RibbonButton;
using GZFramework.UI.Dev;
using GZFramework.UI.Dev.RibbonButton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library.Config.RibbonButtons
{
    internal class RiibonButtonsConfig
    {
        public RiibonButtonsConfig()
        {
            new RibbonCommonButtonsConfig<RibbonCommonButtons, RibbonCommonNavButtons>();
        }
    }
}