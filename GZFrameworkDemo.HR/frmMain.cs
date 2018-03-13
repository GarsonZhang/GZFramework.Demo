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
            base.AddFunction(btnUser, typeof(frmUser), "用户管理");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmUser));
        }
    }
}
