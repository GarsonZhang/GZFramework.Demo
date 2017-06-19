using GZFramework.DB.Lib;
using GZFramework.UI.Core;
using GZFramework.UI.Dev.Common;
using System;
using System.Data;

namespace GZFramework.UI.Dev.LibForm
{
    //业务数据窗体
    public partial class frmBaseDataBusiness : frmBaseData
    {
        protected IBLL _bll = null;
        public frmBaseDataBusiness()
        {
            InitializeComponent();
            this.Load += frmBaseDataBusiness_Load;

        }

        void _SummaryView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (CurrentDataState == FormDataState.Search)
                tp_Edit.PageEnabled = false;
        }

        protected override DevExpress.XtraGrid.Views.Base.ColumnView _SummaryView
        {
            get
            {
                return base._SummaryView;
            }
            set
            {
                base._SummaryView = value;
                _SummaryView.FocusedRowChanged += _SummaryView_FocusedRowChanged;
            }
        }

        void frmBaseDataBusiness_Load(object sender, EventArgs e)
        {

        }

        //查看
        protected override void DoView(object sender)
        {
            DataRow dr = _SummaryView.GetFocusedDataRow();
            if (dr == null)
            {
                Msg.Warning("没有选择数据！");
                return;
            }

            CurrentDataState = FormDataState.View;//设置状态
            string Key = ConvertEx.ToString(dr[_bll.SummaryModel.PrimaryKey]);
            //2015年10月21日11:55:26 当双击不同记录的时候再重新获取数据，避免重复读取数据库
            bool Repeat = EditData != null && Object.Equals(Key, EditData.Tables[_bll.SummaryModel.TableName].Rows[0][_bll.SummaryModel.PrimaryKey]);
            if (!Repeat)
            {
                EditData = GetEditData(Key);//获得需要绑定的数据
                DoBoundEditData();//绑定数据

            }
        }

        protected void DoViewDetail()
        {
            DataRow dr = _SummaryView.GetFocusedDataRow();
            string Key = ConvertEx.ToString(dr[_bll.SummaryModel.PrimaryKey]);
            EditData = GetEditData(Key);//获得需要绑定的数据
            DoBoundEditData();//绑定数据
        }

        //增加
        protected override void DoAdd(object sender)
        {
            CurrentDataState = FormDataState.Add;
            EditData = GetEditData("");//获得需要绑定的数据.
            EditData.Tables[_bll.SummaryModel.TableName].Rows.Add();
            DoBoundEditData();//绑定数据
        }
        //删除
        protected override void DoDelete(object sender)
        {
            DataRow dr = _SummaryView.GetFocusedDataRow();
            if (dr == null)
            {
                Msg.Warning("没有选择数据！");
                return;
            }

            if (Msg.AskQuestion("确定要删除选中记录吗？") == false) return;

            //CurrentDataState = FormDataState.View;删除不需要修改状态
            string Key = ConvertEx.ToString(dr[_bll.SummaryModel.PrimaryKey]);
            if (_bll.Delete(Key))
            {
                _SummaryView.DeleteSelectedRows();
                if (CurrentDataState == FormDataState.View)
                    DoView(null);
                else//2015年10月21日12:06:17，查看明细后跳转到查询页面，进行删除当前记录后光标定位到新纪录，然而明细页数据是旧数据切是可用状态，修改为明细页不可用，当有新的查看时，就会刷新明细页数据了
                    tp_Edit.PageEnabled = false;
                Msg.Warning("删除成功！");
            }
        }

        DataRow CurrentSummaryRow;
        //修改
        protected override void DoEdit(object sender)
        {
            CurrentSummaryRow = _SummaryView.GetFocusedDataRow();
            if (CurrentSummaryRow == null)
            {
                Msg.Warning("没有选择数据！");
                return;
            }
            CurrentDataState = FormDataState.Edit;
            string Key = ConvertEx.ToString(CurrentSummaryRow[_bll.SummaryModel.PrimaryKey]);
            EditData = GetEditData(Key);//获得需要绑定的数据
            DoBoundEditData();//绑定数据


        }

