
using GZFrameworkDemo.Business;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.Config.DBConnBuilder;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.SystemManagement
{
    public partial class frmDialog_DBEdit : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        bllDataBaseList bll;
        public static DataTable ShowForm()
        {
            frmDialog_DBEdit frm = new frmDialog_DBEdit();
            frm.ShowIcon = frm.ShowInTaskbar = false;
            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
                return frm.Data;
            else
                return null;

        }
        private frmDialog_DBEdit()
        {
            InitializeComponent();
            bll = new bllDataBaseList();
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
        DataTable Data;

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
            if (String.IsNullOrEmpty(txt_DBText.Text))
            {
                txt_DBText.ErrorText = "数据库名不能为空!";
                return;
            }

            //判断编号是否存在
            if (ConvertLib.ToString(txt_DBCode.EditValue) != "")
            {
                if (bll.DBCodeExists(txt_DBCode.EditValue.ToString()) == true)
                {
                    txt_DBCode.ErrorText = "数据库编号已经存在！";
                    return;
                }
            }


            var db = uc.DoConfig();
            if (db == null) return;

            INIDBConfig i = new INIDBConfig();
            string ProviderName = db.ProviderName;
            string ConStr = db.GetConnectionStr();
            //string ConnStr = Encrypt.DESEncrypt(db.GetConnectionStr(), Globals.KeyConnectionStr);

            var fac = System.Data.Common.DbProviderFactories.GetFactory(ProviderName);

            using (var conn = fac.CreateConnection())
            {
                conn.ConnectionString = ConStr;
                conn.Open();



                DataTable dt = bll.GetTableStruct(sys_DataBaseList._TableName);
                DataRow row = dt.Rows.Add();
                row[sys_DataBaseList.DBCode] = txt_DBCode.EditValue;
                row[sys_DataBaseList.DBDisplayText] = txt_DBText.EditValue;
                row[sys_DataBaseList.DBProviderName] = ProviderName;
                row[sys_DataBaseList.DBServer] = conn.DataSource;
                row[sys_DataBaseList.DBName] = conn.Database;
                row[sys_DataBaseList.DBConnection] = Encrypt.DESEncrypt(ConStr, Globals.KeyConnectionStr);
                bll.Update(dt);
                Data = dt;
                conn.Close();
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
