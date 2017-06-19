using DevExpress.XtraTreeList.Nodes;
using GZFrameworkDemo.BusinessSQLite;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.MyClass;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.MyControl
{
    [ToolboxItem(true)]
    public class ucModuleTreeList : DevExpress.XtraTreeList.TreeList
    {
        TreeListInitial _TreeListInitial;
        bllModules bll;

        private DataTable _EditData;
        /// <summary>
        /// 必须包含FunctionID,Authority两列
        /// </summary>
        public DataTable EditData
        {
            get { return _EditData; }
            set
            {
                _EditData = value;
                RefreshNodeCheckState();
            }
        }

        void RefreshNodeCheckState()
        {
            this.UncheckAll();
            if (_EditData == null) return;
            string Key;
            foreach (DataRow row in EditData.Rows)
            {
                int authority = ConvertLib.ToInt(row[dt_MyRoleAuthority.Authority]);
                var v = ConvertLib.ToBinaryNums(authority);
                foreach (int i in v)
                {
                    Key = String.Format("{0}.{1}", row[dt_MyRoleAuthority.FunctionID], i);
                    TreeListNode node = this.FindNodeByKeyID(Key);
                    if (node == null) continue;

                    _TreeListInitial.SetNodeCheckState(node, CheckState.Checked);
                }
            }
        }

        protected override void RaiseLayoutUpdated()
        {
            base.RaiseLayoutUpdated();
        }

        protected override void UpdateRootBands()
        {
            base.UpdateRootBands();
        }

        protected override void UpdateLayout()
        {
            base.UpdateLayout();
        }

        public override void EndUpdate()
        {
            base.EndUpdate();
        }

        public override void Refresh()
        {
            base.Refresh();
        }




        public ucModuleTreeList()
        {

            this.OptionsBehavior.Editable = false;
            this.OptionsView.ShowCheckBoxes = true;
            this.OptionsView.ShowColumns = false;
            _TreeListInitial = new TreeListInitial(this);
            if (CheckDesingModel.IsDesingMode) return;


            var Column = this.Columns.Add();
            Column.Caption = "名称";
            Column.FieldName = "DisplayName";
            Column.MinWidth = 32;
            Column.Name = "treeListColumn1";
            Column.Visible = true;
            Column.VisibleIndex = 0;




            this.AfterCheckNode += ucModuleList_AfterCheckNode;
            this.KeyFieldName = "PKey";
            this.ParentFieldName = "ParentKey";
            bll = new bllModules();
            this.DataSource = bll.GetSystemModules();
        }


        public bool AllowCheck
        {
            get
            {
                return _TreeListInitial.AllowCheck;
            }
            set
            {
                _TreeListInitial.AllowCheck = value;
            }
        }
        protected override void OnLoaded()
        {
            base.OnLoaded();
            RefreshNodeCheckState();
        }

        void LoadDataSource()
        {
            if (CheckDesingModel.IsDesingMode) return;
            DataTable dtSource = null;
            switch (DataSourceType)
            {
                case DataType.所有系统模块:
                    {
                        dtSource = bll.GetSystemModules();
                    }
                    break;
                case DataType.当前用户模块:
                    {
                        dtSource = bll.GetTreeModule_CurrentUser();
                    }
                    break;
            }
            if (dtSource != null)
            {
                this.DataSource = dtSource;
                RefreshNodeCheckState();
            }
        }


        public void BoundModuleOfUser(string User)
        {
            this.DataSource = bll.GetTreeModule_User(User);
        }

        private DataType _DataSourceType = DataType.None;

        [Description("数据绑定类型"), DefaultValue(DataType.None)]
        public DataType DataSourceType
        {
            get { return _DataSourceType; }
            set
            {
                _DataSourceType = value;
                LoadDataSource();
            }
        }

        public enum DataType
        {
            None,
            所有系统模块,
            当前用户模块
        }

        public void CheckKey(string Key)
        {
            TreeListNode node = this.FindNodeByKeyID(Key);
            if (node == null) return;
            _TreeListInitial.SetNodeCheckState(node, CheckState.Checked);
        }

        void ucModuleList_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            UpdateAuthority(e.Node);
        }

        public event AddDataRowHandler AddDataRow;

        public delegate void AddDataRowHandler(object sender, ArgsAddDataRow e);

        public class ArgsAddDataRow : EventArgs
        {
            public DataRow Row { get; private set; }

            public ArgsAddDataRow(DataRow dr)
            {
                Row = dr;
            }
        }
        void UpdateAuthority(TreeListNode Node)
        {
            if (EditData == null) return;

            if (Node.HasChildren)
            {
                foreach (TreeListNode Cnode in Node.Nodes)
                {
                    UpdateAuthority(Cnode);
                }
            }
            else
            {
                if (ConvertLib.ToInt(Node.GetValue("AuthorityID")) <= 0) return;
                string filter = String.Format("{0}='{1}'", sys_ModulesFunctionAuthority.FunctionID, Node.GetValue("ParentKey"));
                var v = EditData.Select(filter);

                if (Node.Checked)
                {

                    DataRow dr;
                    if (v.Length > 0)
                    {
                        dr = v[0];
                        dr[dt_MyRoleAuthority.Authority] = ConvertLib.ToInt(dr[dt_MyRoleAuthority.Authority]) + ConvertLib.ToInt(Node.GetValue("AuthorityID"));
                    }
                    else
                    {
                        dr = EditData.Rows.Add();
                        dr[dt_MyRoleAuthority.FunctionID] = Node.GetValue("ParentKey");
                        dr[dt_MyRoleAuthority.Authority] = Node.GetValue("AuthorityID");
                        if (AddDataRow != null)
                            AddDataRow(this, new ArgsAddDataRow(dr));
                    }
                }
                else
                {
                    if (v.Length > 0)
                    {
                        int authority = 0;
                        if (v.Length > 0)
                            authority = ConvertLib.ToInt(v[0][dt_MyRoleAuthority.Authority]);

                        int NoteValue = ConvertLib.ToInt(Node.GetValue("AuthorityID"));

                        if ((authority & NoteValue) == NoteValue)//包含权限
                        {
                            v[0][dt_MyRoleAuthority.Authority] = authority - NoteValue;
                        }
                    }

                }
            }
        }

    }
}
