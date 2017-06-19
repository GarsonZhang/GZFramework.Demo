using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFramework.UI.Dev.RibbonButton
{
    public interface IRibbonCommonButtons
    {
        /// <summary>
        /// 查看
        /// </summary>
        RibbonItemButtonBase btnView { get; }
        /// <summary>
        /// 刷新
        /// </summary>
        RibbonItemButtonBase btnRefresh { get; }
        /// <summary>
        /// 新增
        /// </summary>
        RibbonItemButtonBase btnADD { get; }
        /// <summary>
        /// 删除
        /// </summary>
        RibbonItemButtonBase btnDelete { get; }
        /// <summary>
        /// 修改
        /// </summary>
        RibbonItemButtonBase btnEdit { get; }
        /// <summary>
        /// 保存
        /// </summary>
        RibbonItemButtonBase btnSave { get; }
        /// <summary>
        /// 保存并关闭
        /// </summary>
        RibbonItemButtonBase btnSaveAndClose { get; }
        /// <summary>
        /// 审核
        /// </summary>
        RibbonItemButtonBase btnApproval { get; }
        /// <summary>
        /// 返回取消
        /// </summary>
        RibbonItemButtonBase btnCancel { get; }
        /// <summary>
        /// 打印预览
        /// </summary>
        RibbonItemButtonBase btnPreview { get; }
        /// <summary>
        /// 导出数据
        /// </summary>
        RibbonItemButtonBase btnExport { get; }
    }
}
