using GZFramework.UI.Dev.Common;
using GZFrameworkDemo.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.SystemManagement
{
    public partial class frmCompanyInfo : GZFramework.UI.Dev.LibForm.frmBaseFunction
    {
        bllData_CompanyInfo bll;
        public frmCompanyInfo()
        {
            InitializeComponent();
            bll = new bllData_CompanyInfo();
        }

        protected override int CustomerAuthority
        {
            get
            {
                return GZFramework.UI.Core.FunctionAuthorityCommon.SaveEx;
            }
        }

        protected override void DoSave(object sender)
        {
            if (DataSource == null)
                return;

            this.DoValidate();
            DataSource.Rows[0].EndEdit();

            bool b = bll.Update(DataSource);
            if (b == true)
            {
                DataSource.AcceptChanges();
                Msg.ShowInformation("保存成功！");
            }
        }



        private DataTable DataSource;
        private void frmCompanyInfo_Load(object sender, EventArgs e)
        {
            DataSource = bll.Search(null);
            if (DataSource.Rows.Count == 0)
                DataSource.Rows.Add();
            dataBindingView1.DataSource = DataSource;
        }
    }
}
