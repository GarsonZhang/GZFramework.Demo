using GZFrameworkDemo.BusinessSQLite;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.MyClass;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Main
{
    public partial class frmLogin : GZFramework.UI.Dev.LibForm.frmBase
    {
        bllLogin bll;
        public frmLogin()
        {
            InitializeComponent();

            bll = new bllLogin();

            this.Shown += frmLoginNew_Shown;

        }

        void frmLoginNew_Shown(object sender, EventArgs e)
        {
            string user = INIUserAccound.GetAccound();
            chk_Accound.Checked = !String.IsNullOrEmpty(user);
            txt_User.Text = user;
            if (chk_Accound.Checked)
                txt_Pwd.Focus();
            if (Common.CheckDesingModel.IsDebug)
            {
                txt_DataBaseList.EditValue = txt_DataBaseList.Properties.GetDataSourceValue(txt_DataBaseList.Properties.ValueMember, 0);
                txt_Pwd.EditValue = "888888";
                //btn_Login_Click(null, null);
            }
        }


        public event EventHandler LoginSuccess;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool validate = Tools_VerificationEditValue.VerificationNotEmpEditValue(txt_User, "用户名不能为空") &
               Tools_VerificationEditValue.VerificationNotEmpEditValue(txt_Pwd, "密码不能为空");
            if (validate == false) return;

            string User = txt_User.Text;
            string Pwd = txt_Pwd.Text;
            string LoginDBCode = ConvertLib.ToString(txt_DataBaseList.EditValue);//当前账套(数据库名),暂时为空

            var user = bll.VerifyPwd(User, Pwd, LoginDBCode);
            if (user != null)
            {
                if (user.IsDBLock == true)
                {
                    txt_Error.Text = "用户所选账套已经被锁定！！";
                    txt_Error.Visible = true;
                    return;
                }
                if (user.IsSysLock == true)
                {
                    txt_Error.Text = "用户已经被锁定！！";
                    txt_Error.Visible = true;
                    return;
                }
                if (String.IsNullOrEmpty(LoginDBCode) && (!user.IsSysAdmin))
                {
                    txt_Error.Text = "请选择账套！";
                    txt_Error.Visible = true;
                    return;
                }
                if (String.IsNullOrEmpty(user.LoginDBCode) && (!user.IsSysAdmin))
                {
                    txt_Error.Text = "没有此账套的权限！！";
                    txt_Error.Visible = true;
                    return;
                }

                txt_Error.Visible = false;

                Loginer.CurrentLoginer.Account = user.Account;
                Loginer.CurrentLoginer.UserName = user.UserName;
                Loginer.CurrentLoginer.IsSysAdmin = user.IsSysAdmin;
                Loginer.CurrentLoginer.IsSysLock = user.IsSysLock;
                Loginer.CurrentLoginer.LoginDBCode = user.LoginDBCode;
                Loginer.CurrentLoginer.IsDBAdmin = user.IsDBAdmin;
                Loginer.CurrentLoginer.IsDBLock = user.IsDBLock;
                Library.Config.Config.Intentce.LoadDBList();
                if (chk_Accound.Checked == true)//记住账号
                    INIUserAccound.SetAccound(User);
                else
                    INIUserAccound.SetAccound("");

                GZFramework.UI.Dev.WaiteServer.ShowWaite(this.MdiParent);
                this.Close();
                if (LoginSuccess != null)
                {
                   DataCache.Cache.  LoadCatch();
                    LoginSuccess(this, null);
                }
                GZFramework.UI.Dev.WaiteServer.CloseWaite();

                this.Dispose();


            }
            else
            {
                txt_Error.Text = "用户名或密码不正确！！";
                txt_Error.Visible = true;
                return;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            bllDataBaseList bll = new bllDataBaseList();
            DataTable dt = bll.GetTableData(sys_DataBaseList._TableName);
            txt_DataBaseList.Properties.DataSource = dt;
        }
    }
}
