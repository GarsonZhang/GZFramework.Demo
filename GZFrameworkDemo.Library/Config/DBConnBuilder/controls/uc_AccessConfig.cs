using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    [ToolboxItem(false)]
    public partial class uc_AccessConfig : UserControl, IUCDBConfig
    {
        public uc_AccessConfig()
        {
            InitializeComponent();
        }

        private void txt_Path_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (OpenFileDialog v = new OpenFileDialog())
            {
                v.Filter = "Access(*.mdb,*..accdb)|*.mdb;*.accdb|所有文件(*.*)|*.*";
                v.DefaultExt = "*.mdb;*.accdb";
                if (v.ShowDialog() == DialogResult.OK)
                {
                    txt_Path.Text = v.FileName;
                }

            }
        }
         public IDB DoConfig()
        {
            IDB Config = null;

            if (String.IsNullOrEmpty(txt_Path.Text))
            {
                txt_Path.ErrorText = "文件路径不能为空！";
                txt_Path.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                return Config;
            }

            if (!String.IsNullOrEmpty(txt_UserID.Text))
            {
                if (String.IsNullOrEmpty(txt_Pwd.Text))
                {
                    txt_Pwd.ErrorText = "密码不能为空！";
                    txt_Pwd.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                    return Config;
                }
            }

            DB_Access tmp = new DB_Access()
            {
                DataSource = txt_Path.Text,
                UserID = txt_UserID.Text,
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
