using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.SystemManagement.Dialog
{
    public partial class frmDialog_MenuEdit : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        DataRow DataSource;

        public static DialogResult ShowForm(DataRow row)
        {
            frmDialog_MenuEdit frm = new frmDialog_MenuEdit(row);
            return frm.ShowDialog();
        }

        private frmDialog_MenuEdit(DataRow row)
        {
            InitializeComponent();
            DataSource = row;
        }

        private void frmDialog_MenuEdit_Load(object sender, EventArgs e)
        {
            txt_ID.EditValue = DataSource["PKey"];
            txt_OldName.EditValue = DataSource["Name"];
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (GZFramework.UI.Dev.Common.LibraryTools.IsNotEmpBaseEdit(txt_NewName, "名称不能为空") == false)
                return;
            DataSource["Name"] = txt_NewName.EditValue;
            DataSource["DisplayName"] = txt_NewName.EditValue;
            this.DialogResult = DialogResult.OK;
        }


    }
}
