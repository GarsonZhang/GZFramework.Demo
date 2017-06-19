using GZPSI.Library.SearchTextEdit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZPSI.Demo.Dialog
{
    public partial class frmDialogDataSearch_Product : frmDialogDataSearchBase
    {
        public frmDialogDataSearch_Product()
        {
            InitializeComponent();


        }


        private void frmDialogDataSearch_Product_Load(object sender, EventArgs e)
        {
            DataTable dt = getDataSource();
            if (!String.IsNullOrEmpty(SearchCode))
                dt.DefaultView.RowFilter = $"zjm='{SearchCode}'";
            gridControl1.DataSource = dt;

        }

        DataTable getDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("spbh", typeof(string));
            dt.Columns.Add("spmc", typeof(string));
            dt.Columns.Add("kc", typeof(int));
            dt.Columns.Add("zjm", typeof(string));

            dt.Rows.Add("2016001", "阿莫西林胶囊", 50, "AMXL");
            dt.Rows.Add("2016002", "阿莫西林胶囊", 30, "AMXL");
            dt.Rows.Add("2016003", "阿莫西林胶囊", 25, "AMXL");
            dt.Rows.Add("2016004", "阿莫西林胶囊", 13, "AMXL");
            dt.Rows.Add("2016005", "阿莫西林胶囊", 35, "AMXL");

            dt.Rows.Add("2016006", "女神牌风油精", 2, "FYJ");
            dt.Rows.Add("2016007", "风油精挑战型", 15, "FYJ");
            dt.Rows.Add("2016008", "风油精", 30, "FYJ");
            dt.Rows.Add("2016009", "风油精", 55, "FYJ");
            dt.Rows.Add("2016010", "风油精", 68, "FYJ");

            return dt;
        }

        protected override bool ValidateForSelect()
        {
            return gridView1.FocusedRowHandle >= 0;
        }

        public override object GetSelect(out object EditValue, out bool Success)
        {
            Success = true;
            DataRow dr = gridView1.GetFocusedDataRow();
            EditValue = dr["spmc"];
            return dr;
        }

        protected override void SetFocus()
        {
            gridView1.Focus();
        }


    }
}
