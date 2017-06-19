using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GZFramework.DB.Lib;
using GZFramework.UI.Dev.Common;
using GZFramework.UI.Dev.LibForm;
using ClothingPSISQLite.BusinessSQLite.Business;
using ClothingPSISQLite.Models.Business;
using GZFramework.UI.Core;
using ClothingPSISQLite.Library.MyForm;
using ClothingPSISQLite.Common;
using ClothingPSISQLite.Models;

namespace ClothingPSISQLite.PSIModule
{
    public partial class frmPO : frmBaseDataBusiness
    {
        bllPO bll;
        public frmPO()
        {
            InitializeComponent();
            this.Load += frm_Load;
            //实例化必须，bllBusinessBase必须替换为bll层自己继承的子类(指定正确的dal.DBCode)，建议封装重写到项目bll层

            _bll = bll = new bllPO();


            DataTable dt = new DataTable();
            dt.Columns.Add("value", typeof(System.Int32));
            dt.Columns.Add("text", typeof(System.String));



        }
        private void frm_Load(object sender, EventArgs e)
        {
            _SummaryView = gvMainData;//必须赋值
            //base.AddControlsOnAddKey(this.txtItemNo);
            Library.DataBinderTools.Bound.BoundCategory(lue_Category, false);
            Library.DataBinderTools.Bound.BoundEnumData(lueAppStatus, typeof(frmAppResult));
            Library.DataBinderTools.Bound.BoundSupplier(lue_Supplier, false, false);
            Library.DataBinderTools.Bound.BoundSupplier(txtSupplierID, false, false);
            base.AddControlsOnlyRead(this.txtDocNo, this.txtTotalQty, this.txtTotalPOAmount, this.txtAppStatus, this.txtAppUser, this.txtAppDate, this.txtCreateUser, this.txtCreateDate);
        }
        //查询
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();

            if (!String.IsNullOrEmpty(txts_DocNo.Text)) dic.Add("@DocNo", txts_DocNo.Text);


            DataTable dt = bll.Search(dic);

