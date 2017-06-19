using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraNavBar;
using ClothingPSISQLite.BusinessSQLite;
using ClothingPSISQLite.Common;
using ClothingPSISQLite.Library;
using ClothingPSISQLite.Library.Config.RibbonButtons;
using ClothingPSISQLite.Library.ModuleFun;
using ClothingPSISQLite.Library.MyClass;
using ClothingPSISQLite.Models;
using GZFramework.UI.Core;
using GZFramework.UI.Dev.Common;
using GZFramework.UI.Dev.LibForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClothingPSISQLite.SystemManagement
{
    public partial class frmModuleUpdateEx : GZFramework.UI.Dev.LibForm.frmBaseFunction
    {
        bllModules bll;
        public frmModuleUpdateEx()
        {
            InitializeComponent();
            bll = new bllModules();

            this.Shown += frmModuleUpdateEx_Shown;
        }

        protected override void OnLoad(EventArgs e)
        {
            GZFramework.UI.Dev.WaiteServer.ShowWaite(this);
            GZFramework.UI.Dev.WaiteServer.SetWaitFormDescription("正在加载模块。。。");
            base.OnLoad(e);
        }

        void frmModuleUpdateEx_Shown(object sender, EventArgs e)
        {
            GZFramework.UI.Dev.WaiteServer.CloseWaite();
        }
        /// <summary>
        /// 添加
        /// </summary>
        public override void IniButton()
        {
            base.IniButton();

            //if (CurrentAuthorityExist(16))
            //    AddButton(GZFramework.UI.Dev.RibbonButton.RibbonCommonButtons.CommonButtons.btnSave, 16, DoSave);
        }



        protected override int CustomerAuthority
        {
            get
            {
                return FunctionAuthorityCommon.SaveEx;
            }
        }





        DataSet Data = new DataSet();

        DataTable dtModule
        {
            get
            {
                return Data.Tables[sys_Modules._TableName];
            }
        }
        DataTable dtModulesFunction
        {
            get
            {
                return Data.Tables[sys_ModulesFunction._TableName];
            }
        }
        DataTable dtModulesFunctionAuthority
        {
            get
            {
                return Data.Tables[sys_ModulesFunctionAuthority._TableName];
            }
        }

        GZFunctionLayout _GZTable;


        private void frmModuleUpdate_Load(object sender, EventArgs e)
        {
            //创建表格实例并初始化5行
            _GZTable = new GZFunctionLayout(pan_Container, 90, 103);
            _GZTable.IsManage = true;
            _GZTable.ControlCellChanged += _GZTable_ControlCellChanged;

            Data = bll.GetTableData(Loginer.CurrentLoginer.SystemDBCode, new string[] { sys_Modules._TableName, sys_ModulesFunction._TableName, sys_ModulesFunctionAuthority._TableName });
            dtModule.Columns.Add("Tag", typeof(System.String));
            dtModulesFunction.Columns.Add("Tag", typeof(System.String));
            dtModulesFunctionAuthority.Columns.Add("Tag", typeof(System.String));
            dtModulesFunctionAuthority.DefaultView.RowFilter = "1=2";
            dtModulesFunctionAuthority.DefaultView.Sort = sys_ModulesFunctionAuthority.AuthorityID;
            gc_Authority.DataSource = dtModulesFunctionAuthority;
            Data.AcceptChanges();
            LoadModules();

            navBarControl1.ActiveGroupChanged += navBarControl1_ActiveGroupChanged;
        }

        void _GZTable_ControlCellChanged(GZTableCell cell)
        {
            var dr = (cell.ContainControl.Tag as NavBarItem).Tag as DataRow;
            dr[sys_ModulesFunction.GroupIndex] = cell.RowIndex;
            dr[sys_ModulesFunction.ItemIndex] = cell.ColIndex;
        }

        //刷新模块
        private void LoadModules()
        {
            LoadModuleHelper LM = new LoadModuleHelper();
            //var modules = LM.GetLocalAllModules(Globals.BaseDirectory);
            //ModuleFunctionsPool modules;

            var modules = LM.GetLocalAllModules();

            navBarControl1.Groups.Clear();
            navBarGroup1.ItemLinks.Clear();

            NavBarGroup group;
            DataRow drModule;

            List<Module> Ms = new List<Module>();


            int NewCount = 0;
            foreach (Module v in modules.Modules)
            {

                var SlectModules = dtModule.Select(String.Format("{0}='{1}'", sys_Modules.ModuleID, v.ModuleID));
                if (SlectModules.Length <= 0)
                {
                    drModule = dtModule.Rows.Add();
                    drModule["Tag"] = "Y";
                    drModule[sys_Modules.ModuleID] = v.ModuleID;
                    drModule[sys_Modules.ModuleNameRef] = drModule[sys_Modules.ModuleName] = v.ModuleName;
                    drModule[sys_Modules.ImgRef] = drModule[sys_Modules.Img] = v.ModuleImg;
                    v.Sort = NewCount++;
                    drModule[sys_Modules.Sort] = v.Sort;
                    v.Tag = drModule;
                    //drModule.AcceptChanges();
                    group = LoadModule(v);
                    //group.Caption = "(新)" + group.Caption;
                    group.Appearance.ForeColor = Color.FromArgb(0x99, 0x00, 0x33);
                    group.Appearance.Font = new Font(group.Appearance.Font, FontStyle.Bold);

                }
                else
                {
                    drModule = SlectModules[0];
                    drModule["Tag"] = "Y";
                    drModule[sys_Modules.ModuleNameRef] = v.ModuleName;
                    drModule[sys_Modules.ImgRef] = v.ModuleImg;

                    v.Sort = ConvertEx.ToInt(drModule[sys_Modules.Sort]);
                    //drModule.AcceptChanges();
                    v.Tag = drModule;
                    Ms.Add(v);
                }
            }
            Ms.Sort(new Comparison<Module>(new ModulesComparison().CompareASC));

            foreach (Module v in Ms)
            {
                group = LoadModule(v);
            }

            foreach (DataRow dr in dtModule.Select("ISNULL(Tag,'')=''"))
                dr.Delete();
            foreach (DataRow dr in dtModulesFunction.Select("ISNULL(Tag,'')=''"))
                dr.Delete();
            foreach (DataRow dr in dtModulesFunctionAuthority.Select("ISNULL(Tag,'')=''"))
                dr.Delete();

            UpdateModuleInfo();
            navBarControl1_GroupExpanded(null, null);
        }

        public class ModulesComparison
        {
            public int CompareASC(Module x, Module y)
            {
                if (x == null)
                {
                    if (y == null)
                        return 0;
                    else
                        return -1;
                }
                else
                {
                    if (y == null)
                    {
                        return 1;
                    }
                    else
                    {
                        return x.Sort.CompareTo(y.Sort);

                    }
                }
            }

            public int CompareDESC(Module x, Module y)
            {
                if (x == null)
                {
                    if (y == null)
                        return -1;
                    else
                        return 0;
                }
                else
                {
                    if (y == null)
                    {
                        return -1;
                    }
                    else
                    {
                        return y.Sort.CompareTo(x.Sort);
                    }
                }
            }
        }


        private NavBarGroup LoadModule(Module v)
        {
            var group = navBarControl1.Groups.Add();
            group.Caption = v.ModuleName;
            group.SmallImage = LoadUIImage.LoadNavBarImage_Group(v.ModuleImg);
            group.Tag = v.Tag;

            LoadFunction(group, v);
            return group;
        }
        private void LoadFunction(NavBarGroup group, Module v)
        {
            DataRow drFunction;
            foreach (ModuleFunction f in v.FunctionCollection)
            {
                var SlectFunctions = dtModulesFunction.Select(String.Format("{0}='{1}'", sys_ModulesFunction.FunctionID, f.FunctionID));
                bool IsNew = SlectFunctions.Length == 0;
                if (!IsNew)
                {
                    drFunction = SlectFunctions[0];
                    drFunction["Tag"] = "Y";
                    drFunction.AcceptChanges();
                }
                else
                {
                    drFunction = dtModulesFunction.Rows.Add();
                    drFunction["Tag"] = "Y";
                    drFunction[sys_ModulesFunction.FunctionID] = f.FunctionID;
                    drFunction[sys_ModulesFunction.FunctionName] = f.FunctionName;
                    drFunction[sys_ModulesFunction.ModuleID] = f.ModuleID;
                    drFunction[sys_ModulesFunction.ImgLarge] = f.FunctionPngLarge;
                    drFunction[sys_ModulesFunction.ImgSmall] = f.FunctionPngSmall;
                    drFunction[sys_ModulesFunction.GroupIndex] = -1;
                    drFunction[sys_ModulesFunction.ItemIndex] = -1;
                }
                drFunction[sys_ModulesFunction.FunctionNameRef] = f.FunctionName;
                drFunction[sys_ModulesFunction.ImgLargeRef] = f.FunctionPngLarge;
                drFunction[sys_ModulesFunction.ImgSmallRef] = f.FunctionPngSmall;


                //添加功能到navBarControl1
                NavBarItem item = navBarControl1.Items.Add();
                item.Caption = drFunction[sys_ModulesFunction.FunctionName].ToString();
                if (IsNew == true)
                {
                    item.Appearance.ForeColor = Color.FromArgb(0x99, 0x00, 0x33);
                    item.Appearance.Font = new Font(group.Appearance.Font, FontStyle.Bold);
                }
                item.SmallImage = LoadUIImage.LoadNavBarImage_Item(drFunction[sys_ModulesFunction.ImgSmall].ToString());
                item.Tag = drFunction;
                group.ItemLinks.Add(item);

                LoadFunctionAuthority(f);

            }
        }
        private void LoadFunctionAuthority(ModuleFunction f)
        {
            Dictionary<int, string> o = new Dictionary<int, string>();
            f.UserAuthority = FunctionAuthority.All;
            Form frm = f.LoadForm(null);
            if (frm is frmBaseChild)
            {
                (frm as frmBaseChild).InitialForm();
                o = (frm as frmBaseChild).AuthorityDisplay;
            }

            DataRow drAuthority;
            foreach (int key in o.Keys)
            {
                var drAuthoritys = dtModulesFunctionAuthority.Select(String.Format("{0}='{1}' AND {2}='{3}'",
                     sys_ModulesFunctionAuthority.FunctionID, f.FunctionID, sys_ModulesFunctionAuthority.AuthorityID, key));

                if (drAuthoritys.Length > 0)
                {
                    drAuthority = drAuthoritys[0];
                    drAuthority["Tag"] = "Y";
                    drAuthority.AcceptChanges();
                }
                else
                {
                    drAuthority = dtModulesFunctionAuthority.Rows.Add();
                    drAuthority["Tag"] = "Y";


                    drAuthority[sys_ModulesFunctionAuthority.FunctionID] = f.FunctionID;
                    drAuthority[sys_ModulesFunctionAuthority.AuthorityID] = key;
                    drAuthority[sys_ModulesFunctionAuthority.AuthorityName] = o[key];
                }
                //if (FunctionAuthorityCommon.APPROVAL.Equals(key))//审核不算权限
                //    drAuthority[sys_ModulesFunction.AppDoc] = "Y";

                drAuthority[sys_ModulesFunctionAuthority.AuthorityNameRef] = o[key];
            }
        }
        #region
        //刷新模块信息
        void navBarControl1_ActiveGroupChanged(object sender, NavBarGroupEventArgs e)
        {
            UpdateModuleInfo();
        }

        //设置模块名称
        void txt_ModuleName_TextChanged(object sender, EventArgs e)
        {
            if (navBarControl1.ActiveGroup == null) return;
            navBarControl1.ActiveGroup.Caption = txt_ModuleName.Text;

        }

        //刷新模块信息
        private void UpdateModuleInfo()
        {

            txt_ModuleName.Text = navBarControl1.ActiveGroup.Caption;
            txt_ModuleImage.Text = ConvertEx.ToString((navBarControl1.ActiveGroup.Tag as DataRow)[sys_Modules.Img]);
        }

        //恢复模块默认设置
        private void btn_ModuleRecover_Click(object sender, EventArgs e)
        {
            DataRow dr = navBarControl1.ActiveGroup.Tag as DataRow;
            dr[sys_Modules.ModuleName] = dr[sys_Modules.ModuleNameRef];
            dr[sys_Modules.Img] = dr[sys_Modules.ImgRef];
            txt_ModuleName.EditValue = dr[sys_Modules.ModuleName];
            txt_ModuleImage.EditValue = dr[sys_Modules.Img];

            navBarControl1.ActiveGroup.Caption = dr[sys_Modules.ModuleName].ToString();
            navBarControl1.ActiveGroup.SmallImage = LoadUIImage.LoadNavBarImage_Group(dr[sys_Modules.Img].ToString());
        }
        private void btn_FunctionRecover_Click(object sender, EventArgs e)
        {
            if (FocusButton == null) return;
            DataRow dr = (FocusButton.Tag as NavBarItem).Tag as DataRow;
            dr[sys_ModulesFunction.FunctionName] = dr[sys_ModulesFunction.FunctionNameRef];
            dr[sys_ModulesFunction.ImgLarge] = dr[sys_ModulesFunction.ImgLargeRef];
            dr[sys_ModulesFunction.ImgSmall] = dr[sys_ModulesFunction.ImgSmallRef];

            txt_FunName.EditValue = dr[sys_ModulesFunction.FunctionName];
            txt_FunImageLarge.EditValue = dr[sys_ModulesFunction.ImgLarge];
            txt_FunImgSmall.EditValue = dr[sys_ModulesFunction.ImgSmall];


            FocusButton.Text = dr[sys_ModulesFunction.FunctionName].ToString();
            FocusButton.Image = LoadUIImage.LoadFunctionButtonImg(dr[sys_ModulesFunction.ImgLarge].ToString());
            (FocusButton.Tag as NavBarItem).SmallImage = LoadUIImage.LoadNavBarImage_Item(dr[sys_ModulesFunction.ImgSmall].ToString());
        }

        //设置模块图标
        private void txt_ModuleImage_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (navBarControl1.ActiveGroup == null) return;
            var img = GetImage();
            if (!String.IsNullOrEmpty(img))
            {
                txt_ModuleImage.EditValue = img;
                (navBarControl1.ActiveGroup.Tag as DataRow)[sys_Modules.Img] = img;
                navBarControl1.ActiveGroup.SmallImage = LoadUIImage.LoadNavBarImage_Group(img);
            }
        }
        //上移模块
        private void btn_ModuleMoveUp_Click(object sender, EventArgs e)
        {
            int index = navBarControl1.Groups.IndexOf(navBarControl1.ActiveGroup);
            if (index == 0) return;
            (navBarControl1.Groups[index].Tag as DataRow)[sys_Modules.Sort] = index - 1;
            (navBarControl1.Groups[index - 1].Tag as DataRow)[sys_Modules.Sort] = index;
            navBarControl1.Groups.Move(index, index - 1);
        }
        //下移模块
        private void btn_ModuleMoveDown_Click(object sender, EventArgs e)
        {
            int index = navBarControl1.Groups.IndexOf(navBarControl1.ActiveGroup);
            if (index == navBarControl1.Groups.Count - 1) return;
            (navBarControl1.Groups[index].Tag as DataRow)[sys_Modules.Sort] = index + 1;
            (navBarControl1.Groups[index + 1].Tag as DataRow)[sys_Modules.Sort] = index;
            navBarControl1.Groups.Move(index, index + 1);

        }

        #endregion

        //模块展开，根据模块获取功能列表
        private void navBarControl1_GroupExpanded(object sender, NavBarGroupEventArgs e)
        {

            UpdateModule(navBarControl1.ActiveGroup);
        }

        public void UpdateModule(NavBarGroup group)
        {
            if (FocusButton != null)
            {
                FocusButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
                FocusButton.Appearance.Options.UseFont = true;
                FocusButton.ForeColor = Color.Empty;
            }
            FocusButton = null;


            //_GZTable.RemoveButton();

            _GZTable.ClearControl();

            this.SuspendLayout();

            if (group != null)
            {
                NavBarItem item;
                int RowIndex = 0, OrderID = 0;

                List<Control> lstAdd = new List<Control>();

                foreach (NavBarItemLink itemLink in group.VisibleItemLinks)
                {
                    item = itemLink.Item;
                    DataRow dr = item.Tag as DataRow;

                    RowIndex = ConvertEx.ToInt(dr[sys_ModulesFunction.GroupIndex]);
                    OrderID = ConvertEx.ToInt(dr[sys_ModulesFunction.ItemIndex]);



                    SimpleButton btn = new SimpleButton();
                    btn.Text = item.Caption;

                    btn.Appearance.Options.UseTextOptions = true;
                    btn.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    btn.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
                    btn.Image = ClothingPSISQLite.Library.MyClass.LoadUIImage.LoadFunctionButtonImg((item.Tag as DataRow)[sys_ModulesFunction.ImgLarge].ToString());
                    btn.Margin = new System.Windows.Forms.Padding(5);
                    btn.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
                    btn.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;

                    btn.Tag = item;

                    btn.GotFocus += btn_GotFocus;

                    if (dr.RowState == DataRowState.Added)
                    {
                        lstAdd.Add(btn);

                        btn.ForeColor = Color.FromArgb(0x99, 0x00, 0x33);
                        btn.Font = new Font(btn.Font, FontStyle.Bold);

                        continue;
                    }

                    _GZTable.SetControl(RowIndex, OrderID, btn);
                }
                if (lstAdd.Count > 0)
                {
                    for (int i = 0; i < _GZTable.GT.RowCount; i++)
                    {
                        for (int j = 0; j < _GZTable.GT.CellCount; j++)
                        {
                            if (_GZTable.GT[i][j].IsUsed == false)
                            {
                                _GZTable.SetControl(i, j, lstAdd[0]);
                                DataRow dr = (lstAdd[0].Tag as NavBarItem).Tag as DataRow;
                                dr[sys_ModulesFunction.GroupIndex] = i;
                                dr[sys_ModulesFunction.ItemIndex] = j;
                                lstAdd.RemoveAt(0);
                            }
                            if (lstAdd.Count == 0) break;
                        }
                        if (lstAdd.Count == 0) break;
                    }
                }
            }
            this.Activate();
            this.ResumeLayout();
        }


        SimpleButton _focusbutton;
        SimpleButton FocusButton
        {
            get
            {
                return _focusbutton;
            }
            set
            {
                _focusbutton = value;
                if (_focusbutton != null)
                {
                    DataRow dr = (FocusButton.Tag as NavBarItem).Tag as DataRow;
                    txt_FunName.Text = dr[sys_ModulesFunction.FunctionName].ToString();
                    txt_FunImgSmall.Text = dr[sys_ModulesFunction.ImgSmall].ToString();
                    txt_FunImageLarge.Text = dr[sys_ModulesFunction.ImgLarge].ToString();
                    dtModulesFunctionAuthority.DefaultView.RowFilter = String.Format("{0}='{1}'", sys_ModulesFunctionAuthority.FunctionID, dr[sys_ModulesFunction.FunctionID]);
                    //gc_Authority.DataSource = dtModulesFunctionAuthority;
                }
                else
                {
                    txt_FunName.Text = "";
                    txt_FunImgSmall.Text = "";
                    txt_FunImageLarge.Text = "";
                    dtModulesFunctionAuthority.DefaultView.RowFilter = "1=2";
                }
                txt_FunName.Properties.ReadOnly = txt_FunImgSmall.Properties.ReadOnly = txt_FunImageLarge.Properties.ReadOnly = _focusbutton == null;
                gc_Authority.Enabled = _focusbutton != null;
            }
        }

        //选中要编辑的功能
        void btn_GotFocus(object sender, EventArgs e)
        {
            if (FocusButton != null)
            {
                if (((FocusButton.Tag as NavBarItem).Tag as DataRow).RowState == DataRowState.Added)
                {
                    FocusButton.Appearance.Font = new Font(FocusButton.Font, FontStyle.Bold);
                    FocusButton.Appearance.Options.UseFont = true;
                    FocusButton.ForeColor = Color.FromArgb(0x99, 0x00, 0x33);
                }
                else
                {
                    FocusButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
                    FocusButton.Appearance.Options.UseFont = true;
                    FocusButton.ForeColor = Color.Empty;
                }
            }
            FocusButton = sender as SimpleButton;

            FocusButton.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            FocusButton.Appearance.Options.UseFont = true;
            FocusButton.ForeColor = Color.Green;

            //UpdateFunInfo();
        }

        //设置功能名称
        private void txt_FunName_TextChanged(object sender, EventArgs e)
        {
            if (FocusButton == null) return;
            FocusButton.Text = txt_FunName.Text;
            (FocusButton.Tag as NavBarItem).Caption = txt_FunName.Text;
            ((FocusButton.Tag as NavBarItem).Tag as DataRow)[sys_ModulesFunction.FunctionName] = txt_FunName.Text;
        }
        //设置功能大图标
        private void txt_FunImageLarge_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (FocusButton == null) return;
            var img = GetImage();
            if (!String.IsNullOrEmpty(img))
            {
                ((FocusButton.Tag as NavBarItem).Tag as DataRow)[sys_ModulesFunction.ImgLarge] = img;
                FocusButton.Image = LoadUIImage.LoadFunctionButtonImg(img);
            }
        }
        //设置功能小图标
        private void txt_FunImgSmall_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (FocusButton == null) return;
            var img = GetImage();
            if (!String.IsNullOrEmpty(img))
            {
                ((FocusButton.Tag as NavBarItem).Tag as DataRow)[sys_ModulesFunction.ImgSmall] = img;
                (FocusButton.Tag as NavBarItem).SmallImage = LoadUIImage.LoadNavBarImage_Item(img);
            }
        }

        #region Tools
        //获得图标
        private string GetImage()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Title = "图标选择";
            of.Filter = "png|*.png";
            of.InitialDirectory = Globals.BaseDirectory;
            if (of.ShowDialog() == DialogResult.OK)
                return of.FileName.Replace(Globals.BaseDirectory + "\\", "");
            else
                return "";
        }
        #endregion

        protected override void DoSave(object sender)
        {
            try
            {
                bll.Update(Data);
                Data.AcceptChanges();
                Msg.ShowInformation("保存成功！");
            }
            catch (Exception ex)
            {
            }
        }

    }
}
