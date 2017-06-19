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
using System.Windows.Forms;


namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    [ToolboxItem(false)]
    public partial class uc_OracleConfig : UserControl, IUCDBConfig
    {


        public uc_OracleConfig()
        {
            InitializeComponent();
        }

        public IDB DoConfig()
        {
            IDB Config = null;

            if (String.IsNullOrEmpty(txt_Server.Text))
            {
                txt_Server.ErrorText = "服务器不能为空！";
                txt_Server.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return null;
            }

            if (String.IsNullOrEmpty(txt_User.Text))
            {
                txt_User.ErrorText = "用户名不能为空！";
                txt_User.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return null;
            }

            if (String.IsNullOrEmpty(txt_Pwd.Text))
            {
                txt_Pwd.ErrorText = "密码不能为空！";
                txt_Pwd.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return null;
            }
            if (String.IsNullOrEmpty(txt_DataBase.Text))
            {
                txt_DataBase.ErrorText = "数据库不能为空！";
                txt_DataBase.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return null;
            }


            DB_Oracle tmp = new DB_Oracle()
            {
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
