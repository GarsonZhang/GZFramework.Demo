using GZFrameworkDemo.BusinessSQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.MyControl
{
    public partial class frmDialog_CommonSearchSetting : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        public static bool ShowForm(string Code)
        {
            frmDialog_CommonSearchSetting frm = new frmDialog_CommonSearchSetting();
            frm.Code = Code;
            return frm.ShowDialog() == DialogResult.OK;
        }
        public string Code { get; set; }

        bllCommonSearch bll;
        public frmDialog_CommonSearchSetting()
        {
            InitializeComponent();
            bll = new bllCommonSearch();
        }
        DataTable DataSource;
        private void frmDialog_CommonSearchSetting_Load(object sender, EventArgs e)
        {
            DataSource = bll.GetCommonSearchCurrentUser(Code);
            gridControl1.DataSource = DataSource;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (DataSource.GetChanges() == null)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                foreach (DataRow dr in DataSource.Rows)
                {
                    if (dr.RowState != DataRowState.Unchanged)
                    {
                        if (Object.Equals(dr["isid"], DBNull.Value))
                        {
                            dr.AcceptChanges();
                            dr.SetAdded();
                        }
                    }
                }
                if (bll.UpdateCommonSearchUser(DataSource) == true)
                    this.DialogResult = DialogResult.OK;
            }
        }
    }
}
