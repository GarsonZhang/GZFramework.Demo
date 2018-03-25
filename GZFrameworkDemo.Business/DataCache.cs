using GZFrameworkDemo.Business.CustomerEnum;
using GZFrameworkDemo.Models;
using GZDBHelper;
using GZFramework.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business
{
    public enum EDBName
    {
        System,
        Login
    }
    public class DataProviderAttribute : Attribute
    {
        public EDBName DBName { get; set; }
        public DataProviderAttribute(EDBName type)
        {
            DBName = type;
        }
    }

    public class DataCache
    {
        DataCacheMgr CommonData;


        public DataCache()
        {
            CommonData = new DataCacheMgr();
        }

        private static DataCache _Cache = null;

      

        /// <summary>
        /// 缓存数据唯一实例
        /// </summary>
        public static DataCache Cache
        {
            get
            {
                if (_Cache == null) _Cache = new DataCache();
                return _Cache;
            }
        }

        /// <summary>
        /// 账套数据
        /// </summary>
        public DataTable dtDBList
        {
            get
            {
                DataTable dt = CommonData.FindFromCache(sys_DataBaseList._TableName);
                if (dt == null)
                {
                    dt = new bllDataBaseList().GetDBList();
                    dt.TableName = sys_DataBaseList._TableName;
                    AddToCache(dt.Copy());
                }
                return dt;
            }
        }

        public DataTable CompanyInfo
        {
            get
            {
                DataTable dt = CommonData.FindFromCache(dt_Data_CompanyInfo._TableName);
                if (dt == null)
                {
                    dt = RefreshCompanyInfo(null);
                }
                return dt;
            }
        }


        public void LoadCatch()
        {
            List<System.Reflection.MethodInfo> MethodLogin = new List<System.Reflection.MethodInfo>();
            List<System.Reflection.MethodInfo> MethodSystem = new List<System.Reflection.MethodInfo>();
            var ms = this.GetType().GetMethods(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            foreach (var v in ms)
            {
                var dp = (DataProviderAttribute)v.GetCustomAttributes(typeof(DataProviderAttribute), false).FirstOrDefault();
                if (dp != null)
                {
                    if (dp.DBName == EDBName.System)
                        MethodSystem.Add(v);
                    if (dp.DBName == EDBName.Login)
                        MethodLogin.Add(v);
                }
            }
            if (!String.IsNullOrEmpty(Loginer.CurrentLoginer.LoginDBCode))
            {
                var dbLogin = DataBaseFactoryEx.CreateDataBase(Loginer.CurrentLoginer.LoginDBCode);
                dbLogin.Excute(db =>
                {
                    foreach (var m in MethodLogin)
                    {
                        m.Invoke(this, new object[] { db });
                    }
                });
            }
            var dbSystem = DataBaseFactoryEx.CreateDataBase(Loginer.CurrentLoginer.SystemDBCode);
            dbSystem.Excute(db =>
            {
                foreach (var m in MethodSystem)
                {
                    m.Invoke(this, new object[] { db });
                }
            });

        }

        [DataProviderAttribute(EDBName.Login)]
        private DataTable RefreshCompanyInfo(IDatabase db)
        {
            if (db == null)
                db = DBServices.DB;
            string sql = "SELECT * FROM dt_Data_CompanyInfo";
            DataTable dt = db.GetTable(sql, dt_Data_CompanyInfo._TableName, null);
            AddToCache(dt);
            return dt;
        }

        /// <summary>
        /// 系统用户
        /// </summary>
        public DataTable UserName
        {
            get
            {
                DataTable dt = CommonData.FindFromCache(dt_MyUser._TableName);
                if (dt == null)
                {
                    dt = RefreshUserName(null);
                    AddToCache(dt.Copy());
                }
                return dt;
            }
        }

        [DataProviderAttribute(EDBName.System)]
        private DataTable RefreshUserName(IDatabase db)
        {
            if (db == null)
                db = DataBaseFactoryEx.CreateDataBase(Loginer.CurrentLoginer.SystemDBCode);
            string sql = bllDataCommon.Instance.GetAllDataSQL(dt_MyUser._TableName, dt_MyUser.Account, dt_MyUser.UserName);
            DataTable dt = db.GetTable(sql, dt_MyUser._TableName, null);
            AddToCache(dt);
            return dt;
        }


        /// <summary>
        /// 角色
        /// </summary>
        public DataTable dtRole
        {
            get
            {
                DataTable dt = CommonData.FindFromCache(dt_MyRole._TableName);
                if (dt == null)
                {
                    dt = bllDataCommon.Instance.GetTableData(Loginer.CurrentLoginer.SystemDBCode, dt_MyRole._TableName, dt_MyRole.RoleID, dt_MyRole.RoleName);
                    dt.TableName = dt_MyRole._TableName;
                    AddToCache(dt.Copy());
                }
                return dt;
            }
        }

        /// <summary>
        /// 基础字典数据
        /// </summary>
        /// <param name="E"></param>
        /// <returns></returns>
        public DataTable GetCommonDictData(EnumCommonDicData E)
        {
            string TableName = dt_CommonDicData._TableName + (int)E;
            DataTable dt = CommonData.FindFromCache(TableName);
            if (dt == null)
            {
                dt = bllDataCommon.Instance.getCommonDicData(E, TableName);
                AddToCache(dt.Copy());
            }
            return dt;
        }


        //public DataTable dtCategory
        //{
        //    get
        //    {
        //        DataTable dt = CommonData.FindFromCache(Models.Business.tb_ProductCategory._TableName);
        //        if (dt == null)
        //        {
        //            dt = RefreshCategory(null);
        //        }
        //        return dt;
        //    }
        //}

        //[DataProviderAttribute(EDBName.Login)]
        //private DataTable RefreshCategory(IDatabase db)
        //{
        //    if (db == null)
        //        db = DBServices.DB;
        //    string sql = bllDataCommon.Instance.GetAllDataSQL(Models.Business.tb_ProductCategory._TableName, tb_ProductCategory.Flag, tb_ProductCategory.CategoryID, tb_ProductCategory.ParentCategoryID, tb_ProductCategory.CategoryName);
        //    DataTable dt = db.GetTable(sql, tb_ProductCategory._TableName, null);
        //    dt.Columns.Add("ID", typeof(System.String));
        //    dt.Columns.Add("ParentID", typeof(System.String));
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        dr["ID"] = dr[tb_ProductCategory.CategoryID];
        //        dr["ParentID"] = dr[tb_ProductCategory.ParentCategoryID];
        //    }
        //    dt.AcceptChanges();
        //    AddToCache(dt);
        //    return dt;
        //}




        /// <summary>
        /// 刷新缓存
        /// </summary>
        /// <param name="TableName"></param>
        public void RefreshCache(string TableName)
        {
            CommonData.ClearCache(TableName);
        }
        public void RefreshCacheAll()
        {
            CommonData.ClearCacheAll();
        }

        private void AddToCache(DataTable dataTable)
        {
            CommonData.AddToCache(dataTable);
        }





    }

    public class DataCacheMgr : IDisposable
    {
        DataSet _CacheData = new DataSet();

        public void Dispose()
        {
            if (_CacheData != null)
            {
                _CacheData.Dispose();
                _CacheData = null;
            }
        }
        /// <summary>
        /// 加到缓存的数据集
        /// </summary>
        /// <param name="dt"></param>
        public void AddToCache(DataTable dt)
        {

            if (_CacheData.Tables.Contains(dt.TableName))
                _CacheData.Tables.Remove(dt.TableName);
            _CacheData.Tables.Add(dt);
        }

        /// <summary>
        /// 刷新缓存的数据集(删除)
        /// </summary>
        /// <param name="dt"></param>
        public void ClearCache(string tableName)
        {
            if (_CacheData.Tables.Contains(tableName))
                _CacheData.Tables.Remove(tableName);
        }
        /// <summary>
        /// 刷新缓存的数据集(删除所有)
        /// </summary>
        /// <param name="dt"></param>
        public void ClearCacheAll()
        {
            if (_CacheData != null)
            {
                _CacheData.Dispose();
                _CacheData = new DataSet();
            }
        }

        /// <summary>
        /// 查找缓存表
        /// </summary>
        /// <param name="tableName">指定表名</param>
        /// <returns></returns>
        public DataTable FindFromCache(string tableName)
        {
            return _CacheData.Tables[tableName];
        }

    }

}
