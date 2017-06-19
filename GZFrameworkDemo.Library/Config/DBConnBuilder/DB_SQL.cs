using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    internal class DB_SQL : IDB
    {

        public string ProviderName
        {
            get;
            set;
        }

        public DB_SQL()
        {
            ProviderName = "System.Data.SqlClient";
        }

        /// <summary>
        /// 服务器地址
        /// </summary>
        public string Server { get; set; }

        private string _Port = "1433";
        public string Port { get { return _Port; } set { _Port = value; } }

        /// <summary>
        /// 登陆用户名
        /// </summary>
        public string UserID { get; set; }
        /// <summary>
        /// 数据库
        /// </summary>
        public string DataBase { get; set; }
        /// <summary>
        /// 登陆密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 是否可信任链接
        /// </summary>
        public bool Trusted_Connection { get; set; }

        public string ServerFull
        {
            get
            {
                return Server + (Port == "1433" ? "" : "," + Port);
            }
        }


        public  string GetConnectionStr()
        {
            string constr = "";
            if (Trusted_Connection)
                constr = String.Format("Server = {0};Database = {1};Trusted_Connection = True", ServerFull, DataBase);
            else
                constr = String.Format("Server = {0};Database = {1};User ID = {2};Password = {3};Trusted_Connection = False", ServerFull, DataBase, UserID, Password);

            return constr;
        }
        public string GetConnectionStr(string DBName)
        {
            string constr = "";
            if (Trusted_Connection)
                constr = String.Format("Server = {0};Database = {1};Trusted_Connection = True", ServerFull, DBName);
            else
                constr = String.Format("Server = {0};Database = {1};User ID = {2};Password = {3};Trusted_Connection = False", ServerFull, DBName, UserID, Password);

            return constr;
        }

        /*
         
            标准安全连接

            Data Source = myServerAddress;Initial Catalog = myDataBase;User Id = myUsername;Password = myPassword;
            使用服务器名\实例名作为连接指定SQL Server实例的数据源。如果你使用的是SQL Server 2008 Express版，实例名为SQLEXPRESS。



            可替代的标准安全连接 

            Server = myServerAddress;Database = myDataBase;User ID = myUsername;Password = myPassword;Trusted_Connection = False;
            这条连接字符串跟上一条效果一样。把这条写出来只是想说，其实很多连接字符串的关键字有多种写法。



            信任连接

            Data Source = myServerAddress;Initial Catalog = myDataBase;Integrated Security = SSPI;
            可替代的信任连接

            Server = myServerAddress;Database = myDataBase;Trusted_Connection = True;
         */





    }

}
