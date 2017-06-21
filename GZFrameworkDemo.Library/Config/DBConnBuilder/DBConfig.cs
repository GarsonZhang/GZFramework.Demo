

using GZFrameworkDemo.Business;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.MyClass;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;
using GZFrameworkDemo.Models;
using System.Data;
using System;
using GZDBHelper;
using System.Data.SqlClient;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    public class DBConfig
    {

        public class DabaBaseModel
        {

            public string ProviderName { get; set; }
            public string ConnnectionString { get; set; }

            private IDatabase _db;
            public IDatabase Database
            {
                get
                {
                    if (_db == null)
                        _db = DatabaseFactory.CreateDatabase(ConnnectionString, ProviderName, DbDataAdapterMSSqlIDENTITY);
                    return _db;
                }
            }
            private const string IDENTITYCOLUMNNAME = "isid";
            /// <summary>
            /// MS数据库
            /// </summary>
            /// <param name="obj"></param>
            private void DbDataAdapterMSSqlIDENTITY(DbDataAdapter obj)
            {
                if (obj is SqlDataAdapter)
                {
                    SqlDataAdapter adpt = obj as SqlDataAdapter;
                    adpt.RowUpdating += MSSQL_RowUpdating;
                    adpt.RowUpdated += MSSQL_RowUpdated;
                }
            }

            private void MSSQL_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
            {
                if (e.StatementType == StatementType.Insert && e.Row != null)
                {
                    //DataColumnCollection _columns = e.Row.Table.Columns;
                    //foreach (DataColumn dc in _columns)
                    //{
                    //    if (dc.AutoIncrement)
                    //    {
                    //        dc.ReadOnly = false;
                    //        e.Row[dc] = e.Command.Parameters["@GZFramework_ID"].Value;
                    //        dc.ReadOnly = true;
                    //        break;
                    //    }
                    //}
                    if (e.Row.Table.Columns.Contains(IDENTITYCOLUMNNAME))
                    {
                        e.Row[IDENTITYCOLUMNNAME] = e.Command.Parameters["@GZFramework_ID"].Value;
                    }

                }
            }

            private void MSSQL_RowUpdating(object sender, SqlRowUpdatingEventArgs e)
            {
                if (e.StatementType == StatementType.Insert)
                {
                    //DataColumnCollection _columns = e.Row.Table.Columns;
                    //foreach (DataColumn dc in _columns)
                    //{
                    //    if (dc.AutoIncrement)
                    //    {
                    //        e.Command.CommandText = e.Command.CommandText + ";SELECT @GZFramework_ID = SCOPE_IDENTITY()";
                    //        e.Command.Parameters.Add("@GZFramework_ID", SqlDbType.Int);
                    //        e.Command.Parameters["@GZFramework_ID"].Direction = ParameterDirection.Output;
                    //        break;
                    //    }
                    //}
                    if (e.Row.Table.Columns.Contains(IDENTITYCOLUMNNAME))
                    {
                        e.Command.CommandText = e.Command.CommandText + ";SELECT @GZFramework_ID = SCOPE_IDENTITY()";
                        e.Command.Parameters.Add("@GZFramework_ID", SqlDbType.Int);
                        e.Command.Parameters["@GZFramework_ID"].Direction = ParameterDirection.Output;
                    }
                }
            }

        }

        private string System_DBCode = "";
        private DabaBaseModel System_Model;

        Dictionary<string, DabaBaseModel> dic;
        public DBConfig()
        {
            dic = new Dictionary<string, DabaBaseModel>();
            System_Model = new DabaBaseModel();
            bool success = LoadSysConfig();
            bool FormShow = GZFramework.UI.Dev.SplashScreenServer.Shown;
            if (success == false)//没有数据库配置
            {

                if (frmDBConfigNew.ShowForm() == DialogResult.OK)
                {
                    success = LoadSysConfig();
                    if (success == false)
                        ApplicationEx.Exit();
                }
                else
                    ApplicationEx.Exit();
            }
            if (FormShow == true)
                GZFramework.UI.Dev.SplashScreenServer.ShowForm(null);//跳转窗体
        }




        bool LoadSysConfig()
        {
            INIDBConfig i = new INIDBConfig();
            string DBCode = i.GetDBCode();
            string ConnnectionString = i.GetConnStr();
            string ProviderName = i.GetProviderName();
            var validate = DatabaseFactory.Validate(ConnnectionString, ProviderName);
            if (validate == true)
            {
                Loginer.CurrentLoginer.SystemDBCode = DBCode;
                System_DBCode = DBCode;
                System_Model.ConnnectionString = ConnnectionString;
                System_Model.ProviderName = ProviderName;
            }
            return validate;
        }

        public IDatabase GetDBConnectionInfo(string DBCode)
        {
            if (System_DBCode == DBCode)
                return System_Model.Database;

            if (dic.ContainsKey(DBCode))
                return dic[DBCode].Database;
            else
            {
                throw new Exception("数据库没有配置！" + DBCode);
            }
        }




        public void RefreshDBList()
        {
            dic.Clear();
            LoadConfigDBList();
        }

        void LoadConfigDBList()
        {

            bllDataBaseList bll = new bllDataBaseList();
            DataTable dt = bll.GetUserDBList(Loginer.CurrentLoginer.Account);
            foreach (DataRow dr in dt.Rows)
            {
                string DBCode = ConvertLib.ToString(dr[sys_DataBaseList.DBCode]);
                string DBConnection = Encrypt.DESDecrypt(ConvertLib.ToString(dr[sys_DataBaseList.DBConnection]), Globals.KeyConnectionStr);
                string DBProviderName = ConvertLib.ToString(dr[sys_DataBaseList.DBProviderName]);
                dic.Add(DBCode, new DabaBaseModel() { ConnnectionString = DBConnection, ProviderName = DBProviderName });
            }
        }
    }
}
