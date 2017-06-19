using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClothingPSISQLite.BusinessSQLite.Business;
using ClothingPSISQLite.Models.Business;
using ClothingPSISQLite.Common;

namespace ClothingPSISQLite.PSIModule.ucControls
{
    public partial class ucProductQty : UserControl
    {
        bllProductInventory bll;
        public ucProductQty()
        {
            InitializeComponent();
            this.gv_Detail_tb_PODetail.OptionsFind.FindFilterColumns = "BarCode;ItemNo;ItemName";
            if (Common.CheckDesingModel.IsDesingMode) return;
            bll = new bllProductInventory();
            treeProductCategory.FocusedNodeChanged += TreeProductCategory_FocusedNodeChanged;
            gv_Detail_tb_PODetail.CellMerge += Gv_Detail_tb_PODetail_CellMerge;
            LoadProductCategory();
            Library.DataBinderTools.Bound.BoundCategory(lue_Category, false);
        }

        public string FindText
        {
            get
            {
                return txt_Search.Text;
            }
            set
            {
                txt_Search.EditValue = value;
            }
        }

        private void Gv_Detail_tb_PODetail_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (e.Column.FieldName != tb_PODetail.ItemNo)
            {
                if (e.RowHandle1 >= 0 && e.RowHandle2 >= 0)
                {
                    string ItemName1 = gv_Detail_tb_PODetail.GetDataRow(e.RowHandle1)[tb_PODetail.ItemNo] + "";
                    string ItemName2 = gv_Detail_tb_PODetail.GetDataRow(e.RowHandle2)[tb_PODetail.ItemNo] + "";
                    if (ItemName1 != ItemName2)
                    {
                        e.Merge = false;
                        e.Handled = true;
                    }
                }
            }
        }

        private void TreeProductCategory_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var v = ConvertLib.ToString(e.Node.GetValue(treeListColumn1));
            gc_Detail_tb_PODetail.DataSource = bll.SearchData(v);
            gv_Detail_tb_PODetail.ExpandAllGroups();
        }

        public DataRow GetSelectDataRow()
        {
            return gv_Detail_tb_PODetail.GetFocusedDataRow();
        }


        void LoadProductCategory()
        {
            DataTable dt = BusinessSQLite.DataCache.Cache.dtCategory.Copy(); ;
            dt.Columns.Add("KeyFieldName", typeof(String));
            dt.Columns.Add("ParentFieldName", typeof(String));
            foreach (DataRow dr in dt.Rows)
            {
                dr["KeyFieldName"] = dr[tb_ProductCategory.CategoryID];
                dr["ParentFieldName"] = dr[tb_ProductCategory.ParentCategoryID];
            }
            if (dt.Rows.Count == 0)
                dt.Rows.Add();

            DataRow row = dt.NewRow();
            row["KeyFieldName"] = "";
            row["ParentFieldName"] = "";
            row[tb_ProductCategory.CategoryName] = "所有类别";
            dt.Rows.InsertAt(row, 0);
            dt.AcceptChanges();

            //treeProductCategory
            treeProductCategory.KeyFieldName = "KeyFieldName";
            treeProductCategory.ParentFieldName = "ParentFieldName";

            treeProductCategory.DataSource = dt;
            // treeProductCategory.BestFitColumns();
        }

        private void chk_AllowMerge_CheckedChanged(object sender, EventArgs e)
        {
            gv_Detail_tb_PODetail.OptionsView.AllowCellMerge = chk_AllowMerge.Checked;
        }

        private void txt_Search_EditValueChanged(object sender, EventArgs e)
        {
            gv_Detail_tb_PODetail.ApplyFindFilter(txt_Search.Text);
            gv_Detail_tb_PODetail.ExpandAllGroups();
        }
        public event OnRowSelectedHandle OnRowSelected;
        private void gv_Detail_tb_PODetail_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = GetSelectDataRow();
            if (row != null)
                OnRowSelected?.Invoke(row);
        }
    }
}
