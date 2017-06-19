//======================================================================
//        版权所有@GarsonZhang
//        文件名 :uc_DBConfig              									
//		  .NET版本：4.0
//        创建人：GarsonZhang  QQ：382237285
//        创建日期：2015-07-24 14:55:27
//        描述 :自定义控件
//======================================================================
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    [ToolboxItem(false)]
    public partial class uc_SQLConfig : UserControl, IUCDBConfig
    {


        public uc_SQLConfig()
        {
            InitializeComponent();
            txt_DataBase.QueryPopUp += txt_DataBase_QueryPopUp;
        }

        void txt_DataBase_QueryPopUp(object sender, CancelEventArgs e)
        {
            DataTable dt = GetDataBaseList();
            txt_DataBase.Properties.DataSource = dt;
        }



        #region 属性

        string StrServer
        {
            get
            {
                return txt_Server.Text;
            }
        }
        string StrUser
        {
            get
            {
                return txt_User.Text;
            }
        }
        string StrPassword
        {
            get
            {
                return txt_Pwd.Text;
            }
        }

        string StrDataBase
        {
            get
            {
                return txt_DataBase.Text;
            }
        }
        #endregion


        public DataTable GetDataBaseList()
        {

            if (String.IsNullOrEmpty(StrServer))
            {
                txt_Server.ErrorText = "服务器不能为空！";
                txt_Server.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return null;
            }

            if (String.IsNullOrEmpty(StrUser))
            {
                txt_User.ErrorText = "用户名不能为空！";
                txt_User.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return null;
            }

            if (String.IsNullOrEmpty(StrPassword))
            {
                txt_Pwd.ErrorText = "密码不能为空！";
                txt_Pwd.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return null;
            }

            DataTable dt = new DataTable();

            DB_SQL tmp = new DB_SQL()
            {
                Server = StrServer,
                Port = txt_Port.Text,
                DataBase = "master",
                UserID = StrUser,
                Password = StrPassword
            };
            string ConnectionStr = tmp.GetConnectionStr();
            SqlConnection conn = new SqlConnection(ConnectionStr);
            try
            {
                conn.Open();
                string str = "SELECT name FROM  sys.sysdatabases WHERE dbid>6";
                SqlCommand cmd = new SqlCommand(str, conn);
                SqlDataAdapter sdap = new SqlDataAdapter();
                sdap.SelectCommand = cmd;

                sdap.Fill(dt);
                conn.Close();

            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                MessageBox.Show(ex.ToString());
                dt = null;
            }
            return dt;
        }


        public IDB DoConfig()
        {
            DB_SQL Config = null;

            if (String.IsNullOrEmpty(StrServer))
            {
                txt_Server.ErrorText = "服务器不能为空！";
                txt_Server.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return Config;
            }

            if (String.IsNullOrEmpty(StrUser))
            {
                txt_User.ErrorText = "用户名不能为空！";
                txt_User.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return Config;
            }

            if (String.IsNullOrEmpty(StrPassword))
            {
                txt_Pwd.ErrorText = "密码不能为空！";
                txt_Pwd.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return Config;
            }

            if (String.IsNullOrEmpty(StrDataBase))
            {
                txt_DataBase.ErrorText = "数据库不能为空！";
                txt_DataBase.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return Config;
            }


            DB_SQL tmp = new DB_SQL()
            {
                Server = StrServer,
                DataBase = StrDataBase,
                UserID = StrUser,
                Password = StrPassword,
                Port = txt_Port.Text
            };
            try
            {
                var fac = System.Data.Common.DbProviderFactories.GetFactory(tmp.ProviderName);

                using (var conn = fac.CreateConnection())
                {
                    conn.ConnectionString = tmp.GetConnectionStr();
                    conn.Open();
                    conn.Close();
                    Config = tmp;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return Config;
        }
    }
}