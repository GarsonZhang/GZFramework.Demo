using ClothingPSISQLite.Common;
using ClothingPSISQLite.Models.Business;
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
    public partial class frmDailogSalePay : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {


        public static DialogResult ShowForm(decimal Amount, out decimal AmountIn, out decimal AmountOut)
        {
            frmDailogSalePay frm = new Dialog.frmDailogSalePay();
            frm.txtAmount.EditValue = Amount;
            frm.txtIn.EditValue = Amount;
            var v = frm.ShowDialog();
            AmountIn = frm.AmountIn;
            AmountOut = frm.AmountOut;
            return v;

        }

        public frmDailogSalePay()
        {
            InitializeComponent();
            this.FormClosed += FrmDailogSalePay_FormClosed;
        }

        public object Amount
        {
            get
            {
                return txtAmount.EditValue;
            }
            set
            {
                txtAmount.EditValue = value;
            }
        }

        private void FrmDailogSalePay_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            AmountIn = 0;
            AmountOut = 0;
            this.DialogResult = DialogResult.Cancel;
        }
        decimal AmountIn = 0, AmountOut = 0;
        private void btn_OK_Click(object sender, EventArgs e)
        {
 
            decimal amount = ConvertLib.ToDecimal(txtAmount.EditValue, 0);
            AmountIn = ConvertLib.ToDecimal(txtIn.EditValue, 0);
            AmountOut = ConvertLib.ToDecimal(txtOut.EditValue, 0);
            if (AmountIn < amount)
            {
                Msg.ShowError("收款金额不能小于应收款");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void frmDailogSalePay_Load(object sender, EventArgs e)
        {
            txtIn.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void txtIn_EditValueChanged(object sender, EventArgs e)
        {
            txtOut.EditValue = ConvertLib.ToDecimal(txtIn.EditValue, 0) - ConvertLib.ToDecimal(txtAmount.EditValue, 0);
        }
    }
}
