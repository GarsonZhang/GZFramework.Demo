using GZFrameworkDemo.Business.Base;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace GZFrameworkDemo.Business
{
    public class bllMyUser : bllBase
    {
        public bllMyUser()
            : base(typeof(dt_MyUser), typeof(dt_MyUserDBs), typeof(dt_MyUserRole))
        {
            DBCode = Loginer.CurrentLoginer.SystemDBCode;
        }
        /// <summary>
        /// 获得角色列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetRoleList()
        {
            var sql = "SELECT RoleID,RoleName,[Description] FROM dt_MyRole";
            return dal.DBHelper.GetTable(sql, dt_MyRole._TableName, null);
        }



        public DataTable GetRolesAuthority(string RoleIDs)
        {
            if (String.IsNullOrEmpty(RoleIDs)) return null;
            //string sql = "SELECT FunctionID,BinaryOrOperation(Authority) as Authority FROM dt_MyRoleAuthority  WHERE RoleID IN ("+ RoleIDs + "))  GROUP BY FunctionID";
            string sql = "SELECT FunctionID,Authority as Authority FROM dt_MyRoleAuthority  WHERE RoleID IN (" + RoleIDs + ")";

            DataTable dt = dal.DBHelper.GetTable(sql, "tmp", null);

            var query = from t in dt.AsEnumerable()
                        group t by new { FunctionID = t.Field<string>(dt_MyRoleAuthority.FunctionID) } into m
                        select new
                        {
                            FunctionID = m.Key.FunctionID,
                            Authority = m.Aggregate(0, (d, n) =>
                            {
                                return d | Common.ConvertLib.ToInt(n["Authority"]);
                            })
                        };

            DataTable data = new DataTable();
            data.Columns.Add("FunctionID", typeof(System.String));
            data.Columns.Add("Authority", typeof(System.Int32));
            query.ToList().ForEach(p =>
            {
                DataRow row = data.Rows.Add();
                row["FunctionID"] = p.FunctionID;
                row["Authority"] = p.Authority;
            });
            data.AcceptChanges();
            return data;

        }

        /// <summary>
        /// 获得系统模块列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetSystemModules()
        {
            return new bllModules().GetSystemModules();
        }
    }
}
