using GZFramework.UI.Core;
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
    public partial class frmSetting : GZFramework.UI.Dev.LibForm.frmBaseFunction
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            txt_title.Text = INISystemConfig.GetTitle();
        }

        protected override int CustomerAuthority
        {
            get
            {
                return FunctionAuthorityCommon.SaveEx;
            }

        }


        protected override void DoSave(object sender)
        {
            INISystemConfig.SetTitle(txt_title.Text);
            GZFramework.UI.Dev.Common.Msg.ShowInformation("保存成功！");
        }

    }
}
