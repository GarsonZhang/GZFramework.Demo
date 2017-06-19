using GZFramework.UI.Dev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingPSISQLite.PSIModule.Dialog
{
    public partial class frmDialogProductList : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {


        public frmDialogProductList()
        {
            InitializeComponent();
            ucProductList1.OnRowSelected += UcProductList1_OnRowSelected;
        }

        private void UcProductList1_OnRowSelected(DataRow row)
        {
            Return();
        }

        public static DataRow ShowForm()
        {
            frmDialogProductList frm = new frmDialogProductList();
            if (frm.ShowDialog() == DialogResult.OK)
                return frm.Data;
            else
                return null;
        }

        DataRow Data = null;
        private void btn_OK_Click(object sender, EventArgs e)
        {
            Return();
        }

        void Return()
        {
            Data = ucProductList1.GetSelectDataRow();
            if (Data == null)
            {
                Msg.Warning("没有选择任何数据");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Data = null;
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
