using GZFrameworkDemo.Business.Base;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business
{
    public class bllCommonDicData : bllBase
    {
        public bllCommonDicData()
            : base(typeof(dt_CommonDicData))
        {
            DBCode = Loginer.CurrentLoginer.LoginDBCode;
        }
        public DataTable GetAllDetail()
        {
            string sql = "SELECT * FROM dt_CommonDicData ORDER BY SortIndex";
            return dal.DBHelper.GetTable(sql, dt_CommonDicData._TableName, null);
        }
        public DataTable GetDetail(string DataType)
        {
            string sql = "SELECT * FROM dt_CommonDicData WHERE DataType=@DataType";
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@DataType", SqlDbType.VarChar, 50, DataType);
            return dal.DBHelper.GetTable(sql, dt_CommonDicData._TableName, p);
        }
    }
}
