using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library
{
    public static class GridControlExtensions
    {
        /// <summary>
        /// 空数据提醒
        /// </summary>
        /// <param name="gv"></param>
        public static void SetEmpDataTextVisible(this DevExpress.XtraGrid.Views.Grid.GridView gv, bool ShowEmpText)
        {
            if (ShowEmpText == false)
                gv.CustomDrawEmptyForeground -= new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(gv_CustomDrawEmptyForeground);
            else
                gv.CustomDrawEmptyForeground += new DevExpress.XtraGrid.Views.Base.CustomDrawEventHandler(gv_CustomDrawEmptyForeground);
        }


        //空数据提醒
        private static void gv_CustomDrawEmptyForeground(object sender, DevExpress.XtraGrid.Views.Base.CustomDrawEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView gv = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            DataView bindingSource = gv.DataSource as DataView;
            if (bindingSource != null && bindingSource.Count == 0)
            {
                string str = "数据为空!";
                Font f = new Font("宋体", 10, FontStyle.Bold);

                Rectangle r = new Rectangle(gv.GridControl.Width / 2 - 100, gv.GridControl.Height / 2, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString(str, f, Brushes.Red, r);
            }
        }


        /// <summary>
        /// Indicator显示行号
        /// </summary>
        /// <param name="gv"></param>
        public static void SetIndicatorRowNumVisible(this DevExpress.XtraGrid.Views.Grid.GridView gv,bool ShowRowNumInIndicator)
        {
            if (ShowRowNumInIndicator == false)
            {
                gv.IndicatorWidth = -1;
                gv.CustomDrawRowIndicator -= new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(gv_CustomDrawRowIndicator);
            }
            else
            {
                gv.OptionsView.ShowIndicator = true;
                gv.IndicatorWidth = 35;
                gv.DataSourceChanged += gv_DataSourceChanged;
                gv.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(gv_CustomDrawRowIndicator);
            }
        }

        static void gv_DataSourceChanged(object sender, EventArgs e)
        {
            int i = ((sender as DevExpress.XtraGrid.Views.Grid.GridView).DataSource as DataView).Count;
            var width = (i.ToString().Length) * 12 + 5;
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).IndicatorWidth = width < 20 ? 25 : width;
        }
        //Indicator显示行号
        private static void gv_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }
    }
}
