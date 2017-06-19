using GZPSI.Business.Base;
using GZPSI.Models.DocSN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZPSI.Business
{
    public class bllSamplePO : bllBaseUser<SN_PO>
    {
        public bllSamplePO()
            : base(typeof(Models.tb_SamplePO), typeof(Models.tb_SamplePODetail))
        {
        }

        public override DataSet DoGetDocData(string DocNo)
        {
            string sql = "SELECT* FROM dbo.tb_SamplePO WHERE PONO = @PONO; " +
                    "SELECT* FROM dbo.tb_SamplePODetail WHERE PONO = @PONO";
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@PONO", SqlDbType.VarChar, 20, DocNo);
            DataSet ds = dal.DBHelper.GetDataSet(sql, p);
            ds.Tables[0].TableName = Models.tb_SamplePO._TableName;
            ds.Tables[1].TableName = Models.tb_SamplePODetail._TableName;

            ds.Tables[0].Columns["isid"].AutoIncrement = true;//设置该列为自增长，
            ds.Tables[0].Columns["isid"].AutoIncrementSeed = -1;//新增列的初始值。
            ds.Tables[0].Columns["isid"].AutoIncrementStep = -1;//列的值自动递增的数值。默认为 1。

            ds.Tables[1].Columns["isid"].AutoIncrement = true;//设置该列为自增长，
            ds.Tables[1].Columns["isid"].AutoIncrementSeed = -1;//新增列的初始值。
            ds.Tables[1].Columns["isid"].AutoIncrementStep = -1;//列的值自动递增的数值。默认为 1。
            return ds;

        }

        public override DataTable Search(Dictionary<string, object> parameters)
        {
            return base.Search(parameters);
        }


        public bool UpdateSummary(DataTable dt)
        {
            bool success = false;
            if (dt.Rows[0].RowState == DataRowState.Added)//如果是新增，事务中生成单据号码
            {
                dal.DBHelper.ExecuteTransaction(db =>
                {
                    string docno = dal.DoGetDocSN(db);
                    dt.Rows[0][Models.tb_SamplePO.PONO] = docno;
                    success = db.Update(dt, $"select * from {Models.tb_SamplePO._TableName}");
                    if (success == true)
                        dt.AcceptChanges();

                });
            }
            else
            {
                success = dal.DBHelper.Update(dt, $"select * from {Models.tb_SamplePO._TableName}");
            }
            if (success == true)
                dt.AcceptChanges();
            return success;

        }
        public bool UpdateDetail(DataTable dt)
        {
            bool success = dal.DBHelper.Update(dt, $"select * from {Models.tb_SamplePODetail._TableName}");
            if (success == true)
                dt.AcceptChanges();
            return success;
        }

    }
}
