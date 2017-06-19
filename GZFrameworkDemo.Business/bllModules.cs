using GZFrameworkDemo.BusinessSQLite.Base;
using GZFrameworkDemo.Models;
using GZFramework.DB.Lib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using GZDBHelper;

namespace GZFrameworkDemo.BusinessSQLite
{
    public class bllModules : bllBase
    {
        public bllModules()
            : base(typeof(sys_Modules), typeof(sys_ModulesFunction), typeof(sys_ModulesFunctionAuthority))
        {
            DBCode = Loginer.CurrentLoginer.SystemDBCode;
        }

        public System.Data.DataSet GetUserModules(string Account)
        {
            SqlParameterProvider p1 = new GZFrameworkDemo.BusinessSQLite.SqlParameterProvider();
            p1.AddParameter("@Account", SqlDbType.VarChar, 20, Account);
            DataSet ds = null;
            DBServices.DB.ExecuteTransaction(db =>
            {
                string sql = "SELECT IsSysAdmain FROM dt_MyUser WHERE Account=@Account";

                string isAdmin = db.ExecuteScalar<string>(sql, p1);
                if ("Y".Equals(isAdmin))
                {
                    string sql2 = "SELECT * FROM sys_Modules ORDER BY Sort;" +
                                "SELECT *,1073741823 AS UserAuthority FROM sys_ModulesFunction ORDER BY Sort ";
                    ds = dal.DBHelper.GetDataSet(sql2, null);
                }
                else
                {
                    string sql2 = @"SELECT * FROM sys_Modules ORDER BY Sort;
                                SELECT *,0 AS UserAuthority FROM sys_ModulesFunction ORDER BY Sort;
                                SELECT * FROM dt_MyRoleAuthority 
                                WHERE RoleID IN(
                                    SELECT RoleID FROM dt_MyUserRole WHERE Account = @Account
                                )";
                    ds = dal.DBHelper.GetDataSet(sql2, p1);

                    //获得总权限，
                    DataTable dtAuthority = ds.Tables[2];
                    var query = from t in dtAuthority.AsEnumerable()
                                group t by new { FunctionID = t.Field<string>("FunctionID") } into m
                                select new
                                {
                                    FunctionID = m.Key.FunctionID,
                                    Authority = m.Aggregate(0, (d, n) =>
                                    {
                                        return d | Common.ConvertLib.ToInt(n["Authority"]);
                                    })
                                };

                    query.ToList().ForEach(p =>
                    {
                        ds.Tables[1].Select($"FunctionID='{p.FunctionID}'").ToList().ForEach(row =>
                        {
                            row["UserAuthority"] = p.Authority;
                        });
                    });
                    ds.Tables[1].Select("UserAuthority=0").ToList().ForEach(row =>
                    {
                        ds.Tables[1].Rows.Remove(row);
                    });

                    var ModuleNo = from module in ds.Tables[0].AsEnumerable()
                                   where !ds.Tables[1].AsEnumerable().Any(y =>
                                   y.Field<string>(sys_ModulesFunction.ModuleID) == module.Field<string>(sys_Modules.ModuleID))
                                   select new
                                   {
                                       row = module,
                                       ModuleID = module.Field<string>(sys_Modules.ModuleID)
                                   };

                    ModuleNo.ToList().ForEach(r =>
                    {
                        ds.Tables[0].Rows.Remove(r.row);
                    });
                    ds.Tables.RemoveAt(2);
                    ds.AcceptChanges();
                }
            });
            ds.Tables[0].TableName = sys_Modules._TableName;
            ds.Tables[1].TableName = sys_ModulesFunction._TableName;
            return ds;
        }

        public bool DeleteModule(string Modules)
        {
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@ModuleIDs", SqlDbType.VarChar, 500, Modules);
            int query = dal.DBHelper.ExecuteNonQuerySP("usp_DeleteModule", p);
            return query > 0;
        }

        public DataSet GetModulesData()
        {
            DataSet ds = new DataSet();
            dal.DBHelper.ExecuteTransaction(db =>
            {
                ds.Tables.Add(db.GetTable("select * from " + sys_Modules._TableName, sys_Modules._TableName, null));
                ds.Tables.Add(db.GetTable("select * from " + sys_ModulesFunction._TableName, sys_ModulesFunction._TableName, null));
                ds.Tables.Add(db.GetTable("select * from " + sys_ModulesFunctionAuthority._TableName, sys_ModulesFunctionAuthority._TableName, null));
            });
            return ds;
        }

        /// <summary>
        /// 获得系统模块列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetSystemModules()
        {
            string sql = @"SELECT ModuleID AS PKey,'' AS ParentKey,ModuleName AS DisplayName,ModuleID,'' AS FunctionID,0 AS AuthorityID 
                        FROM sys_Modules
                        union
                        SELECT FunctionID AS Pkey,ModuleID AS ParentKey,FunctionName AS DisplayName,'' AS ModuleID,FunctionID,0 AS Authority 
                        FROM sys_ModulesFunction
                        union
                        SELECT FunctionID+'.'+CAST(AuthorityID AS VARCHAR) AS PKey,FunctionID AS ParentKey,AuthorityName AS DisplayName,'' AS ModuleID,'' AS FunctionID,AuthorityID 
                        FROM sys_ModulesFunctionAuthority";
            return dal.DBHelper.GetTable(sql, "tmp", null);
        }


        public DataTable GetTreeModule_CurrentUser()
        {
            //return dal.DBHelper.GetTableSP("usp_sys_GetModules_CurrentUser", "tmp", new { @Account = Loginer.CurrentLoginer.Account });
            return GetTreeModule_User(Loginer.CurrentLoginer.Account);
        }
        public DataTable GetTreeModule_User(string Account)
        {
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@Account", SqlDbType.VarChar, 20, Account);
            return dal.DBHelper.GetTableSP("usp_sys_GetModules_CurrentUser", "tmp", p);
        }

        public override bool Update(DataSet ds)
        {
            return dal.Update<UpdateHandle>(ds);
        }

        public class UpdateHandle : IUpdateHandle
        {
            public void AfterUpdate(IDatabase db, DataSet data)
            {

            }

            public void BeforeUpdate(IDatabase db, DataSet data)
            {
                string sql = @"delete from sys_Modules;
                        delete from sys_ModulesFunction;
                        delete from sys_ModulesFunctionAuthority;";
                db.ExecuteNonQuery(sql, null);
            }
        }
    }
}
