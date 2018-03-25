using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GZFramework.UI.Dev.Common;
using GZFramework.UI.Dev.LibForm;
using GZFrameworkDemo.Business.Base;
using GZFrameworkDemo.Models;
using GZFrameworkDemo.Common;
using DevExpress.XtraEditors;
using GZFrameworkDemo.Business;
using GZFrameworkDemo.Library.MyClass;
using DevExpress.XtraTreeList.Nodes;
using GZFrameworkDemo.Library;
using GZFramework.UI.Core;

namespace GZFrameworkDemo.SystemManagement
{
    public partial class frmMyUser : frmBaseDataBusiness
    {
        bllMyUser bll;
        public frmMyUser()
        {
            InitializeComponent();
            this.Load += frm_Load;
            _bll = bll = new bllMyUser();
        }

        DataTable dtRoles;
        DataTable dtDBList;
        private void frm_Load(object sender, EventArgs e)
        {
            _SummaryView = gvMainData;//必须赋值
            base.AddControlsOnAddKey(txtAccount);
            dtRoles = bll.GetRoleList();
            dtDBList = DataCache.Cache.dtDBList.Copy();
            base.AddControlsOnlyRead(txtCreateUser, txtCreateDate, txtLastUpdateUser, txtLastUpdateDate);

            DataBinderTools.Bound.BoundDBList(lue_DBList, false, false);
            DataBinderTools.Bound.BoundUserName(txtCreateUser, txtLastUpdateUser);
            DataBinderTools.Bound.BoundUserName(lue_UserName);
            DataBinderTools.Bound.BoundRoleID(lue_RoleName, false, false);
        }
        //查询
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //SqlParameterProvider p = new SqlParameterProvider();


            //if (!String.IsNullOrEmpty(txts_Account.Text)) p.AddParameter("@Account", SqlDbType.VarChar, 20, txts_Account.Text);
            //if (!String.IsNullOrEmpty(txts_UserName.Text)) p.AddParameter("@UserName", SqlDbType.VarChar, 20, txts_UserName.Text);
            //if (!String.IsNullOrEmpty(txts_Phone.Text)) p.AddParameter("@Phone", SqlDbType.VarChar, 15, txts_Phone.Text);
            //if (!String.IsNullOrEmpty(txts_Email.Text)) p.AddParameter("@Email", SqlDbType.VarChar, 50, txts_Email.Text);

            Dictionary<String, object> p = new Dictionary<string, object>();
            if (!String.IsNullOrEmpty(txts_Account.Text)) p.Add("Account", txts_Account.Text);
            if (!String.IsNullOrEmpty(txts_UserName.Text)) p.Add("UserName", txts_UserName.Text);
            if (!String.IsNullOrEmpty(txts_Phone.Text)) p.Add("Phone", txts_Phone.Text);
            if (!String.IsNullOrEmpty(txts_Email.Text)) p.Add("Email", txts_Email.Text);
            DataTable dt = bll.Search(p);

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
                       & LibraryTools.IsNotEmpBaseEdit(txtAccount, "账号不能为空！")
                       & LibraryTools.IsNotEmpBaseEdit(txtUserName, "名称不能为空！");
            if (Validate == false) return false;

            //密码字段加密
            DataRow row = EditData.Tables[_bll.SummaryModel.TableName].Rows[0];

            if (row.HasVersion(DataRowVersion.Proposed))//只有修改之后的密码字段才进行加密
            {
                //修改过密码字段
                Validate = Validate & LibraryTools.IsNotEmpBaseEdit(txtPassword, "密码不能为空！")
                   & LibraryTools.IsNotEmpBaseEdit(txxtPassword, "确认密码不能为空！");
                if (Validate == false) return false;

                if (!Object.Equals(txtPassword.EditValue, txxtPassword.EditValue))
                {
                    Msg.Warning("两次密码输入不一致，请重新输入！");
                    return false;
                }
                if (!object.ReferenceEquals(row[dt_MyUser.Password, DataRowVersion.Current], row[dt_MyUser.Password, DataRowVersion.Proposed]))
                {
                    row[dt_MyUser.Password] = Encrypt.DESEncrypt(row[dt_MyUser.Password].ToString());
                }
            }
            txxtPassword.EditValue = EditData.Tables[_bll.SummaryModel.TableName].Rows[0][dt_MyUser.Password];
            return true;
        }


