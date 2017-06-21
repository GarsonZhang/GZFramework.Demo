using GZFrameworkDemo.Common;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using GZFramework.DB;

namespace GZFrameworkDemo.Business
{
    public class bllLogin
    {

        /// <summary>
        /// 验证用户名密码
        /// </summary>
        /// <param name="User"></param>
        /// <param name="Pwd"></param>
        /// <param name="dr"></param>
        /// <returns></returns>
        public Loginer VerifyPwd(string User, string Pwd, string LoginDBCode)
        {
            Pwd = PwdEncrypt(Pwd);

            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@Account", SqlDbType.VarChar, User);
            p.AddParameter("@Pwd", SqlDbType.VarChar, Pwd);
            p.AddParameter("@LoginDBCode", SqlDbType.VarChar, LoginDBCode);

            DataTable dt = DataBaseFactoryEx.CreateDataBase(Loginer.CurrentLoginer.SystemDBCode).GetTableSP("usp_UserLogin", "tmp", p);
            if (dt.Rows.Count == 0) return null;
            else
            {
                DataRow row = dt.Rows[0];
                Loginer user = new Loginer();
                user.Account = (string)row[dt_MyUser.Account];
                user.UserName = (string)row[dt_MyUser.UserName];
                user.IsSysAdmin = Object.Equals(row[dt_MyUser.IsSysAdmain], "Y");
                user.IsSysLock = Object.Equals(row[dt_MyUser.IsSysLock], "Y");
                user.LoginDBCode = ConvertLib.ToString(row[dt_MyUserDBs.DBCode]);
                user.IsDBAdmin = Object.Equals(row[dt_MyUserDBs.IsDBAdmin], "Y");
                user.IsDBLock = Object.Equals(row[dt_MyUserDBs.IsDBLock], "Y");
                if (user.IsSysAdmin && String.IsNullOrEmpty(user.LoginDBCode))
                    user.LoginDBCode = LoginDBCode;
                return user;
            }
            //var v = DatabaseFactory.CreateDataBaseEx(Loginer.CurrentLoginer.SystemDBCode).ExecuteDataReader(sql, new { Account = User, Pwd = Pwd }, row =>
            //{
            //    return new Loginer()
            //    {
            //        Account = (string)row[dt_MyUser.Account],
            //        UserName = (string)row[dt_MyUser.UserName],
            //        IsDBAdmin = Object.Equals(row[dt_MyUser.IsAdmain], "Y")
            //    };
            //});

            //if (v.Count() > 0)
            //    return v.First();
            //else
            //    return null;
        }
        private string PwdEncrypt(string Pwd)
        {
            return Encrypt.DESEncrypt(Pwd);
        }
        public bool VerifyPwdEx(string User, string Pwd)
        {
            Pwd = PwdEncrypt(Pwd);
            const string sql = "SELECT COUNT(0) FROM  dt_MyUser WHERE Account=@Account AND [Password]=@Pwd";
            SqlParameterProvider p = new SqlParameterProvider();
            p.AddParameter("@Account", SqlDbType.VarChar, 20, User);
            p.AddParameter("@Pwd", SqlDbType.VarChar, 50, Pwd);
            long v = DataBaseFactoryEx.CreateDataBase(Loginer.CurrentLoginer.SystemDBCode).ExecuteScalar<long>(sql, p);
            return v > 0;
        }
    }
}
