using GZFramework.UI.Dev.LibForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GZFrameworkDemo.Library;
using GZFrameworkDemo.Common;
using DevExpress.XtraEditors;
using GZFrameworkDemo.Models;
using GZFramework.UI.Dev.Common;
using GZFrameworkDemo.BusinessSQLite;
using GZFramework.UI.Core;
using GZFrameworkDemo.Library.Config.RibbonButtons;
using GZFrameworkDemo.BusinessSQLite.CustomerEnum;

namespace GZFrameworkDemo.Dictionary
{
    public partial class frmCommonDataDictNew : frmBaseFunction
    {
        public frmCommonDataDictNew()
        {
            InitializeComponent();
            gv_DataDetail.SetIndicatorRowNumVisible(true);
            gv_DataType.SetIndicatorRowNumVisible(true);
        }
        bllCommonDicData bll;

        DataTable DataSource;
        private void frmCommonDataDictNew_Load(object sender, EventArgs e)
        {
            bll = new bllCommonDicData();
            RefreshData();
            DataBinderTools.Bound.BoundUserName(lue_UserName);
            DataTable dt = Tools.EnumToDataTable(typeof(EnumCommonDicData), "Name", "Value");
            gc_DataType.DataSource = dt;

            gv_DataDetail.OptionsBehavior.Editable = _Edit;
            base.SetButtonEnabled(ButtonNames.btnSave, _Edit);
            base.SetButtonEnabled(ButtonNames.btnCancel, _Edit);
            base.SetButtonEnabled(ButtonNames.btnEdit, !_Edit);
            gc_DataDetail.EmbeddedNavigator.Buttons.Prev.Enabled =
                  gc_DataDetail.EmbeddedNavigator.Buttons.Next.Enabled =
                  gc_DataDetail.EmbeddedNavigator.Buttons.First.Enabled =
                      gc_DataDetail.EmbeddedNavigator.Buttons.Last.Enabled = Edit;

        }

        protected override int CustomerAuthority
        {
            get
            {
                return FunctionAuthorityCommon.EDIT;
            }
        }

        bool _Edit = false;
        public bool Edit
        {
            get
            {
                return _Edit;
            }
            set
            {
                _Edit = value;
                gv_DataDetail.OptionsBehavior.Editable = _Edit;
                base.SetButtonEnabled(ButtonNames.btnSave, _Edit);
                base.SetButtonEnabled(ButtonNames.btnCancel, _Edit);
                base.SetButtonEnabled(ButtonNames.btnEdit, !_Edit);
                gc_DataDetail.EmbeddedNavigator.Buttons.Prev.Enabled =
                    gc_DataDetail.EmbeddedNavigator.Buttons.Next.Enabled =
                    gc_DataDetail.EmbeddedNavigator.Buttons.First.Enabled =
                        gc_DataDetail.EmbeddedNavigator.Buttons.Last.Enabled = Edit;
            }
        }

        protected override void DoEdit(object sender)
        {
            RefreshData();
            Edit = true;
        }
        protected override void DoCancel(object sender)
        {
            if (DataSource.GetChanges() != null)
            {
                if (Msg.AskQuestion("修改尚未保存！确定要舍弃所做的更改吗？") == false)
                {
                    return;
                }
            }
            Edit = false;
            DataSource.RejectChanges();
        }

        protected override void DoSave(object sender)
        {
            if (DataSource.GetChanges() != null)
            {
                bll.Update(DataSource);
                RefreshData();
                Edit = false;
            }
            else
            {
                Msg.Warning("没有更改的记录！");
            }
        }

        void RefreshData()
        {
            DataSource = bll.GetAllDetail();
            gc_DataDetail.DataSource = DataSource;
            FitterDateData();
        }

        private void gc_DataDetail_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            int handle = gv_DataDetail.FocusedRowHandle;
            if (e.Button.ButtonType == NavigatorButtonType.First)
            {
                DataTableMoveTools.DataRowMoveFirst(gv_DataDetail.GetFocusedDataRow());
                gv_DataDetail.MoveFirst();
                UpdateIndex();
                e.Handled = true;
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Last)
            {

                DataTableMoveTools.DataRowMoveLast(gv_DataDetail.GetFocusedDataRow());
                gv_DataDetail.MoveLast();
                UpdateIndex();
                e.Handled = true;
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Prev)
            {

                DataTableMoveTools.DataRowMovePrev(gv_DataDetail.GetFocusedDataRow());
                gv_DataDetail.FocusedRowHandle = handle - 1;
                UpdateIndex();
                e.Handled = true;
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Next)
            {

                DataTableMoveTools.DataRowMoveNext(gv_DataDetail.GetFocusedDataRow());
                gv_DataDetail.FocusedRowHandle = handle + 1;
                UpdateIndex();
                e.Handled = true;
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                DataTable dt = gc_DataDetail.DataSource as DataTable;
                DataRow dr = dt.Rows.Add();
                dr[dt_CommonDicData.DataType] = gv_DataType.GetFocusedRowCellValue("Name");
                UpdateIndex();
                e.Handled = true;
            }
            else if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Msg.AskQuestion("确定要删除选中的记录吗？") == false)
                    e.Handled = true;
            }

        }

        void UpdateIndex()
        {
            for (int i = 0; i < gv_DataDetail.RowCount; i++)
            {
                gv_DataDetail.GetDataRow(i)[dt_CommonDicData.SortIndex] = i + 1;
            }
        }

        private void gv_DataType_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            FitterDateData();
        }

        void FitterDateData()
        {
            DataRow dr = gv_DataType.GetFocusedDataRow();
            if (dr == null)
            {
                DataSource.DefaultView.RowFilter = "1=2";
                return;
            }
            DataSource.DefaultView.RowFilter = String.Format("{0}='{1}'", dt_CommonDicData.DataType, dr["Name"]);
            gv_DataDetail.RefreshData();
        }
    }
}