        #region 其他常用
        //绑定明细页数据
        public override void DoBoundEditData()
        {
            base.DoBoundEditData();
            gc_DBList.DataSource = EditData.Tables[dt_MyUserDBs._TableName];
            gc_Detail.DataSource = EditData.Tables[dt_MyUserRole._TableName];
            //其他绑定
            //LibraryTools.DoBindingEditorPanel(pan_Summary, EditData.Tables[_bll.SummaryTableName], "txt");
            //txxtPassword.EditValue = EditData.Tables[_bll.SummaryTableName].Rows[0][dt_MyUser.Password];
            //gc_Detail.DataSource = EditData.Tables[dt_MyUserRole._TableName];  
            UpdateRoleAuthority();
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
        protected override void DataStateChanged(FormDataState NewState)
        {
            base.DataStateChanged(NewState);
            if (this.IsAddOrEdit)
                xtraTabControl1.SelectedTabPageIndex = 0;
        }
        //窗体状态改时
        protected override void DataStateChanging(FormDataState OldState, FormDataState NewState)
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

            layoutControlItem1.Visibility = Edit == false ? DevExpress.XtraLayout.Utils.LayoutVisibility.Never : DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }
        #endregion

        #region 操作事件，不需要的可以删除
        /// <summary>
        /// 查询
        /// </summary>
        protected override void DoView(object sender)
        {
            base.DoView(sender);
            layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
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
            layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
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
            layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
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

        private void gc_Detail_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Msg.AskQuestion("确定要删除选中角色吗？"))
                {
                    gv_Detail.DeleteSelectedRows();
                    UpdateRoleAuthority();
                }


            }
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                //添加角色
                //frmDialog_RoleList
                DataTable dtdetail = EditData.Tables[dt_MyUserRole._TableName];
                var str = dtdetail.FormatInValue(dt_MyRole.RoleID);
                dtRoles.DefaultView.RowFilter = String.IsNullOrEmpty(str) ? "" : String.Format("{0} NOT IN ({1})", dt_MyRole.RoleID, str);
                DataTable dt = frmDialog_RoleList.ShowForm(dtRoles.DefaultView.ToTable());
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DataRow row = EditData.Tables[dt_MyUserRole._TableName].Rows.Add();
                        row[dt_MyUserRole.Account] = txtAccount.EditValue;
                        row[dt_MyUserRole.RoleID] = dr[dt_MyRole.RoleID];
                        //row[dt_MyRole.RoleName] = dr[dt_MyRole.RoleName];
                    }
                    UpdateRoleAuthority();
                }

            }
            e.Handled = true;
        }

        void UpdateRoleAuthority()
        {
            //选择节点
            //tree_Module.UncheckAll();
            //if (tree_Module.Nodes.Count == 0) return;
            string RoleIDs = EditData.Tables[dt_MyUserRole._TableName].FormatInValue(dt_MyUserRole.RoleID);
            DataTable dt = bll.GetRolesAuthority(RoleIDs);
            tree_ModuleEx.EditData = dt;

        }

        private void tree_Module_NodesReloaded(object sender, EventArgs e)
        {
            UpdateRoleAuthority();
        }

        private void frmMyUser_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_EditValueChanged(object sender, EventArgs e)
        {
            if (layoutControlItem1.Visibility == DevExpress.XtraLayout.Utils.LayoutVisibility.Never)
                layoutControlItem1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;

        }

        private void gc_DBList_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            //frmDialog_DBList
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Msg.AskQuestion("确定要删除选中账套吗？"))
                {
                    gv_DBList.DeleteSelectedRows();
                }

            }
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                //添加角色
                //frmDialog_RoleList
                DataTable dtdetail = EditData.Tables[dt_MyUserDBs._TableName];
                var str = dtdetail.FormatInValue(dt_MyUserDBs.DBCode);
                dtDBList.DefaultView.RowFilter = String.IsNullOrEmpty(str) ? "" : String.Format("{0} NOT IN ({1})", sys_DataBaseList.DBCode, str);
                DataTable dt = frmDialog_DBList.ShowForm(dtDBList.DefaultView.ToTable());
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        DataRow row = EditData.Tables[dt_MyUserDBs._TableName].Rows.Add();
                        row[dt_MyUserDBs.Account] = txtAccount.EditValue;
                        row[dt_MyUserDBs.DBCode] = dr[sys_DataBaseList.DBCode];
                    }
                }

            }
            e.Handled = true;
        }
    }
}
