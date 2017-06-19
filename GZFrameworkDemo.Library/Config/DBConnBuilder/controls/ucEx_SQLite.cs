using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder.controls
{
    public partial class ucEx_SQLite : UserControl, IUCDBConfig
    {
        public ucEx_SQLite()
        {
            InitializeComponent();
        }

        private void btn_View_Click(object sender, EventArgs e)
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
        void SetError(Control col, string errmsg)
        {
            this.errorProvider1.SetError(col, errmsg);
        }
        public IDB DoConfig()
        {
            IDB Config = null;

            if (String.IsNullOrEmpty(txt_Path.Text))
            {
                SetError(txt_Path, "文件路径不能为空");
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
