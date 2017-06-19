using GZFrameworkDemo.Models;
using GZFramework.DB.Lib;
using GZDBHelper;
using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using GZFrameworkDemo.Models.Sys;
using GZFramework.DB;

namespace GZFrameworkDemo.BusinessSQLite.Base
{
    public class bllBase<T> : bllBase where T : ModelDocNo, new()
    {
        public bllBase(Type sMainModel, params Type[] sDetailModel)
            : base(sMainModel, sDetailModel)
        {
            T dp = new T();
            (dal as dalCommon).DocSNProvider = dp;
        }

        public ModelDocNo DocSNProvider { get { return (dal as dalCommon).DocSNProvider; } }

    }

    public class bllBase : bllBusinessBase<dalCommon>, IBLL
    {
        protected string DBCode { get { return dal.DBCode; } set { dal.DBCode = value; } }
        public bllBase(Type sMainModel, params Type[] sDetailModel)
            : base(sMainModel, sDetailModel)
        {
            //dal.DBCode = Loginer.CurrentLoginer.SystemDBCode;
        }

        string GetAllDataSQL(string TableName, params string[] Columns)
        {
            StringBuilder str = new StringBuilder();
            foreach (string col in Columns)
                str.AppendFormat(",{0}", col);
            string sql;
            if (str.Length > 0)
                sql = String.Format("SELECT {0} FROM {1} ", str.ToString(1, str.Length - 1), TableName);
            else
                sql = String.Format("SELECT * FROM {0} ", TableName);

            return sql;
        }
        string GetStructSql(string TableName, params string[] Columns)
        {
            StringBuilder str = new StringBuilder();
            foreach (string col in Columns)
                str.AppendFormat(",{0}", col);
            string sql;
            if (str.Length > 0)
                sql = String.Format("SELECT {0} FROM {1} WHERE 1=2", str.ToString(1, str.Length - 1), TableName);
            else
                sql = String.Format("SELECT * FROM {0}  WHERE 1=2", TableName);

            return sql;
        }

        public DateTime GetServerTime()
        {
            return dal.GetServerTime(dal.DBHelper);
        }


        public DataSet GetTableData(string DBCode, IEnumerable<string> TableNames, params string[] Columns)
        {


            DataSet ds = new DataSet();

            var DataBase = DataBaseFactoryEx.CreateDataBase(DBCode);
            DataBase.ExecuteTransaction(db =>
            {
                foreach (string TableName in TableNames)
                {
                    string sql = GetAllDataSQL(TableName, Columns);
                    ds.Tables.Add(db.GetTable(sql, TableName, null));
                }
            });
            return ds;
        }

        public DataSet GetTableStruct(string DBCode, IEnumerable<string> TableNames, params string[] Columns)
        {
            var dbH = DataBaseFactoryEx.CreateDataBase(DBCode);

            DataSet ds = new DataSet();

            dbH.ExecuteTransaction(db =>
            {
                foreach (string TableName in TableNames)
                {
                    string sql = GetStructSql(TableName, Columns);
                    ds.Tables.Add(db.GetTable(sql, TableName, null));
                }
            });
            return ds;
        }

        public DataTable GetTableStruct(string TableNames, params string[] Columns)
        {
            string sql = GetStructSql(TableNames, Columns);
            return dal.DBHelper.GetTable(sql, TableNames, null);
        }

        public bool Update(System.Data.DataTable dt)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            try
            {
                bool success = Update(ds);
                return success;
            }
            finally
            {
                ds.Tables.Remove(dt);
            }

        }

        //public bool Update<H>(System.Data.DataTable dt) where H : IUpdateHandle, new()
        //{
        //    DataSet ds = new DataSet();
        //    ds.Tables.Add(dt);
        //    try
        //    {

        //        bool success = dal.Update<H>(ds);
        //        return success;
        //    }
        //    finally
        //    {
        //        ds.Tables.Remove(dt);
        //    }
        //}

        public bool UpdateUnit<T>(DataTable Data)
        {
            bool success = false;
            dal.DBHelper.ExecuteTransaction(db =>
            {
                (dal as dalCommon).UpdateCommonData(Data, db);
                success = dal.UpdateUnit<T>(Data);
            });
            return success;
        }
    }

}
