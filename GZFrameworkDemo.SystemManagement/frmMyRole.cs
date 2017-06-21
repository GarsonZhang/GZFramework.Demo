
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraTreeList.Nodes;
using GZFrameworkDemo.Business;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library;
using GZFrameworkDemo.Library.MyClass;
using GZFrameworkDemo.Models;
using GZFramework.UI.Core;
using GZFramework.UI.Dev.Common;
using GZFramework.UI.Dev.LibForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.SystemManagement
{
    public partial class frmMyRole : frmBaseDataBusiness
    {
        public frmMyRole()
            : base()
        {
            InitializeComponent();
        }



        bllRole bll;

        private void frmModulesManage_Load(object sender, EventArgs e)
        {
            _SummaryView = gv_Summary;

            _bll = bll = new bllRole();


            //base.AddControlsOnAddKey(txtRoleID);
            base.AddControlsOnlyRead(txtRoleID, txtCreateUser, txtCreateDate, txtLastUpdateDate, txtLastUpdateUser);

            DataBinderTools.Bound.BoundUserName(txtCreateUser);
            DataBinderTools.Bound.BoundUserName(txtLastUpdateUser);
            DataBinderTools.Bound.BoundUserName(lue_UserName);
        }

        //public override void DoCancel(object sender)
        //{
        //    CurrentDataState = FormDataState.View;
        //    if (_SummaryView.RowCount > 0)

        //        DoView(null);
        //    else
        //    {
        //        tc_Data.SelectedTabPage = tp_Search;
        //        tp_Edit.PageEnabled = false;
        //    }
        //    //base.DoCancel(sender);
        //}

        public override void DoBoundEditData()
        {
            //选择节点
            LibraryTools.DoBindingEditorPanel(pan_Summary, EditData.Tables[_bll.SummaryModel.TableName], "txt");



            tree_Module.EditData = EditData.Tables[dt_MyRoleAuthority._TableName];
        }




        protected override void DoView(object sender)
        {
            DataRow dr = _SummaryView.GetFocusedDataRow();
            if (dr == null)
            {
                Msg.Warning("没有选择数据！");
                return;
            }

            CurrentDataState = FormDataState.View;//设置状态
            string Key = ConvertLib.ToString(dr[_bll.SummaryModel.PrimaryKey]);
            //2015年10月21日11:55:26 当双击不同记录的时候再重新获取数据，避免重复读取数据库
            bool Repeat = EditData != null && Object.Equals(Key, EditData.Tables[_bll.SummaryModel.TableName].Rows[0][_bll.SummaryModel.PrimaryKey]);
            if (!Repeat)
            {
                EditData = GetEditData(Key);//获得需要绑定的数据
                DoBoundEditData();//绑定数据
            }

        }
        protected override void DoAdd(object sender)
        {
            base.DoAdd(sender);

            DateTime time = bll.GetServerTime();

            DataTable dt = EditData.Tables[bll.SummaryModel.TableName];

            dt.Rows[0]["CreateUser"] = Loginer.CurrentLoginer.Account;
            dt.Rows[0]["CreateDate"] = time;
            dt.Rows[0]["LastUpdateUser"] = Loginer.CurrentLoginer.Account;
            dt.Rows[0]["LastUpdateDate"] = time;
        }

        private void tree_Module_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            UpdateAuthority(e.Node);
        }

        void UpdateAuthority(TreeListNode Node)
        {
            if (Node.HasChildren)
            {
                foreach (TreeListNode Cnode in Node.Nodes)
                {
                    UpdateAuthority(Cnode);
                }
            }
            else
            {
                if (Node.Checked)
                {
                    if (ConvertLib.ToInt(Node.GetValue("AuthorityID")) <= 0) return;
                    string filter = String.Format("{0}='{1}'", dt_MyRoleAuthority.FunctionID, Node.GetValue("ParentKey"));
                    var v = EditData.Tables[dt_MyRoleAuthority._TableName].Select(filter);
                    DataRow dr;
                    if (v.Length > 0)
                    {
                        dr = v[0];
                        dr[dt_MyRoleAuthority.Authority] = ConvertLib.ToInt(dr[dt_MyRoleAuthority.Authority]) + ConvertLib.ToInt(Node.GetValue("AuthorityID"));
                    }
                    else
                    {
                        dr = EditData.Tables[dt_MyRoleAuthority._TableName].Rows.Add();
                        dr[dt_MyRoleAuthority.RoleID] = EditData.Tables[dt_MyRole._TableName].Rows[0][dt_MyRole.RoleID];
                        dr[dt_MyRoleAuthority.FunctionID] = Node.GetValue("ParentKey");
                        dr[dt_MyRoleAuthority.Authority] = Node.GetValue("AuthorityID");
                    }
                }
                else
                {
                    string filter = String.Format("{0}='{1}'", dt_MyRoleAuthority.FunctionID, Node.GetValue("ParentKey"));
                    //string stringFormat = String.Format("{0}='{1}' AND {2}='{3}'",
                    //                    dt_MyRoleAuthority.FunctionID, Node.GetValue("ParentKey"), dt_MyRoleAuthority.Authority, Node.GetValue("AuthorityID"));
                    DataRow[] drs = EditData.Tables[dt_MyRoleAuthority._TableName].Select(filter);
                    if (drs.Length > 0)
                    {
                        int authority = 0;
                        if (drs.Length > 0)
                            authority = ConvertLib.ToInt(drs[0][dt_MyRoleAuthority.Authority]);

                        int NoteValue = ConvertLib.ToInt(Node.GetValue("AuthorityID"));

                        if ((authority & NoteValue) == NoteValue)//包含权限
                        {
                            drs[0][dt_MyRoleAuthority.Authority] = authority - NoteValue;
                        }
                    }

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gc_Summary.DataSource = _bll.Search(null);
        }

        protected override void SetControlAccessable(bool Edit)
        {
            base.SetControlAccessable(Edit);
            tree_Module.AllowCheck = Edit;
            //tree_Module.OptionsBehavior.Editable = true;
        }


        protected override bool ValidateBeforSave()
        {
            bool validate = Tools_VerificationEditValue.VerificationNotEmpEditValue(txtRoleName, "角色名称不能为空！");
            return validate;
        }




    }
}
