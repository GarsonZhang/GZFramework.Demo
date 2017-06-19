using GZFramework.DB;
using GZFrameworkDemo.BusinessSQLite.Base;
using GZFrameworkDemo.BusinessSQLite.CustomerEnum;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.BusinessSQLite
{
    public class bllDataCommon
    {
        private static bllDataCommon _instance;
        public static bllDataCommon Instance
        {
            get
            {
                if (_instance == null) _instance = new bllDataCommon();
                return _instance;
            }
        }


        public string GetAllDataSQL(string TableName, params string[] Columns)
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
                sql = String.Format("SELECT  {0} FROM {1} WHERE 1=2", str.ToString(1, str.Length - 1), TableName);
            else
                sql = String.Format("SELECT * FROM {0}  WHERE 1=2", TableName);

            return sql;
        }

        public DataTable GetTableData(string DBCode, string TableName, params string[] Columns)
        {
            var db = DataBaseFactoryEx.CreateDataBase(DBCode);
            string sql = GetAllDataSQL(TableName, Columns);
            return db.GetTable(sql, TableName, null);
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

        public DataTable GetTableStruct(string DBCode, string TableName, params string[] Columns)
        {
            var db = DataBaseFactoryEx.CreateDataBase(DBCode);
            string sql = GetStructSql(TableName, Columns);
            return db.GetTable(sql, TableName, null);
        }
        public DateTime GetServerTime()
        {
            return DateTime.Now;
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

     
        public DataTable getCommonDicData(EnumCommonDicData E, string TableName)
        {
            var sql = "SELECT DataCode,DataName FROM dt_CommonDicData WHERE DataType=@DataType ORDER BY SortIndex";
            //var dbH = DataBaseFactoryEx.CreateDataBase(Loginer.CurrentLoginer.LoginDBCode);
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@DataType", SqlDbType.VarChar, 50, E.ToString());
            return DBServices.DB.GetTable(sql, TableName, p);
        }

        public DataTable getCompanyInfo()
        {
            string sql = "SELECT * FROM dt_Data_CompanyInfo";
            //var dbH = DataBaseFactoryEx.CreateDataBase(Loginer.CurrentLoginer.LoginDBCode);
            return DBServices.DB.GetTable(sql, dt_Data_CompanyInfo._TableName, null);
        }
    }

}
