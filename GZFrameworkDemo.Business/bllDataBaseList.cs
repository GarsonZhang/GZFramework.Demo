using GZFrameworkDemo.BusinessSQLite.Base;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.BusinessSQLite
{
    public class bllDataBaseList : bllBase
    {
        public bllDataBaseList()
            : base(typeof(sys_DataBaseList), typeof(sys_DataBaseListAuthority))
        {
            DBCode = Loginer.CurrentLoginer.SystemDBCode;
        }
        /// <summary>
        /// 获得用户权限内的账套列表
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        public System.Data.DataTable GetUserDBList(string Account)
        {
            //@Account
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@Account", SqlDbType.VarChar, 20, Account);
            return dal.DBHelper.GetTableSP("usp_GetUserDBList", sys_DataBaseList._TableName, p);
        }

        public DataTable GetDBList()
        {
            string sql = "";
            SqlParameterProvider p = null;
            if (!String.IsNullOrEmpty(Loginer.CurrentLoginer.LoginDBCode))
            {
                sql = "SELECT * FROM dbo.sys_DataBaseList WHERE DBCode=@DBCode";
                p = new SqlParameterProvider();
                p.AddParameter("@DBCode", SqlDbType.VarChar, 20, Loginer.CurrentLoginer.LoginDBCode);
            }
            else
            {
                sql = "SELECT * FROM dbo.sys_DataBaseList";
            }
            return dal.DBHelper.GetTable(sql, sys_DataBaseList._TableName, p);

        }

        public bool DBCodeExists(string DBCode)
        {
            string sql = "SELECT COUNT(*) FROM dbo.sys_DataBaseList WHERE DBCode=@DBCode";
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@DBCode", SqlDbType.VarChar, 20, DBCode);
            int count = dal.DBHelper.ExecuteScalar<int>(sql, p);
            return count > 0;
        }

        public System.Data.DataTable GetDBAuthority(string DBCode)
        {
            string sql = "SELECT * FROM dbo.sys_DataBaseListAuthority WHERE DBCode=@DBCode";
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@DBCode", SqlDbType.VarChar, 20, DBCode);
            return dal.DBHelper.GetTable(sql, sys_DataBaseListAuthority._TableName, p);
        }
    }
}
