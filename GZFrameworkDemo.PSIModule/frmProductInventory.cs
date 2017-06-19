using ClothingPSISQLite.BusinessSQLite.Business;
using ClothingPSISQLite.Common;
using ClothingPSISQLite.Models.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingPSISQLite.PSIModule
{
    public partial class frmProductInventory : GZFramework.UI.Dev.LibForm.frmBaseFunction
    {
        //bllProductInventory bll;
        public frmProductInventory()
        {
            InitializeComponent();
          
        }

        //void LoadProductCategory()
        //{
        //    DataTable dt = Business.DataCache.Cache.dtCategory.Copy(); ;
        //    dt.Columns.Add("KeyFieldName", typeof(String));
        //    dt.Columns.Add("ParentFieldName", typeof(String));
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        dr["KeyFieldName"] = dr[tb_ProductCategory.CategoryID];
        //        dr["ParentFieldName"] = dr[tb_ProductCategory.ParentCategoryID];
        //    }
        //    if (dt.Rows.Count == 0)
        //        dt.Rows.Add();

        //    DataRow row = dt.NewRow();
        //    row["KeyFieldName"] = "";
        //    row["ParentFieldName"] = "";
        //    row[tb_ProductCategory.CategoryName] = "所有类别";
        //    dt.Rows.InsertAt(row, 0);
        //    dt.AcceptChanges();

        //    //treeProductCategory
        //    treeProductCategory.KeyFieldName = "KeyFieldName";
        //    treeProductCategory.ParentFieldName = "ParentFieldName";

        //    treeProductCategory.DataSource = dt;
        //    // treeProductCategory.BestFitColumns();
        //}

        //private void treeProductCategory_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        //{
        //    var v = ConvertLib.ToString(e.Node.GetValue(treeListColumn1));
        //    gc_Detail_tb_PODetail.DataSource = bll.SearchData(v);
        //    gv_Detail_tb_PODetail.ExpandAllGroups();
        //}

        //private void gv_Detail_tb_PODetail_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        //{
        //    if (e.Column.FieldName != tb_PODetail.ItemNo)
        //    {
        //        if (e.RowHandle1 >= 0 && e.RowHandle2 >= 0)
        //        {
        //            string ItemName1 = gv_Detail_tb_PODetail.GetDataRow(e.RowHandle1)[tb_PODetail.ItemNo] + "";
        //            string ItemName2 = gv_Detail_tb_PODetail.GetDataRow(e.RowHandle2)[tb_PODetail.ItemNo] + "";
        //            if (ItemName1 != ItemName2)
        //            {
        //                e.Merge = false;
        //                e.Handled = true;
        //            }
        //        }
        //    }
        //}

        //private void chk_AllowMerge_CheckedChanged(object sender, EventArgs e)
        //{
        //    gv_Detail_tb_PODetail.OptionsView.AllowCellMerge = chk_AllowMerge.Checked;
        //}

        //private void txt_Search_EditValueChanged(object sender, EventArgs e)
        //{
        //    gv_Detail_tb_PODetail.ApplyFindFilter(txt_Search.Text);
        //    gv_Detail_tb_PODetail.ExpandAllGroups();
        //}
    }
}
