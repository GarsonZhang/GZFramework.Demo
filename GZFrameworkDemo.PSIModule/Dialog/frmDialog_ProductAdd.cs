using ClothingPSISQLite.BusinessSQLite;
using ClothingPSISQLite.Common;
using ClothingPSISQLite.Library;
using ClothingPSISQLite.Models.Business;
using GZFramework.UI.Dev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingPSISQLite.PSIModule.Dialog
{
    public partial class frmDialog_ProductAdd : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        DataTable dtQty;
        DataTable dtSize;
        public frmDialog_ProductAdd()
        {
            InitializeComponent();
            DataBinderTools.Bound.BoundCategory(txtCategory, true);
            dtSize = DataCache.Cache.GetCommonDictData(BusinessSQLite.CustomerEnum.EnumCommonDicData.尺码);
            dtQty = new DataTable();
            gridView1.Columns.Clear();
            dtQty.Columns.Add("Color", typeof(System.String));
            AddColumn("颜色", "Color");
            for (int i = 0; i < dtSize.Rows.Count; i++)
            {
                string fileName = "Qty_" + (i + 1);
                dtQty.Columns.Add(fileName);
                AddColumn(dtSize.Rows[i]["DataName"] + "", fileName);
            }
            gridControl1.DataSource = dtQty;
        }

        void AddColumn(string Caption, string FieldName)
        {
            var col = gridView1.Columns.Add();
            col.Caption = Caption;
            col.VisibleIndex = gridView1.Columns.Count;
            col.FieldName = FieldName;
        }
        public DataTable Data;

        private void btn_OK_Click(object sender, EventArgs e)
        {

            bool b = LibraryTools.IsNotEmpBaseEdit(txtItemNo, "货号不能为空！");
            if (b == false) return;
            Data = new DataTable();
            Data.Columns.Add(nameof(tb_PODetail.ItemNo), typeof(System.String));
            Data.Columns.Add(nameof(tb_PODetail.ItemName), typeof(System.String));
            Data.Columns.Add(nameof(tb_PODetail.CategoryID), typeof(System.String));
            Data.Columns.Add(nameof(tb_PODetail.POPrice), typeof(System.Decimal));
            Data.Columns.Add(nameof(tb_PODetail.SOPrice), typeof(System.Decimal));
            Data.Columns.Add(nameof(tb_PODetail.Color), typeof(System.String));
            Data.Columns.Add(nameof(tb_PODetail.Size), typeof(System.String));
            Data.Columns.Add(nameof(tb_PODetail.Qty), typeof(System.Int16));
            Data.Columns.Add(nameof(tb_PODetail.TotalPOAmount), typeof(System.Decimal));
            foreach (DataRow row in dtQty.Rows)
            {
                string color = ConvertLib.ToString(row["Color"]);
                for (int i = 0; i < dtSize.Rows.Count; i++)
                {
                    string fileName = "Qty_" + (i + 1);
                    int qty = ConvertLib.ToInt(row[fileName]);
                    if (qty > 0)
                    {
                        DataRow dr = Data.NewRow();


                        dr[tb_PODetail.ItemNo] = txtItemNo.EditValue;
                        if (!String.IsNullOrEmpty(ConvertLib.ToString(txtItemName.EditValue)))
                            dr[tb_PODetail.ItemName] = txtItemName.EditValue;
                        dr[tb_PODetail.CategoryID] = txtCategory.EditValue;
                        if (!String.IsNullOrEmpty(ConvertLib.ToString(txtPOPrice.EditValue)))
                            dr[tb_PODetail.POPrice] = txtPOPrice.EditValue;
                        if (!String.IsNullOrEmpty(ConvertLib.ToString(txtSOPrice.EditValue)))
                            dr[tb_PODetail.SOPrice] = txtSOPrice.EditValue;
                        dr[tb_PODetail.Color] = color;
                        dr[tb_PODetail.Size] = dtSize.Rows[i]["DataName"];
                        dr[tb_PODetail.Qty] = qty;
                        dr[tb_PODetail.TotalPOAmount] = ConvertLib.ToDecimal(txtPOPrice.EditValue, 0) * qty;
                        Data.Rows.Add(dr);
                    }
                }
            }
            Data.AcceptChanges();
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtItemNo_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "选")
            {
                DataRow row = frmDialogProductList.ShowForm();
                if (row != null)
                {
                    txtItemNo.EditValue = row[tb_PODetail.ItemNo];
                    txtItemName.EditValue = row[tb_PODetail.ItemName];
                    txtCategory.EditValue = row[tb_PODetail.CategoryID];
                    txtSOPrice.EditValue = row[tb_PODetail.SOPrice];
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
