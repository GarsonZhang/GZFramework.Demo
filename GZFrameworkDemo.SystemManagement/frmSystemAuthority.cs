using GZFrameworkDemo.Library.ModuleProvider;
using GZFrameworkDemo.Models;
using GZFrameworkDemo.SystemManagement.Dialog;
using GZFramework.UI.Dev.Common;
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
    public partial class frmSystemAuthority : GZFramework.UI.Dev.LibForm.frmBaseChild
    {

        DataTable DataSource;
        BusinessSQLite.bllModules bll;
        public frmSystemAuthority()
        {
            InitializeComponent();
            bll = new BusinessSQLite.bllModules();
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsView.ShowCheckBoxes = true;
            //this.treeList1.OptionsView.ShowColumns = false;



            var Column = this.treeList1.Columns.Add();
            Column.Caption = "名称";
            Column.FieldName = "DisplayName";
            Column.MinWidth = 32;
            Column.Name = "treeListColumn1";
            Column.Visible = true;
            Column.VisibleIndex = 0;

            this.treeList1.KeyFieldName = "PKey";
            this.treeList1.ParentFieldName = "ParentKey";

            toolMenu_Edit.Click += ToolMenu_Edit_Click;


        }

        private void ToolMenu_Edit_Click(object sender, EventArgs e)
        {
            if (treeList1.FocusedNode == null) return;
            DataRowView drv = treeList1.GetDataRecordByNode(treeList1.FocusedNode) as DataRowView;
            frmDialog_MenuEdit.ShowForm(drv.Row);
        }

        void ResetDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PKey", typeof(System.String));
            dt.Columns.Add("ParentKey", typeof(System.String));
            dt.Columns.Add("DisplayName", typeof(System.String));
            dt.Columns.Add("Name", typeof(System.String));
            dt.Columns.Add("Type", typeof(System.Int32));//1 模块 2 功能 3权限
            dt.Columns.Add("Authority", typeof(System.Int32));
            dt.Columns.Add("ModuleSort", typeof(System.Int32));
            dt.Columns.Add("FunctionSort", typeof(System.Int32));

            dt.DefaultView.Sort = "ModuleSort,FunctionSort";
            DataSource = dt;
        }

        void AddRow(string Key, string ParentKey, string DisplayName, string Name, int Type, int Authority, int ModuleSort, int FunctionSort)
        {
            DataRow row = DataSource.Rows.Add();
            row["PKey"] = Key;
            row["ParentKey"] = ParentKey;
            row["DisplayName"] = DisplayName;
            row["Name"] = Name;
            row["Type"] = Type;
            row["Authority"] = Authority;
            row["ModuleSort"] = ModuleSort;
            row["FunctionSort"] = FunctionSort;
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            GZFramework.UI.Dev.WaiteServer.ShowWaite(this);
            try
            {
                ResetDataSource();

                var modules = LoadModuleHelper.Intance.GetModuleALL();

                int ModuleIndex = 0;
                foreach (var m in modules)
                {
                    int FunctionIndex = 0;
                    ModuleIndex++;
                    this.AddRow(m.ModuleID, "", m.Caption, m.ModuleName, 1, 0, ModuleIndex, FunctionIndex);
                    foreach (var fun in m.functions)
                    {
                        FunctionIndex++;
                        this.AddRow(fun.FunctionID, m.ModuleID, fun.Caption, fun.FunctionName, 2, 0, ModuleIndex, FunctionIndex);

                        fun.UserAuthority = GZFramework.UI.Core.FunctionAuthority.All;
                        Form form = fun.LoadFormEx();
                        if (form is GZFramework.UI.Dev.LibForm.frmBaseChild)
                        {
                            (form as GZFramework.UI.Dev.LibForm.frmBaseChild).InitialForm();
                            var o = (form as GZFramework.UI.Dev.LibForm.frmBaseChild).AuthorityDisplay;
                            foreach (int i in o.Keys)
                            {
                                this.AddRow(string.Format("{0}_{1}", fun.FunctionID, i), fun.FunctionID, o[i], o[i], 3, i, ModuleIndex, FunctionIndex);
                            }
                        }
                    }
                }

                treeList1.DataSource = DataSource;
                GZFramework.UI.Dev.WaiteServer.CloseWaite();
            }
            catch (Exception ex)
            {
                GZFramework.UI.Dev.WaiteServer.CloseWaite();
                throw ex;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool success;
            //DataSource.DefaultView.Sort = "ModuleSort,FunctionSort DESC";
            GZFramework.UI.Dev.WaiteServer.ShowWaite(this);
            try
            {
                DataSet ds = bll.DoGetDocData("-");
                DataSource.DefaultView.RowFilter = "Type=1";
                DataTable dtModule = DataSource.DefaultView.ToTable();

                int ModuleIndex = 0;

                //模块
                foreach (DataRow rowModule in dtModule.Rows)
                {
                    ModuleIndex++;
                    DataRow drModule = ds.Tables[sys_Modules._TableName].Rows.Add();
                    drModule[sys_Modules.ModuleID] = rowModule["PKey"];
                    drModule[sys_Modules.ModuleName] = rowModule["Name"];
                    drModule[sys_Modules.Sort] = ModuleIndex;


                    //功能
                    DataSource.DefaultView.RowFilter = $"ParentKey='{rowModule["PKey"]}' AND Type=2";
                    DataTable dtFunction = DataSource.DefaultView.ToTable();
                    int FunIndex = 0;
                    foreach (DataRow rowFun in dtFunction.Rows)
                    {
                        FunIndex++;
                        DataRow drfun = ds.Tables[sys_ModulesFunction._TableName].Rows.Add();
                        drfun[sys_ModulesFunction.ModuleID] = rowModule["PKey"];
                        drfun[sys_ModulesFunction.FunctionID] = rowFun["PKey"];
                        drfun[sys_ModulesFunction.FunctionName] = rowFun["Name"];
                        drfun[sys_ModulesFunction.Sort] = FunIndex;

                        //权限
                        DataSource.DefaultView.RowFilter = $"ParentKey='{rowFun["PKey"]}' AND Type=3";
                        DataTable dtAuthority = DataSource.DefaultView.ToTable();
                        foreach (DataRow rowAuthority in dtAuthority.Rows)
                        {
                            DataRow drAuthority = ds.Tables[sys_ModulesFunctionAuthority._TableName].Rows.Add();
                            drAuthority[sys_ModulesFunctionAuthority.FunctionID] = rowFun["PKey"];
                            drAuthority[sys_ModulesFunctionAuthority.AuthorityID] = rowAuthority["Authority"];
                            drAuthority[sys_ModulesFunctionAuthority.AuthorityName] = rowAuthority["Name"];
                        }
                    }
                }


                success = bll.Update(ds);
                GZFramework.UI.Dev.WaiteServer.CloseWaite();
            }
            catch (Exception ex)
            {
                GZFramework.UI.Dev.WaiteServer.CloseWaite();
                throw ex;

            }
            if (success == true)
            {
                Msg.ShowInformation("提交成功！");
                btn_Load.PerformClick();
            }
            
        }
    }
}
