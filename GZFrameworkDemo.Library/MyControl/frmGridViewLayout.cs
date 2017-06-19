using DevExpress.Utils;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using GZFrameworkDemo.BusinessSQLite;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.MyClass;
using GZFrameworkDemo.Models;
using GZFramework.UI.Dev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.MyControl
{
    public partial class frmGridViewLayout : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        public static bool ShowForm(GridView gv)
        {
            frmGridViewLayout frm = new frmGridViewLayout(gv);
            return frm.ShowDialog() == DialogResult.OK;
        }
        bllGridViewLayout bll;
        private frmGridViewLayout(GridView gv)
        {
            InitializeComponent();
            bll = new bllGridViewLayout();
            _View = gv;
        }
        GridView _View;
        string _ViewCode;
        private void frmGridViewLayout_Load(object sender, EventArgs e)
        {
            _ViewCode = string.Format("{0}.{1}", _View.GridControl.FindForm().GetType().FullName, _View.Name);

            lue_LayoutName.Properties.DataSource = bll.GetViewLayoutItems(_ViewCode);
            DataBinderTools.Bound.BoundEnumData(lue_Alignment, typeof(HorzAlignment));
            DataBinderTools.Bound.BoundEnumData(lue_SummaryType, typeof(DevExpress.Data.SummaryItemType));

            lue_LayoutName.EditValueChanged += lue_LayoutName_EditValueChanged;



            lue_LayoutName.EditValue = bll.GetLayoutIDUser(_ViewCode);

            gridView1.PopupMenuShowing += gridView1_PopupMenuShowing;
            

            DataTable dt = new DataTable();
            dt.Columns.Add("Value", typeof(Int16));
            dt.Columns.Add("Text", typeof(String));
            dt.Rows.Add(1, "用户");
            dt.Rows.Add(2, "角色");
            
        }

        void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.Column != gcol_BackColor && e.HitInfo.Column != gcol_FontColor) return;

            DXMenuItem copyitem = new DXMenuItem("设置默认颜色", new EventHandler(DoSetDefaultColor), null);

            e.Menu.Items.Add(copyitem);
        }

        private void DoSetDefaultColor(object sender, EventArgs e)
        {
            gridView1.SetFocusedValue(Color.FromArgb(0));
        }



        DataSet dsData;
        void lue_LayoutName_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView dv = lue_LayoutName.Properties.GetDataSourceRowByKeyValue(lue_LayoutName.EditValue) as DataRowView;
            if (dv.Row.RowState == DataRowState.Added) return;

            string LayoutID = ConvertLib.ToString(lue_LayoutName.EditValue);
            if (String.IsNullOrEmpty(LayoutID)) return;
            dsData = bll.GetViewLayoutLayoutID(_ViewCode, LayoutID);

            BoundData(dsData, LayoutID);
        }


        Dictionary<string, DataSet> DataCatch = new Dictionary<string, DataSet>();

        private void btn_Add_Click(object sender, EventArgs e)
        {



            string LayoutID = Guid.NewGuid().ToString().Replace("-", "");
            DataSet ds = bll.GetLayoutDefault(_ViewCode);
            ds.AcceptChanges();
            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    dr.SetAdded();
                    dr[sys_GridViewLayout.LayoutID] = LayoutID;
                }
            }
            dsData = ds;
            dsData.Tables[sys_GridViewLayout._TableName].Rows[0][sys_GridViewLayout.LayoutName] = "新增布局";
            dsData.Tables[sys_GridViewLayout._TableName].Rows[0][sys_GridViewLayout.IsDefault] = "";
            //DataCatch.Add(LayoutID, ds);
            BoundData(dsData, LayoutID);

            layoutControl1.Enabled = false;
            btn_Add.Enabled = false;

            DataTable dtLayoutID = lue_LayoutName.Properties.DataSource as DataTable;
            dtLayoutID.Rows.Add(LayoutID, "新增布局！");

            lue_LayoutName.EditValue = LayoutID;
        }

        private void btn_Default_Click(object sender, EventArgs e)
        {
            dsData.RejectChanges();
        }


        private void BoundData(DataSet ds, string LayoutID)
        {
            DataTable dtDetail = ds.Tables[sys_GridViewLayoutDetail._TableName];

            DataRow row;
            foreach (GridColumn col in _View.Columns)
            {
                if (dtDetail.Select(String.Format("{0}='{1}'", sys_GridViewLayoutDetail.FileName, col.FieldName)).Length == 0)
                {
                    row = dtDetail.Rows.Add();

                    row[sys_GridViewLayoutDetail.LayoutID] = LayoutID;
                    row[sys_GridViewLayoutDetail.FileName] = col.FieldName;
                    row[sys_GridViewLayoutDetail.FileCaptionBK] = col.Caption;
                    row[sys_GridViewLayoutDetail.FileCaption] = col.Caption;
                    row[sys_GridViewLayoutDetail.IsShow] = col.Visible ? "Y" : "N";
                    row[sys_GridViewLayoutDetail.Width] = col.Width;
                    row[sys_GridViewLayoutDetail.FontColor] = col.AppearanceCell.ForeColor.ToArgb();
                    row[sys_GridViewLayoutDetail.BackColor] = col.AppearanceCell.BackColor.ToArgb();
                    row[sys_GridViewLayoutDetail.Alignment] = (int)col.AppearanceCell.TextOptions.HAlignment;
                    if (col.SummaryItem != null)
                    {
                        row[sys_GridViewLayoutDetail.SummaryType] = (int)col.SummaryItem.SummaryType;
                        row[sys_GridViewLayoutDetail.SummaryFormat] = col.SummaryItem.DisplayFormat;
                    }
                }
            }

            gridControl1.DataSource = ds.Tables[sys_GridViewLayoutDetail._TableName];
            dataBindingView1.DataSource = ds.Tables[sys_GridViewLayout._TableName];

            txt_HorzLineColor.Color = Color.FromArgb(ConvertLib.ToInt(ds.Tables[sys_GridViewLayout._TableName].Rows[0][sys_GridViewLayout.HorzLineColor]));
            txt_VertLineColor.Color = Color.FromArgb(ConvertLib.ToInt(ds.Tables[sys_GridViewLayout._TableName].Rows[0][sys_GridViewLayout.VertLineColor]));
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_LayoutName.Text))
            {
                txt_LayoutName.ErrorText = "布局名称不能为空！";
                return;
            }

            DataTable dt = dsData.Tables[sys_GridViewLayout._TableName];
            dt.Rows[0][sys_GridViewLayout.HorzLineColor] = txt_HorzLineColor.Color.ToArgb();
            dt.Rows[0][sys_GridViewLayout.VertLineColor] = txt_VertLineColor.Color.ToArgb();

            dsData.Tables[0].Rows[0].EndEdit();

            bool success = bll.Update(dsData);

            DataRowView dv = lue_LayoutName.Properties.GetDataSourceRowByKeyValue(lue_LayoutName.EditValue) as DataRowView;
            if (dv.Row.RowState == DataRowState.Added)
            {
                dv.Row[sys_GridViewLayout.LayoutName] = txt_LayoutName.EditValue;
                dv.Row.Table.AcceptChanges();
            }

            this.DialogResult = DialogResult.OK;
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Msg.AskQuestion("确定要删除吗？") == false) return;
            DataRowView dv = lue_LayoutName.Properties.GetDataSourceRowByKeyValue(lue_LayoutName.EditValue) as DataRowView;

            if (dv.Row.RowState != DataRowState.Added)
            {
                string LayoutID = ConvertLib.ToString(lue_LayoutName.EditValue);
                if (bll.Delete(LayoutID) == true)
                    Msg.ShowInformation("删除成功！");
            }

            dv.Row.Table.Rows.Remove(dv.Row);
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            string FileName = "";
            if (e.Column == gcol_BackColor) FileName = sys_GridViewLayoutDetail.BackColor;
            if (e.Column == gcol_FontColor) FileName = sys_GridViewLayoutDetail.FontColor;
            if (!String.IsNullOrEmpty(FileName))
            {
                if (e.IsSetData)
                {
                    var color = (Color)e.Value;
                    (e.Row as DataRowView)[FileName] = color.ToArgb();
                }
                if (e.IsGetData)
                {
                    var bVal = (e.Row as DataRowView)[FileName];
                    var color = Color.FromArgb(Convert.ToInt32(bVal));
                    e.Value = color;
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_DefaultColor_HorzLine_Click(object sender, EventArgs e)
        {
            txt_HorzLineColor.Color = Color.Empty;
        }

        private void btn_DefaultColor_VertLine_Click(object sender, EventArgs e)
        {
            txt_VertLineColor.Color = Color.Empty;
        }
        
    




    }
}
