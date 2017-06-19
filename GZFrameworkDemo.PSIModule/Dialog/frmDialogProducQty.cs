using ClothingPSISQLite.BusinessSQLite.Business;
using ClothingPSISQLite.Common;
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
    public partial class frmDialogProducQty : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        bllProductInventory bll;

        public static DataRow ShowForm(string code, DataTable dtDataSorce)
        {
            frmDialogProducQty frm = new frmDialogProducQty(dtDataSorce);
            frm.FindText = code;

            if (frm.ShowDialog() == DialogResult.OK)
                return frm.Data;
            else
                return null;
        }
        public static DataRow ShowForm(string code)
        {
            frmDialogProducQty frm = new frmDialogProducQty(null);
            frm.FindText = code;

            if (frm.ShowDialog() == DialogResult.OK)
                return frm.Data;
            else
                return null;
        }


        public frmDialogProducQty(DataTable dtsource)
        {
            InitializeComponent();
            this.gv_Detail_tb_PODetail.OptionsFind.FindFilterColumns = "BarCode;ItemNo;ItemName";
            bll = new bllProductInventory();
            gv_Detail_tb_PODetail.CellMerge += Gv_Detail_tb_PODetail_CellMerge;
            LoadProductCategory();
            Library.DataBinderTools.Bound.BoundCategory(lue_Category, false);
            this.chk_AllowMerge.CheckedChanged += Chk_AllowMerge_CheckedChanged;
            txt_Search.EditValueChanged += Txt_Search_EditValueChanged;
            this.gv_Detail_tb_PODetail.DoubleClick += Gv_Detail_tb_PODetail_DoubleClick;
            this.Load += FrmDialogProducQty_Load;
            if (dtsource == null)
            {
                refreshDataSource();
            }
            else
            {
                gc_Detail_tb_PODetail.DataSource = dtsource;
                gv_Detail_tb_PODetail.ExpandAllGroups();
            }
        }

        private void FrmDialogProducQty_Load(object sender, EventArgs e)
        {
            treeProductCategory.FocusedNodeChanged += TreeProductCategory_FocusedNodeChanged;
        }

        private void Gv_Detail_tb_PODetail_DoubleClick(object sender, EventArgs e)
        {
            Return();
        }

        private void Txt_Search_EditValueChanged(object sender, EventArgs e)
        {
            gv_Detail_tb_PODetail.ApplyFindFilter(txt_Search.Text);
            gv_Detail_tb_PODetail.ExpandAllGroups();
        }

        private void Chk_AllowMerge_CheckedChanged(object sender, EventArgs e)
        {
            gv_Detail_tb_PODetail.OptionsView.AllowCellMerge = chk_AllowMerge.Checked;
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

        private void TreeProductCategory_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            //var v = ConvertLib.ToString(e.Node.GetValue(treeListColumn1));
            //gc_Detail_tb_PODetail.DataSource = bll.SearchData(v);
            //gv_Detail_tb_PODetail.ExpandAllGroups();
            refreshDataSource();
        }

        void refreshDataSource()
        {

            var v = ConvertLib.ToString(treeProductCategory.FocusedNode.GetValue(treeListColumn1));
            gc_Detail_tb_PODetail.DataSource = bll.SearchData(v);
            gv_Detail_tb_PODetail.ExpandAllGroups();
        }
        private void UcProductQty1_OnRowSelected(DataRow row)
        {
            Return();
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

        DataRow Data = null;
        private void btn_OK_Click(object sender, EventArgs e)
        {
            Return();
        }
        void Return()
        {
            Data = gv_Detail_tb_PODetail.GetFocusedDataRow();
            if (Data == null)
            {
                Msg.Warning("没有选择任何数据");
                return;
            }
            this.DialogResult = DialogResult.OK;
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Data = null;
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
