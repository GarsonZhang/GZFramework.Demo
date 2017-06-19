using DevExpress.XtraBars;
using GZFramework.UI.Core;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.LibForm
{
    //功能窗体基类，权限
    public partial class frmBaseFunction : frmBaseChild
    {
        public frmBaseFunction()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 判断模块是否拥有权限
        /// </summary>
        /// <param name="Authority"></param>
        /// <returns></returns>
        protected bool CurrentAuthorityExist(int Authority)
        {
            return (CurrentAuthorityEx & Authority) == Authority;
            
        }



        public override void IniButton()
        {
            //查看
            //if (CurrentAuthorityExist(FunctionAuthorityCommon.VIEW))
            //    AddButton(RibbonCommonButtons.CommonButtons.btnView, FunctionAuthorityCommon.VIEW, DoView);

            //刷新
            if (CurrentAuthorityExist(FunctionAuthorityCommon.Refresh))
                AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnRefresh, FunctionAuthorityCommon.Refresh, DoRefresh);

            //新增
            if (CurrentAuthorityExist(FunctionAuthorityCommon.ADD))
                AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnADD, FunctionAuthorityCommon.ADD, DoAdd);
            //修改
            if (CurrentAuthorityExist(FunctionAuthorityCommon.EDIT))
                AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnEdit, FunctionAuthorityCommon.EDIT, DoEdit);

            if (CurrentAuthorityExist(FunctionAuthorityCommon.ADD) || CurrentAuthorityExist(FunctionAuthorityCommon.EDIT))
            {
                //保存
                //if (CurrentAuthorityExist(FunctionAuthorityCommon.Save))
                AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnSave, FunctionAuthorityCommon._None, DoSave);
                //保存并关闭
                //if (CurrentAuthorityExist(FunctionAuthorityCommon.SaveAndCloseEx))
                //    AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnSaveAndClose, FunctionAuthorityCommon._None, DoSaveAndClose);
                //取消
                //if (CurrentAuthorityExist(FunctionAuthorityCommon.Cancel))
                AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnCancel, FunctionAuthorityCommon._None, DoCancel);
            }
            else
            {
                //保存
                if (CurrentAuthorityExist(FunctionAuthorityCommon.SaveEx))
                    AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnSave, FunctionAuthorityCommon.SaveEx, DoSave);
                //保存并关闭
                if (CurrentAuthorityExist(FunctionAuthorityCommon.SaveAndCloseEx))
                    AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnSaveAndClose, FunctionAuthorityCommon.SaveAndCloseEx, DoSaveAndClose);
                //取消
                if (CurrentAuthorityExist(FunctionAuthorityCommon.CancelEx))
                    AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnCancel, FunctionAuthorityCommon.CancelEx, DoCancel);
            }

            //删除
            if (CurrentAuthorityExist(FunctionAuthorityCommon.DELETE))
                AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnDelete, FunctionAuthorityCommon.DELETE, DoDelete);

            if (CurrentAuthorityExist(FunctionAuthorityCommon.APPROVAL))
                AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnApproval, FunctionAuthorityCommon.APPROVAL, DoApproval);


            if (CurrentAuthorityExist(FunctionAuthorityCommon.PREVIEW))
                AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnPreview, FunctionAuthorityCommon.PREVIEW, DoPreview);

            if (CurrentAuthorityExist(FunctionAuthorityCommon.Export))
                AddButton(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnExport, FunctionAuthorityCommon.Export, DoExport);
        }


        #region 按钮ItemClick事件 Do***


        protected override void AuthorityInitial()
        {
            base.AuthorityInitial();

            bool Edit = AuthorityExist(FunctionAuthorityCommon.ADD) || AuthorityExist(FunctionAuthorityCommon.EDIT);
            if (Edit == false)
            {
                var btn = _Buttons.GetButtonByName(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnSave.name);
                if (btn != null && !AuthorityExist(FunctionAuthorityCommon.SaveEx))
                    btn.Item.Visibility = BarItemVisibility.Never;

                btn = _Buttons.GetButtonByName(GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnCancel.name);
                if (btn != null && !AuthorityExist(FunctionAuthorityCommon.CancelEx))
                    btn.Item.Visibility = BarItemVisibility.Never;
            }

        }


        private void DoRefresh(object sender, ItemClickEventArgs e) { DoRefresh(sender); }
        /// <summary>
        /// 刷新
        /// </summary>
        protected virtual void DoRefresh(object sender) { }


        private void DoAdd(object sender, ItemClickEventArgs e) { DoAdd(sender); }
        /// <summary>
        /// 新增
        /// </summary>
        protected virtual void DoAdd(object sender) { }


        private void DoDelete(object sender, ItemClickEventArgs e) { DoDelete(sender); }
        /// <summary>
        /// 删除
        /// </summary>
        protected virtual void DoDelete(object sender) { }


        private void DoEdit(object sender, ItemClickEventArgs e) { DoEdit(sender); }
        /// <summary>
        /// 修改
        /// </summary>
        protected virtual void DoEdit(object sender) { }


        private void DoSave(object sender, ItemClickEventArgs e) { DoSave(sender); }
        /// <summary>
        /// 保存
        /// </summary>
        protected virtual void DoSave(object sender) { }



        private void DoSaveAndClose(object sender, ItemClickEventArgs e) { DoSaveAndClose(sender); }
        /// <summary>
        /// 保存并关闭
        /// </summary>
        protected virtual void DoSaveAndClose(object sender) { }


        private void DoApproval(object sender, ItemClickEventArgs e) { DoApproval(sender); }
        /// <summary>
        /// 审核
        /// </summary>
        protected virtual void DoApproval(object sender) { }


        private void DoCancel(object sender, ItemClickEventArgs e) { DoCancel(sender); }
        /// <summary>
        /// 返回取消
        /// </summary>
        protected virtual void DoCancel(object sender) { }


        private void DoPreview(object sender, ItemClickEventArgs e) { DoPreview(sender); }
        /// <summary>
        /// 打印预览
        /// </summary>
        protected virtual void DoPreview(object sender) { }


        private void DoExport(object sender, ItemClickEventArgs e) { DoExport(sender); }
        /// <summary>
        /// 导出数据
        /// </summary>
        protected virtual void DoExport(object sender) { }

        #endregion
    }

}
