using ClothingPSISQLite.Common;
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
    public partial class frmDialogPrice : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {

        public static decimal ShowForm()
        {
            frmDialogPrice frm = new frmDialogPrice();
            frm.ShowDialog();
            return frm.value;
        }

        private frmDialogPrice()
        {
            InitializeComponent();
        }


        public decimal value = 0;
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            value = ConvertLib.ToDecimal(textEdit1.EditValue, 0);
            this.Close();
        }

        private void frmDialogPrice_Load(object sender, EventArgs e)
        {
            textEdit1.Focus();
        }
    }
}
