using GZFrameworkDemo.BusinessSQLite;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Models;
using GZFrameworkDemo.Models.DocSN;
using GZFrameworkDemo.Models.Sys;
using GZFramework.UI.Core;
using GZFramework.UI.Dev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Dictionary
{
    public partial class frmDocSNHeader : GZFramework.UI.Dev.LibForm.frmBaseFunction
    {
        bllDataSN bll;
        public frmDocSNHeader()
        {
            InitializeComponent();
            bll = new bllDataSN();
        }

        void LoadData()
        {
            SNDataHelper m = new SNDataHelper();
            m.GetSNCollonection();

            DataTable dt = bll.Search(null);
            foreach (var SN in m.SNModels)
            {
                if (SN.GetType().IsSubclassOf(typeof(ModelDocNo)) == false) continue;
                
                //if (SN.GetType().IsAssignableFrom(typeof(ModelDocNo)) == true) continue;
                if (dt.Select(String.Format("{0}='{1}'", sys_DataSN.DocCode, SN.DocCode)).Length == 0)
                {
                    
                    DataRow row = dt.Rows.Add();
                    row[sys_DataSN.DocCode] = SN.DocCode;
                    row[sys_DataSN.DocName] = SN.DocName;
                    row[sys_DataSN.DocHeader] = SN.DocHeader;
                    row[sys_DataSN.Separate] = SN.Separate;
                    row[sys_DataSN.DocType] = SN.DocRule;
                    row[sys_DataSN.Length] = SN.Length;
                    row[sys_DataSN.Demo] = GetSN(SN.DocHeader, SN.Separate, SN.DocRule, SN.Length);
                }
            }

            gc_Summary.DataSource = dt;
        }

        protected override int CustomerAuthority
        {
            get
            {
                return FunctionAuthorityCommon.SaveEx;
            }
        }

        protected override void DoSave(object sender)
        {
            DataTable dt = gc_Summary.DataSource as DataTable;
            bool success = bll.Update(dt);
            if (success)
            {
                dt.AcceptChanges();
                Msg.ShowInformation("保存成功！");
            }

        }



        public string GetSN(string DocHeader, string Separate, string DocType, int Length)
        {
            if (DocType == "Customer") return "";
            string header = DocHeader;
            if (!String.IsNullOrEmpty(header)) header += Separate;

            switch (DocType)
            {
                case "Up":
                    header += ""; break;
                case "Year":
                    header += (DateTime.Now.Year.ToString() + Separate); break;
                case "Year-Month":
                    header += (DateTime.Now.ToString("yyyyMM") + Separate); break;
                case "Year-Month-dd":
                    header += (DateTime.Now.ToString("yyyyMMdd") + Separate); break;
            }

            return header + "1".PadLeft(Length, '0');
        }

        private void frmDocSNHeader_Load(object sender, EventArgs e)
        {
            DataTable dtDocType = new DataTable();
            dtDocType.Columns.Add("value");
            dtDocType.Columns.Add("name");

            DataTable dtDocTypeCustomer = dtDocType.Clone();

            dtDocType.Rows.Add("Up", GenerateDocSNRule.Up.ToString());
            dtDocType.Rows.Add("Year", GenerateDocSNRule.Year.ToString());
            dtDocType.Rows.Add("Year-Month", GenerateDocSNRule.Year_Month.ToString());
            dtDocType.Rows.Add("Year-Month-dd", GenerateDocSNRule.Year_Month_Day.ToString());

            dtDocTypeCustomer.Rows.Add("Customer", GenerateDocSNRule.Custom.ToString());


            lue_DocType.DataSource = dtDocType;

            lue_DocTypeCustomer.DataSource = dtDocTypeCustomer;

            LoadData();
        }

        private void gv_Summary_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column == this.gcolumn_DocType)
            {
                DataRow dr = gv_Summary.GetDataRow(e.RowHandle);
                bool Customer = Object.Equals(dr[sys_DataSN.DocType], "Customer");
                if (Customer) e.RepositoryItem = lue_DocTypeCustomer;
                else e.RepositoryItem = lue_DocType;
            }
        }

        private void gc_Summary_Click(object sender, EventArgs e)
        {

        }

        private void gv_Summary_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == sys_DataSN.Demo)
                return;
            DataRow dr = gv_Summary.GetFocusedDataRow();
            string DocHeader = ConvertEx.ToString(dr[sys_DataSN.DocHeader]);
            string Separate = ConvertEx.ToString(dr[sys_DataSN.Separate]);
            string DocType = ConvertEx.ToString(dr[sys_DataSN.DocType]);
            int Length = ConvertEx.ToInt(dr[sys_DataSN.Length]);

            gv_Summary.SetFocusedRowCellValue(sys_DataSN.Demo, GetSN(DocHeader, Separate, DocType, Length));
        }
    }
}
