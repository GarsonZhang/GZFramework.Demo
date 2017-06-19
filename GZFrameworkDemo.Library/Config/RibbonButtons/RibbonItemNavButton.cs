using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.MyClass;
using GZFramework.UI.Core.RibbonButton;
using GZFramework.UI.Dev;
using GZFramework.UI.Dev.RibbonButton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GZFrameworkDemo.Library.Config.RibbonButtons
{
    public class RibbonItemNavButton : RibbonItemButtonBase, IDisposable
    {
        private Image img = null;
        public string ImgFileName { get; set; }


        public override Image LoadImage
        {
            get
            {
                if (img == null)
                    img = LoadUIImage.LoadRibbonControlGlyph_BarItem("images\\"+ImgFileName);

                return img;
            }
        }
        public void Dispose()
        {
            if (img != null)
            {
                img.Dispose();
                img = null;
            }
        }
    }
}
