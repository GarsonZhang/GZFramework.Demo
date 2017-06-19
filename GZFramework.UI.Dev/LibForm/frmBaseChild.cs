using DevExpress.XtraBars;
using GZFramework.UI.Core;
using GZFramework.UI.Core.RibbonButton;
using GZFramework.UI.Dev.RibbonButton;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.LibForm
{
    public partial class frmBaseChild : GZFramework.UI.Dev.LibForm.frmBase, Core.Module.IFunction
    {
        private RibbonControlGenerate gen;
        protected RibbonBarButtonCollection _Buttons;
        /// <summary>
        /// 用户权限
        /// </summary>
        public int UserAuthority
        {
            get;
            set;
        }

        /// <summary>
        /// 根据名称获得按钮对象
        /// </summary>
        /// <param name="btnName">GZFramework.UI.Core.RibbonButton.RibbonCommonButtons.CommonButtons.btnADD.name</param>
        /// <returns></returns>
        private BarItemLink GetButtonByName(string btnName)
        {
            return _Buttons.GetButtonByName(btnName);
        }

        protected void SetButtonCaption(string btnName, string NewCaption)
        {
            GetButtonByName(btnName).Caption = NewCaption;
        }


        protected virtual int CustomerAuthority { get; }

        /// <summary>
        /// 当前窗体权限
        /// </summary>
        protected int CurrentAuthorityEx
        {
            get
            {
                return CustomerAuthority | FunctionAuthorityCommon.FVIEW;
            }
        }



        public frmBaseChild()
        {
            InitializeComponent();
            if (CheckDesingModel.IsDesingMode) return;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            _Buttons = new RibbonBarButtonCollection();
            this.Load += frmChildBase_Load;
            AuthorityAdd(null, FunctionAuthorityCommon.FVIEW, "查看");
        }

        /// <summary>
        /// 初始化窗体
        /// </summary>
        public void InitialForm()
        {

            if (CheckDesingModel.IsDesingMode) return;

            this.SuspendLayout();//挂起布局

            gen = new RibbonControlGenerate(this);
            IniButton();//初始化按钮

            this.ResumeLayout();//恢复布局


            this.FormClosed += frmChildBase_FormClosed;

        }

        void frmChildBase_Load(object sender, EventArgs e)
        {
            if (CheckDesingModel.IsDesingMode) return;
            InitialForm();
            this.WindowState = FormWindowState.Maximized;
            this.AuthorityInitial();//初始化权限


        }

        void frmChildBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            gen.Dispose();
        }

        /// <summary>
        /// 初始化按钮
        /// </summary>
        public virtual void IniButton()
        {

        }

        public Dictionary<int, string> AuthorityDisplay = new Dictionary<int, string>();
        public Dictionary<int, Object> AuthorityRelation = new Dictionary<int, Object>();

        public Dictionary<string, Object> BarButtons = new Dictionary<string, Object>();

        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="Control">权限对应的按钮，比如保存按钮</param>
        /// <param name="Authority">权限值,FunctionAuthority</param>
        /// <param name="AuthorityName">权限名称</param>
        protected void AuthorityAdd(object Obj, int Authority, string AuthorityName)
        {
            if (AuthorityDisplay.ContainsKey(Authority) == false)
                AuthorityDisplay.Add(Authority, AuthorityName);

            if (Obj != null && AuthorityRelation.ContainsKey(Authority) == false)
            {
                Obj.GetType().GetProperty("Tag").SetValue(Obj, Authority, null);
                AuthorityRelation.Add(Authority, Obj);
            }
        }



        /// <summary>
        /// 添加操作按钮
        /// </summary>
        /// <param name="Caption">操作按钮名称</param>
        /// <param name="ImgName">操作按钮图片</param>
        /// <param name="Authority">操作对应的权限</param>
        /// <param name="AuthorityName">操作对应的权限名称，当为空时取Caption</param>
        private BarItem AddButton(RibbonItemButtonBase btn, int Authority, string AuthorityName = null)
        {
            if (String.IsNullOrEmpty(AuthorityName))
                AuthorityName = btn.Caption;
            BarItemLink bilink = gen.AddBarItem(btn.name, btn.Caption, btn.LoadImage);
            BarItem bi = bilink.Item;

            _Buttons.AddBtn(bilink);

            if (btn.Shortcut != Keys.None)
                bi.ItemShortcut = new DevExpress.XtraBars.BarShortcut(btn.Shortcut);
            if (Authority > 0)
                this.AuthorityAdd(bi, Authority, AuthorityName);

            return bi;
        }

        /// <summary>
        /// 插入操作按钮，
        /// </summary>
        /// <param name="ReferButtonName">参照按钮</param>
        /// <param name="Before">在操作按钮前插入还是在操作按钮后插入，默认在之前插入True</param>
        /// <param name="btn">按钮类</param>
        /// <param name="Authority">权限值</param>
        /// <param name="AuthorityName">权限名称，如果为空权限名称==按钮显示名称</param>
        /// <returns></returns>
        private BarItem InsertButton(string ReferButtonName, bool Before, RibbonItemButtonBase btn, int Authority, string AuthorityName = null)
        {
            BarItemLink Refer = GetButtonByName(ReferButtonName);

            if (String.IsNullOrEmpty(AuthorityName))
                AuthorityName = btn.Caption;
            BarItemLink bilink = gen.InsertBarItem(btn.name, btn.Caption, btn.LoadImage, Refer, Before);
            BarItem bi = bilink.Item;
            _Buttons.AddBtn(bilink);

            //if (btn.Shortcut != null && btn.Shortcut != Keys.None)
            if (btn.Shortcut != Keys.None)
                bi.ItemShortcut = new DevExpress.XtraBars.BarShortcut(btn.Shortcut);
            if (Authority > 0)
                this.AuthorityAdd(bi, Authority, AuthorityName);

            return bi;
        }





        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="btn">按钮对象</param>
        /// <param name="Authority">权限，默认0</param>
        /// <param name="AuthorityName">权限名称</param>
        /// <param name="DoClick">事件绑定</param>
        protected void AddButton(RibbonItemButtonBase btn, int Authority, string AuthorityName, ItemClickEventHandler DoClick)
        {
            var bi = AddButton(btn, Authority, AuthorityName);
            bi.ItemClick += DoClick;
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="btn">按钮对象</param>
        /// <param name="Authority">权限，默认0</param>
        /// <param name="DoClick">事件绑定</param>
        protected void AddButton(RibbonItemButtonBase btn, int Authority, ItemClickEventHandler DoClick)
        {
            var bi = AddButton(btn, Authority, "");
            bi.ItemClick += DoClick;
        }


        protected void InsertBeforeButton(string ReferButtonName, RibbonItemButtonBase btn, int Authority, string AuthorityName, ItemClickEventHandler DoClick)
        {
            var bi = InsertButton(ReferButtonName, true, btn, Authority, AuthorityName);
            bi.ItemClick += DoClick;
        }
        protected void InsertAfterButton(string ReferButtonName, RibbonItemButtonBase btn, int Authority, string AuthorityName, ItemClickEventHandler DoClick)
        {
            var bi = InsertButton(ReferButtonName, false, btn, Authority, AuthorityName);
            bi.ItemClick += DoClick;
        }



        protected BarItem AddNavButton(Core.RibbonButton.RibbonItemButtonBase btn)
        {
            BarItemLink bilink = gen.AddNavBarItem(btn.name, btn.Caption, btn.LoadImage, btn.BeginGroup);
            BarItem bi = bilink.Item;
            _Buttons.AddBtn(bilink);

            if (btn.Shortcut != Keys.None)
                bi.ItemShortcut = new DevExpress.XtraBars.BarShortcut(btn.Shortcut);

            return bi;
        }



        /// <summary>
        /// 设置按钮可用状态
        /// </summary>
        /// <param name="btnName"></param>
        /// <param name="sEnabled"></param>
        protected void SetButtonEnabled(string btnName, bool sEnabled)
        {
            BarItemLink bi = _Buttons.GetButtonByName(btnName);
            if (bi != null)
                bi.Item.Enabled = sEnabled;
        }

        /// <summary>
        /// 设置按钮可见状态
        /// </summary>
        /// <param name="btnName"></param>
        /// <param name="sEnabled"></param>
        protected void SetButtonVisible(string btnName, bool sVisible)
        {
            BarItemLink bi = _Buttons.GetButtonByName(btnName);
            if (bi != null)
                bi.Item.Visibility = sVisible == true ? BarItemVisibility.Always : BarItemVisibility.Never;
        }

        /// <summary>
        /// 判断用户是否拥有权限
        /// </summary>
        /// <param name="Authority"></param>
        /// <returns></returns>
        protected bool AuthorityExist(int Authority)
        {
            return (UserAuthority & Authority) == Authority;
        }
        /// <summary>
        /// 初始化权限控件
        /// </summary>
        protected virtual void AuthorityInitial()
        {

            int CAuthority = 0;
            bool Exist = false;
            foreach (int key in AuthorityRelation.Keys)
            {
                if (int.TryParse(AuthorityRelation[key].GetType().GetProperty("Tag").GetValue(AuthorityRelation[key], null).ToString(), out CAuthority))
                {
                    Exist = AuthorityExist(CAuthority);

                    if (AuthorityRelation[key] is Control)
                        (AuthorityRelation[key] as Control).Visible = Exist;
                    if (AuthorityRelation[key] is BarItem)
                        (AuthorityRelation[key] as BarItem).Visibility = Exist == true ? BarItemVisibility.Always : BarItemVisibility.Never;
                }
            }
        }

        public Form ShowChildForm(string functionID)
        {
            if (this.ParentForm == null)
                return null;
            var main = this.ParentForm as IMain;
            return main.ShowChildForm(functionID);
        }

        public Form ShowChildForm(Type function)
        {
            return ShowChildForm(function.FullName);
        }
    }




}
