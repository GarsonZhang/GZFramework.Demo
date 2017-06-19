using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.RibbonButton
{
    public abstract class RibbonItemButtonBase
    {
        public string name { get; set; }
        public string Caption { get; set; }
        public bool BeginGroup { get; set; }
        public abstract Image LoadImage { get; }
        public Keys Shortcut { get; set; }
    }
}
