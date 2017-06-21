/**************************************************************************
	-- 作者：Garson_Zhang
	-- CLR版本： 4.0.30319.34209
	-- 命名空间名称：GZDemo.Library.Reports
	-- 文件名：RptCommonBase
	-- 时间：2015-03-04 16:00:30
	-- 创建年月：2015
	-- 描述：尚未编写描述

**************************************************************************/

using FastReport;
using GZDBHelper;
using GZFramework.DB;
using GZFrameworkDemo.Business;
using GZFrameworkDemo.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace GZFrameworkDemo.ReportServer
{
    public abstract class RptCommonBase : IReport
    {
        private string _dbcode = "";
        public string DBCode
        {
            get
            {
                return _dbcode;
            }
            set
            {
                _dbcode = value;
            }
        }

        /// <summary>
        /// 水印
        /// </summary>
        public string Watermark { get; set; }

        protected IDatabase db
        {
            get
            {
                return DataBaseFactoryEx.CreateDataBase(DBCode);
            }
        }

        public RptCommonBase(Form owner, string RptFileName)
        {
            this.Owner = owner;
            this.RptFileName = RptFileName;
            _dbcode = Loginer.CurrentLoginer.SystemDBCode;
            this.IsDesign = Loginer.CurrentLoginer.IsSysAdmin;
        }


        /// <summary>
        /// 报表父窗体
        /// </summary>
        public Form Owner { get; private set; }

        /// <summary>
        /// 是否用设计权限
        /// </summary>
        public bool IsDesign { get; set; }

        /// <summary>
        /// 报表路径
        /// </summary>
        public string RptFileName { get; set; }


        /// <summary>
        /// 报表打印前准备成功
        /// </summary>
        protected bool RptSuccess = true;
        /// <summary>
        /// 报表准备异常
        /// </summary>
        protected Exception RptException = null;



        //public FileStream RptStream { get; set; }

        /// <summary>
        /// 加载报表
        /// </summary>
        /// <param name="RptFileName"></param>
        protected Report LoadReport(string RptFileName)
        {
            //Report rpt = new FastReport.Report();
            //if (RptStream == null)
            //{
            //    RptStream = System.IO.File.OpenRead(RptFileName);
            //}
            //rpt.Load(RptStream);//加载报表模板文件
            //return rpt;

            if (String.IsNullOrWhiteSpace(RptFileName))
            {
                throw new Exception("没有指定报表文件！");
            }

            Report rpt = new FastReport.Report();
            rpt.Load(RptFileName);//加载报表模板文件

            return rpt;

            //string RptPath = GetFilePath(RptFileName);

            //_Report.Load(RptPath);//加载报表模板文件
        }

        /// <summary>
        /// 更新公共数据
        /// </summary>
        /// <param name="rpt"></param>
        protected virtual void UpdateRptCommandData(Report rpt)
        {
            var PrintUser = rpt.Parameters.FindByName("PrintUser");
            if (PrintUser != null) PrintUser.Value = Loginer.CurrentLoginer.UserName;
            var PrintDate = rpt.Parameters.FindByName("PrintDate");
            if (PrintDate != null) PrintDate.Value = GetServerTime();
        }

        private DateTime GetServerTime()
        {
            string sql = "SELECT GETDATE()";
            return db.ExecuteScalar<DateTime>(sql, null);
        }

        /// <summary>
        /// 根据报表名称获取报表全路径
        /// </summary>
        /// <param name="RptFileName"></param>
        /// <returns></returns>
        private string GetFilePath(string RptFileName)
        {
            return String.Format(@"{0}\Reports\{1}", AppDomain.CurrentDomain.BaseDirectory, RptFileName);
        }

        public abstract Report PrepareReport();
    }
}
