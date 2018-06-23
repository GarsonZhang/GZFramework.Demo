using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder.controls
{
    public partial class ucEx_SQLConfig : UserControl, IUCDBConfig
    {
        public ucEx_SQLConfig()
        {
            InitializeComponent();
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            txt_DataBase.ValueMember = "name";
            txt_DataBase.DisplayMember = "name";
            txt_DataBase.DropDown += Txt_DataBase_DropDown;
        }

        private void Txt_DataBase_DropDown(object sender, EventArgs e)
        {
            DataTable dt = GetDataBaseList();
            txt_DataBase.DataSource = dt;
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
                SetError(this.txt_Server, "服务器不能为空");
                return null;
            }

            if (String.IsNullOrEmpty(StrUser))
            {
                SetError(this.txt_User, "用户名不能为空");
                return null;
            }

            if (String.IsNullOrEmpty(StrPassword))
            {
                SetError(this.txt_Pwd, "密码不能为空");
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
                //string str = "SELECT name FROM  sys.sysdatabases WHERE dbid>6";
                string str = "SELECT name FROM  sys.sysdatabases";
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

        void SetError(Control col, string errmsg)
        {
            this.errorProvider1.SetError(col, errmsg);
        }
        public IDB DoConfig()
        {
            DB_SQL Config = null;

            if (String.IsNullOrEmpty(StrServer))
            {
                SetError(this.txt_Server, "服务器不能为空");

                return Config;
            }

            if (String.IsNullOrEmpty(StrUser))
            {
                SetError(txt_User, "用户名不能为空");
                return Config;
            }

            if (String.IsNullOrEmpty(StrPassword))
            {
                SetError(txt_Pwd, "密码不能为空");
                return Config;
            }

            if (String.IsNullOrEmpty(StrDataBase))
            {
                SetError(txt_DataBase, "数据库不能为空");
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
