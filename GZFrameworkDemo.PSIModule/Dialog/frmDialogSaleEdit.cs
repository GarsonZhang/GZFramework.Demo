using ClothingPSISQLite.Common;
using ClothingPSISQLite.Models.Business;
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
    public partial class frmDialogSaleEdit : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        public DataRow DataSource = null;

        public static DialogResult ShowForm(DataRow row)
        {
            frmDialogSaleEdit frm = new Dialog.frmDialogSaleEdit(row);
            return frm.ShowDialog();
        }

        private frmDialogSaleEdit(DataRow row)
        {
            InitializeComponent();
            DataSource = row;
            txtBarCode.Text = ConvertLib.ToString(DataSource[tb_SODetail.BarCode]);
            txtItemNo.Text = ConvertLib.ToString(DataSource[tb_SODetail.ItemNo]);
            txtItemName.Text = ConvertLib.ToString(DataSource[tb_SODetail.ItemName]);
            txtQty.EditValue = DataSource[tb_SODetail.Qty];
            txtUnitPrice.EditValue = DataSource[tb_SODetail.UnitPrice];
            txtTotalAmount.EditValue = DataSource[tb_SODetail.TotalAmount];
            txtRemark.EditValue = DataSource[tb_SODetail.Remark];
           
        }
        private void frmDialogSaleEdit_Load(object sender, EventArgs e)
        {
            txtQty.Focus();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DataSource[tb_SODetail.Qty] = txtQty.EditValue;
            DataSource[tb_SODetail.UnitPrice] = txtUnitPrice.EditValue;
            DataSource[tb_SODetail.TotalAmount] = txtTotalAmount.EditValue;
            DataSource[tb_SODetail.Remark] = txtRemark.EditValue;
            this.DialogResult = DialogResult.OK;
        }

        private void txtQty_EditValueChanged(object sender, EventArgs e)
        {
            refreshAmount();
        }

        private void txtUnitPrice_EditValueChanged(object sender, EventArgs e)
        {
            refreshAmount();
        }

        void refreshAmount()
        {
            int qty = ConvertLib.ToInt(txtQty.EditValue);
            decimal price = ConvertLib.ToDecimal(txtUnitPrice.EditValue, 0);
            txtTotalAmount.EditValue = qty * price;
        }

     
    }
}
