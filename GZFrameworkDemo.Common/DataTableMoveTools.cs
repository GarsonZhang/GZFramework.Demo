using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Common
{
    public class DataTableMoveTools
    {
        public static void DataRowMoveNext(DataTable dt, int RowIndex)
        {
            DataRowMove(dt, RowIndex, RowIndex + 1);
        }
        public static void DataRowMoveNext(DataRow row)
        {
            DataTable table = row.Table;
            int rowindex = table.Rows.IndexOf(row);
            DataRowMove(table, rowindex, rowindex + 1);
        }
        public static void DataRowMovePrev(DataTable dt, int RowIndex)
        {
            DataRowMove(dt, RowIndex, RowIndex - 1);
        }
        public static void DataRowMovePrev(DataRow row)
        {
            DataTable table = row.Table;
            int rowindex = table.Rows.IndexOf(row);
            DataRowMove(table, rowindex, rowindex - 1);
        }
        public static void DataRowMoveFirst(DataTable dt, int RowIndex)
        {
            DataRowMove(dt, RowIndex, 0);
        }
        public static void DataRowMoveFirst(DataRow row)
        {
            DataTable table = row.Table;
            int rowindex = table.Rows.IndexOf(row);
            DataRowMove(table, rowindex, 0);
        }
        public static void DataRowMoveLast(DataTable dt, int RowIndex)
        {
            DataRowMove(dt, RowIndex, dt.Rows.Count);
        }
        public static void DataRowMoveLast(DataRow row)
        {
            DataTable table = row.Table;
            int rowindex = table.Rows.IndexOf(row);
            DataRowMove(table, rowindex, table.Rows.Count);
        }

        public static void DataRowMove(DataTable dt, int RowIndex, int ToRowIndex)
        {
            DataRow dr = dt.Rows[RowIndex];
            DataRowState state = dr.RowState;
            DataRow NewRow = GenerateNewRow(dr);

            dt.Rows.RemoveAt(RowIndex);
            dt.Rows.InsertAt(NewRow, ToRowIndex);

            NewRow.AcceptChanges();
            if (state == DataRowState.Modified)
                NewRow.SetModified();
            if (state == DataRowState.Added)
                NewRow.SetAdded();
        }
        public static DataRow GenerateNewRow(DataRow row)
        {
            row.AcceptChanges();
            DataRow dr = row.Table.NewRow();
            dr.ItemArray = row.ItemArray;
            return dr;
        }
    }
}
