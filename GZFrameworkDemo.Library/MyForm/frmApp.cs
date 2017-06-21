using GZFrameworkDemo.Business;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Models;
using GZFramework.UI.Dev.LibForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.MyForm
{
    public partial class frmApp : frmBaseDialog
    {
        DataRow dr;
        public static frmAppResult ShowForm(frmAppResult LoadResult)
        {

            frmApp frm = new frmApp(LoadResult);

            frm.ShowIcon = false;
            frm.ShowInTaskbar = false;
            frm.ShowDialog();
            return frm.Result;
        }
        public static DialogResult ShowForm(DataRow row)
        {
            frmApp frm = new frmApp(row);

            frm.ShowIcon = false;
            frm.ShowInTaskbar = false;
            return frm.ShowDialog();
        }

        frmAppResult Result = frmAppResult.未审核;
        protected frmApp()
        {
            InitializeComponent();

        }
        protected frmApp(DataRow row)
        {
            dr = row;
            frmAppResult LoadResult = (frmAppResult)ConvertLib.ToInt(row["AppStatus"]);
            InitializeComponent();
            btn_Access.Enabled = LoadResult == frmAppResult.未审核;
            btn_Abort.Enabled = LoadResult == frmAppResult.已审核;
            btn_Stop.Enabled = LoadResult == frmAppResult.未审核;
        }
        protected frmApp(frmAppResult LoadResult)
        {
            InitializeComponent();
            btn_Access.Enabled = LoadResult == frmAppResult.未审核;
            btn_Abort.Enabled = LoadResult == frmAppResult.已审核;
            btn_Stop.Enabled = LoadResult == frmAppResult.未审核;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_Access_Click(object sender, EventArgs e)
        {
            if (ValidatePwd() == false) return;
            Result = frmAppResult.已审核;
            if (dr != null)
            {
                dr["AppStatus"] = (int)Result;
                dr["AppUser"] = Loginer.CurrentLoginer.Account;
                dr["AppDate"] = bllDataCommon.Instance.GetServerTime();
            }
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if (ValidatePwd() == false) return;
            Result = frmAppResult.已驳回;
            if (dr != null)
            {
                dr["AppStatus"] = (int)Result;
                dr["AppUser"] = Loginer.CurrentLoginer.Account;
                dr["AppDate"] = bllDataCommon.Instance.GetServerTime();
            }
            this.DialogResult = DialogResult.OK;
        }
        private void btn_Abort_Click(object sender, EventArgs e)
        {
            if (ValidatePwd() == false) return;
            Result = frmAppResult.已弃审;
            if (dr != null)
            {
                dr["AppStatus"] = (int)Result;
                dr["AppUser"] = Loginer.CurrentLoginer.Account;
                dr["AppDate"] = bllDataCommon.Instance.GetServerTime();
            }
            this.DialogResult = DialogResult.OK;
        }

        bool ValidatePwd()
        {
            string pwd = ConvertLib.ToString(txt_pwd.EditValue);
            bllLogin bll = new Business.bllLogin();
            bool Success = bll.VerifyPwdEx(Loginer.CurrentLoginer.Account, pwd);
            if (Success == false)
            {
                txt_pwd.ErrorText = "密码错误！";
            }
            return Success;

        }

        private void frmApp_Load(object sender, EventArgs e)
        {

        }


    }

    public enum frmAppResult
    {
        未审核 = 0,
        已审核 = 1,
        已驳回 = -1,
        已弃审 = 2
        /*
      未审核 = 0,
        已审核 = 1,
        已驳回 = -1,
        已弃审 = 2    
     */

    }
}
