using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    [ToolboxItem(false)]
    public partial class uc_SQLiteConfig : UserControl, IUCDBConfig
    {
        public uc_SQLiteConfig()
        {
            InitializeComponent();
        }

        private void txt_Path_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (OpenFileDialog v = new OpenFileDialog())
            {
                v.Filter = "SQLite(*.db2,*.db3)|*.db2;*.db3|所有文件(*.*)|*.*";
                v.DefaultExt = "*.db2;*.db3";
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

            DB_SQLite tmp = new DB_SQLite()
            {
                DataSource = txt_Path.Text,
                password = txt_Pwd.Text
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
