using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.ModuleProvider
{
    public partial class frmModuleBase : GZFramework.UI.Dev.Module.frmModuleMainBase
    {
        public frmModuleBase()
        {
            InitializeComponent();
        }
        //判断是否拥有权限
        protected override bool HasAuthority(string functionid)
        {
            return LoadModuleHelper.Intance.HasAuthority(functionid);
        }

        //根据权限设置按钮可用状态
        protected override void SetControlAuthority(Control col, bool HasAuthority)
        {
            if (HasAuthority == false)
                col.Visible = false;
        }
    }
}