        public override void IniButton()
        {
            base.IniButton();
            //if (CurrentAuthorityExist(FunctionAuthorityCommon.APPROVAL))
            //    AddButton(BarButtonNameCommon.APPROVAL, "审核", "Approval_32x32.png", FunctionAuthorityCommon.APPROVAL, "审核").ItemClick += DoApproval;
        }

        //取消
        protected override void DoCancel(object sender)
        {
            CurrentDataState = FormDataState.View;
            if (_SummaryView.RowCount > 0)

                DoView(null);
            else
            {
                tc_Data.SelectedTabPage = tp_Search;
                tp_Edit.PageEnabled = false;
            }
        }
        /// <summary>
        /// 刷新缓存数据
        /// </summary>
        public virtual void RefreshDataCache()
        {

        }

        //保存
        protected override void DoSave(object sender)
        {
            //pan_Summary.Focus();
            //this.DoValidate();

            //if (ValidateBeforSave() == false)
            //    return;
            //WaiteServer.ShowWaite(this);
            //DataRow dataRow = EditData.Tables[_bll.SummaryModel.TableName].Rows[0];

            //dataRow.EndEdit();

            //if (_bll.Update(EditData))
            //{
            //    if (_SummaryView.GridControl.DataSource == null)
            //    {
            //        _SummaryView.GridControl.DataSource = _bll.GetTableStruct(_bll.SummaryModel.TableName);
            //    }

            //    if (CurrentDataState == FormDataState.Add)
            //    {
            //        _SummaryView.AddNewRow();
            //        CurrentSummaryRow = _SummaryView.GetFocusedDataRow();
            //    }
            //    CommonTools.CopyDatarowValue(EditData.Tables[_bll.SummaryModel.TableName].Rows[0], CurrentSummaryRow);
            //    _SummaryView.UpdateCurrentRow();

            //    CurrentDataState = FormDataState.View;

            //    WaiteServer.CloseWaite();
            //    Msg.ShowInformation("保存成功！");
            //    RefreshDataCache();//刷新缓存数据
            //}
            if (Save(_bll.Update) == true)
                Msg.ShowInformation("保存成功！");
        }

        protected bool Save(Func<DataSet, bool> Update)
        {
            //pan_Summary.Focus();
            this.DoValidate();

            if (ValidateBeforSave() == false)
                return false;
            WaiteServer.ShowWaite(this);
            DataRow dataRow = EditData.Tables[_bll.SummaryModel.TableName].Rows[0];

            dataRow.EndEdit();

            if (Update.Invoke(EditData))
            {
                if (_SummaryView.GridControl.DataSource == null)
                {
                    _SummaryView.GridControl.DataSource = _bll.GetTableStruct(_bll.SummaryModel.TableName);
                }

                if (CurrentDataState == FormDataState.Add)
                {
                    _SummaryView.AddNewRow();
                    CurrentSummaryRow = _SummaryView.GetFocusedDataRow();
                }
                if (CurrentSummaryRow != null)
                {
                    CommonTools.CopyDatarowValue(EditData.Tables[_bll.SummaryModel.TableName].Rows[0], CurrentSummaryRow);
                    _SummaryView.UpdateCurrentRow();
                }

                CurrentDataState = FormDataState.View;

                WaiteServer.CloseWaite();
                RefreshDataCache();//刷新缓存数据
                return true;
            }
            else
            {
                WaiteServer.CloseWaite();
                return false;
            }
        }

        protected override void SetControlAccessable(bool Edit)
        {
            LibraryTools.SetControlAccessable(tp_Edit, Edit);
            base.SetControlAccessable(Edit);
        }



        /// <summary>
        /// 编辑数据
        /// </summary>
        protected DataSet EditData;


        public virtual DataSet GetEditData(string KeyValue)
        {
            return _bll.DoGetDocData(KeyValue);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="KeyValue"></param>
        public virtual void DoBoundEditData()
        {
            LibraryTools.DoBindingEditorPanel(pan_Summary, EditData.Tables[_bll.SummaryModel.TableName], "txt");
        }
    }
}
