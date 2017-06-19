using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFramework.UI.Dev.RibbonButton
{
    public class RibbonCommonButtonName
    {


        private static string _View;
        /// <summary>
        /// 查看
        /// </summary>
        public static string View
        {
            get
            {
                if (String.IsNullOrEmpty(_View))
                    _View = RibbonCommonButtons.CommonButtons.btnView.name;
                return _View;
            }
        }

        private static string _Rfresh;
        /// <summary>
        /// 刷新
        /// </summary>
        public static string Rfresh
        {
            get
            {
                if (String.IsNullOrEmpty(_Rfresh))
                    _Rfresh = RibbonCommonButtons.CommonButtons.btnRefresh.name;
                return _Rfresh;
            }
        }

        private static string _ADD;
        /// <summary>
        /// 新增
        /// </summary>
        public static string Add
        {
            get
            {
                if (String.IsNullOrEmpty(_ADD))
                    _ADD = RibbonCommonButtons.CommonButtons.btnADD.name;
                return _ADD;
            }
        }

        private static string _Delete;
        /// <summary>
        /// 删除
        /// </summary>
        public static string Delete
        {
            get
            {
                if (String.IsNullOrEmpty(_Delete))
                    _Delete = RibbonCommonButtons.CommonButtons.btnDelete.name;
                return _Delete;
            }
        }

        private static string _Edit;
        /// <summary>
        /// 修改
        /// </summary>
        public static string Edit
        {
            get
            {
                if (String.IsNullOrEmpty(_Edit))
                    _Edit = RibbonCommonButtons.CommonButtons.btnEdit.name;
                return _Edit;
            }
        }

        private static string _Save;
        /// <summary>
        /// 保存
        /// </summary>
        public static string Save
        {
            get
            {
                if (String.IsNullOrEmpty(_Save))
                    _Save = RibbonCommonButtons.CommonButtons.btnSave.name;
                return _Save;
            }
        }


        private static string _SaveAndClose;
        /// <summary>
        /// 保存并关闭
        /// </summary>
        public static string SaveAndClose
        {
            get
            {
                if (String.IsNullOrEmpty(_SaveAndClose))
                    _SaveAndClose = RibbonCommonButtons.CommonButtons.btnSaveAndClose.name;
                return _SaveAndClose;
            }
        }

        private static string _Approval;
        /// <summary>
        /// 审核
        /// </summary>
        public static string Approval
        {
            get
            {
                if (String.IsNullOrEmpty(_Approval))
                    _Approval = RibbonCommonButtons.CommonButtons.btnApproval.name;
                return _Approval;
            }
        }

        private static string _Cancel;
        /// <summary>
        /// 返回取消
        /// </summary>
        public static string Cancel
        {
            get
            {
                if (String.IsNullOrEmpty(_Cancel))
                    _Cancel = RibbonCommonButtons.CommonButtons.btnCancel.name;
                return _Cancel;
            }
        }


        private static string _Preview;
        /// <summary>
        /// 返回取消
        /// </summary>
        public static string Preview
        {
            get
            {
                if (String.IsNullOrEmpty(_Preview))
                    _Preview = RibbonCommonButtons.CommonButtons.btnPreview.name;
                return _Preview;
            }
        }

        private static string _Export;
        /// <summary>
        /// 导出数据
        /// </summary>
        public static string Export
        {
            get
            {
                if (String.IsNullOrEmpty(_Export))
                    _Export = RibbonCommonButtons.CommonButtons.btnExport.name;
                return _Export;
            }
        }

    }
}
