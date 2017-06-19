using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.ModuleFun
{
    public class GZTable
    {
        List<GZTableRow> lstRow = new List<GZTableRow>();

        private int _CellCount;
        private int _CellWidth;
        private int _CellHeight;

        public int CellCount { get { return _CellCount; } }
        public int RowCount { get { return lstRow.Count; } }
        public int CellWidth { get { return _CellWidth; } }
        public int CellHeight { get { return _CellHeight; } }


        public GZTable(int ColumnCount, int CellWidth, int CellHeight)
        {
            _CellCount = ColumnCount;
            _CellWidth = CellWidth;
            _CellHeight = CellHeight;
        }

        public GZTableRow this[int Index]
        {
            get
            {
                if (Index <= lstRow.Count - 1)
                    return lstRow[Index];
                else
                    return null;
            }
        }
        /// <summary>
        /// 添加一行
        /// </summary>
        /// <param name="CellNum"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public void AddRow()
        {
            GZTableRow GRow = new GZTableRow(_CellCount, CellWidth, CellHeight, RowCount);
            lstRow.Add(GRow);
        }

        public GZTableCell GetCellByPoint(Point P)
        {
            int X = P.X;
            int Y = P.Y;

            if (X < 0 || Y < 0) return null;
            int PanWidth = CellCount * CellWidth;
            int PanHeight = RowCount * CellHeight;
            if (X < PanWidth && Y < PanHeight)
            {
                int I = X / CellWidth - 1;
                int J = Y / CellHeight - 1;
                if (X % CellWidth > 5) I++;
                if (Y % CellHeight > 5) J++;
                if (I < 0 || J < 0)
                    return null;
                return lstRow[J][I];
            }

            return null;
        }

        ///// <summary>
        ///// 删除行
        ///// </summary>
        ///// <param name="Grow"></param>
        //public void RemoveRow(GZRow Grow)
        //{
        //    lstRow.Remove(Grow);
        //}
        ///// <summary>
        ///// 删除行
        ///// </summary>
        ///// <param name="index"></param>
        //public void RemoveRow(int index)
        //{
        //    RemoveRow(lstRow[index]);
        //}
    }
}
