using GZFramework.UI.Dev.LibForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.SystemManagement
{
    public partial class frmDialog_DBList : frmBaseDialog
    {
        private frmDialog_DBList()
        {
            InitializeComponent();
        }


        public static DataTable ShowForm(DataTable dt)
        {
            var frm = new frmDialog_DBList();
            frm.gcSummary.DataSource = dt;
            var result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                DataTable tmp = dt.Clone();
                foreach (int i in frm.gvSummary.GetSelectedRows())
                {
                    tmp.Rows.Add(frm.gvSummary.GetDataRow(i).ItemArray);
                }
                if (tmp.Rows.Count == 0) return null;
                return tmp;
            }
            else
                return null;
        }

         private void btn_OK_Click(object sender, EventArgs e)
         {
             this.DialogResult = DialogResult.OK;
         }

         private void btn_Cancel_Click(object sender, EventArgs e)
         {
             this.DialogResult = DialogResult.Cancel;
         }

         private void frmDialog_DBList_Load(object sender, EventArgs e)
         {

         }
    }
}
