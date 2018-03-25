namespace GZFrameworkDemo.SystemManagement
{
    partial class frmMyUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMyUser));
            this.txtAccount = new DevExpress.XtraEditors.TextEdit();
            this.LC_Edit = new DevExpress.XtraLayout.LayoutControl();
            this.txxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtLastUpdateDate = new DevExpress.XtraEditors.DateEdit();
            this.txtCreateDate = new DevExpress.XtraEditors.DateEdit();
            this.txtIsSysLock = new DevExpress.XtraEditors.CheckEdit();
            this.txtIsSysAdmain = new DevExpress.XtraEditors.CheckEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateUser = new DevExpress.XtraEditors.LookUpEdit();
            this.txtLastUpdateUser = new DevExpress.XtraEditors.LookUpEdit();
            this.LCGroup_Edit = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LCItem_UserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItem_Account = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItem_IsAdmain = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItem_IsLock = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItem_Password = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItem_Phone = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItem_Email = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItem_CreateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItem_CreateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItem_LastUpdateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItem_LastUpdateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txts_Account = new DevExpress.XtraEditors.TextEdit();
            this.LC_Search = new DevExpress.XtraLayout.LayoutControl();
            this.txts_Email = new DevExpress.XtraEditors.TextEdit();
            this.txts_Phone = new DevExpress.XtraEditors.TextEdit();
            this.txts_UserName = new DevExpress.XtraEditors.TextEdit();
            this.LCGroup_Search = new DevExpress.XtraLayout.LayoutControlGroup();
            this.LCItems_Account = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItems_Email = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItems_UserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.LCItems_Phone = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_IsAdmain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gc_IsLock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_CreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_UserName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gc_CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_LastUpdateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_LastUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMainData = new DevExpress.XtraGrid.GridControl();
            this.gvMainData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gc_Detail = new DevExpress.XtraGrid.GridControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gv_Detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_RoleName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.tree_ModuleEx = new GZFrameworkDemo.Library.MyControl.ucModuleTreeList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gc_DBList = new DevExpress.XtraGrid.GridControl();
            this.gv_DBList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_DBList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.pan_Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tp_Search.SuspendLayout();
            this.tp_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).BeginInit();
            this.tc_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Edit)).BeginInit();
            this.LC_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txxtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsSysLock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsSysAdmain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_IsAdmain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_IsLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_Password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_Phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_CreateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_CreateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_LastUpdateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_LastUpdateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Account.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Search)).BeginInit();
            this.LC_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItems_Account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItems_Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItems_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItems_Phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_UserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_RoleName)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tree_ModuleEx)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DBList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DBList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_DBList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Summary
            // 
            this.pan_Summary.Controls.Add(this.panel1);
            this.pan_Summary.Controls.Add(this.LC_Edit);
            this.pan_Summary.Size = new System.Drawing.Size(1357, 923);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Clear);
            this.panelControl1.Controls.Add(this.btn_Search);
            this.panelControl1.Controls.Add(this.LC_Search);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelControl1.Size = new System.Drawing.Size(1357, 116);
            // 
            // tp_Search
            // 
            this.tp_Search.Appearance.PageClient.BackColor = System.Drawing.Color.DarkRed;
            this.tp_Search.Appearance.PageClient.Options.UseBackColor = true;
            this.tp_Search.Controls.Add(this.gcMainData);
            this.tp_Search.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.tp_Search.Size = new System.Drawing.Size(1357, 923);
            this.tp_Search.Controls.SetChildIndex(this.panelControl1, 0);
            this.tp_Search.Controls.SetChildIndex(this.gcMainData, 0);
            // 
            // tp_Edit
            // 
            this.tp_Edit.Margin = new System.Windows.Forms.Padding(9, 13, 9, 13);
            this.tp_Edit.Size = new System.Drawing.Size(1357, 923);
            // 
            // tc_Data
            // 
            this.tc_Data.SelectedTabPage = this.tp_Search;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(117, 18);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Properties.MaxLength = 20;
            this.txtAccount.Properties.ValidateOnEnterKey = true;
            this.txtAccount.Size = new System.Drawing.Size(233, 36);
            this.txtAccount.StyleController = this.LC_Edit;
            this.txtAccount.TabIndex = 14;
            // 
            // LC_Edit
            // 
            this.LC_Edit.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LC_Edit.Appearance.Control.Options.UseFont = true;
            this.LC_Edit.Controls.Add(this.txxtPassword);
            this.LC_Edit.Controls.Add(this.txtLastUpdateDate);
            this.LC_Edit.Controls.Add(this.txtCreateDate);
            this.LC_Edit.Controls.Add(this.txtIsSysLock);
            this.LC_Edit.Controls.Add(this.txtIsSysAdmain);
            this.LC_Edit.Controls.Add(this.txtEmail);
            this.LC_Edit.Controls.Add(this.txtPhone);
            this.LC_Edit.Controls.Add(this.txtUserName);
            this.LC_Edit.Controls.Add(this.txtPassword);
            this.LC_Edit.Controls.Add(this.txtAccount);
            this.LC_Edit.Controls.Add(this.txtCreateUser);
            this.LC_Edit.Controls.Add(this.txtLastUpdateUser);
            this.LC_Edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.LC_Edit.Location = new System.Drawing.Point(0, 0);
            this.LC_Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LC_Edit.Name = "LC_Edit";
            this.LC_Edit.Root = this.LCGroup_Edit;
            this.LC_Edit.Size = new System.Drawing.Size(707, 923);
            this.LC_Edit.TabIndex = 0;
            this.LC_Edit.Text = "layoutControl1";
            // 
            // txxtPassword
            // 
            this.txxtPassword.Location = new System.Drawing.Point(455, 102);
            this.txxtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txxtPassword.Name = "txxtPassword";
            this.txxtPassword.Properties.UseSystemPasswordChar = true;
            this.txxtPassword.Size = new System.Drawing.Size(234, 36);
            this.txxtPassword.StyleController = this.LC_Edit;
            this.txxtPassword.TabIndex = 15;
            // 
            // txtLastUpdateDate
            // 
            this.txtLastUpdateDate.EditValue = null;
            this.txtLastUpdateDate.Location = new System.Drawing.Point(455, 228);
            this.txtLastUpdateDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastUpdateDate.Name = "txtLastUpdateDate";
            this.txtLastUpdateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLastUpdateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLastUpdateDate.Properties.MaxValue = new System.DateTime(2200, 1, 1, 0, 0, 0, 0);
            this.txtLastUpdateDate.Properties.MinValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtLastUpdateDate.Properties.ValidateOnEnterKey = true;
            this.txtLastUpdateDate.Size = new System.Drawing.Size(234, 36);
            this.txtLastUpdateDate.StyleController = this.LC_Edit;
            this.txtLastUpdateDate.TabIndex = 4;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.EditValue = null;
            this.txtCreateDate.Location = new System.Drawing.Point(455, 186);
            this.txtCreateDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCreateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCreateDate.Properties.MaxValue = new System.DateTime(2200, 1, 1, 0, 0, 0, 0);
            this.txtCreateDate.Properties.MinValue = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.txtCreateDate.Properties.ValidateOnEnterKey = true;
            this.txtCreateDate.Size = new System.Drawing.Size(234, 36);
            this.txtCreateDate.StyleController = this.LC_Edit;
            this.txtCreateDate.TabIndex = 6;
            // 
            // txtIsSysLock
            // 
            this.txtIsSysLock.EditValue = null;
            this.txtIsSysLock.Location = new System.Drawing.Point(356, 60);
            this.txtIsSysLock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIsSysLock.Name = "txtIsSysLock";
            this.txtIsSysLock.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtIsSysLock.Properties.Caption = "锁定";
            this.txtIsSysLock.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.txtIsSysLock.Properties.ValueChecked = "Y";
            this.txtIsSysLock.Properties.ValueUnchecked = "N";
            this.txtIsSysLock.Size = new System.Drawing.Size(333, 33);
            this.txtIsSysLock.StyleController = this.LC_Edit;
            this.txtIsSysLock.TabIndex = 8;
            // 
            // txtIsSysAdmain
            // 
            this.txtIsSysAdmain.EditValue = null;
            this.txtIsSysAdmain.Location = new System.Drawing.Point(356, 18);
            this.txtIsSysAdmain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIsSysAdmain.Name = "txtIsSysAdmain";
            this.txtIsSysAdmain.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.txtIsSysAdmain.Properties.Caption = "是否是管理员";
            this.txtIsSysAdmain.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.txtIsSysAdmain.Properties.ValueChecked = "Y";
            this.txtIsSysAdmain.Properties.ValueUnchecked = "N";
            this.txtIsSysAdmain.Size = new System.Drawing.Size(333, 33);
            this.txtIsSysAdmain.StyleController = this.LC_Edit;
            this.txtIsSysAdmain.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(455, 144);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.MaxLength = 400;
            this.txtEmail.Properties.ValidateOnEnterKey = true;
            this.txtEmail.Size = new System.Drawing.Size(234, 36);
            this.txtEmail.StyleController = this.LC_Edit;
            this.txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(117, 144);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Properties.MaxLength = 20;
            this.txtPhone.Properties.ValidateOnEnterKey = true;
            this.txtPhone.Size = new System.Drawing.Size(233, 36);
            this.txtPhone.StyleController = this.LC_Edit;
            this.txtPhone.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(117, 60);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.MaxLength = 40;
            this.txtUserName.Properties.ValidateOnEnterKey = true;
            this.txtUserName.Size = new System.Drawing.Size(233, 36);
            this.txtUserName.StyleController = this.LC_Edit;
            this.txtUserName.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 102);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.MaxLength = 200;
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Properties.ValidateOnEnterKey = true;
            this.txtPassword.Size = new System.Drawing.Size(233, 36);
            this.txtPassword.StyleController = this.LC_Edit;
            this.txtPassword.TabIndex = 13;
            this.txtPassword.EditValueChanged += new System.EventHandler(this.txtPassword_EditValueChanged);
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(117, 186);
            this.txtCreateUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCreateUser.Properties.MaxLength = 20;
            this.txtCreateUser.Properties.NullText = "";
            this.txtCreateUser.Properties.ValidateOnEnterKey = true;
            this.txtCreateUser.Size = new System.Drawing.Size(233, 36);
            this.txtCreateUser.StyleController = this.LC_Edit;
            this.txtCreateUser.TabIndex = 7;
            // 
            // txtLastUpdateUser
            // 
            this.txtLastUpdateUser.Location = new System.Drawing.Point(117, 228);
            this.txtLastUpdateUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastUpdateUser.Name = "txtLastUpdateUser";
            this.txtLastUpdateUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLastUpdateUser.Properties.MaxLength = 20;
            this.txtLastUpdateUser.Properties.NullText = "";
            this.txtLastUpdateUser.Properties.ValidateOnEnterKey = true;
            this.txtLastUpdateUser.Size = new System.Drawing.Size(233, 36);
            this.txtLastUpdateUser.StyleController = this.LC_Edit;
            this.txtLastUpdateUser.TabIndex = 5;
            // 
            // LCGroup_Edit
            // 
            this.LCGroup_Edit.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.LCGroup_Edit.AppearanceItemCaption.Options.UseFont = true;
            this.LCGroup_Edit.AppearanceItemCaption.Options.UseTextOptions = true;
            this.LCGroup_Edit.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LCGroup_Edit.CustomizationFormText = "LCGroup_Edit";
            this.LCGroup_Edit.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LCGroup_Edit.GroupBordersVisible = false;
            this.LCGroup_Edit.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LCItem_UserName,
            this.LCItem_Account,
            this.LCItem_IsAdmain,
            this.LCItem_IsLock,
            this.LCItem_Password,
            this.layoutControlItem1,
            this.LCItem_Phone,
            this.LCItem_Email,
            this.LCItem_CreateUser,
            this.LCItem_CreateDate,
            this.LCItem_LastUpdateUser,
            this.LCItem_LastUpdateDate});
            this.LCGroup_Edit.Location = new System.Drawing.Point(0, 0);
            this.LCGroup_Edit.Name = "LCGroup_Edit";
            this.LCGroup_Edit.Size = new System.Drawing.Size(707, 923);
            this.LCGroup_Edit.TextVisible = false;
            // 
            // LCItem_UserName
            // 
            this.LCItem_UserName.Control = this.txtUserName;
            this.LCItem_UserName.CustomizationFormText = "名称";
            this.LCItem_UserName.Location = new System.Drawing.Point(0, 42);
            this.LCItem_UserName.Name = "LCItem_UserName";
            this.LCItem_UserName.Size = new System.Drawing.Size(338, 42);
            this.LCItem_UserName.Text = "名称";
            this.LCItem_UserName.TextSize = new System.Drawing.Size(96, 29);
            // 
            // LCItem_Account
            // 
            this.LCItem_Account.Control = this.txtAccount;
            this.LCItem_Account.CustomizationFormText = "账号";
            this.LCItem_Account.Location = new System.Drawing.Point(0, 0);
            this.LCItem_Account.Name = "LCItem_Account";
            this.LCItem_Account.Size = new System.Drawing.Size(338, 42);
            this.LCItem_Account.Text = "账号";
            this.LCItem_Account.TextSize = new System.Drawing.Size(96, 29);
            // 
            // LCItem_IsAdmain
            // 
            this.LCItem_IsAdmain.Control = this.txtIsSysAdmain;
            this.LCItem_IsAdmain.CustomizationFormText = "是否是管理员";
            this.LCItem_IsAdmain.Location = new System.Drawing.Point(338, 0);
            this.LCItem_IsAdmain.Name = "LCItem_IsAdmain";
            this.LCItem_IsAdmain.Size = new System.Drawing.Size(339, 42);
            this.LCItem_IsAdmain.Text = " ";
            this.LCItem_IsAdmain.TextSize = new System.Drawing.Size(0, 0);
            this.LCItem_IsAdmain.TextVisible = false;
            // 
            // LCItem_IsLock
            // 
            this.LCItem_IsLock.Control = this.txtIsSysLock;
            this.LCItem_IsLock.CustomizationFormText = "锁定";
            this.LCItem_IsLock.Location = new System.Drawing.Point(338, 42);
            this.LCItem_IsLock.Name = "LCItem_IsLock";
            this.LCItem_IsLock.Size = new System.Drawing.Size(339, 42);
            this.LCItem_IsLock.Text = " ";
            this.LCItem_IsLock.TextSize = new System.Drawing.Size(0, 0);
            this.LCItem_IsLock.TextVisible = false;
            // 
            // LCItem_Password
            // 
            this.LCItem_Password.Control = this.txtPassword;
            this.LCItem_Password.CustomizationFormText = "密码";
            this.LCItem_Password.Location = new System.Drawing.Point(0, 84);
            this.LCItem_Password.Name = "LCItem_Password";
            this.LCItem_Password.Size = new System.Drawing.Size(338, 42);
            this.LCItem_Password.Text = "密码";
            this.LCItem_Password.TextSize = new System.Drawing.Size(96, 29);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txxtPassword;
            this.layoutControlItem1.CustomizationFormText = "确认密码";
            this.layoutControlItem1.Location = new System.Drawing.Point(338, 84);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(339, 42);
            this.layoutControlItem1.Text = "确认密码";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(96, 29);
            // 
            // LCItem_Phone
            // 
            this.LCItem_Phone.Control = this.txtPhone;
            this.LCItem_Phone.CustomizationFormText = "电话";
            this.LCItem_Phone.Location = new System.Drawing.Point(0, 126);
            this.LCItem_Phone.Name = "LCItem_Phone";
            this.LCItem_Phone.Size = new System.Drawing.Size(338, 42);
            this.LCItem_Phone.Text = "电话";
            this.LCItem_Phone.TextSize = new System.Drawing.Size(96, 29);
            // 
            // LCItem_Email
            // 
            this.LCItem_Email.Control = this.txtEmail;
            this.LCItem_Email.CustomizationFormText = "Email";
            this.LCItem_Email.Location = new System.Drawing.Point(338, 126);
            this.LCItem_Email.Name = "LCItem_Email";
            this.LCItem_Email.Size = new System.Drawing.Size(339, 42);
            this.LCItem_Email.Text = "Email";
            this.LCItem_Email.TextSize = new System.Drawing.Size(96, 29);
            // 
            // LCItem_CreateUser
            // 
            this.LCItem_CreateUser.Control = this.txtCreateUser;
            this.LCItem_CreateUser.CustomizationFormText = "创建人";
            this.LCItem_CreateUser.Location = new System.Drawing.Point(0, 168);
            this.LCItem_CreateUser.Name = "LCItem_CreateUser";
            this.LCItem_CreateUser.Size = new System.Drawing.Size(338, 42);
            this.LCItem_CreateUser.Text = "创建人";
            this.LCItem_CreateUser.TextSize = new System.Drawing.Size(96, 29);
            // 
            // LCItem_CreateDate
            // 
            this.LCItem_CreateDate.Control = this.txtCreateDate;
            this.LCItem_CreateDate.CustomizationFormText = "创建日期";
            this.LCItem_CreateDate.Location = new System.Drawing.Point(338, 168);
            this.LCItem_CreateDate.Name = "LCItem_CreateDate";
            this.LCItem_CreateDate.Size = new System.Drawing.Size(339, 42);
            this.LCItem_CreateDate.Text = "创建日期";
            this.LCItem_CreateDate.TextSize = new System.Drawing.Size(96, 29);
            // 
            // LCItem_LastUpdateUser
            // 
            this.LCItem_LastUpdateUser.Control = this.txtLastUpdateUser;
            this.LCItem_LastUpdateUser.CustomizationFormText = "修改人";
            this.LCItem_LastUpdateUser.Location = new System.Drawing.Point(0, 210);
            this.LCItem_LastUpdateUser.Name = "LCItem_LastUpdateUser";
            this.LCItem_LastUpdateUser.Size = new System.Drawing.Size(338, 683);
            this.LCItem_LastUpdateUser.Text = "修改人";
            this.LCItem_LastUpdateUser.TextSize = new System.Drawing.Size(96, 29);
            // 
            // LCItem_LastUpdateDate
            // 
            this.LCItem_LastUpdateDate.Control = this.txtLastUpdateDate;
            this.LCItem_LastUpdateDate.CustomizationFormText = "修改日期";
            this.LCItem_LastUpdateDate.Location = new System.Drawing.Point(338, 210);
            this.LCItem_LastUpdateDate.Name = "LCItem_LastUpdateDate";
            this.LCItem_LastUpdateDate.Size = new System.Drawing.Size(339, 683);
            this.LCItem_LastUpdateDate.Text = "修改日期";
            this.LCItem_LastUpdateDate.TextSize = new System.Drawing.Size(96, 29);
            // 
            // gc_Account
            // 
            this.gc_Account.Caption = "账号";
            this.gc_Account.FieldName = "Account";
            this.gc_Account.Name = "gc_Account";
            this.gc_Account.Visible = true;
            this.gc_Account.VisibleIndex = 0;
            // 
            // txts_Account
            // 
            this.txts_Account.Location = new System.Drawing.Point(63, 18);
            this.txts_Account.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txts_Account.Name = "txts_Account";
            this.txts_Account.Properties.MaxLength = 20;
            this.txts_Account.Properties.ValidateOnEnterKey = true;
            this.txts_Account.Size = new System.Drawing.Size(269, 28);
            this.txts_Account.StyleController = this.LC_Search;
            this.txts_Account.TabIndex = 10;
            // 
            // LC_Search
            // 
            this.LC_Search.Controls.Add(this.txts_Email);
            this.LC_Search.Controls.Add(this.txts_Phone);
            this.LC_Search.Controls.Add(this.txts_UserName);
            this.LC_Search.Controls.Add(this.txts_Account);
            this.LC_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.LC_Search.Location = new System.Drawing.Point(0, 0);
            this.LC_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LC_Search.Name = "LC_Search";
            this.LC_Search.Root = this.LCGroup_Search;
            this.LC_Search.Size = new System.Drawing.Size(669, 116);
            this.LC_Search.TabIndex = 0;
            this.LC_Search.Text = "layoutControl1";
            // 
            // txts_Email
            // 
            this.txts_Email.Location = new System.Drawing.Point(383, 52);
            this.txts_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txts_Email.Name = "txts_Email";
            this.txts_Email.Properties.MaxLength = 400;
            this.txts_Email.Properties.ValidateOnEnterKey = true;
            this.txts_Email.Size = new System.Drawing.Size(268, 28);
            this.txts_Email.StyleController = this.LC_Search;
            this.txts_Email.TabIndex = 6;
            // 
            // txts_Phone
            // 
            this.txts_Phone.Location = new System.Drawing.Point(63, 52);
            this.txts_Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txts_Phone.Name = "txts_Phone";
            this.txts_Phone.Properties.MaxLength = 20;
            this.txts_Phone.Properties.ValidateOnEnterKey = true;
            this.txts_Phone.Size = new System.Drawing.Size(269, 28);
            this.txts_Phone.StyleController = this.LC_Search;
            this.txts_Phone.TabIndex = 7;
            // 
            // txts_UserName
            // 
            this.txts_UserName.Location = new System.Drawing.Point(383, 18);
            this.txts_UserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txts_UserName.Name = "txts_UserName";
            this.txts_UserName.Properties.MaxLength = 40;
            this.txts_UserName.Properties.ValidateOnEnterKey = true;
            this.txts_UserName.Size = new System.Drawing.Size(268, 28);
            this.txts_UserName.StyleController = this.LC_Search;
            this.txts_UserName.TabIndex = 8;
            // 
            // LCGroup_Search
            // 
            this.LCGroup_Search.AppearanceItemCaption.Options.UseTextOptions = true;
            this.LCGroup_Search.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LCGroup_Search.CustomizationFormText = "LCGroup_Search";
            this.LCGroup_Search.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LCGroup_Search.GroupBordersVisible = false;
            this.LCGroup_Search.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.LCItems_Account,
            this.LCItems_Email,
            this.LCItems_UserName,
            this.LCItems_Phone});
            this.LCGroup_Search.Location = new System.Drawing.Point(0, 0);
            this.LCGroup_Search.Name = "LCGroup_Search";
            this.LCGroup_Search.Size = new System.Drawing.Size(669, 116);
            this.LCGroup_Search.TextVisible = false;
            // 
            // LCItems_Account
            // 
            this.LCItems_Account.Control = this.txts_Account;
            this.LCItems_Account.CustomizationFormText = "账号";
            this.LCItems_Account.Location = new System.Drawing.Point(0, 0);
            this.LCItems_Account.Name = "LCItem_Account";
            this.LCItems_Account.Size = new System.Drawing.Size(320, 34);
            this.LCItems_Account.Text = "账号";
            this.LCItems_Account.TextSize = new System.Drawing.Size(42, 22);
            // 
            // LCItems_Email
            // 
            this.LCItems_Email.Control = this.txts_Email;
            this.LCItems_Email.CustomizationFormText = "Email";
            this.LCItems_Email.Location = new System.Drawing.Point(320, 34);
            this.LCItems_Email.Name = "LCItem_Email";
            this.LCItems_Email.Size = new System.Drawing.Size(319, 52);
            this.LCItems_Email.Text = "Email";
            this.LCItems_Email.TextSize = new System.Drawing.Size(42, 22);
            // 
            // LCItems_UserName
            // 
            this.LCItems_UserName.Control = this.txts_UserName;
            this.LCItems_UserName.CustomizationFormText = "名称";
            this.LCItems_UserName.Location = new System.Drawing.Point(320, 0);
            this.LCItems_UserName.Name = "LCItem_UserName";
            this.LCItems_UserName.Size = new System.Drawing.Size(319, 34);
            this.LCItems_UserName.Text = "姓名";
            this.LCItems_UserName.TextSize = new System.Drawing.Size(42, 22);
            // 
            // LCItems_Phone
            // 
            this.LCItems_Phone.Control = this.txts_Phone;
            this.LCItems_Phone.CustomizationFormText = "电话";
            this.LCItems_Phone.Location = new System.Drawing.Point(0, 34);
            this.LCItems_Phone.Name = "LCItem_Phone";
            this.LCItems_Phone.Size = new System.Drawing.Size(320, 52);
            this.LCItems_Phone.Text = "电话";
            this.LCItems_Phone.TextSize = new System.Drawing.Size(42, 22);
            // 
            // gc_Password
            // 
            this.gc_Password.Caption = "密码";
            this.gc_Password.FieldName = "Password";
            this.gc_Password.Name = "gc_Password";
            this.gc_Password.Visible = true;
            this.gc_Password.VisibleIndex = 1;
            // 
            // gc_UserName
            // 
            this.gc_UserName.Caption = "名称";
            this.gc_UserName.FieldName = "UserName";
            this.gc_UserName.Name = "gc_UserName";
            this.gc_UserName.Visible = true;
            this.gc_UserName.VisibleIndex = 2;
            // 
            // gc_Phone
            // 
            this.gc_Phone.Caption = "电话";
            this.gc_Phone.FieldName = "Phone";
            this.gc_Phone.Name = "gc_Phone";
            this.gc_Phone.Visible = true;
            this.gc_Phone.VisibleIndex = 3;
            // 
            // gc_Email
            // 
            this.gc_Email.Caption = "Email";
            this.gc_Email.FieldName = "Email";
            this.gc_Email.Name = "gc_Email";
            this.gc_Email.Visible = true;
            this.gc_Email.VisibleIndex = 4;
            // 
            // gc_IsAdmain
            // 
            this.gc_IsAdmain.Caption = "是否是管理员";
            this.gc_IsAdmain.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gc_IsAdmain.FieldName = "IsSysAdmain";
            this.gc_IsAdmain.Name = "gc_IsAdmain";
            this.gc_IsAdmain.Visible = true;
            this.gc_IsAdmain.VisibleIndex = 5;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit2.ValueChecked = "Y";
            this.repositoryItemCheckEdit2.ValueUnchecked = "N";
            // 
            // gc_IsLock
            // 
            this.gc_IsLock.Caption = "锁定";
            this.gc_IsLock.ColumnEdit = this.repositoryItemCheckEdit2;
            this.gc_IsLock.FieldName = "IsSysLock";
            this.gc_IsLock.Name = "gc_IsLock";
            this.gc_IsLock.Visible = true;
            this.gc_IsLock.VisibleIndex = 6;
            this.gc_IsLock.Width = 48;
            // 
            // gc_CreateUser
            // 
            this.gc_CreateUser.Caption = "创建人";
            this.gc_CreateUser.ColumnEdit = this.lue_UserName;
            this.gc_CreateUser.FieldName = "CreateUser";
            this.gc_CreateUser.Name = "gc_CreateUser";
            this.gc_CreateUser.Visible = true;
            this.gc_CreateUser.VisibleIndex = 7;
            // 
            // lue_UserName
            // 
            this.lue_UserName.AutoHeight = false;
            this.lue_UserName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_UserName.Name = "lue_UserName";
            // 
            // gc_CreateDate
            // 
            this.gc_CreateDate.Caption = "创建日期";
            this.gc_CreateDate.FieldName = "CreateDate";
            this.gc_CreateDate.Name = "gc_CreateDate";
            this.gc_CreateDate.Visible = true;
            this.gc_CreateDate.VisibleIndex = 8;
            // 
            // gc_LastUpdateUser
            // 
            this.gc_LastUpdateUser.Caption = "修改人";
            this.gc_LastUpdateUser.ColumnEdit = this.lue_UserName;
            this.gc_LastUpdateUser.FieldName = "LastUpdateUser";
            this.gc_LastUpdateUser.Name = "gc_LastUpdateUser";
            this.gc_LastUpdateUser.Visible = true;
            this.gc_LastUpdateUser.VisibleIndex = 9;
            // 
            // gc_LastUpdateDate
            // 
            this.gc_LastUpdateDate.Caption = "修改日期";
            this.gc_LastUpdateDate.FieldName = "LastUpdateDate";
            this.gc_LastUpdateDate.Name = "gc_LastUpdateDate";
            this.gc_LastUpdateDate.Visible = true;
            this.gc_LastUpdateDate.VisibleIndex = 10;
            // 
            // gcMainData
            // 
            this.gcMainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMainData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcMainData.Location = new System.Drawing.Point(0, 116);
            this.gcMainData.MainView = this.gvMainData;
            this.gcMainData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gcMainData.Name = "gcMainData";
            this.gcMainData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lue_UserName,
            this.repositoryItemCheckEdit2});
            this.gcMainData.Size = new System.Drawing.Size(1357, 807);
            this.gcMainData.TabIndex = 1;
            this.gcMainData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMainData});
            // 
            // gvMainData
            // 
            this.gvMainData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_Account,
            this.gc_Password,
            this.gc_UserName,
            this.gc_Phone,
            this.gc_Email,
            this.gc_IsAdmain,
            this.gc_IsLock,
            this.gc_CreateUser,
            this.gc_CreateDate,
            this.gc_LastUpdateUser,
            this.gc_LastUpdateDate});
            this.gvMainData.GridControl = this.gcMainData;
            this.gvMainData.Name = "gvMainData";
            this.gvMainData.OptionsBehavior.Editable = false;
            this.gvMainData.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMainData.OptionsView.ColumnAutoWidth = false;
            this.gvMainData.OptionsView.ShowGroupPanel = false;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(709, 24);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(107, 64);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "查找";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(850, 24);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(107, 64);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 374);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(610, 549);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gc_Detail);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(600, 504);
            this.xtraTabPage1.Text = "角色";
            // 
            // gc_Detail
            // 
            this.gc_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Detail.EmbeddedNavigator.Buttons.Append.ImageIndex = 0;
            this.gc_Detail.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gc_Detail.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gc_Detail.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gc_Detail.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gc_Detail.EmbeddedNavigator.Buttons.ImageList = this.imageList1;
            this.gc_Detail.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gc_Detail.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gc_Detail.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gc_Detail.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gc_Detail.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gc_Detail.EmbeddedNavigator.Buttons.Remove.ImageIndex = 2;
            this.gc_Detail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gc_Detail.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gc_Detail_EmbeddedNavigator_ButtonClick);
            this.gc_Detail.Location = new System.Drawing.Point(0, 0);
            this.gc_Detail.MainView = this.gv_Detail;
            this.gc_Detail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gc_Detail.Name = "gc_Detail";
            this.gc_Detail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lue_RoleName});
            this.gc_Detail.Size = new System.Drawing.Size(600, 504);
            this.gc_Detail.TabIndex = 3;
            this.gc_Detail.UseEmbeddedNavigator = true;
            this.gc_Detail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Detail});
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "16_Add.ico");
            this.imageList1.Images.SetKeyName(1, "16_Insert.ico");
            this.imageList1.Images.SetKeyName(2, "16_Delete.ico");
            this.imageList1.Images.SetKeyName(3, "16_First.png");
            this.imageList1.Images.SetKeyName(4, "16_Last.png");
            this.imageList1.Images.SetKeyName(5, "16_Next.png");
            this.imageList1.Images.SetKeyName(6, "16_Previous.png");
            // 
            // gv_Detail
            // 
            this.gv_Detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gv_Detail.GridControl = this.gc_Detail;
            this.gv_Detail.Name = "gv_Detail";
            this.gv_Detail.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gv_Detail.OptionsSelection.MultiSelect = true;
            this.gv_Detail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_Detail.OptionsView.ColumnAutoWidth = false;
            this.gv_Detail.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "角色编号";
            this.gridColumn1.FieldName = "RoleID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 74;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "角色名称";
            this.gridColumn2.ColumnEdit = this.lue_RoleName;
            this.gridColumn2.FieldName = "RoleID";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 94;
            // 
            // lue_RoleName
            // 
            this.lue_RoleName.AutoHeight = false;
            this.lue_RoleName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_RoleName.Name = "lue_RoleName";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.tree_ModuleEx);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(600, 504);
            this.xtraTabPage2.Text = "权限预览";
            // 
            // tree_ModuleEx
            // 
            this.tree_ModuleEx.AllowCheck = true;
            this.tree_ModuleEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree_ModuleEx.EditData = null;
            this.tree_ModuleEx.Location = new System.Drawing.Point(0, 0);
            this.tree_ModuleEx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tree_ModuleEx.Name = "tree_ModuleEx";
            this.tree_ModuleEx.OptionsBehavior.Editable = false;
            this.tree_ModuleEx.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.tree_ModuleEx.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.tree_ModuleEx.OptionsView.ShowCheckBoxes = true;
            this.tree_ModuleEx.OptionsView.ShowColumns = false;
            this.tree_ModuleEx.Size = new System.Drawing.Size(600, 504);
            this.tree_ModuleEx.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xtraTabControl1);
            this.panel1.Controls.Add(this.splitterControl1);
            this.panel1.Controls.Add(this.gc_DBList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(707, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 923);
            this.panel1.TabIndex = 2;
            // 
            // gc_DBList
            // 
            this.gc_DBList.Dock = System.Windows.Forms.DockStyle.Top;
            this.gc_DBList.EmbeddedNavigator.Buttons.Append.ImageIndex = 0;
            this.gc_DBList.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gc_DBList.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gc_DBList.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gc_DBList.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gc_DBList.EmbeddedNavigator.Buttons.ImageList = this.imageList1;
            this.gc_DBList.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gc_DBList.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gc_DBList.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gc_DBList.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gc_DBList.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gc_DBList.EmbeddedNavigator.Buttons.Remove.ImageIndex = 2;
            this.gc_DBList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gc_DBList.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gc_DBList_EmbeddedNavigator_ButtonClick);
            this.gc_DBList.Location = new System.Drawing.Point(0, 0);
            this.gc_DBList.MainView = this.gv_DBList;
            this.gc_DBList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gc_DBList.Name = "gc_DBList";
            this.gc_DBList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.lue_DBList});
            this.gc_DBList.Size = new System.Drawing.Size(610, 366);
            this.gc_DBList.TabIndex = 17;
            this.gc_DBList.UseEmbeddedNavigator = true;
            this.gc_DBList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DBList});
            // 
            // gv_DBList
            // 
            this.gv_DBList.ColumnPanelRowHeight = 35;
            this.gv_DBList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_DBList.GridControl = this.gc_DBList;
            this.gv_DBList.Name = "gv_DBList";
            this.gv_DBList.OptionsView.ColumnAutoWidth = false;
            this.gv_DBList.OptionsView.ShowGroupPanel = false;
            this.gv_DBList.RowHeight = 35;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "账套名称";
            this.gridColumn3.ColumnEdit = this.lue_DBList;
            this.gridColumn3.FieldName = "DBCode";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // lue_DBList
            // 
            this.lue_DBList.AutoHeight = false;
            this.lue_DBList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_DBList.Name = "lue_DBList";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "管理员";
            this.gridColumn4.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn4.FieldName = "IsDBAdmin";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.ValueChecked = "Y";
            this.repositoryItemCheckEdit1.ValueUnchecked = "N";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "锁定";
            this.gridColumn5.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn5.FieldName = "IsDBLock";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 366);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(610, 8);
            this.splitterControl1.TabIndex = 18;
            this.splitterControl1.TabStop = false;
            // 
            // frmMyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 968);
            this.Margin = new System.Windows.Forms.Padding(27, 49, 27, 49);
            this.Name = "frmMyUser";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.frmMyUser_Load);
            this.pan_Summary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tp_Search.ResumeLayout(false);
            this.tp_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).EndInit();
            this.tc_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Edit)).EndInit();
            this.LC_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txxtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsSysLock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIsSysAdmain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_IsAdmain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_IsLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_Password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_Phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_CreateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_CreateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_LastUpdateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItem_LastUpdateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Account.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Search)).EndInit();
            this.LC_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txts_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_Phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txts_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItems_Account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItems_Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItems_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LCItems_Phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_UserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_RoleName)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tree_ModuleEx)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_DBList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DBList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_DBList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcMainData;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMainData;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.SimpleButton btn_Search;
        private DevExpress.XtraLayout.LayoutControl LC_Search;

        private DevExpress.XtraLayout.LayoutControlGroup LCGroup_Search;

        private DevExpress.XtraLayout.LayoutControl LC_Edit;

        private DevExpress.XtraLayout.LayoutControlGroup LCGroup_Edit;


        private DevExpress.XtraEditors.TextEdit txtAccount;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_Account;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Account;
        private DevExpress.XtraEditors.TextEdit txts_Account;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_Account;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_Password;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Password;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_UserName;
        private DevExpress.XtraGrid.Columns.GridColumn gc_UserName;
        private DevExpress.XtraEditors.TextEdit txts_UserName;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_UserName;
        private DevExpress.XtraEditors.TextEdit txtPhone;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Phone;
        private DevExpress.XtraEditors.TextEdit txts_Phone;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_Phone;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_Email;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Email;
        private DevExpress.XtraEditors.TextEdit txts_Email;
        private DevExpress.XtraLayout.LayoutControlItem LCItems_Email;
        private DevExpress.XtraEditors.CheckEdit txtIsSysAdmain;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_IsAdmain;
        private DevExpress.XtraGrid.Columns.GridColumn gc_IsAdmain;
        private DevExpress.XtraEditors.CheckEdit txtIsSysLock;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_IsLock;
        private DevExpress.XtraGrid.Columns.GridColumn gc_IsLock;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_CreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CreateUser;
        private DevExpress.XtraEditors.DateEdit txtCreateDate;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CreateDate;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_LastUpdateUser;
        private DevExpress.XtraGrid.Columns.GridColumn gc_LastUpdateUser;
        private DevExpress.XtraEditors.DateEdit txtLastUpdateDate;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_LastUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn gc_LastUpdateDate;
        private DevExpress.XtraEditors.TextEdit txxtPassword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gc_Detail;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Detail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LookUpEdit txtCreateUser;
        private DevExpress.XtraEditors.LookUpEdit txtLastUpdateUser;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lue_UserName;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lue_RoleName;
        private Library.MyControl.ucModuleTreeList tree_ModuleEx;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gc_DBList;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DBList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lue_DBList;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}