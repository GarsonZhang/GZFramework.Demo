using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.ReportServer
{
    public partial class frmRptDesign : Form
    {
        public frmRptDesign(RptCommonBase RptCommon)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            report1.Load(RptCommon.RptFileName);
            designerControl1.Report = report1;

        }

        public frmRptDesign(System.IO.FileStream stream)
        {
            InitializeComponent();
            report1.Load(stream);
            designerControl1.Report = report1;

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            designerControl1.cmdSave.Invoke();
            GZFramework.UI.Dev.Common.Msg.ShowInformation("保存成功！");
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
