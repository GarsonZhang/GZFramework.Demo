using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using GZFrameworkDemo.Library.ModuleFun;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.ModuleFun
{
    public class GZTableLayout
    {
        public GZTable GT;
        protected readonly int ControlWidth;
        protected readonly int ControlHeight;

        protected Control pan_Container;
        public GZTableLayout(Control Container, int width, int height)
        {
            pan_Container = Container;
            pan_Container.Size = new Size(748, 642);

            if (pan_Container is PanelControl)
                (pan_Container as PanelControl).BorderStyle = BorderStyles.NoBorder;

            int PanWidth = Container.Width - 20;//预留给滚动条20像素
            int PanHeight = Container.Height - 20;//预留给滚动条20像素

            ControlWidth = width;
            ControlHeight = height;


            //计算表格的行数和列数
            int ColumnCoount = PanWidth / (width + 10);
            int RowCount = PanHeight / (height + 20);
            GT = new GZTable(ColumnCoount, width + 10, height + 20);

            for (int i = 0; i < RowCount; i++)
            {
                GT.AddRow();
            }
        }


        public virtual void ClearControl()
        {
            for (int i = 0; i < GT.RowCount; i++)
            {
                for (int j = 0; j < GT.CellCount; j++)
                    GT[i][j].ContainControl = null;
            }
            pan_Container.Controls.Clear();
        }

        public void AddRow()
        {
            GT.AddRow();
        }

        public virtual void SetControl(int Row, int Column, Control col)
        {

            col.Size = new Size(ControlWidth, ControlHeight);
            GT[Row][Column].ContainControl = col;
            GT[Row][Column].Tag = col;


            pan_Container.Controls.Add(col);
        }

    }
}
