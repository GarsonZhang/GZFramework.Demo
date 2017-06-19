namespace GZFrameworkDemo.SystemManagement
{
    partial class frmMyRole
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tree_Module = new GZFrameworkDemo.Library.MyControl.ucModuleTreeList();
            this.txtLastUpdateUser = new DevExpress.XtraEditors.LookUpEdit();
            this.txtLastUpdateDate = new DevExpress.XtraEditors.DateEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txtRoleName = new DevExpress.XtraEditors.TextEdit();
            this.txtRoleID = new DevExpress.XtraEditors.TextEdit();
            this.txtCreateUser = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCreateDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gc_Summary = new DevExpress.XtraGrid.GridControl();
            this.gv_Summary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_UserName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.pan_Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tp_Search.SuspendLayout();
            this.tp_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).BeginInit();
            this.tc_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tree_Module)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Summary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Summary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_UserName)).BeginInit();
            this.SuspendLayout();
            // 
            // pan_Summary
            // 
            this.pan_Summary.Controls.Add(this.layoutControl1);
            this.pan_Summary.Size = new System.Drawing.Size(872, 589);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Size = new System.Drawing.Size(872, 55);
            // 
            // tp_Search
            // 
            this.tp_Search.Appearance.PageClient.BackColor = System.Drawing.Color.DarkRed;
            this.tp_Search.Appearance.PageClient.Options.UseBackColor = true;
            this.tp_Search.Controls.Add(this.gc_Summary);
            this.tp_Search.Size = new System.Drawing.Size(872, 589);
            this.tp_Search.Controls.SetChildIndex(this.panelControl1, 0);
            this.tp_Search.Controls.SetChildIndex(this.gc_Summary, 0);
            // 
            // tp_Edit
            // 
            this.tp_Edit.Size = new System.Drawing.Size(872, 589);
            // 
            // tc_Data
            // 
            this.tc_Data.Size = new System.Drawing.Size(878, 618);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tree_Module);
            this.layoutControl1.Controls.Add(this.txtLastUpdateUser);
            this.layoutControl1.Controls.Add(this.txtLastUpdateDate);
            this.layoutControl1.Controls.Add(this.txtDescription);
            this.layoutControl1.Controls.Add(this.txtRoleName);
            this.layoutControl1.Controls.Add(this.txtRoleID);
            this.layoutControl1.Controls.Add(this.txtCreateUser);
            this.layoutControl1.Controls.Add(this.txtCreateDate);
            this.layoutControl1.Location = new System.Drawing.Point(13, 16);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(741, 440, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(448, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tree_Module
            // 
            this.tree_Module.AllowCheck = true;
            this.tree_Module.DataSourceType = GZFrameworkDemo.Library.MyControl.ucModuleTreeList.DataType.所有系统模块;
            this.tree_Module.EditData = null;
            this.tree_Module.Location = new System.Drawing.Point(198, 12);
            this.tree_Module.Name = "tree_Module";
            this.tree_Module.OptionsBehavior.Editable = false;
            this.tree_Module.OptionsView.ShowCheckBoxes = true;
            this.tree_Module.OptionsView.ShowColumns = false;
            this.tree_Module.Size = new System.Drawing.Size(238, 426);
            this.tree_Module.TabIndex = 12;
            // 
            // txtLastUpdateUser
            // 
            this.txtLastUpdateUser.Location = new System.Drawing.Point(63, 156);
            this.txtLastUpdateUser.Name = "txtLastUpdateUser";
            this.txtLastUpdateUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.txtLastUpdateUser.Properties.NullText = "";
            this.txtLastUpdateUser.Size = new System.Drawing.Size(131, 20);
            this.txtLastUpdateUser.StyleController = this.layoutControl1;
            this.txtLastUpdateUser.TabIndex = 10;
            // 
            // txtLastUpdateDate
            // 
            this.txtLastUpdateDate.EditValue = null;
            this.txtLastUpdateDate.Location = new System.Drawing.Point(63, 132);
            this.txtLastUpdateDate.Name = "txtLastUpdateDate";
            this.txtLastUpdateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.txtLastUpdateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLastUpdateDate.Size = new System.Drawing.Size(131, 20);
            this.txtLastUpdateDate.StyleController = this.layoutControl1;
            this.txtLastUpdateDate.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(63, 60);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(131, 20);
            this.txtDescription.StyleController = this.layoutControl1;
            this.txtDescription.TabIndex = 6;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(63, 36);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(131, 20);
            this.txtRoleName.StyleController = this.layoutControl1;
            this.txtRoleName.TabIndex = 5;
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(63, 12);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(131, 20);
            this.txtRoleID.StyleController = this.layoutControl1;
            this.txtRoleID.TabIndex = 4;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(63, 108);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.txtCreateUser.Properties.NullText = "";
            this.txtCreateUser.Size = new System.Drawing.Size(131, 20);
            this.txtCreateUser.StyleController = this.layoutControl1;
            this.txtCreateUser.TabIndex = 8;
            // 
            // txtCreateDate
            // 
            this.txtCreateDate.EditValue = null;
            this.txtCreateDate.Location = new System.Drawing.Point(63, 84);
            this.txtCreateDate.Name = "txtCreateDate";
            this.txtCreateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject4, "", null, null, true)});
            this.txtCreateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCreateDate.Properties.Mask.EditMask = "";
            this.txtCreateDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtCreateDate.Size = new System.Drawing.Size(131, 20);
            this.txtCreateDate.StyleController = this.layoutControl1;
            this.txtCreateDate.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlGroup1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(448, 450);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.txtRoleID;
            this.layoutControlItem1.CustomizationFormText = "角色ID";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(186, 24);
            this.layoutControlItem1.Text = "角色ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.txtRoleName;
            this.layoutControlItem2.CustomizationFormText = "角色名称";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(186, 24);
            this.layoutControlItem2.Text = "角色名称";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.txtDescription;
            this.layoutControlItem3.CustomizationFormText = "描述";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(186, 24);
            this.layoutControlItem3.Text = "描述";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.txtCreateDate;
            this.layoutControlItem4.CustomizationFormText = "创建日期";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(186, 24);
            this.layoutControlItem4.Text = "创建时间";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.Control = this.txtCreateUser;
            this.layoutControlItem5.CustomizationFormText = "创建人";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(186, 24);
            this.layoutControlItem5.Text = "创建人";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtLastUpdateDate;
            this.layoutControlItem6.CustomizationFormText = "修改时间";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(186, 24);
            this.layoutControlItem6.Text = "修改时间";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtLastUpdateUser;
            this.layoutControlItem7.CustomizationFormText = "修改人";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(186, 286);
            this.layoutControlItem7.Text = "修改人";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.tree_Module;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem8";
            this.layoutControlItem8.Location = new System.Drawing.Point(186, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(242, 430);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // gc_Summary
            // 
            this.gc_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Summary.Location = new System.Drawing.Point(0, 55);
            this.gc_Summary.MainView = this.gv_Summary;
            this.gc_Summary.Name = "gc_Summary";
            this.gc_Summary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lue_UserName});
            this.gc_Summary.Size = new System.Drawing.Size(872, 534);
            this.gc_Summary.TabIndex = 1;
            this.gc_Summary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Summary});
            // 
            // gv_Summary
            // 
            this.gv_Summary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gv_Summary.GridControl = this.gc_Summary;
            this.gv_Summary.Name = "gv_Summary";
            this.gv_Summary.OptionsView.ColumnAutoWidth = false;
            this.gv_Summary.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "角色编号";
            this.gridColumn1.FieldName = "RoleID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "角色名称";
            this.gridColumn2.FieldName = "RoleName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "描述";
            this.gridColumn3.FieldName = "Description";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "创建人";
            this.gridColumn4.ColumnEdit = this.lue_UserName;
            this.gridColumn4.FieldName = "CreateUser";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // lue_UserName
            // 
            this.lue_UserName.AutoHeight = false;
            this.lue_UserName.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_UserName.Name = "lue_UserName";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "创建时间";
            this.gridColumn5.FieldName = "CreateDate";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "修改人";
            this.gridColumn6.ColumnEdit = this.lue_UserName;
            this.gridColumn6.FieldName = "LastUpdateUser";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "修改时间";
            this.gridColumn7.FieldName = "LastUpdateDate";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(406, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 27);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查找";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmMyRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 618);
            this.Name = "frmMyRole";
            this.Text = "角色管理";
            this.Load += new System.EventHandler(this.frmModulesManage_Load);
            this.pan_Summary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tp_Search.ResumeLayout(false);
            this.tp_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).EndInit();
            this.tc_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tree_Module)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLastUpdateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreateDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Summary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Summary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_UserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txtRoleName;
        private DevExpress.XtraEditors.TextEdit txtRoleID;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gc_Summary;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Summary;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LookUpEdit txtCreateUser;
        private DevExpress.XtraEditors.DateEdit txtCreateDate;
        private DevExpress.XtraEditors.LookUpEdit txtLastUpdateUser;
        private DevExpress.XtraEditors.DateEdit txtLastUpdateDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lue_UserName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private Library.MyControl.ucModuleTreeList tree_Module;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;

    }
}