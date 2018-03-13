using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraNavBar;
using DevExpress.XtraTab;
using GZFramework.UI.Dev;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using DevExpress.XtraBars.Ribbon;
using System.Drawing;
using DevExpress.XtraTabbedMdi;
using GZFramework.UI.Dev.Common;
using GZFrameworkDemo.Library;
using GZFrameworkDemo.Business;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.MyClass;
using GZFrameworkDemo.Models;
using GZFrameworkDemo.Library.ModuleProvider;
using GZFramework.UI.Dev.LibForm;
using GZFramework.UI.Dev.Module;
using GZFramework.UI.Core;
using GZFramework.UI.Core.Module;

namespace GZFrameworkDemo.Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm, IMain
    {
        XtraTabbedMdiManagerPageColor PageHeadColor;

        bllModules bll;

        public frmMain()
        {
            InitializeComponent();
            ribbonControl1.ShowPageHeadersMode = ShowPageHeadersMode.Hide;
            UpdateMainUI();
            string title = INISystemConfig.GetTitle();
            if (!String.IsNullOrEmpty(title))
            {
                this.Text = title;
            }
            PageHeadColor = new XtraTabbedMdiManagerPageColor();

            bll = new bllModules();


            MDIPageOption();
            if (INISystemConfig.GetWindowState() == "Y")
                this.WindowState = FormWindowState.Maximized;

            new GZFramework.UI.Dev.RibbonButton.RibbonLoad(rpage_Option, rpg_Function, rpg_DataNav);

            //设置皮肤
            SkinTools.InitSkinAStyleGallery(ribbonGalleryBarItem1, ribbonControl1, barItem_RbStyle);

            this.FormClosing += frmMain_FormClosing;


        }


        void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                INISystemConfig.SetWindowState("Y");
            else
                INISystemConfig.SetWindowState("");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GZFramework.UI.Dev.SplashScreenServer.CloseForm();//跳转窗体
        }
        ModuleObserver ModulesOb;
        private void frmMain_Load(object sender, EventArgs e)
        {

            ModulesOb = new ModuleObserver(navBarControl1);
            ModulesOb.SowModule += SowModule;

            frmLogin frm = new frmLogin();
            frm.MdiParent = this;
            frm.ControlBox = false;
            frm.WindowState = FormWindowState.Maximized;
            frm.LoginSuccess += frm_LoginSuccess;
            frm.Show();
            return;
        }



        //设置用户配置
        void MDIPageOption()
        {
            cmb_PageImagePosition.Items.AddEnum(typeof(TabPageImagePosition));
            cmb_ClosePageButton.Items.AddEnum(typeof(ClosePageButtonShowMode));
            cmb_HeaderLocation.Items.AddEnum(typeof(TabHeaderLocation));
            cmb_HeaderOrientation.Items.AddEnum(typeof(TabOrientation));

            bei_PageImagePosition.Tag = "TabPageImagePosition";
            bei_ClosePageButton.Tag = "ClosePageButtonShowMode";
            bei_HeaderLocation.Tag = "TabHeaderLocation";
            bei_HeaderOrientation.Tag = "TabOrientation";

            //绑定值改变事件
            bei_PageImagePosition.EditValueChanged += MDIPageOptionEmun_EditValueChanged;
            bei_ClosePageButton.EditValueChanged += MDIPageOptionEmun_EditValueChanged;
            bei_HeaderLocation.EditValueChanged += MDIPageOptionEmun_EditValueChanged;
            bei_HeaderOrientation.EditValueChanged += MDIPageOptionEmun_EditValueChanged;



            string val = "";

            val = INISystemConfig.GetTabPageImagePosition();
            if (val != "")
                bei_PageImagePosition.EditValue = (TabPageImagePosition)Enum.Parse(typeof(TabPageImagePosition), val);

            val = INISystemConfig.GetTabClosePageButton();
            if (val != "")
                bei_ClosePageButton.EditValue = (ClosePageButtonShowMode)Enum.Parse(typeof(ClosePageButtonShowMode), val);

            val = INISystemConfig.GetTabHeaderLocation();
            if (val != "")
                bei_HeaderLocation.EditValue = (TabHeaderLocation)Enum.Parse(typeof(TabHeaderLocation), val);

            val = INISystemConfig.GetTabHeaderOrientation();
            if (val != "")
                bei_HeaderOrientation.EditValue = (TabOrientation)Enum.Parse(typeof(TabOrientation), val);




            chk_FlatOnDoubleClick.CheckedChanged += MDIPageOptionBool_EditValueChanged;
            chk_FloatOnDrag.CheckedChanged += MDIPageOptionBool_EditValueChanged;
            chk_Colored.CheckedChanged += MDIPageOptionBool_EditValueChanged;
            chk_HeaderAutoFill.CheckedChanged += MDIPageOptionBool_EditValueChanged;

            chk_FlatOnDoubleClick.Tag = "TabFloatOnDoubleClick";
            chk_FloatOnDrag.Tag = "TabFloatOnDrag";
            chk_Colored.Tag = "TabColored";
            chk_HeaderAutoFill.Tag = "TabHeaderAutoFill";


            chk_FlatOnDoubleClick.Checked = INISystemConfig.GetTabFloatOnDoubleClick();
            chk_FloatOnDrag.Checked = INISystemConfig.GetTabFloatOnDrag();
            chk_Colored.Checked = INISystemConfig.GetTabColored();
            chk_HeaderAutoFill.Checked = INISystemConfig.GetTabHeaderAutoFill();



        }
        /*
         // 设置当前 tab页的 图标,我这里也默认取navBar中的Item中的图标
            xtraTabbedMdiManager1.Pages[frm].Image = Image.FromHbitmap(frm.Icon.ToBitmap().GetHbitmap());
             */

        private void MDIPageOptionEmun_EditValueChanged(object sender, EventArgs e)
        {
            BarEditItem bei = (sender as BarEditItem);
            string text = "";
            string tag = ConvertLib.ToString(bei.Tag);

            switch (tag)
            {
                case "TabPageImagePosition":
                    {
                        text = ((TabPageImagePosition)bei.EditValue).ToString();
                        xtraTabbedMdiManager1.PageImagePosition = (TabPageImagePosition)bei.EditValue;
                    }; break;
                case "ClosePageButtonShowMode":
                    {
                        text = ((ClosePageButtonShowMode)bei.EditValue).ToString();
                        xtraTabbedMdiManager1.ClosePageButtonShowMode = (ClosePageButtonShowMode)bei.EditValue;
                    }; break;
                case "TabHeaderLocation":
                    {
                        text = ((TabHeaderLocation)bei.EditValue).ToString();
                        xtraTabbedMdiManager1.HeaderLocation = (TabHeaderLocation)bei.EditValue;
                    }; break;
                case "TabOrientation":
                    {
                        text = ((TabOrientation)bei.EditValue).ToString();
                        xtraTabbedMdiManager1.HeaderOrientation = (TabOrientation)bei.EditValue;
                    }; break;
            }



            INISystemConfig.SetTabStrValue(tag, text);

        }



        private void MDIPageOptionBool_EditValueChanged(object sender, ItemClickEventArgs e)
        {
            BarCheckItem bci = (sender as BarCheckItem);
            bool check = bci.Checked;
            string tag = ConvertLib.ToString(bci.Tag);



            DefaultBoolean boolean = check == true ? DefaultBoolean.True : DefaultBoolean.False;
            switch (tag)
            {
                case "TabFloatOnDoubleClick":
                    {
                        xtraTabbedMdiManager1.FloatOnDoubleClick = boolean;
                    }; break;
                case "TabFloatOnDrag":
                    {
                        xtraTabbedMdiManager1.FloatOnDrag = boolean;
                    }; break;
                case "TabColored":
                    {
                        if (check)
                            PageHeadColor.BoundChildPagesBackColor(xtraTabbedMdiManager1);
                        else
                            PageHeadColor.UnBoundChildPagesBackColor(xtraTabbedMdiManager1);
                    }; break;
                case "TabHeaderAutoFill":
                    {
                        xtraTabbedMdiManager1.HeaderAutoFill = boolean;
                    }; break;
            }

            INISystemConfig.SetTabStrValue(tag, check);
        }


        private bool _islogin = false;
        private bool _islock = false;


        #region 锁定和登出以及清空缓存
        public bool IsLogin
        {
            get
            {
                return _islogin;
            }
            set
            {
                _islogin = value;
                UpdateMainUI();
                if (value == false)
                {
                    navBarControl1.Groups.Clear();
                    navBarControl1.Items.Clear();
                    bsi_Modules.ClearLinks();

                    List<Form> frms = new List<Form>();
                    foreach (XtraMdiTabPage v in xtraTabbedMdiManager1.Pages)
                    {
                        if (!frms.Contains(v.MdiChild))
                            frms.Add(v.MdiChild);
                    }
                    foreach (Form f in xtraTabbedMdiManager1.FloatForms)
                    {
                        if (!frms.Contains(f))
                            frms.Add(f);
                    }
                    for (int i = frms.Count - 1; i >= 0; i--)
                    {
                        frms[i].Close();
                    }


                    xtraTabbedMdiManager1.FloatForms.Clear();
                    xtraTabbedMdiManager1.Pages.Clear();



                    //清空缓存
                    DataCache.Cache.RefreshCacheAll();
                    this.SuspendLayout();
                    frmLogin frm = new frmLogin();
                    frm.MdiParent = this;
                    frm.ControlBox = false;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.LoginSuccess += frm_LoginSuccess;
                    frm.Show();
                    this.ResumeLayout();
                    GC.Collect();
                }
            }
        }
        void frm_LoginSuccess(object sender, EventArgs e)
        {
            //是否有新通知
            bool NewNotice = false;
            if (NewNotice == true)
            {
                btn_Notice.Caption = "<backcolor='red'><color='white'>你有新通知</color></backcolor>";
                btn_Notice.Visibility = BarItemVisibility.Always;
            }
            else
            {
                btn_Notice.Caption = "通知";
                btn_Notice.Visibility = BarItemVisibility.Never;
            }

            bbi_CurrentAccound.Caption = String.Format("当前用户：<color='red'>{0}</color>", Loginer.CurrentLoginer.UserName);

            this.SuspendLayout();
            navBarControl1.BeginInit();

            RefreshModule();

            IsLogin = true;

            if (navBarControl1.ActiveGroup != null)
                SowModule(navBarControl1.ActiveGroup);

            navBarControl1.EndInit();
            this.ResumeLayout();
        }
        public bool IsLock
        {
            get
            {
                return _islock;
            }
            set
            {
                _islock = value;
                UpdateMainUI();

                if (value == true)
                {
                    frmLock frm = new frmLock();
                    frm.MdiParent = this;
                    frm.ControlBox = false;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.VerifySuccess += frm_VerifySuccess;
                    frm.Show();
                    GC.Collect();
                }
            }
        }

        void frm_VerifySuccess(object sender, EventArgs e)
        {
            IsLock = false;
            WaiteServer.CloseWaite();
        }

        void UpdateMainUI()
        {
            bool IsShow = _islogin && (!_islock);
            if (IsShow) ShowUI();
            else HideUI();

        }
        //隐藏Ribbon，Navbar，以及导航，锁定
        private void HideUI()
        {
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Hidden;
            dock_Left.Visible = false;
            ribbonStatusBar1.Visible = false;
            foreach (Form f in xtraTabbedMdiManager1.FloatForms)
                f.Visible = false;

            foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            {
                page.MdiChild.Visible = false;
            }

            ribbonControl1.Enabled = false;


        }

        //显示Ribbon，Navbar，以及导航，接触锁定
        private void ShowUI()
        {


            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible;
            dock_Left.Visible = true;
            ribbonStatusBar1.Visible = true;
            foreach (Form f in xtraTabbedMdiManager1.FloatForms)
                f.Visible = true;

            foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            {
                page.MdiChild.Visible = true;
            }

            ribbonControl1.Enabled = true;

        }
        //登出
        private void barbtn_Exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            IsLogin = false;
        }
        //锁定离开
        private void bbi_Lock_ItemClick(object sender, ItemClickEventArgs e)
        {
            IsLock = true;
        }
        //清空缓存
        private void btn_ClearDataCatch_ItemClick(object sender, ItemClickEventArgs e)
        {
            DataCache.Cache.RefreshCacheAll();
            Msg.ShowInformation("清空缓存成功！");
        }

        #endregion


        public void RefreshModule()
        {
            List<ModuleModel> lstModule = LoadModuleHelper.Intance.GetModule();
            LoadModule(lstModule);
        }

        private void LoadModule(List<ModuleModel> lstModule)
        {
            NavBarGroup CurrentGroup;
            BarSubItem CurrentBarItem;

            foreach (ModuleModel m in lstModule)
            {

                #region 加载模块
                LoadModule(m, out CurrentGroup, out CurrentBarItem);
                #endregion 加载模块
                foreach (ModuleFunction fun in m.functions)
                {
                    LoadModuleFunction(CurrentGroup, CurrentBarItem, fun);
                }

            }
        }

        //加载模块功能
        private void LoadModuleFunction(NavBarGroup CurrentGroup, BarSubItem CurrentBarItem, ModuleFunction fun)
        {
            if (CurrentGroup != null)
            {
                //添加功能到navBarControl1
                NavBarItem item = navBarControl1.Items.Add();
                item.Caption = fun.Caption;
                item.Tag = fun.FunctionID;
                //item.SmallImage = FunSmallImage;
                item.SmallImage = imageList1.Images["Forward"];

                item.LinkClicked += item_LinkClicked;

                CurrentGroup.ItemLinks.Insert(0, item);

                if (fun.IsNew)
                {
                    item.Appearance.ForeColor = Color.FromArgb(0x99, 0x00, 0x33);
                    item.Appearance.Font = new Font(CurrentGroup.Appearance.Font, FontStyle.Bold);
                }

            }
            if (CurrentBarItem != null)
            {
                //添加功能到bbi_Module
                var bbif = new DevExpress.XtraBars.BarButtonItem()
                {
                    Caption = fun.Caption,
                    Tag = fun.FunctionID,
                    //Glyph = FunSmallImage
                    Glyph = imageList1.Images["Forward"]
                };
                //if (fun.IsNew)
                //{
                //    item.Appearance.ForeColor = Color.FromArgb(0x99, 0x00, 0x33);
                //    item.Appearance.Font = new Font(CurrentGroup.Appearance.Font, FontStyle.Bold);
                //}

                bbif.ItemClick += bbi_ItemClick;
                this.ribbonControl1.Items.Add(bbif);
                if (CurrentBarItem.ItemLinks.Count > 0)
                    CurrentBarItem.InsertItem(CurrentBarItem.ItemLinks[0], bbif);
                else
                    CurrentBarItem.AddItem(bbif);
            }
        }
        //加载功能
        private void LoadModule(ModuleModel m, out NavBarGroup CurrentGroup, out BarSubItem CurrentBarItem)
        {
            var ModuleImage = LoadUIImage.LoadNavBarImage_Group(ConvertLib.ToString(m.ModuleImg));

            //添加模块到navBarControl1

            //m.ModuleName = "(新)" + m.ModuleName;
            //LoadModule(hp, dtModulesFun, m);
            //hp.CurrentGroup.Appearance.ForeColor = Color.FromArgb(0x99, 0x00, 0x33);
            //hp.CurrentGroup.Appearance.Font = new Font(hp.CurrentGroup.Appearance.Font, FontStyle.Bold);

            CurrentGroup = new NavBarGroup()
            {
                Caption = m.Caption,
                SmallImage = ModuleImage,
                Tag = m
            };
            navBarControl1.Groups.Add(CurrentGroup);


            //添加模块到bbi_Module
            CurrentBarItem = new BarSubItem()
            {
                Caption = m.Caption,
                Glyph = ModuleImage
            };
            if (m.IsNew)
            {
                CurrentGroup.Appearance.ForeColor = Color.FromArgb(0x99, 0x00, 0x33);
                CurrentGroup.Appearance.Font = new Font(CurrentGroup.Appearance.Font, FontStyle.Bold);
            }

            ribbonControl1.Items.Add(CurrentBarItem);
            bsi_Modules.AddItem(CurrentBarItem);
        }

        private void bbi_ItemClick(object sender, ItemClickEventArgs e)
        {
            string fun = ConvertLib.ToString(e.Item.Tag);
            ShowChildForm(fun);
        }

        private void item_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            string fun = ConvertLib.ToString(e.Link.Item.Tag);
            ShowChildForm(fun);
        }

        public Form ShowChildForm(string functionID)
        {
            var fun = LoadModuleHelper.Intance.FindFunctionByFunctionID(functionID);
            if (fun != null)
            {
                WaiteServer.ShowWaite(this);
                Form frm = fun.LoadForm(this);
                frm.Text = fun.FunctionName;
                //frm.Icon = LoadUIImage.LoadFormIcon(fun.FunctionPngSmall);
                frm.Show();
                frm.Activate();
                // 设置当前 tab页的 图标,我这里也默认取navBar中的Item中的图标
                xtraTabbedMdiManager1.Pages[frm].Image = Image.FromHbitmap(frm.Icon.ToBitmap().GetHbitmap());
                WaiteServer.CloseWaite();
                return frm;
            }
            else
                return null;
        }

        public void SowModule(NavBarGroup group)
        {
            ModuleModel m = (ModuleModel)group.Tag;
            if (m == null) return;
            Form frm = m.LoadForm(this);
            if (frm == null) return;
            frm.Show();
            frm.Activate();
            //xtraTabbedMdiManager1.Pages[frm].Image = Image.FromHbitmap(frm.Icon.ToBitmap().GetHbitmap());
            //UpdateMdiPictureFormPreview(xtraTabbedMdiManager1.Pages[frm], Image.FromHbitmap(frm.Icon.ToBitmap().GetHbitmap()));
        }

        void UpdateMdiPictureFormPreview(XtraMdiTabPage page, Image img)
        {
            if (page == null)
                return;
            Image preview = null;
            const int previewHeight = 32;
            const int previewWidthMax = 64;
            //int previewHeight = this.imageList3.ImageSize.Height;
            if (img != null && img.Height > 0 && previewHeight > 0)
            {
                int previewWidth = previewHeight * img.Width / img.Height;
                if (previewWidth > 0)
                {
                    if (previewWidth > previewWidthMax)
                        previewWidth = previewWidthMax;
                    preview = new Bitmap(img, previewWidth, previewHeight);
                }
            }
            page.Image = preview;
        }

        private void bci_FullScreen_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (bci_FullScreen.Checked)
            {
                this.dock_Left.Hide();
                navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
            }
            else
            {
                this.dock_Left.Show();
                navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Expanded;
            }
        }
        //关闭窗体
        private void bbi_Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = xtraTabbedMdiManager1.SelectedPage.MdiChild;
            //if (frm is frmModuleView) return;
            //else
            frm.Close();
        }


        private void xtraTabbedMdiManager1_BeginFloating(object sender, DevExpress.XtraTabbedMdi.FloatingCancelEventArgs e)
        {
            if (e.ChildForm is frmModuleMainBase)
                e.Cancel = true;
            e.ChildForm.StartPosition = FormStartPosition.CenterScreen;
        }


        public RibbonControl MainRibbonControl
        {
            get
            {
                return this.ribbonControl1;
            }
        }

        //通知
        private void btn_Notice_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNotice.ShowForm(this);
        }

        private void btn_FrameworkSetting_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbonControl1.SelectedPage = rpage_Setting;
        }

        private void btn_Retrurn_ItemClick(object sender, ItemClickEventArgs e)
        {
            ribbonControl1.SelectedPage = rpage_Option;
        }
    }
}
