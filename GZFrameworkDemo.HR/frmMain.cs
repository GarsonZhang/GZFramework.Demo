using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.HR
{
    public partial class frmMain : GZFrameworkDemo.Library.ModuleProvider.frmModuleBase
    {
        public frmMain()
        {
            InitializeComponent();

            //注册功能，第一个参数为对应按钮，根据权限控制按钮可用状态
            this.AddFunction(btnUser, typeof(frmUser), "账号管理");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmUser));
        }
    }
}
