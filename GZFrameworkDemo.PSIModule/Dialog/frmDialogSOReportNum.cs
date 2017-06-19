using ClothingPSISQLite.Common;
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
    public partial class frmDialogSOReportNum : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        public static int ShowForm(int num)
        {
            frmDialogSOReportNum frm = new Dialog.frmDialogSOReportNum();
            frm.txtNum.EditValue = num;
            if (frm.ShowDialog() == DialogResult.OK)
                return frm.Num;
            else
                return 0;
        }

        int Num;
        private frmDialogSOReportNum()
        {
            InitializeComponent();
        }

        private void frmDialogSOReportNum_Load(object sender, EventArgs e)
        {
            txtNum.Focus();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Num = ConvertLib.ToInt(txtNum.EditValue);
            if (Num <= 0)
            {
                Msg.Warning("数量必须大于0");
                return;
            }
            DialogResult = DialogResult.Cancel;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Num = 0;
            DialogResult = DialogResult.Cancel;
        }
    }
}
