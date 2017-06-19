using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    internal class DB_Oracle : IDB
    {
        
       public string ProviderName
        {
            get;
            set;
        }

       public DB_Oracle()
        {
            //ProviderName = "System.Data.OracleClient";
            ProviderName = "Oracle.ManagedDataAccess";
        }

        /// <summary>
        /// 服务器地址
        /// </summary>
       public string HOST { get; set; }

       private string _Port = "1521";
       public string Port { get { return _Port; } set { _Port = value; } }

        public string ServiceName{get;set;}

        /// <summary>
        /// 登陆用户名
        /// </summary>
        public string UserID { get; set; }
  
        public string Password{get;set;}

        public string GetConnectionStr()
        {
            
            string Format = "User Id={0}; password={1};Data Source={2}:{3}/{4}; Pooling=false;";
            //string Format = "Provider=OraOLEDB.Oracle.1;User ID={0};Password={1};Data Source=(DESCRIPTION = (ADDRESS_LIST= (ADDRESS = (PROTOCOL = TCP)(HOST = {2})(PORT = {3}))) (CONNECT_DATA = (SERVICE_NAME = {4})))";
            //string Format = "User ID={0};Password={1};Data Source=(DESCRIPTION = (ADDRESS_LIST= (ADDRESS = (PROTOCOL = TCP)(HOST = {2})(PORT = {3}))) (CONNECT_DATA = (SERVICE_NAME = {4})))";
            string constr = String.Format(Format, UserID, Password, HOST, Port, ServiceName);
            return constr;
        }

    }
}
