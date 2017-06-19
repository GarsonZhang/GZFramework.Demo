using GZFrameworkDemo.BusinessSQLite;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Models;
using GZFramework.UI.Dev.Common;
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
    public partial class frmLock : Form
    {
        public frmLock()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (Msg.AskQuestion("确定要退出系统吗？") == false) return;
            Application.Exit();
        }
        public event EventHandler VerifySuccess;
        private void btn_UNLock_Click(object sender, EventArgs e)
        {
            string pwd = ConvertLib.ToString(txt_pwd.EditValue);
            if (new bllLogin().VerifyPwdEx(Loginer.CurrentLoginer.Account, pwd))
            {

                if (VerifySuccess != null)
                    VerifySuccess(null, null);

                this.Close();
                this.Dispose();
            }
            else
            {
                txt_pwd.ErrorText = "密码错误！";
            }
        }

        private void txt_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_UNLock_Click(null, null);
        }
    }
}
