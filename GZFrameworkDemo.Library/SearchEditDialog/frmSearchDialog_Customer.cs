using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClothingPSI.Library.SearchEditDialog
{
    public partial class frmSearchDialog_Customer : SearchTextEdit.frmDialogDataSearchBase
    {
        Business.bllData_Customer bll;
        public frmSearchDialog_Customer()
        {
            InitializeComponent();
            bll = new Business.bllData_Customer();
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (!String.IsNullOrEmpty(SearchCode))
            {
                txt_Code.Text = SearchCode;
            }
            LoadData();
            if (DataSource != null && DataSource.Rows.Count > 0)
                gridView1.Focus();
            else
                txt_Code.Focus();

        }



        public DataTable DataSource;
        private void btn_Search_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            DataSource = bll.Search(txt_Code.Text, "", "");
            gridControl1.DataSource = DataSource;
            gridView1.BestFitColumns();
        }
        //处理数据
        public override object GetSelect(out object EditValue, out bool Success)
        {
            EditValue = null;
            Success = false;
            DataRow dr = gridView1.GetFocusedDataRow();
            if (dr == null) return null;
            EditValue = dr[Models.dt_Data_Customer.CustomerName];
            Success = true;
            return dr;
        }
        //验证是否选择数据
        protected override bool ValidateForSelect()
        {
            return gridView1.FocusedRowHandle >= 0;
        }
        //验证返回数据是否正确，
        protected override bool ValidateObject(object obj)
        {
            return obj != null;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            doSelect();
        }
    }
}
