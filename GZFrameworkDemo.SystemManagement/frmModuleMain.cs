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
    public partial class frmModuleMain : Library.ModuleProvider.frmModuleBase
    {
        public frmModuleMain()
        {
            InitializeComponent();

            //注册功能，第一个参数为对应按钮，根据权限控制按钮可用状态
            this.AddFunction(btn_User, typeof(frmMyUser), "账号管理");
            this.AddFunction(btn_MyRole, typeof(frmMyRole), "角色管理");
            this.AddFunction(btn_Setting, typeof(frmSetting), "系统设置");
            this.AddFunction(btn_CompanyInfo, typeof(frmCompanyInfo), "公司信息");
            this.AddFunction(btn_SystemAuthority, typeof(frmSystemAuthority), "功能注册");
        }
        #region 按钮点击事件
        private void btn_User_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmMyUser));
        }

        private void btn_MyRole_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmMyRole));
        }

        private void btn_SystemAuthority_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmSystemAuthority));
        }

        private void btn_CompanyInfo_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmCompanyInfo));
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmSetting));
        }
        #endregion
    }
}
