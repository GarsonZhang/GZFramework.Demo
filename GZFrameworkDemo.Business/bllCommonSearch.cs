using GZFrameworkDemo.Business.Base;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business
{

    public class bllCommonSearch : bllBase
    {
        public bllCommonSearch()
            : base(null)
        {
            DBCode = Loginer.CurrentLoginer.SystemDBCode;
        }

        public DataTable GetCommonSearch(string SearchCode)
        {
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@SearchCode", SqlDbType.VarChar, 50, SearchCode);
            return dal.DBHelper.GetTableSP("usp_CommonSearch_Search", sys_CommonSearch._TableName, p);
        }

        public DataTable GetCommonSearchUser(string SearchCode, string Account)
        {
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@SearchCode", SqlDbType.VarChar, 50, SearchCode);
            p.AddParameter("@Account", SqlDbType.VarChar, 20, Account);
            return dal.DBHelper.GetTableSP("usp_CommonSearchUser_Search", sys_CommonSearchUser._TableName, p);
        }
        //public string GetPlaceholder(string SearchCode)
        //{
        //    var p = new
        //    {
        //        @SearchCode = SearchCode,
        //        @Account = Loginer.CurrentLoginer.Account
        //    };
        //    return dal.DBHelper.ExecuteScalarSP<string>("usp_CommonSearchUser_Placeholder", p);
        //}

        public DataTable GetCommonSearchCurrentUser(string SearchCode)
        {
            return GetCommonSearchUser(SearchCode, Loginer.CurrentLoginer.Account);
        }

        public bool UpdateCommonSearch(DataTable Data)
        {
            return base.UpdateUnit<sys_CommonSearch>(Data);
        }
        public bool UpdateCommonSearchUser(DataTable Data)
        {
            return base.UpdateUnit<sys_CommonSearchUser>(Data);
        }
    }
}
