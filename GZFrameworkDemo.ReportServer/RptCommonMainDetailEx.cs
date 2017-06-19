using GZDBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FastReport;

namespace GZFrameworkDemo.ReportServer
{
    public class RptCommonMainDetail : RptCommonBase
    {
        /// <summary>
        /// 数据源  主表
        /// </summary>
        private DataTable DataSummary { get; set; }
        /// <summary>
        /// 数据源  明细
        /// </summary>
        private DataTable DataDetail { get; set; }

        /// <summary>
        /// 存储过程名称
        /// </summary>
        private string SPName { get; set; }

        /// <summary>
        /// 存储过程参数
        /// </summary>
        private IDbParms Parms { get; set; }

        private bool ISSP { get; set; } = false;

        public void PrepareDataSource()
        {
            if (ISSP == true)
            {
                DataSet ds = db.GetDataSetSP(SPName, Parms);
                if (ds.Tables.Count > 0)
                {
                    DataSummary = ds.Tables[0];
                    if (ds.Tables.Count > 1)
                        DataDetail = ds.Tables[1];
                    else
                        DataDetail = null;
                }
                else
                {
                    DataSummary = null;
                    DataDetail = null;
                }
            }
        }

        /// <summary>
        /// 自定义报表准备
        /// </summary>

        public event Action<Report> BeforePrepare;

        public RptCommonMainDetail(Form owner, string RptFileName, DataTable DataSummary, DataTable DataDetail)
            : base(owner, RptFileName)
        {
            ISSP = false;
            this.DataSummary = DataSummary;
            this.DataDetail = DataDetail;
        }

        public RptCommonMainDetail(Form owner, string RptFileName, string SPName, IDbParms Parms)
            : base(owner, RptFileName)
        {
            ISSP = true;
            this.SPName = SPName;
            this.Parms = Parms;
        }

        public override Report PrepareReport()
        {
            Report _Report = null;
            try
            {
                GZFramework.UI.Dev.WaiteServer.ShowWaite(Owner);
                _Report = LoadReport(RptFileName);

                PrepareDataSource();

                _Report.RegisterData(DataSummary, "M");
                _Report.RegisterData(DataDetail, "D");

                DataBand dataBandD1 = _Report.FindObject("Data1") as DataBand;
                dataBandD1.DataSource = _Report.GetDataSource("D");

                UpdateRptCommandData(_Report);

                BeforePrepare?.Invoke(_Report);
            }
            catch (Exception ex)
            {
                RptSuccess = false;
                RptException = ex;
            }
            finally
            {
                GZFramework.UI.Dev.WaiteServer.CloseWaite();
                if (RptSuccess == false)
                {
                    GZFramework.UI.Dev.Common.Msg.ShowError(RptException.Message);
                    //_Report = null;
                }
                //else
                //{
                //    _Report.Prepare();//准备工作     
                //    frmRptPreview.Preview(_Report, owner, !ShowPrint);
                //}
            }
            return _Report;
        }

    }
}
