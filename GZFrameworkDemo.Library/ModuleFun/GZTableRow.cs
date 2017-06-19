using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Library.ModuleFun
{
    public class GZTableRow
    {
        List<GZTableCell> lstGZRow = new List<GZTableCell>();

        public GZTableCell this[int Index]
        {
            get
            {
                return lstGZRow[Index];
            }
        }

        public GZTableRow(int ColCount, int width, int height, int RowIndex)
        {
            for (int i = 0; i < ColCount; i++)
            {
                lstGZRow.Add(new GZTableCell(width, height, RowIndex, i));
            }
        }
        ///// <summary>
        ///// 删除单元格
        ///// </summary>
        ///// <param name="GCell"></param>
        //public void RemoveCell(GZCell GCell)
        //{
        //    lstGZRow.Remove(GCell);
        //}
        ///// <summary>
        ///// 删除单元格
        ///// </summary>
        ///// <param name="Index"></param>
        //public void RemoveCell(int Index)
        //{
        //    RemoveCell(lstGZRow[Index]);
        //}

        public int Count()
        {
            return lstGZRow.Count;
        }
    }
}
