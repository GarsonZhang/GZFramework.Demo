using FastReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.ReportServer
{
    public partial class frmRptPreview : GZFramework.UI.Dev.LibForm.frmBase
    {
        RptCommonBase rpt;
        private frmRptPreview(RptCommonBase rpt)
        {
            FastReport.Utils.Res.LoadLocale(Path.GetDirectoryName(typeof(Report).Assembly.Location) + @"\Localization\Chinese (Simplified).frl");
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;
            this.rpt = rpt;
            //previewControl1.Report.Export()
            //FastReport.Export.OoXML.Excel2007Export
        }

        public static void ShowForm(RptCommonBase rpt)
        {
            frmRptPreview previewForm = new frmRptPreview(rpt);
            previewForm.init();
            previewForm.Preview();
            previewForm.ShowDialog();
        }
        void init()
        {
            btn_Design.Visible = rpt.IsDesign;//设计权限
            if (rpt.Owner != null) this.Text = rpt.Owner.Text;
        }
        public void Preview()
        {
            try
            {
                
                Report report = rpt.PrepareReport();
                report.Preview = this.previewControl1;

                if (!String.IsNullOrEmpty(rpt.Watermark))//有水印
                {
                    if (report.Pages.Count > 0 && report.Pages[0] is ReportPage)
                    {
                        ReportPage page = report.Pages[0] as ReportPage;
                        Watermark watermark = new Watermark();
                        watermark.Enabled = true;
                        watermark.Font = new Font(watermark.Font.FontFamily, (float)40, FontStyle.Bold);
                        watermark.Text = rpt.Watermark;


                        page.Watermark = watermark;
                    }
                }
                //if (!isPrepared) report.Prepare(false);//准备工作,显示报表预览窗体
                report.Prepare(false);//准备工作,显示报表预览窗体
                report.ShowPrepared(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

                
        //设计报表
        private void btn_Design_Click(object sender, EventArgs e)
        {
            frmRptDesign f = new frmRptDesign(rpt);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Preview();
            }
        }

        //打印
        private void btn_Print_Click(object sender, EventArgs e)
        {
            previewControl1.Print();
        }


    }
}
