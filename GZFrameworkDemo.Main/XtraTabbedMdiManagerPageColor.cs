using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GZFrameworkDemo.Main
{
    public class XtraTabbedMdiManagerPageColor
    {

        Color[] TabColor = new Color[]{
                Color.FromArgb(35,83,194),
                Color.FromArgb(64,168,19),
                Color.FromArgb(245,121,10),
                Color.FromArgb(141,62,168),
                Color.FromArgb(70,155,183),
                Color.FromArgb(196,19,19)
            };


        public void BoundChildPagesBackColor(XtraTabbedMdiManager xmdi)
        {
            xmdi.PageAdded += xmdi_PageAdded;
            for (int i = 0; i < xmdi.Pages.Count; i++)
            {
                xmdi.Pages[i].Appearance.Header.BackColor = TabColor[i % 6];
            }
        }
        public void UnBoundChildPagesBackColor(XtraTabbedMdiManager xmdi)
        {
            xmdi.PageAdded -= xmdi_PageAdded;
            foreach (XtraMdiTabPage page in xmdi.Pages)
            {
                page.Appearance.Header.BackColor = Color.Empty;
            }
        }

        void xmdi_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            var xtraTabbedMdiManager1 = sender as XtraTabbedMdiManager;
            xtraTabbedMdiManager1.Pages[xtraTabbedMdiManager1.Pages.Count - 1].Appearance.Header.BackColor = TabColor[(xtraTabbedMdiManager1.Pages.Count) % 6];
        }
    }
}
