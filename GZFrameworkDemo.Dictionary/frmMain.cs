using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Dictionary
{
    public partial class frmMain : Library.ModuleProvider.frmModuleBase
    {
        public frmMain()
        {
            InitializeComponent();
            // Activator.CreateInstance(ChildForm)
            this.AddFunction(btnCommonDataDictNew, typeof(frmCommonDataDictNew), "公共字典");
            this.AddFunction(btnDocSNHeader, typeof(frmDocSNHeader), "单据自定义管理");
            this.AddFunction(btn_Customer, typeof(frmCustomer), "客户资料");
        }

        private void btnCommonDataDictNew_Click(object sender, EventArgs e)
        {
            //两种实现方式,如过跨模块，参数可为窗体类全名
            this.ShowChildForm(typeof(frmCommonDataDictNew));
            //this.ShowChildForm("GZFrameworkDemo.Dictionary.frmCommonDataDictNew");
        }

        private void btnDocSNHeader_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmDocSNHeader));
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            this.ShowChildForm(typeof(frmCustomer));
        }
    }
}
