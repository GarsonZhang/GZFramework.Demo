using GZFrameworkDemo.Business.Base;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business
{
    public class bllGridViewLayout : bllBase
    {
        public bllGridViewLayout()
            : base(typeof(sys_GridViewLayout), typeof(sys_GridViewLayoutDetail))
        {
            DBCode = Loginer.CurrentLoginer.SystemDBCode;
        }
        public DataTable GetViewLayoutItems(string ViewCode)
        {
            string sql = " SELECT LayoutID,LayoutName FROM sys_GridViewLayout WHERE ViewCode=@ViewCode ";
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@ViewCode", SqlDbType.VarChar, 200, ViewCode);
            return dal.DBHelper.GetTable(sql, sys_GridViewLayout._TableName, p);
        }

        public DataSet GetViewLayoutUser(string ViewCode)
        {
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@ViewCode", SqlDbType.VarChar, 200, ViewCode);
            p.AddParameter("@Account", SqlDbType.VarChar, 20, Loginer.CurrentLoginer.Account);
            DataSet ds = dal.DBHelper.GetDataSetSP("usp_GetViewLayoutUser", p);
            ds.Tables[0].TableName = sys_GridViewLayout._TableName;
            ds.Tables[1].TableName = sys_GridViewLayoutDetail._TableName;
            return ds;
        }

        public string GetLayoutIDUser(string ViewCode)
        {
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@ViewCode", SqlDbType.VarChar, 200, ViewCode);
            p.AddParameter("@Account", SqlDbType.VarChar, 20, Loginer.CurrentLoginer.Account);
            return dal.DBHelper.ExecuteScalarSP<string>("usp_GridViewLayout_IDOfUser", p);
        }
        public DataSet GetLayoutDefault(string ViewCode)
        {
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@ViewCode", SqlDbType.VarChar, 200, ViewCode);
            DataSet ds = dal.DBHelper.GetDataSetSP("usp_GetViewLayout_Default", p);
            ds.Tables[0].TableName = sys_GridViewLayout._TableName;
            ds.Tables[1].TableName = sys_GridViewLayoutDetail._TableName;
            return ds;
        }

        public DataSet GetViewLayoutLayoutID(string ViewCode, string LayoutID)
        {
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@ViewCode", SqlDbType.VarChar, 200, ViewCode);
            p.AddParameter("@LayoutID", SqlDbType.VarChar, 50, LayoutID);
            DataSet ds = dal.DBHelper.GetDataSetSP("usp_GetViewLayoutLayoutID", p);
            ds.Tables[0].TableName = sys_GridViewLayout._TableName;
            ds.Tables[1].TableName = sys_GridViewLayoutDetail._TableName;
            return ds;
        }
    }
}
