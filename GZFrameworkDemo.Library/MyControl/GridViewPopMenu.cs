using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using GZFrameworkDemo.Business;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.MyClass;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.MyControl
{
    [ToolboxItem(true)]
    public partial class GridViewPopMenu : Component
    {
        public GridViewPopMenu()
        {
            InitializeComponent();
        }

        public GridViewPopMenu(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private GridView _view;

        public GridView View
        {
            get
            {
                return _view;
            }
            set
            {
                _view = value;
                this.SetViewPopMenu(_view);
            }
        }
        public void SetViewPopMenu(GridView gv)
        {
            if (CheckDesingModel.IsDesingMode) return;

            var AutoWidth = new GridViewAddPopupMenuBase(gv, "自动调整列宽", LoadUIImage.LoadImage("View_16x16.png"));
            AutoWidth.DoEvent += AutoWidth_DoEvent;
            new ViewLayout(gv);

        }


        void AutoWidth_DoEvent(object sender, EventArgs e)
        {
            View.BestFitColumns();
        }

    }

    public class ViewLayout
    {
        GridView View;
        string ViewCode;

        bllGridViewLayout bll;
        public ViewLayout(GridView gv)
        {
            View = gv;
            Form frm = gv.GridControl.FindForm();
            ViewCode = string.Format("{0}.{1}", frm.GetType().FullName, gv.Name);
            bll = new bllGridViewLayout();
            frm.Load += frm_Load;

            var Layout = new GridViewAddPopupMenuBase(gv, "布局管理", LoadUIImage.LoadImage("LayoutOptions_16x16.png"));
            var LayoutRefresh = new GridViewAddPopupMenuBase(gv, "刷新布局", LoadUIImage.LoadImage("Refresh_16x16.png"));
            Layout.DoEvent += Layout_DoEvent;
            LayoutRefresh.DoEvent += LayoutRefresh_DoEvent;
        }

        void LayoutRefresh_DoEvent(object sender, EventArgs e)
        {
            RefreshLayout();
        }
        void Layout_DoEvent(object sender, EventArgs e)
        {
            bool Reload = frmGridViewLayout.ShowForm(View);
            //if (Reload == true)
            //{
            //    DataSet ds = bll.GetViewLayoutUser(ViewCode);
            //    LayoutHelper.LoadData(View, ds);
            //}
        }
        void frm_Load(object sender, EventArgs e)
        {
            RefreshLayout();
        }

        private void RefreshLayout()
        {
            DataSet ds = bll.GetViewLayoutUser(ViewCode);
            if (ds.Tables[0].Rows.Count == 0)
            {
                LayoutHelper.GenerateData(View, ds, ViewCode);

                bll.Update(ds);
            }
            else
            {
                LayoutHelper.LoadData(View, ds);
            }
        }
    }

    public class LayoutHelper
    {


        public static void GenerateData(GridView gv, DataSet ds, string ViewCode)
        {
            string LayoutID = GenerateSummaryData(gv, ds.Tables[sys_GridViewLayout._TableName], ViewCode);
            GenerateDetailData(gv, ds.Tables[sys_GridViewLayoutDetail._TableName], LayoutID);
        }

        private static string GenerateSummaryData(GridView gv, DataTable dt, string ViewCode)
        {
            DataRow row = dt.Rows.Add();
            string LayoutID = Guid.NewGuid().ToString().Replace("-", "");
            row[sys_GridViewLayout.LayoutID] = LayoutID;
            row[sys_GridViewLayout.ViewCode] = ViewCode;
            row[sys_GridViewLayout.LayoutName] = "默认布局";
            row[sys_GridViewLayout.IsDefault] = "Y";

            if (gv.OptionsView.EnableAppearanceEvenRow && gv.OptionsView.EnableAppearanceOddRow)
                row[sys_GridViewLayout.IntervalColor] = "Y";//交替行颜色

            row[sys_GridViewLayout.HeadHeight] = gv.ColumnPanelRowHeight;//表头高

            row[sys_GridViewLayout.RowHeight] = gv.RowHeight;//行高

            if (gv.OptionsView.ShowHorizontalLines != DefaultBoolean.False)
                row[sys_GridViewLayout.HorzLine] = "Y";//显示横线

            if (gv.OptionsView.ShowVerticalLines != DefaultBoolean.False)
                row[sys_GridViewLayout.VertLine] = "Y";//显示竖线

            row[sys_GridViewLayout.HorzLineColor] = gv.Appearance.HorzLine.BackColor.ToArgb();//横线颜色

            row[sys_GridViewLayout.VertLineColor] = gv.Appearance.VertLine.BackColor.ToArgb();//竖线颜色

            return LayoutID;
        }

        private static void GenerateDetailData(GridView gv, DataTable dt, string LayoutID)
        {
            DataRow row;
            foreach (GridColumn col in gv.Columns)
            {
                row = dt.Rows.Add();

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

        public static void LoadData(GridView gv, DataSet ds)
        {
            LoadSummaryData(gv, ds.Tables[sys_GridViewLayout._TableName]);
            LoadDetailData(gv, ds.Tables[sys_GridViewLayoutDetail._TableName]);
        }
        private static void LoadSummaryData(GridView gv, DataTable dt)
        {
            DataRow row = dt.Rows[0];
            //交替行颜色
            gv.OptionsView.EnableAppearanceEvenRow = gv.OptionsView.EnableAppearanceOddRow = Object.Equals(row[sys_GridViewLayout.IntervalColor], "Y");
            //标题高
            gv.ColumnPanelRowHeight = ConvertLib.ToInt(row[sys_GridViewLayout.HeadHeight], -1);
            //行高
            gv.RowHeight = ConvertLib.ToInt(row[sys_GridViewLayout.RowHeight], -1);
            //显示横线
            gv.OptionsView.ShowHorizontalLines = Object.Equals(row[sys_GridViewLayout.HorzLine], "Y") ? DefaultBoolean.True : DefaultBoolean.False;
            //显示竖线
            gv.OptionsView.ShowVerticalLines = Object.Equals(row[sys_GridViewLayout.VertLine], "Y") ? DefaultBoolean.True : DefaultBoolean.False;

            //横线颜色
            if (ConvertLib.ToInt(row[sys_GridViewLayout.HorzLineColor]) != 0)
                gv.Appearance.HorzLine.BackColor = Color.FromArgb(ConvertLib.ToInt(row[sys_GridViewLayout.HorzLineColor]));
            //竖线颜色
            if (ConvertLib.ToInt(row[sys_GridViewLayout.VertLineColor]) != 0)
                gv.Appearance.VertLine.BackColor = Color.FromArgb(ConvertLib.ToInt(row[sys_GridViewLayout.VertLineColor]));

        }

        private static void LoadDetailData(GridView gv, DataTable dt)
        {
            bool ShowFoot = false;
            List<GridColumn> lst = new List<GridColumn>();
            foreach (GridColumn col in gv.Columns)
            {
                var drs = dt.Select(String.Format("{0}='{1}'", sys_GridViewLayoutDetail.FileName, col.FieldName));
                if (drs.Length > 0)
                {
                    DataRow row = drs[0];
                    col.Caption = ConvertLib.ToString(row[sys_GridViewLayoutDetail.FileCaption]);
                    col.Visible = Object.Equals(row[sys_GridViewLayoutDetail.IsShow], "Y");
                    if (col.Visible == false) lst.Add(col);
                    col.Width = ConvertLib.ToInt(row[sys_GridViewLayoutDetail.Width], 75);
                    col.AppearanceCell.ForeColor = Color.FromArgb(ConvertLib.ToInt(row[sys_GridViewLayoutDetail.FontColor]));
                    col.AppearanceCell.BackColor = Color.FromArgb(ConvertLib.ToInt(row[sys_GridViewLayoutDetail.BackColor]));

                    int alignmeng = ConvertLib.ToInt(row[sys_GridViewLayoutDetail.Alignment]);
                    col.AppearanceCell.TextOptions.HAlignment = (HorzAlignment)alignmeng;

                    if (ConvertLib.ToInt(row[sys_GridViewLayoutDetail.SummaryType], 6) != 6)
                    {
                        ShowFoot = true;
                        col.Summary.Clear();
                        var item = col.Summary.Add();
                        item.FieldName = col.FieldName;
                        item.SummaryType = (SummaryItemType)ConvertLib.ToInt(row[sys_GridViewLayoutDetail.SummaryType]);
                        item.DisplayFormat = ConvertLib.ToString(row[sys_GridViewLayoutDetail.SummaryFormat]);
                    }
                }

            }
            foreach (GridColumn col in lst)
            {
                gv.Columns.Remove(col);
            }
            gv.OptionsView.ShowFooter = ShowFoot;
        }

    }


}
