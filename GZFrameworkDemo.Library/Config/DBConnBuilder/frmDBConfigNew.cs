using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.Config.DBConnBuilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    public partial class frmDBConfigNew : Form
    {
        public static DialogResult ShowForm()
        {
            frmDBConfigNew frm = new frmDBConfigNew();
            frm.ShowIcon = frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;

            return frm.ShowDialog();

        }
        private frmDBConfigNew()
        {
            InitializeComponent();
        }

        private void frmDBConfig_Load(object sender, EventArgs e)
        {
            if (GZFramework.UI.Dev.SplashScreenServer.Shown == true)
                GZFramework.UI.Dev.SplashScreenServer.CloseForm();

            this.tabControl1.Region = new Region(new RectangleF(this.tp_Sql.Left, this.tp_Sql.Top, this.tp_Sql.Width, this.tp_Sql.Height));

            DataTable dt = DbProviderFactories.GetFactoryClasses();

            txt_ProviderName.ValueMember = "InvariantName";
            txt_ProviderName.DisplayMember = "Name";
            txt_ProviderName.DataSource = dt;
        }
        private IUCDBConfig uc;
        private string _ProviderName;
        public string ProviderName
        {
            get { return _ProviderName; }
            set
            {
                _ProviderName = value;
                switch (_ProviderName)
                {
                    case "Error":
                        {
                            uc = null;
                            tabControl1.SelectedTab = tp_Error;
                        }
                        break;
                    case "System.Data.SqlClient":
                        {
                            uc = ucEx_SQLConfig1;
                            tabControl1.SelectedTab = tp_Sql;
                        }; break;
                    case "System.Data.SQLite":
                        {
                            uc = ucEx_SQLite1;
                            tabControl1.SelectedTab = tp_Sqlite;
                        }; break;
                    case "System.Data.OleDb":
                        {
                            uc = ucEx_AccessConfig1;
                            tabControl1.SelectedTab = tp_Access;
                        }; break;
                    case "System.Data.OracleClient":
                    case "Oracle.ManagedDataAccess":
                        {
                            uc = ucEx_OracleConfig1;
                            tabControl1.SelectedTab = tp_Oracle;
                        }; break;
                    default:
                        {
                            uc = null;
                            //xtraTabControl1.SelectedTabPage = tp_Start;
                        }
                        break;
                }
            }
        }
        private void txt_ProviderName_EditValueChanged(object sender, EventArgs e)
        {
            string str = ConvertLib.ToString(txt_ProviderName.SelectedValue);
            tabControl1.Enabled = !String.IsNullOrEmpty(str);
            str = String.IsNullOrEmpty(str) ? "Error" : str;
            ProviderName = str;
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (uc == null) return;
            if (String.IsNullOrEmpty(txt_DBCode.Text))
            {
                MessageBox.Show("数据库别名不能为空!");
                return;
            }
            var db = uc.DoConfig();
            if (db == null) return;

            //MessageBox.Show(db.GetConnectionStr());

            INIDBConfig i = new INIDBConfig();
            i.SetDBCode(txt_DBCode.Text);
            i.SetConnStr(db.GetConnectionStr());
            i.SetProviderName(db.ProviderName);


            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
