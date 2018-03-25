using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GZFramework.DB.Lib;
using GZFramework.UI.Dev.Common;
using GZFramework.UI.Dev.LibForm;
using GZFrameworkDemo.Business.Business;

namespace GZFrameworkDemo.Dictionary
{
    public partial class frmProduct : frmBaseDataBusiness
    {
        bllProduct bll;
        public frmProduct()
        {
            InitializeComponent();
            this.Load += frm_Load;
            //实例化必须，bllBusinessBase必须替换为bll层自己继承的子类(指定正确的dal.DBCode)，建议封装重写到项目bll层

            _bll = bll = new bllProduct();
        }
        private void frm_Load(object sender, EventArgs e)
        {
            _SummaryView = gvMainData;//必须赋值
            base.AddControlsOnAddKey();

            base.AddControlsOnlyRead(this.txtProductID, this.txtCreateUser, this.txtCreateDate, this.txtLastUpdateUser, this.txtLastUpdateDate);

            Library.DataBinderTools.Bound.BoundCommonDictDataID(txtMaterial, Business.CustomerEnum.EnumCommonDicData.产品材质, false, false);
            Library.DataBinderTools.Bound.BoundCommonDictDataID(txts_Material, Business.CustomerEnum.EnumCommonDicData.产品材质, false, true);
            Library.DataBinderTools.Bound.BoundCommonDictDataID(lueMaterial, Business.CustomerEnum.EnumCommonDicData.产品材质, false, false);
            Library.DataBinderTools.Bound.BoundCommonDictDataID(txtUnit, Business.CustomerEnum.EnumCommonDicData.单位, false, false);

            Library.DataBinderTools.Bound.BoundCommonDictDataID(lueUnit, Business.CustomerEnum.EnumCommonDicData.单位, false, false);

            Library.DataBinderTools.Bound.BoundUserName(txtCreateUser, txtLastUpdateUser);
            Library.DataBinderTools.Bound.BoundUserName(lueUserName);
        }
        //查询
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Dictionary<string, object> dic = new Dictionary<string, object>();

            //if (!String.IsNullOrEmpty(txts_ProductID.Text)) dic.Add("@ProductID", txts_ProductID.Text);
            //if (!String.IsNullOrEmpty(txts_Material.Text)) dic.Add("@Material", txts_Material.Text);
            //if (!String.IsNullOrEmpty(txts_ProductName.Text)) dic.Add("@ProductName", txts_ProductName.Text);
            //if (!String.IsNullOrEmpty(txts_ZJM.Text)) dic.Add("@ZJM", txts_ZJM.Text);


            DataTable dt = bll.Search(txts_ProductID.Text, txts_Material.EditValue + "", txts_ProductName.Text, txts_ZJM.Text);

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
            bool Validate = true
                       & LibraryTools.IsNotEmpBaseEdit(txtMaterial, "材质不能为空！")
                       & LibraryTools.IsNotEmpBaseEdit(txtProductName, "产品名称不能为空！")
                       & LibraryTools.IsNotEmpBaseEdit(txtZJM, "助记码不能为空！");

            ;


            return Validate;
        }


        #region 其他常用
        //绑定明细页数据
        public override void DoBoundEditData()
        {
            //base.DoBoundEditData();
            LibraryTools.DoBindingEditorPanel(pan_Summary, EditData.Tables[_bll.SummaryModel.TableName], "txt");

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
                return base.CustomerAuthority;
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
            base.DoDelete(sender);
        }

        /// <summary>
        /// 修改
        /// </summary>
        protected override void DoEdit(object sender)
        {
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
            base.DoApproval(sender);
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

        private void gcMainData_Click(object sender, EventArgs e)
        {

        }
    }
}
