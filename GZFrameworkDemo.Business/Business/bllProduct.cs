using GZFrameworkDemo.Models.DocSN.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business.Business
{
    public class bllProduct : Base.bllBase<SNProduct>
    {
        public bllProduct() : base(typeof(Models.Business.dt_Data_Product))
        {
            DBCode = Models.Loginer.CurrentLoginer.LoginDBCode;
        }

        public DataTable Search(string productID, string material, string productNmae, string zjm)
        {
            string sql = "SELECT * FROM dbo.dt_Data_Product WHERE 1=1 ";
            StringBuilder where = new StringBuilder();
            SqlParameterProvider p = new SqlParameterProvider();
            if (!String.IsNullOrEmpty(productID))
            {
                where.Append("  AND ProductID LIKE '%'+@ProductID+'%' ");
                p.AddParameter("@ProductID", SqlDbType.VarChar, 20, productID);
            }
            if (!String.IsNullOrEmpty(material))
            {
                where.Append("  AND Material = @Material ");
                p.AddParameter("@Material", SqlDbType.VarChar, 20, material);
            }
            if (!String.IsNullOrEmpty(productNmae))
            {
                where.Append("  AND ProductName LIKE '%'+@ProductName+'%' ");
                p.AddParameter("@ProductName", SqlDbType.VarChar, 20, productNmae);
            }
            if (!String.IsNullOrEmpty(zjm))
            {
                where.Append("  AND ZJM LIKE '%'+@ZJM+'%' ");
                p.AddParameter("@ZJM", SqlDbType.VarChar, 20, zjm);
            }

            return dal.DBHelper.GetTable(sql + where.ToString(), Models.Business.dt_Data_Product._TableName, p);
        }
    }
}
