using GZDBHelper;
using GZFramework.DB.Lib;
using GZFramework.DB.ModelAttribute;
using GZFrameworkDemo.Models;
using GZFrameworkDemo.Models.DocSN;
using GZFrameworkDemo.Models.Sys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using GZFrameworkDemo.Common;

namespace GZFrameworkDemo.BusinessSQLite.Base
{

    public class dalCommon : dalBusinessBase
    {

        public dalCommon()
        {
        }

        private ModelDocNo _DocSNProvider;
        public ModelDocNo DocSNProvider
        {
            get { return _DocSNProvider; }
            set
            {
                _DocSNProvider = value;
                GenerateDocNo = !String.IsNullOrEmpty(_DocSNProvider.DocCode);
            }
        }

        public override string DoGetDocSN(IDatabase db)
        {
            return DoGetDocSN(db, DocSNProvider);
        }


        public string DoGetDocSN(IDatabase db, ModelDocNo Model)
        {
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@DocCode", SqlDbType.VarChar, 50, Model.DocCode);
            string sql = "SELECT * FROM sys_DataSN WHERE DocCode=@DocCode";

            DataTable dt = db.GetTable(sql, "", p);
            string DocHeader = "";
            string DocType = "";
            string Separate = "";
            int Length = 0;
            if (dt.Rows.Count > 0)
            {
                DocHeader = ConvertLib.ToString(dt.Rows[0][sys_DataSN.DocHeader]);
                DocType = ConvertLib.ToString(dt.Rows[0][sys_DataSN.DocType]);
                Separate = ConvertLib.ToString(dt.Rows[0][sys_DataSN.Separate]);
                Length = ConvertLib.ToInt(dt.Rows[0][sys_DataSN.Length]);

            }
            else
            {
                AddDocSNRule(db, Model);
                DocHeader = Model.DocHeader;
                DocType = Model.DocRule;
                Separate = Model.Separate;
                Length = Model.Length;
            }

            string DocSeed = "";
            switch (DocType.ToUpper())
            {
                case "YEAR":
                    DocSeed = DateTime.Now.Year.ToString();
                    DocHeader = DocHeader + DocSeed;
                    break;
                case "YEAR-MONTH":
                    DocSeed = DateTime.Now.ToString("yyyyMM");
                    DocHeader = DocHeader + DocSeed;
                    break;
                case "YEAR-MONTH-DD":
                     DocSeed = DateTime.Now.ToString("yyyyMMdd");
                    DocHeader = DocHeader + DocSeed;
                    break;
                case "UP":
                    DocSeed = Model.DocCode;
                    break;
                case "CUSTOMER":
                    DocSeed = Model.CustomerSeed;
                    break;
            }


            int snindex = 0;
            string sql2 = "SELECT * FROM sys_DataSNDetail WHERE DocCode=@DocCode AND Seed=@Seed";
            SqlParameterProvider p2 = new SqlParameterProvider();
            p2.AddParameter("@DocCode", SqlDbType.VarChar, 50, Model.DocCode);
            p2.AddParameter("@Seed", SqlDbType.VarChar, 50, DocSeed);
            DataTable datasn = db.GetTable(sql2, "t", p2);
            if (datasn.Rows.Count > 0)
            {
                snindex = ConvertLib.ToInt(datasn.Rows[0]["MaxID"]);
                snindex = ValidateSN(snindex + 1);

                string sql3 = "UPDATE sys_DataSNDetail SET MaxID=@Value WHERE DocCode=@DocCode AND Seed=@Seed";
                SqlParameterProvider p3 = new SqlParameterProvider();
                p3.AddParameter("@Value", SqlDbType.Int, snindex);
                p3.AddParameter("@DocCode", SqlDbType.VarChar, 50, Model.DocCode);
                p3.AddParameter("@Seed", SqlDbType.VarChar, 50, DocSeed);
                db.ExecuteNonQuery(sql3, p3);
            }
            else
            {
                snindex = ValidateSN(1);
                string sql4 = "INSERT INTO sys_DataSNDetail(DocCode,Seed,MaxID) VALUES(@DocCode, @Seed, @Value)";
                SqlParameterProvider p4 = new SqlParameterProvider();
                p4.AddParameter("@Value", SqlDbType.Int, snindex);
                p4.AddParameter("@DocCode", SqlDbType.VarChar, 50, Model.DocCode);
                p4.AddParameter("@Seed", SqlDbType.VarChar, 50, DocSeed);
                db.ExecuteNonQuery(sql4, p4);
            }
            string snvalue = snindex.ToString().PadLeft(Length, '0');
            if (DocType.ToUpper() == "CUSTOMER")
                return DocHeader + snvalue;
            else
                return DocHeader + Separate + snvalue;
        }

        int ValidateSN(int value)
        {
            while (value.ToString().IndexOf('4') >= 0
                   || value.ToString().IndexOf('7') >= 0)
            {
                value = value + 1;
            }
            return value;
        }


