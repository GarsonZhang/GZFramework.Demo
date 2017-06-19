using GZFrameworkDemo.Common;
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
    public partial class frmDialogChangeDBText : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        public static DialogResult ShowForm(ref string DBName)
        {
            frmDialogChangeDBText frm = new frmDialogChangeDBText();
            frm.ShowIcon = frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.txt_DBName.EditValue = DBName;


            var v = frm.ShowDialog();
            if (v == DialogResult.OK)
                DBName = ConvertLib.ToString(frm.txt_DBName.EditValue);
            return v;
        }

        private frmDialogChangeDBText()
        {
            InitializeComponent();
        }

        private void frmDialogChangeDBText_Load(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (ConvertLib.ToString(txt_DBName.EditValue) == "")
            {
                txt_DBName.ErrorText = "名称不能为空！";
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
