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
    public partial class ucEx_AccessConfig : UserControl, IUCDBConfig
    {
        public ucEx_AccessConfig()
        {
            InitializeComponent();
        }

        private void btn_View_Click(object sender, EventArgs e)
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

            if (!String.IsNullOrEmpty(txt_UserID.Text))
            {
                if (String.IsNullOrEmpty(txt_Pwd.Text))
                {
                    SetError(txt_Pwd, "密码不能为空");
                    
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
