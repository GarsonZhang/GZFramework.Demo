namespace GZFrameworkDemo.HR
{
    partial class frmUser
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
            this.txtAccount = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_Account = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txts_Account = new DevExpress.XtraEditors.TextEdit();
            this.LCItems_Account = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_Password = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Password = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_UserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_UserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txts_UserName = new DevExpress.XtraEditors.TextEdit();
            this.LCItems_UserName = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPhone = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_Phone = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_Email = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIsSysAdmain = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_IsSysAdmain = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_IsSysAdmain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtIsSysLock = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_IsSysLock = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_IsSysLock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCreateUser = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_CreateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_CreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCreateDate = new DevExpress.XtraEditors.DateEdit();
            this.LCItem_CreateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_CreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLastUpdateUser = new DevExpress.XtraEditors.TextEdit();
            this.LCItem_LastUpdateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_LastUpdateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtLastUpdateDate = new DevExpress.XtraEditors.DateEdit();
            this.LCItem_LastUpdateDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_LastUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();

            this.gcMainData = new DevExpress.XtraGrid.GridControl();
            this.gvMainData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LC_Search = new DevExpress.XtraLayout.LayoutControl();
            this.LCGroup_Search = new DevExpress.XtraLayout.LayoutControlGroup();
            this.btn_Search = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.LC_Edit = new DevExpress.XtraLayout.LayoutControl();
            this.LCGroup_Edit = new DevExpress.XtraLayout.LayoutControlGroup();

            this.pan_Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tp_Search.SuspendLayout();
            this.tp_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).BeginInit();
            this.tc_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMainData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Search)).BeginInit();
            this.LC_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Edit)).BeginInit();
            this.LC_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Edit)).BeginInit();
            this.SuspendLayout();

            // 
            // pan_Summary
            // 
            this.pan_Summary.Controls.Add(this.LC_Edit);

            this.pan_Summary.Dock = System.Windows.Forms.DockStyle.Fill;

            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Clear);
            this.panelControl1.Controls.Add(this.btn_Search);
            this.panelControl1.Controls.Add(this.LC_Search);
            this.panelControl1.Size = new System.Drawing.Size(947, 91);
            // 
            // tp_Search
            // 
            this.tp_Search.Appearance.PageClient.BackColor = System.Drawing.Color.DarkRed;
            this.tp_Search.Appearance.PageClient.Options.UseBackColor = true;
            this.tp_Search.Controls.Add(this.gcMainData);
            this.tp_Search.Controls.SetChildIndex(this.panelControl1, 0);
            this.tp_Search.Controls.SetChildIndex(this.gcMainData, 0);




            this.txtAccount.Name = "txtAccount";
            this.txtAccount.StyleController = this.LC_Edit;

            this.LCItem_Account.Control = this.txtAccount;
            this.LCItem_Account.CustomizationFormText = "账号";
            this.LCItem_Account.Location = new System.Drawing.Point(0, 0);
            this.LCItem_Account.Name = "LCItem_Account";
            this.LCItem_Account.Size = new System.Drawing.Size(160, 24);
            this.LCItem_Account.Text = "账号";
            this.LCItem_Account.TextSize = new System.Drawing.Size(36, 14);

            this.gc_Account.Caption = "账号";
            this.gc_Account.Name = "gc_Account";
            this.gc_Account.FieldName = "Account";
            this.gc_Account.Visible = true;
            this.gc_Account.VisibleIndex = 0;


            this.txts_Account.Name = "txts_Account";
            this.txts_Account.StyleController = this.LC_Search;

            this.LCItems_Account.Control = this.txts_Account;
            this.LCItems_Account.CustomizationFormText = "账号";
            this.LCItems_Account.Location = new System.Drawing.Point(0, 0);
            this.LCItems_Account.Name = "LCItems_Account";
            this.LCItems_Account.Size = new System.Drawing.Size(160, 24);
            this.LCItems_Account.Text = "账号";
            this.LCItems_Account.TextSize = new System.Drawing.Size(36, 14);


            this.txtPassword.Name = "txtPassword";
            this.txtPassword.StyleController = this.LC_Edit;

            this.LCItem_Password.Control = this.txtPassword;
            this.LCItem_Password.CustomizationFormText = "密码";
            this.LCItem_Password.Location = new System.Drawing.Point(160, 0);
            this.LCItem_Password.Name = "LCItem_Password";
            this.LCItem_Password.Size = new System.Drawing.Size(160, 24);
            this.LCItem_Password.Text = "密码";
            this.LCItem_Password.TextSize = new System.Drawing.Size(36, 14);

            this.gc_Password.Caption = "密码";
            this.gc_Password.Name = "gc_Password";
            this.gc_Password.FieldName = "Password";
            this.gc_Password.Visible = true;
            this.gc_Password.VisibleIndex = 1;


            this.txtUserName.Name = "txtUserName";
            this.txtUserName.StyleController = this.LC_Edit;

            this.LCItem_UserName.Control = this.txtUserName;
            this.LCItem_UserName.CustomizationFormText = "名称";
            this.LCItem_UserName.Location = new System.Drawing.Point(320, 0);
            this.LCItem_UserName.Name = "LCItem_UserName";
            this.LCItem_UserName.Size = new System.Drawing.Size(160, 24);
            this.LCItem_UserName.Text = "名称";
            this.LCItem_UserName.TextSize = new System.Drawing.Size(36, 14);

            this.gc_UserName.Caption = "名称";
            this.gc_UserName.Name = "gc_UserName";
            this.gc_UserName.FieldName = "UserName";
            this.gc_UserName.Visible = true;
            this.gc_UserName.VisibleIndex = 2;


            this.txts_UserName.Name = "txts_UserName";
            this.txts_UserName.StyleController = this.LC_Search;

            this.LCItems_UserName.Control = this.txts_UserName;
            this.LCItems_UserName.CustomizationFormText = "名称";
            this.LCItems_UserName.Location = new System.Drawing.Point(160, 0);
            this.LCItems_UserName.Name = "LCItems_UserName";
            this.LCItems_UserName.Size = new System.Drawing.Size(160, 24);
            this.LCItems_UserName.Text = "名称";
            this.LCItems_UserName.TextSize = new System.Drawing.Size(36, 14);


            this.txtPhone.Name = "txtPhone";
            this.txtPhone.StyleController = this.LC_Edit;

            this.LCItem_Phone.Control = this.txtPhone;
            this.LCItem_Phone.CustomizationFormText = "电话";
            this.LCItem_Phone.Location = new System.Drawing.Point(480, 0);
            this.LCItem_Phone.Name = "LCItem_Phone";
            this.LCItem_Phone.Size = new System.Drawing.Size(160, 24);
            this.LCItem_Phone.Text = "电话";
            this.LCItem_Phone.TextSize = new System.Drawing.Size(36, 14);

            this.gc_Phone.Caption = "电话";
            this.gc_Phone.Name = "gc_Phone";
            this.gc_Phone.FieldName = "Phone";
            this.gc_Phone.Visible = true;
            this.gc_Phone.VisibleIndex = 3;


            this.txtEmail.Name = "txtEmail";
            this.txtEmail.StyleController = this.LC_Edit;

            this.LCItem_Email.Control = this.txtEmail;
            this.LCItem_Email.CustomizationFormText = "Email";
            this.LCItem_Email.Location = new System.Drawing.Point(0, 24);
            this.LCItem_Email.Name = "LCItem_Email";
            this.LCItem_Email.Size = new System.Drawing.Size(160, 24);
            this.LCItem_Email.Text = "Email";
            this.LCItem_Email.TextSize = new System.Drawing.Size(36, 14);

            this.gc_Email.Caption = "Email";
            this.gc_Email.Name = "gc_Email";
            this.gc_Email.FieldName = "Email";
            this.gc_Email.Visible = true;
            this.gc_Email.VisibleIndex = 4;


            this.txtIsSysAdmain.Name = "txtIsSysAdmain";
            this.txtIsSysAdmain.StyleController = this.LC_Edit;

            this.LCItem_IsSysAdmain.Control = this.txtIsSysAdmain;
            this.LCItem_IsSysAdmain.CustomizationFormText = "是否是管理员";
            this.LCItem_IsSysAdmain.Location = new System.Drawing.Point(160, 24);
            this.LCItem_IsSysAdmain.Name = "LCItem_IsSysAdmain";
            this.LCItem_IsSysAdmain.Size = new System.Drawing.Size(160, 24);
            this.LCItem_IsSysAdmain.Text = "是否是管理员";
            this.LCItem_IsSysAdmain.TextSize = new System.Drawing.Size(36, 14);

            this.gc_IsSysAdmain.Caption = "是否是管理员";
            this.gc_IsSysAdmain.Name = "gc_IsSysAdmain";
            this.gc_IsSysAdmain.FieldName = "IsSysAdmain";
            this.gc_IsSysAdmain.Visible = true;
            this.gc_IsSysAdmain.VisibleIndex = 5;


            this.txtIsSysLock.Name = "txtIsSysLock";
            this.txtIsSysLock.StyleController = this.LC_Edit;

            this.LCItem_IsSysLock.Control = this.txtIsSysLock;
            this.LCItem_IsSysLock.CustomizationFormText = "未知名称";
            this.LCItem_IsSysLock.Location = new System.Drawing.Point(320, 24);
            this.LCItem_IsSysLock.Name = "LCItem_IsSysLock";
            this.LCItem_IsSysLock.Size = new System.Drawing.Size(160, 24);
            this.LCItem_IsSysLock.Text = "未知名称";
            this.LCItem_IsSysLock.TextSize = new System.Drawing.Size(36, 14);

            this.gc_IsSysLock.Caption = "未知名称";
            this.gc_IsSysLock.Name = "gc_IsSysLock";
            this.gc_IsSysLock.FieldName = "IsSysLock";
            this.gc_IsSysLock.Visible = true;
            this.gc_IsSysLock.VisibleIndex = 6;


            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.StyleController = this.LC_Edit;

            this.LCItem_CreateUser.Control = this.txtCreateUser;
            this.LCItem_CreateUser.CustomizationFormText = "创建人";
            this.LCItem_CreateUser.Location = new System.Drawing.Point(480, 24);
            this.LCItem_CreateUser.Name = "LCItem_CreateUser";
            this.LCItem_CreateUser.Size = new System.Drawing.Size(160, 24);
            this.LCItem_CreateUser.Text = "创建人";
            this.LCItem_CreateUser.TextSize = new System.Drawing.Size(36, 14);

            this.gc_CreateUser.Caption = "创建人";
            this.gc_CreateUser.Name = "gc_CreateUser";
            this.gc_CreateUser.FieldName = "CreateUser";
            this.gc_CreateUser.Visible = true;
            this.gc_CreateUser.VisibleIndex = 7;


            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.StyleController = this.LC_Edit;

            this.LCItem_CreateDate.Control = this.txtCreateDate;
            this.LCItem_CreateDate.CustomizationFormText = "创建日期";
            this.LCItem_CreateDate.Location = new System.Drawing.Point(0, 48);
            this.LCItem_CreateDate.Name = "LCItem_CreateDate";
            this.LCItem_CreateDate.Size = new System.Drawing.Size(160, 24);
            this.LCItem_CreateDate.Text = "创建日期";
            this.LCItem_CreateDate.TextSize = new System.Drawing.Size(36, 14);

            this.gc_CreateDate.Caption = "创建日期";
            this.gc_CreateDate.Name = "gc_CreateDate";
            this.gc_CreateDate.FieldName = "CreateDate";
            this.gc_CreateDate.Visible = true;
            this.gc_CreateDate.VisibleIndex = 8;


            this.txtLastUpdateUser.Name = "txtLastUpdateUser";
            this.txtLastUpdateUser.StyleController = this.LC_Edit;

            this.LCItem_LastUpdateUser.Control = this.txtLastUpdateUser;
            this.LCItem_LastUpdateUser.CustomizationFormText = "修改人";
            this.LCItem_LastUpdateUser.Location = new System.Drawing.Point(160, 48);
            this.LCItem_LastUpdateUser.Name = "LCItem_LastUpdateUser";
            this.LCItem_LastUpdateUser.Size = new System.Drawing.Size(160, 24);
            this.LCItem_LastUpdateUser.Text = "修改人";
            this.LCItem_LastUpdateUser.TextSize = new System.Drawing.Size(36, 14);

            this.gc_LastUpdateUser.Caption = "修改人";
            this.gc_LastUpdateUser.Name = "gc_LastUpdateUser";
            this.gc_LastUpdateUser.FieldName = "LastUpdateUser";
            this.gc_LastUpdateUser.Visible = true;
            this.gc_LastUpdateUser.VisibleIndex = 9;


            this.txtLastUpdateDate.Name = "txtLastUpdateDate";
            this.txtLastUpdateDate.StyleController = this.LC_Edit;

            this.LCItem_LastUpdateDate.Control = this.txtLastUpdateDate;
            this.LCItem_LastUpdateDate.CustomizationFormText = "修改日期";
            this.LCItem_LastUpdateDate.Location = new System.Drawing.Point(320, 48);
            this.LCItem_LastUpdateDate.Name = "LCItem_LastUpdateDate";
            this.LCItem_LastUpdateDate.Size = new System.Drawing.Size(160, 24);
            this.LCItem_LastUpdateDate.Text = "修改日期";
            this.LCItem_LastUpdateDate.TextSize = new System.Drawing.Size(36, 14);

            this.gc_LastUpdateDate.Caption = "修改日期";
            this.gc_LastUpdateDate.Name = "gc_LastUpdateDate";
            this.gc_LastUpdateDate.FieldName = "LastUpdateDate";
            this.gc_LastUpdateDate.Visible = true;
            this.gc_LastUpdateDate.VisibleIndex = 10;



            // 
            // tc_Data
            // 
            this.tc_Data.Size = new System.Drawing.Size(953, 612);
            // 
            // gcMainData
            // 
            this.gcMainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMainData.Location = new System.Drawing.Point(0, 74);
            this.gcMainData.MainView = this.gvMainData;
            this.gcMainData.Name = "gcMainData";
            this.gcMainData.Size = new System.Drawing.Size(947, 509);
            this.gcMainData.TabIndex = 1;
            this.gcMainData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMainData});
            // 
            // gvMainData
            // 
            this.gvMainData.GridControl = this.gcMainData;
            this.gvMainData.Name = "gvMainData";
            this.gvMainData.OptionsBehavior.Editable = false;
            this.gvMainData.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvMainData.OptionsView.ColumnAutoWidth = false;
            this.gvMainData.OptionsView.ShowGroupPanel = false;


            this.gvMainData.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
                this.gc_Account,this.gc_Password,this.gc_UserName,this.gc_Phone,this.gc_Email,this.gc_IsSysAdmain,this.gc_IsSysLock,this.gc_CreateUser,this.gc_CreateDate,this.gc_LastUpdateUser,this.gc_LastUpdateDate});


            // 
            // LC_Search
            // 

            this.LC_Search.Dock = System.Windows.Forms.DockStyle.Left;
            this.LC_Search.Location = new System.Drawing.Point(2, 2);
            this.LC_Search.Name = "LC_Search";
            this.LC_Search.Root = this.LCGroup_Search;
            this.LC_Search.Size = new System.Drawing.Size(661, 70);
            this.LC_Search.TabIndex = 0;
            this.LC_Search.Text = "layoutControl1";
            this.LC_Search.Controls.Add(this.txts_Account); this.LC_Search.Controls.Add(this.txts_UserName);


            // 
            // LCGroup_Search
            // 

            this.LCGroup_Search.AppearanceItemCaption.Options.UseTextOptions = true;
            this.LCGroup_Search.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LCGroup_Search.CustomizationFormText = "LCGroup_Search";
            this.LCGroup_Search.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LCGroup_Search.GroupBordersVisible = false;
            this.LCGroup_Search.Items.AddRange(
            new DevExpress.XtraLayout.BaseLayoutItem[] { this.LCItems_Account, this.LCItems_UserName });



            this.LCGroup_Search.Location = new System.Drawing.Point(0, 0);
            this.LCGroup_Search.Name = "LCGroup_Search";
            this.LCGroup_Search.Size = new System.Drawing.Size(240, 70);
            this.LCGroup_Search.Text = "LCGroup_Search";
            this.LCGroup_Search.TextVisible = false;

            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(665, 17);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 41);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "查找";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(764, 17);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 41);
            this.btn_Clear.TabIndex = 1;
            this.btn_Clear.Text = "清空";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // LC_Edit
            // 

            this.LC_Edit.Location = new System.Drawing.Point(5, 5);
            this.LC_Edit.Name = "LC_Edit";
            this.LC_Edit.Root = this.LCGroup_Edit;
            this.LC_Edit.Size = new System.Drawing.Size(661, 120);
            this.LC_Edit.TabIndex = 0;
            this.LC_Edit.Text = "layoutControl1";
            this.LC_Edit.Controls.Add(this.txtAccount); this.LC_Edit.Controls.Add(this.txtPassword); this.LC_Edit.Controls.Add(this.txtUserName); this.LC_Edit.Controls.Add(this.txtPhone); this.LC_Edit.Controls.Add(this.txtEmail); this.LC_Edit.Controls.Add(this.txtIsSysAdmain); this.LC_Edit.Controls.Add(this.txtIsSysLock); this.LC_Edit.Controls.Add(this.txtCreateUser); this.LC_Edit.Controls.Add(this.txtCreateDate); this.LC_Edit.Controls.Add(this.txtLastUpdateUser); this.LC_Edit.Controls.Add(this.txtLastUpdateDate);


            // 
            // LCGroup_Edit
            // 

            this.LCGroup_Edit.AppearanceItemCaption.Options.UseTextOptions = true;
            this.LCGroup_Edit.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.LCGroup_Edit.CustomizationFormText = "LCGroup_Edit";
            this.LCGroup_Edit.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.LCGroup_Edit.GroupBordersVisible = false;
            this.LCGroup_Edit.Location = new System.Drawing.Point(0, 0);
            this.LCGroup_Edit.Name = "LCGroup_Edit";
            this.LCGroup_Edit.Size = new System.Drawing.Size(661, 579);
            this.LCGroup_Edit.Text = "LCGroup_Edit";
            this.LCGroup_Edit.TextVisible = false;

            this.LCGroup_Edit.Items.AddRange(
            new DevExpress.XtraLayout.BaseLayoutItem[] { this.LCItem_Account, this.LCItem_Password, this.LCItem_UserName, this.LCItem_Phone, this.LCItem_Email, this.LCItem_IsSysAdmain, this.LCItem_IsSysLock, this.LCItem_CreateUser, this.LCItem_CreateDate, this.LCItem_LastUpdateUser, this.LCItem_LastUpdateDate });
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 616);
            this.Name = "GZFamework";
            this.Text = "GZFamework";
            this.pan_Summary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tp_Search.ResumeLayout(false);
            this.tp_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).EndInit();
            this.tc_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMainData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Search)).EndInit();
            this.LC_Search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LC_Edit)).EndInit();
            this.LC_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LCGroup_Edit)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_Email;
        private DevExpress.XtraGrid.Columns.GridColumn gc_Email;
        private DevExpress.XtraEditors.TextEdit txtIsSysAdmain;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_IsSysAdmain;
        private DevExpress.XtraGrid.Columns.GridColumn gc_IsSysAdmain;
        private DevExpress.XtraEditors.TextEdit txtIsSysLock;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_IsSysLock;
        private DevExpress.XtraGrid.Columns.GridColumn gc_IsSysLock;
        private DevExpress.XtraEditors.TextEdit txtCreateUser;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_CreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CreateUser;
        private DevExpress.XtraEditors.DateEdit txtCreateDate;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_CreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn gc_CreateDate;
        private DevExpress.XtraEditors.TextEdit txtLastUpdateUser;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_LastUpdateUser;
        private DevExpress.XtraGrid.Columns.GridColumn gc_LastUpdateUser;
        private DevExpress.XtraEditors.DateEdit txtLastUpdateDate;
        private DevExpress.XtraLayout.LayoutControlItem LCItem_LastUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn gc_LastUpdateDate;

    }
}