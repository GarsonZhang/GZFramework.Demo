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
    public partial class frmDialogDataSearch_Dept : frmDialogDataSearchBase
    {
        public frmDialogDataSearch_Dept()
        {
            InitializeComponent();
        }




        DataTable getDataSource()
        {
            DataTable dt = new DataTable();

            DataColumn col = dt.Columns.Add("DeptID", typeof(string));
            col.Caption = "部门编号";
            col = dt.Columns.Add("DeptName", typeof(string));
            col.Caption = "部门名称";
            col = dt.Columns.Add("ZJM", typeof(string));
            col.Caption = "助记码";

            dt.Rows.Add("001", "采购部", "CGB");
            dt.Rows.Add("002", "质管部", "ZGB");
            dt.Rows.Add("003", "销售部", "XSB");
            dt.Rows.Add("004", "业务部", "YWB");
            dt.Rows.Add("005", "财务部", "CWB");

            return dt;
        }

        private void frmDialogDataSearch_Dept_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = getDataSource();
            gridView1.BestFitColumns();
        }

 

        protected override void SetFocus()
        {
            gridView1.Focus();
        }

        //验证是否选择内容
        protected override bool ValidateForSelect()
        {
            return gridView1.FocusedRowHandle >= 0;
        }

        public override object GetSelect(out object EditValue,out bool Success)
        {
            Success = true;
            //EditValue = "";
            DataRow dr = gridView1.GetFocusedDataRow();
            EditValue = dr["DeptName"];
            return dr;
        }

      


    }
}