        private bool AddDocSNRule(IDatabase db, ModelDocNo Model)
        {
            string sql = "INSERT INTO sys_DataSN(DocCode,DocName,DocHeader,Separate,DocType,[Length]) VALUES(@DocCode,@DocName,@DocHeader,@Seperate,@DocType,@Length)";
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@DocCode", SqlDbType.VarChar, Model.DocCode);
            p.AddParameter("@DocName", SqlDbType.VarChar, Model.DocName);
            p.AddParameter("@DocHeader", SqlDbType.VarChar, Model.DocHeader ?? "");
            p.AddParameter("@Seperate", SqlDbType.VarChar, Model.Separate ?? "");
            p.AddParameter("@DocType", SqlDbType.VarChar, Model.DocRule);
            p.AddParameter("@Length", SqlDbType.Int, Model.Length);

            return db.ExecuteNonQuery(sql, p) > 0;
        }


        private bool AddDocSNRule(IDatabase db)
        {
            string sql = "INSERT INTO sys_DataSN(DocCode,DocName,DocHeader,Separate,DocType,[Length]) VALUES(@DocCode,@DocName,@DocHeader,@Seperate,@DocType,@Length)";
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@DocCode", SqlDbType.VarChar, DocSNProvider.DocCode);
            p.AddParameter("@DocName", SqlDbType.VarChar, DocSNProvider.DocName);
            p.AddParameter("@DocHeader", SqlDbType.VarChar, DocSNProvider.DocHeader ?? "");
            p.AddParameter("@Seperate", SqlDbType.VarChar, DocSNProvider.Separate ?? "");
            p.AddParameter("@DocType", SqlDbType.VarChar, DocSNProvider.DocRule);
            p.AddParameter("@Length", SqlDbType.Int, DocSNProvider.Length);

            return db.ExecuteNonQuery(sql, p) > 0;
        }



        public override DateTime GetServerTime(IDatabase db)
        {
            return DateTime.Now;
        }

        public override void UpdateCommonData(IDatabase db, System.Data.DataSet data)
        {
            DateTime time = this.GetServerTime(db);
            bool hasLastUpdateUser = false, hasLastUpdateDate = false, hasCreateUser = false, hasCreateDate = false;

            foreach (DataTable dt in data.Tables)
            {
                hasLastUpdateUser = dt.Columns.Contains("LastUpdateUser");
                hasLastUpdateDate = dt.Columns.Contains("LastUpdateDate");
                hasCreateUser = dt.Columns.Contains("CreateUser");
                hasCreateDate = dt.Columns.Contains("CreateDate");
                if (hasLastUpdateUser || hasLastUpdateDate)
                {
                    foreach (DataRow dr in dt.Select("", "", DataViewRowState.ModifiedCurrent))
                    {
                        if (hasLastUpdateUser) dr["LastUpdateUser"] = Loginer.CurrentLoginer.Account;
                        if (hasLastUpdateDate) dr["LastUpdateDate"] = time;
                    }
                }
                if (hasLastUpdateUser || hasLastUpdateDate | hasCreateUser | hasCreateDate)
                    foreach (DataRow dr in dt.Select("", "", DataViewRowState.Added))
                    {
                        if (hasCreateUser) dr["CreateUser"] = Loginer.CurrentLoginer.Account;
                        if (hasCreateDate) dr["CreateDate"] = time;
                        if (hasLastUpdateUser) dr["LastUpdateUser"] = Loginer.CurrentLoginer.Account;
                        if (hasLastUpdateDate) dr["LastUpdateDate"] = time;
                    }
            }
            base.UpdateCommonData(db, data);
        }

        public void UpdateCommonData(DataTable dt, IDatabase db)
        {
            DateTime time = this.GetServerTime(db);
            bool hasLastUpdateUser = dt.Columns.Contains("LastUpdateUser");
            bool hasLastUpdateDate = dt.Columns.Contains("LastUpdateDate");
            bool hasCreateUser = dt.Columns.Contains("CreateUser");
            bool hasCreateDate = dt.Columns.Contains("CreateDate");
            if (hasLastUpdateUser || hasLastUpdateDate)
            {
                foreach (DataRow dr in dt.Select("", "", DataViewRowState.ModifiedCurrent))
                {
                    if (hasLastUpdateUser) dr["LastUpdateUser"] = Loginer.CurrentLoginer.Account;
                    if (hasLastUpdateDate) dr["LastUpdateDate"] = time;
                }
            }
            if (hasLastUpdateUser || hasLastUpdateDate | hasCreateUser | hasCreateDate)
                foreach (DataRow dr in dt.Select("", "", DataViewRowState.Added))
                {
                    if (hasCreateUser) dr["CreateUser"] = Loginer.CurrentLoginer.Account;
                    if (hasCreateDate) dr["CreateDate"] = time;
                    if (hasLastUpdateUser) dr["LastUpdateUser"] = Loginer.CurrentLoginer.Account;
                    if (hasLastUpdateDate) dr["LastUpdateDate"] = time;
                }
        }

    }

  
}


