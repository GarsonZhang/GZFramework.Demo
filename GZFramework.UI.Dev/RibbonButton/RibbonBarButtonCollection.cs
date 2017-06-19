using DevExpress.XtraBars;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.RibbonButton
{
    public class RibbonBarButtonCollection
    {
        private Dictionary<string, BarItemLink> buttons { get; set; }
        public RibbonBarButtonCollection()
        {
            buttons = new Dictionary<string, BarItemLink>();
        }


        public void AddBtn(BarItemLink btn)
        {
            if (!buttons.ContainsKey(btn.Item.Name))
                buttons.Add(btn.Item.Name, btn);
        }


        public BarItemLink GetButtonByName(string btnName)
        {
            BarItemLink bi = null;
            if (buttons.ContainsKey(btnName))
                bi = buttons[btnName];
            return bi;
        }
    }
}
