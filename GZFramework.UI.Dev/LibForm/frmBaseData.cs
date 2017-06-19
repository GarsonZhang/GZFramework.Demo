using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using GZFramework.UI.Core;
using GZFramework.UI.Dev.Common;

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.LibForm
{
    //数据窗体基类，权限+XtraTabControl+窗体状态(新增，修改，查看)
    public partial class frmBaseData : frmBaseFunction
    {
        FormDataState _currentdatastate;
        EditModel FormModel;
        List<Control> ControlKeys = new List<Control>();
        List<Control> ControlOnlyReads = new List<Control>();

        /// <summary>
        /// 添加只读，任何情况下对不允许编辑
        /// </summary>
        /// <param name="Cols"></param>
        protected void AddControlsOnlyRead(params Control[] Cols)
        {
            foreach (Control col in Cols)
            {
                if (!ControlOnlyReads.Contains(col))
                    ControlOnlyReads.Add(col);
            }
        }

        /// <summary>
        /// 添加主键，只有新增状态下可以修改，
        /// </summary>
        /// <param name="Cols"></param>
        protected void AddControlsOnAddKey(params Control[] Cols)
        {
            foreach (Control col in Cols)
            {
                if (!ControlKeys.Contains(col))
                    ControlKeys.Add(col);
            }
        }

        public frmBaseData()
        {

            InitializeComponent();
            if (CheckDesingModel.IsDesingMode) return;
            tc_Data.SelectedPageChanged += tc_Data_SelectedPageChanged;

            this.Load += frmBaseData_Load;
        }

        void frmBaseData_Load(object sender, EventArgs e)
        {
            if (CheckDesingModel.IsDesingMode) return;
            DataStateChanged(FormDataState.None);//初始化窗体，保存，取消按钮不可用




        }

        public override void IniButton()
        {
            //GZFramework.UI.Dev.RibbonButton
            AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnView, 0, DoView);
            base.IniButton();
            AddNavButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMoveFirst).ItemClick += DoNav;
            AddNavButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMoveLast).ItemClick += DoNav;
            AddNavButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMovePrevious).ItemClick += DoNav;
            AddNavButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMoveNext).ItemClick += DoNav;
        }




        private void DoNav(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (e.Item.Name == GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMoveFirst.name)
                _SummaryView.MoveFirst();
            else if (e.Item.Name == GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMoveLast.name)
                _SummaryView.MoveLast();
            else if (e.Item.Name == GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMovePrevious.name)
                _SummaryView.MovePrev();
            else if (e.Item.Name == GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMoveNext.name)
                _SummaryView.MoveNext();

            if (CurrentDataState == FormDataState.View)
            {
                DoView(null);
            }
        }



        void UpdateNavButton()
        {
            if (_SummaryView == null) return;

            if (IsAddOrEdit == true)
            {
                setNavEnable(false, false, false, false);
                return;
            }
            if (_SummaryView.RowCount < 2)
            {
                setNavEnable(false, false, false, false);
                return;
            }
            if (_SummaryView.FocusedRowHandle == _SummaryView.RowCount - 1)
            {
                setNavEnable(true, false, true, false);
                return;
            }
            if (_SummaryView.FocusedRowHandle == 0)
            {
                setNavEnable(false, true, false, true);
                return;
            }
            setNavEnable(true, true, true, true);
        }

        void setNavEnable(bool EnableMoveFirst, bool EnableMoveLast, bool EnableMovePrevious, bool EnableMoveNext)
        {
            base.SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMoveFirst.name, EnableMoveFirst);
            base.SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMoveLast.name, EnableMoveLast);
            base.SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMovePrevious.name, EnableMovePrevious);
            base.SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.NavButtons.btnMoveNext.name, EnableMoveNext);
        }

        void View_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            UpdateNavButton();
        }

        void View_RowCountChanged(object sender, EventArgs e)
        {
            UpdateNavButton();
        }


        //当选择页面为数据查询时，改变窗体状态为查询状态
        void tc_Data_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (tc_Data.SelectedTabPage == tp_Search)
                CurrentDataState = FormDataState.Search;
        }

        #region _SummaryView

        ColumnView _summaryview;
        protected virtual ColumnView _SummaryView
        {
            get
            {
                return _summaryview;
            }
            set
            {
                value.DoubleClick += View_DoubleClick;
                value.OptionsBehavior.Editable = false;
                value.RowCountChanged += View_RowCountChanged;
                value.FocusedRowChanged += View_FocusedRowChanged;
                if (value is GridView)
                {
                    SetViewIndicatorRowNum(value as GridView);
                    SetViewEmpDataText(value as GridView);
                }
                _summaryview = value;
                UpdateNavButton();
            }
        }


        /// <summary>
        /// 空数据提醒
        /// </summary>
        /// <param name="gv"></param>
        private void SetViewEmpDataText(GridView gv)
        {
            gv.CustomDrawEmptyForeground += new CustomDrawEventHandler(gv_CustomDrawEmptyForeground);
        }


        //空数据提醒
        private void gv_CustomDrawEmptyForeground(object sender, CustomDrawEventArgs e)
        {
            GridView gv = sender as GridView;
            DataView bindingSource = gv.DataSource as DataView;
            if (bindingSource != null && bindingSource.Count == 0)
            {
                Font f = new Font("宋体", 10, FontStyle.Bold);

                Rectangle r = new Rectangle(gv.GridControl.Width / 2 - 100, gv.GridControl.Height / 2, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString("数据为空!", f, Brushes.Red, r);
            }
        }


        /// <summary>
        /// Indicator显示行号
        /// </summary>
        /// <param name="gv"></param>
        private void SetViewIndicatorRowNum(GridView gv)
        {

            gv.IndicatorWidth = 35;
            gv.CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(gv_CustomDrawRowIndicator);
        }
        //Indicator显示行号
        private void gv_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
        }

        //双击查看
        void View_DoubleClick(object sender, EventArgs e)
        {
            DoView(_Buttons.GetButtonByName(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.View));
        }

        #endregion

        //当前窗体初始化的公共权限
        protected override int CustomerAuthority
        {
            get
            {
                return FunctionAuthorityCommon.ADD//新增
                    + FunctionAuthorityCommon.EDIT//修改
                    + FunctionAuthorityCommon.DELETE;//删除
                                                     //+ FunctionAuthorityCommon.Save//保存
                                                     //+ FunctionAuthorityCommon.Cancel;//取消
            }
        }



        /// <summary>
        /// 窗体数据状态
        /// </summary>
        protected FormDataState CurrentDataState
        {
            get
            {
                return _currentdatastate;
            }
            set
            {
                if (_currentdatastate == value)
                    return;
                DataStateChanging(_currentdatastate, value);
                _currentdatastate = value;
                DataStateChanged(_currentdatastate);
            }
        }

        protected virtual bool ValidateBeforSave()
        {
            return false;
        }

        #region 窗体状态





        /// <summary>
        /// 窗体状态改变前
        /// </summary>
        /// <param name="OldState"></param>
        /// <param name="NewState"></param>
        protected virtual void DataStateChanging(FormDataState OldState, FormDataState NewState) { }

        /// <summary>
        /// 窗体状态改变以后
        /// </summary>
        /// <param name="NewState"></param>
        protected virtual void DataStateChanged(FormDataState NewState)
        {
            if (IsAddOrEdit)
                SetEditModel();
            else
                SetViewModel();
            UpdateNavButton();
        }

        /// <summary>
        /// 设置按钮可用状态，如果已经在ControlOnlyReads或SetControlAccessable中添加，这里不需要重新设置
        /// </summary>
        /// <param name="Edit"></param>
        protected virtual void SetControlAccessable(bool Edit)
        {

        }
        /// <summary>
        /// 重置按钮状态，因为在SetEditModel设置了启用按钮编辑功能，针对ControlOnlyReads和SetControlAccessable重新设置其状态
        /// </summary>
        protected void SetControlCommonAccessable()
        {
            foreach (Control col in ControlOnlyReads)
            {
                LibraryTools.SetControlAccessable(col, false);
            }
            if (CurrentDataState == FormDataState.Edit)
            {
                foreach (Control col in ControlKeys)
                {
                    LibraryTools.SetControlAccessable(col, false);
                }
            }
        }

        /// <summary>
        /// 新增或修改状态
        /// </summary>
        public bool IsAddOrEdit
        {
            get
            {
                return (CurrentDataState & (FormDataState.Add | FormDataState.Edit)) > 0;
            }
        }



        protected virtual void SetEditModel()
        {
            tp_Edit.PageEnabled = true;//数据编辑页面可用
            tc_Data.SelectedTabPage = tp_Edit;//切换到数据编辑页面
            tp_Search.PageEnabled = false;//数据查询页面不可用

            if (FormModel == EditModel.Edit) return;

            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.View, false);//查看按钮不可用
            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Add, false);//新增按钮不可用
            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Edit, false);//修改按钮不可用
            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Delete, false);//删除按钮不可用

            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Save, true);//保存按钮可用
            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Cancel, true);//取消按钮可用
            SetControlAccessable(true);
            SetControlCommonAccessable();
            FormModel = EditModel.Edit;
        }



        protected virtual void SetViewModel()
        {
            tp_Edit.PageEnabled = CurrentDataState != FormDataState.None;//数据编辑页面可用
            tp_Search.PageEnabled = true;//数据查询页面可用

            if (CurrentDataState == FormDataState.View)
                tc_Data.SelectedTabPage = tp_Edit;

            if (FormModel == EditModel.View) return;

            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.View, true);//查看按钮可用
            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Add, true);//新增按钮可用
            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Edit, true);//修改按钮可用
            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Delete, true);//删除按钮可用

            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Save, false);//保存按钮不可用
            SetButtonEnabled(GZFramework.UI.Core.RibbonButton.RibbonCommonButtonName.Cancel, false);//取消按钮不可用
            SetControlAccessable(false);
            FormModel = EditModel.View;
        }

        #endregion

        private void DoView(object sender, ItemClickEventArgs e) { DoView(sender); }

        /// <summary>
        /// 查询
        /// </summary>
        protected virtual void DoView(object sender) { }
    }


    public enum EditModel
    {
        None = 0,
        Edit = 1,
        View = 2
    }
}