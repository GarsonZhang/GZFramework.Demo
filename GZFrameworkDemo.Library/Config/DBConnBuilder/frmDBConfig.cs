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
    public partial class frmDBConfig : Form
    {
        public static DialogResult ShowForm()
        {
            frmDBConfig frm = new frmDBConfig();
            frm.ShowIcon = frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;

            return frm.ShowDialog();

        }
        private frmDBConfig()
        {
            InitializeComponent();
        }

        private void frmDBConfig_Load(object sender, EventArgs e)
        {
            xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            DataTable dt = DbProviderFactories.GetFactoryClasses();
            txt_ProviderName.Properties.DataSource = dt;
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
                            xtraTabControl1.SelectedTabPage = tp_Error;
                        } break;
                    case "System.Data.SqlClient":
                        {
                            uc = uc_SQLConfig1;
                            xtraTabControl1.SelectedTabPage = tp_SQL;
                        }; break;
                    case "System.Data.SQLite":
                        {
                            uc = uc_SQLiteConfig1;
                            xtraTabControl1.SelectedTabPage = tp_SQLite;
                        }; break;
                    case "System.Data.OleDb":
                        {
                            uc = uc_AccessConfig1;
                            xtraTabControl1.SelectedTabPage = tp_Access;
                        }; break;
                    case "System.Data.OracleClient":
                    case "Oracle.ManagedDataAccess":
                        {
                            uc = uc_OracleConfig1;
                            xtraTabControl1.SelectedTabPage = tp_Oracle;
                        }; break;
                    default:
                        {
                            uc = null;
                            xtraTabControl1.SelectedTabPage = tp_Start;
                        } break;
                }
            }
        }
        private void txt_ProviderName_EditValueChanged(object sender, EventArgs e)
        {
            string str = ConvertLib.ToString(txt_ProviderName.EditValue);
            xtraTabControl1.Enabled = !String.IsNullOrEmpty(str);
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
                txt_DBCode.ErrorText = "数据库别名不能为空!";
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
