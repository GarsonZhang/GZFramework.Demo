using GZFrameworkDemo.Models.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business.Business
{
    public class bllCustomer : Base.bllBase
    {
        public bllCustomer() : base(typeof(Models.Business.dt_Data_Customer))
        {
            DBCode = Models.Loginer.CurrentLoginer.LoginDBCode;//当前登陆数据库
        }

        /// <summary>
        /// 按条件检索数据
        /// </summary>
        /// <param name="customerID"></param>
        /// <param name="customerName"></param>
        /// <param name="zjm"></param>
        /// <returns></returns>
        public DataTable search(string customerID, string customerName, string zjm)
        {
            string sql = "SELECT * FROM dbo.dt_Data_Customer WHERE 1=1 ";
            SqlParameterProvider p = new SqlParameterProvider();
            StringBuilder where = new StringBuilder();
            if (!String.IsNullOrEmpty(customerID))
            {
                where.Append(" AND CustomerID LIKE '%'+@CustomerID+'%'");
                p.AddParameter("@CustomerID", SqlDbType.VarChar, 20, customerID);
            }
            if (!String.IsNullOrEmpty(customerName))
            {
                where.Append(" AND CustomerName LIKE '%'+ @CustomerName+'%'");
                p.AddParameter("@CustomerName", SqlDbType.VarChar, 20, customerName);
            }
            if (!String.IsNullOrEmpty(zjm))
            {
                where.Append(" AND ZJM LIKE '%'+@ZJM+'%'");
                p.AddParameter("@ZJM", SqlDbType.VarChar, 20, zjm);
            }

            //if (where.Length > 0)//去掉第一个AND
            //    where.Remove(0, 4);

            return dal.DBHelper.GetTable(sql + where.ToString(), dt_Data_Customer._TableName, p);

        }
    }
}
