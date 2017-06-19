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
    public partial class ucEx_OracleConfig : UserControl, IUCDBConfig
    {
        public ucEx_OracleConfig()
        {
            InitializeComponent();
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;

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

                

        void SetError(Control col, string errmsg)
        {
            this.errorProvider1.SetError(col, errmsg);
        }
        public IDB DoConfig()
        {
            DB_Oracle Config = null;

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


            DB_Oracle tmp = new DB_Oracle()
            {

                Port = txt_Port.Text,
                HOST = txt_Server.Text,
                ServiceName = txt_DataBase.Text,
                UserID = txt_User.Text,
                Password = txt_Pwd.Text
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
