namespace GZFrameworkDemo.Dictionary
{
    partial class frmCommonDataDictNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCommonDataDictNew));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gc_DataType = new DevExpress.XtraGrid.GridControl();
            this.gv_DataType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_DataDetail = new DevExpress.XtraGrid.GridControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gv_DataDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_UserName = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DataType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DataType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DataDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DataDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_UserName)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gc_DataType);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(303, 979);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "字典类型";
            // 
            // gc_DataType
            // 
            this.gc_DataType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_DataType.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gc_DataType.Location = new System.Drawing.Point(3, 33);
            this.gc_DataType.MainView = this.gv_DataType;
            this.gc_DataType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gc_DataType.Name = "gc_DataType";
            this.gc_DataType.Size = new System.Drawing.Size(297, 943);
            this.gc_DataType.TabIndex = 0;
            this.gc_DataType.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DataType});
            // 
            // gv_DataType
            // 
            this.gv_DataType.ColumnPanelRowHeight = 30;
            this.gv_DataType.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.gv_DataType.GridControl = this.gc_DataType;
            this.gv_DataType.Name = "gv_DataType";
            this.gv_DataType.OptionsBehavior.Editable = false;
            this.gv_DataType.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv_DataType.OptionsView.ShowGroupPanel = false;
            this.gv_DataType.RowHeight = 30;
            this.gv_DataType.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_DataType_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "类型名称";
            this.gridColumn1.FieldName = "Name";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_DataDetail);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(311, 0);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(704, 979);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "数据详情";
            // 
            // gc_DataDetail
            // 
            this.gc_DataDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.Append.ImageIndex = 0;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.First.Hint = "第一";
            this.gc_DataDetail.EmbeddedNavigator.Buttons.First.ImageIndex = 3;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.ImageList = this.imageList1;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.Last.Hint = "最后";
            this.gc_DataDetail.EmbeddedNavigator.Buttons.Last.ImageIndex = 4;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.Next.Hint = "下移";
            this.gc_DataDetail.EmbeddedNavigator.Buttons.Next.ImageIndex = 5;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.Prev.Hint = "上移";
            this.gc_DataDetail.EmbeddedNavigator.Buttons.Prev.ImageIndex = 6;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gc_DataDetail.EmbeddedNavigator.Buttons.Remove.ImageIndex = 2;
            this.gc_DataDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gc_DataDetail.EmbeddedNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.None;
            this.gc_DataDetail.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.gc_DataDetail_EmbeddedNavigator_ButtonClick);
            this.gc_DataDetail.Location = new System.Drawing.Point(3, 33);
            this.gc_DataDetail.MainView = this.gv_DataDetail;
            this.gc_DataDetail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gc_DataDetail.Name = "gc_DataDetail";
            this.gc_DataDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lue_UserName});
            this.gc_DataDetail.Size = new System.Drawing.Size(698, 943);
            this.gc_DataDetail.TabIndex = 0;
            this.gc_DataDetail.UseEmbeddedNavigator = true;
            this.gc_DataDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DataDetail});
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
            // gv_DataDetail
            // 
            this.gv_DataDetail.ColumnPanelRowHeight = 30;
            this.gv_DataDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gv_DataDetail.GridControl = this.gc_DataDetail;
            this.gv_DataDetail.Name = "gv_DataDetail";
            this.gv_DataDetail.OptionsView.ColumnAutoWidth = false;
            this.gv_DataDetail.OptionsView.ShowGroupPanel = false;
            this.gv_DataDetail.RowHeight = 30;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "数据编号";
            this.gridColumn2.FieldName = "DataCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 164;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "数据名称";
            this.gridColumn3.FieldName = "DataName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.gridColumn4.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn4.Caption = "创建人";
            this.gridColumn4.ColumnEdit = this.lue_UserName;
            this.gridColumn4.FieldName = "CreateUser";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.AllowFocus = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
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
            this.gridColumn5.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.gridColumn5.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn5.Caption = "创建日期";
            this.gridColumn5.FieldName = "CreateDate";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowFocus = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.gridColumn6.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn6.Caption = "修改人";
            this.gridColumn6.ColumnEdit = this.lue_UserName;
            this.gridColumn6.FieldName = "LastUpdateUser";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowFocus = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceCell.BackColor = System.Drawing.Color.Silver;
            this.gridColumn7.AppearanceCell.Options.UseBackColor = true;
            this.gridColumn7.Caption = "修改日期";
            this.gridColumn7.FieldName = "LastUpdateDate";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowFocus = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 5;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(303, 0);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(8, 979);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // frmCommonDataDictNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 979);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(13, 20, 13, 20);
            this.Name = "frmCommonDataDictNew";
            this.Text = "基础字典管理";
            this.Load += new System.EventHandler(this.frmCommonDataDictNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_DataType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DataType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_DataDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DataDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_UserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraGrid.GridControl gc_DataType;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DataType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl gc_DataDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DataDetail;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lue_UserName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}