            gcMainData.DataSource = dt;
            if (gvMainData.RowCount < 100)//行数过多会很耗时
                gvMainData.BestFitColumns();
        }
        //清空条件
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            LibraryTools.DoClearPanel(LC_Search);
        }


        //保存前检查
        protected override bool ValidateBeforSave()
        {
            bool Validate = true;

            Validate = Validate & !gv_Detail_tb_PODetail.HasColumnErrors & gv_Detail_tb_PODetail.ValidateEditor();
            ;


            return Validate;
        }


        //public static void AddProduct(DataTable dt)
        //{
        //    frmPO frm = new PSIModule.frmPO();
        //}

        private void gv_Detail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            string TableName = (sender as DevExpress.XtraGrid.Views.Grid.GridView).GridControl.DataSource.ToString();
            //(sender as DevExpress.XtraGrid.Views.Grid.GridView).SetRowCellValue(e.RowHandle, _bll.DetailModel[TableName].ForeignKey, EditData.Tables[_bll.SummaryModel.TableName].Rows[0][_bll.SummaryModel.PrimaryKey]);            
            (sender as DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedDataRow()[_bll.DetailModel[TableName].ForeignKey] = EditData.Tables[_bll.SummaryModel.TableName].Rows[0][_bll.SummaryModel.PrimaryKey];

        }
        private void gc_Detail_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Remove)
            {
                e.Handled = Msg.AskQuestion("是否确定要删除选中行？") == false;
            }
        }

        private void gv_Detail_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (Object.Equals(view.FocusedColumn.Tag, "NotNull"))
            {
                if (Object.Equals(string.Empty, e.Value) || Object.Equals(null, e.Value) || Object.Equals(DBNull.Value, e.Value))
                {
                    e.Valid = false;
                    e.ErrorText = view.FocusedColumn.Caption + "不能为空！";
                }
            }
            if (view.FocusedColumn.FieldName == tb_PODetail.Qty || view.FocusedColumn.FieldName == tb_PODetail.POPrice)
            {
                decimal price = 0; int qty = 0;
                if (view.FocusedColumn.FieldName == tb_PODetail.Qty)
                {
                    price = ConvertLib.ToDecimal(view.GetFocusedDataRow()[tb_PODetail.POPrice], 0);
                    qty = ConvertLib.ToInt(e.Value, 0);
                }
                else
                {
                    price = ConvertLib.ToDecimal(e.Value, 0);
                    qty = ConvertLib.ToInt(view.GetFocusedDataRow()[tb_PODetail.Qty], 0);
                }



                decimal amount = price * qty;
                view.SetFocusedRowCellValue(tb_PODetail.TotalPOAmount, amount);
                RefreshSummary();
            }

        }

        private void gv_Detail_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            bool V = true;

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in view.Columns)
            {
                if (Object.Equals(column.Tag, "NotNull"))
                {
                    if (String.IsNullOrEmpty(view.GetFocusedRowCellDisplayText(column)))
                    {
                        view.SetColumnError(column, column.Caption + "不能为空!");
                        V = V & false;
                    }
                }
            }
            e.Valid = V;
        }

        private void gv_Detail_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            //去掉验证行失败时弹出的确认框
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }


        #region 其他常用
        //绑定明细页数据
        public override void DoBoundEditData()
        {
            //base.DoBoundEditData();
            LibraryTools.DoBindingEditorPanel(pan_Summary, EditData.Tables[_bll.SummaryModel.TableName], "txt");
            this.gc_Detail_tb_PODetail.DataSource = EditData.Tables[tb_PODetail._TableName];
            if (this.CurrentDataState == GZFramework.UI.Core.FormDataState.Add)
            {
                EditData.Tables[_bll.SummaryModel.TableName].Rows[0][tb_PO.DocDate] = DateTime.Now;
            }
            //其他绑定
            //LibraryTools.DoBindingEditorPanel(pan_Summary, EditData.Tables[_bll.SummaryModel.TableName], "txt");
            //txxtPassword.EditValue = EditData.Tables[_bll.SummaryTableName].Rows[0][dt_MyUser.Password];
            //gc_Detail.DataSource = EditData.Tables[dt_MyUserRole._TableName];    
        }

        //获得详细数据，明细也
        public override DataSet GetEditData(string KeyValue)
        {
            return base.GetEditData(KeyValue);
        }

        /// <summary>
        /// 设置窗体的基础权限从FunctionAuthorityCommon类中取，例如(默认)：
        /// return FunctionAuthorityCommon.VIEW//查看
        ///       + FunctionAuthorityCommon.ADD//新增
        ///       + FunctionAuthorityCommon.EDIT//修改
        ///       + FunctionAuthorityCommon.DELETE//删除
        ///       + FunctionAuthorityCommon.Save//保存
        ///       + FunctionAuthorityCommon.Cancel;//取消
        /// </summary>
        protected override int CustomerAuthority
        {
            get
            {
                return base.CustomerAuthority + FunctionAuthorityCommon.APPROVAL;
            }
        }

        //自定义窗体权限按钮
        public override void IniButton()
        {
            base.IniButton();
        }

        //窗体状态改变后
        protected override void DataStateChanged(GZFramework.UI.Core.FormDataState NewState)
        {
            base.DataStateChanged(NewState);
            base.SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Approval, !IsAddOrEdit);
        }
        //窗体状态改时
        protected override void DataStateChanging(GZFramework.UI.Core.FormDataState OldState, GZFramework.UI.Core.FormDataState NewState)
        {
            base.DataStateChanging(OldState, NewState);
        }



        /// <summary>
        /// 设置按钮可用状态，如果已经在ControlOnlyReads或SetControlAccessable中添加，这里不需要重新设置
        /// </summary>
        /// <param name="Edit"></param>
        protected override void SetControlAccessable(bool Edit)
        {
            //LibraryTools.SetControlAccessable(tp_Edit, Edit);
            base.SetControlAccessable(Edit);

        }
        #endregion

        #region 操作事件，不需要的可以删除
        /// <summary>
        /// 查询
        /// </summary>
        protected override void DoView(object sender)
        {
            base.DoView(sender);
        }

        /// <summary>
        /// 刷新
        /// </summary>
        protected override void DoRefresh(object sender)
        {
            base.DoRefresh(sender);
        }

        /// <summary>
        /// 新增
        /// </summary>
        protected override void DoAdd(object sender)
        {
            base.DoAdd(sender);
        }

        /// <summary>
        /// 删除
        /// </summary>
        protected override void DoDelete(object sender)
        {
            if (validateApprove() == true)
            {
                Msg.Warning("此单据状态不允许此操作，无法删除！");
                return;
            }
            base.DoDelete(sender);
        }

        bool validateApprove()
        {
            DataRow row = gvMainData.GetFocusedDataRow();
            bool app = ConvertLib.ToInt(row[tb_PO.AppStatus]) != 0;
            return app;
        }
        /// <summary>
        /// 修改
        /// </summary>
        protected override void DoEdit(object sender)
        {
            if (validateApprove() == true)
            {
                Msg.Warning("此单据状态不允许此操作，无法修改！");
                return;
            }
            base.DoEdit(sender);
        }

        /// <summary>
        /// 保存
        /// </summary>
        protected override void DoSave(object sender)
        {
            base.DoSave(sender);
        }

        /// <summary>
        /// 保存并关闭
        /// </summary>
        protected override void DoSaveAndClose(object sender)
        {
            base.DoSaveAndClose(sender);
        }

        /// <summary>
        /// 审核
        /// </summary>
        protected override void DoApproval(object sender)
        {
            DataRow row = gvMainData.GetFocusedDataRow();
            if (row == null) return;
            frmAppResult LoadResult = (frmAppResult)ConvertLib.ToInt(row["AppStatus"]);
            frmAppResult appstatus = frmApp.ShowForm(LoadResult);
            if (appstatus != frmAppResult.未审核)
            {
                string docno = row[tb_PO.DocNo] + "";
                bll.Approval(docno, (int)appstatus);
                row[tb_PO.AppUser] = Loginer.CurrentLoginer.Account;
                row[tb_PO.AppDate] = DateTime.Now;
                row[tb_PO.AppStatus] = (int)appstatus;

                if (this.CurrentDataState == FormDataState.View)
                {
                    EditData.Tables[tb_PO._TableName].Rows[0][tb_PO.AppUser] = Loginer.CurrentLoginer.Account;
                    EditData.Tables[tb_PO._TableName].Rows[0][tb_PO.AppDate] = DateTime.Now;
                    EditData.Tables[tb_PO._TableName].Rows[0][tb_PO.AppStatus] = (int)appstatus;
                }

                row.AcceptChanges();
            }
        }

        /// <summary>
        /// 返回取消
        /// </summary>
        protected override void DoCancel(object sender)
        {
            base.DoCancel(sender);
        }

        /// <summary>
        /// 打印预览
        /// </summary>
        protected override void DoPreview(object sender)
        {
            base.DoPreview(sender);
        }

        /// <summary>
        /// 导出数据
        /// </summary>
        protected override void DoExport(object sender)
        {
            base.DoExport(sender);
        }



        #endregion


        private void gridControlTools1_Customer_BeforeAdd(object sender, HandledEventArgs e)
        {
            Dialog.frmDialog_ProductAdd frm = new Dialog.frmDialog_ProductAdd();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (frm.Data == null) return;
                DataTable dt = EditData.Tables[tb_PODetail._TableName];
                foreach (DataRow dr in frm.Data.Rows)
                {
                    DataRow row = dt.NewRow();
                    row[tb_PODetail.ItemNo] = dr[tb_PODetail.ItemNo];
                    row[tb_PODetail.ItemName] = dr[tb_PODetail.ItemName];
                    row[tb_PODetail.CategoryID] = dr[tb_PODetail.CategoryID];
                    row[tb_PODetail.POPrice] = dr[tb_PODetail.POPrice];
                    row[tb_PODetail.SOPrice] = dr[tb_PODetail.SOPrice];
                    row[tb_PODetail.Color] = dr[tb_PODetail.Color];
                    row[tb_PODetail.Size] = dr[tb_PODetail.Size];
                    row[tb_PODetail.Qty] = dr[tb_PODetail.Qty];
                    row[tb_PODetail.BarCode] = Library.BarCodeHelper.GenerateBarCode(dr[tb_PODetail.ItemNo] + "", dr[tb_PODetail.Color] + "", dr[tb_PODetail.Size] + "");
                    row[tb_PODetail.TotalPOAmount] = dr[tb_PODetail.TotalPOAmount];
                    dt.Rows.Add(row);
                }
                RefreshSummary();
            }
            e.Handled = true;
        }

        void RefreshSummary()
        {
            DataTable detail = EditData.Tables[tb_PODetail._TableName];
            EditData.Tables[tb_PO._TableName].Rows[0][tb_PO.TotalQty] = detail.Compute("SUM(Qty)", "1=1");
            EditData.Tables[tb_PO._TableName].Rows[0][tb_PO.TotalPOAmount] = detail.Compute("SUM(TotalPOAmount)", "1=1");
        }

        private void gv_Detail_tb_PODetail_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (e.Column.FieldName == tb_PODetail.CategoryID || e.Column.FieldName == tb_PODetail.Color)
            {
                if (e.RowHandle1 >= 0 && e.RowHandle2 >= 0)
                {
                    string ItemName1 = gv_Detail_tb_PODetail.GetDataRow(e.RowHandle1)[tb_PODetail.ItemName] + "";
                    string ItemName2 = gv_Detail_tb_PODetail.GetDataRow(e.RowHandle2)[tb_PODetail.ItemName] + "";
                    if (ItemName1 != ItemName2)
                    {
                        e.Merge = false;
                        e.Handled = true;
                    }
                }
            }
        }

        //private void gridControlTools1_Customer_BeforeDelete(object sender, HandledEventArgs e)
        //{
        //    gv_Detail_tb_PODetail.DeleteSelectedRows();
        //}
    }
}
