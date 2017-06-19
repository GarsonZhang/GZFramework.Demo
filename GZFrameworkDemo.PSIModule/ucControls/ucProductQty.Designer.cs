namespace ClothingPSISQLite.PSIModule.ucControls
{
    partial class ucProductQty
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Search = new DevExpress.XtraEditors.TextEdit();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_Category = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_Detail_tb_PODetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_Detail_tb_PODetail = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeProductCategory = new DevExpress.XtraTreeList.TreeList();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chk_AllowMerge = new DevExpress.XtraEditors.CheckEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Detail_tb_PODetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Detail_tb_PODetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeProductCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chk_AllowMerge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(175, 11);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Properties.NullValuePrompt = "输入货号或名称";
            this.txt_Search.Properties.ShowNullValuePromptWhenFocused = true;
            this.txt_Search.Size = new System.Drawing.Size(197, 20);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.EditValueChanged += new System.EventHandler(this.txt_Search_EditValueChanged);
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "尺码";
            this.gridColumn7.FieldName = "Size";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn7.OptionsFilter.AllowFilter = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 56;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "颜色";
            this.gridColumn6.FieldName = "Color";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn6.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn6.OptionsFilter.AllowFilter = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 55;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "销售价";
            this.gridColumn5.FieldName = "SOPrice";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 57;
            // 
            // lue_Category
            // 
            this.lue_Category.AutoHeight = false;
            this.lue_Category.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_Category.Name = "lue_Category";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "商品类别";
            this.gridColumn3.ColumnEdit = this.lue_Category;
            this.gridColumn3.FieldName = "CategoryID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn3.OptionsFilter.AllowFilter = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "商品名称";
            this.gridColumn2.FieldName = "ItemName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "商品编码";
            this.gridColumn10.FieldName = "BarCode";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn10.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn10.OptionsFilter.AllowAutoFilter = false;
            this.gridColumn10.OptionsFilter.AllowFilter = false;
            this.gridColumn10.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 0;
            this.gridColumn10.Width = 134;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "数量";
            this.gridColumn8.FieldName = "Qty";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn8.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn8.OptionsFilter.AllowFilter = false;
            this.gridColumn8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "合计:{0}")});
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 46;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "货号";
            this.gridColumn1.FieldName = "ItemNo";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gv_Detail_tb_PODetail
            // 
            this.gv_Detail_tb_PODetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn1,
            this.gridColumn10,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gv_Detail_tb_PODetail.GridControl = this.gc_Detail_tb_PODetail;
            this.gv_Detail_tb_PODetail.GroupCount = 1;
            this.gv_Detail_tb_PODetail.Name = "gv_Detail_tb_PODetail";
            
            this.gv_Detail_tb_PODetail.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gv_Detail_tb_PODetail.OptionsSelection.MultiSelect = true;
            this.gv_Detail_tb_PODetail.OptionsView.ColumnAutoWidth = false;
            this.gv_Detail_tb_PODetail.OptionsView.ShowFooter = true;
            this.gv_Detail_tb_PODetail.OptionsView.ShowGroupPanel = false;
            this.gv_Detail_tb_PODetail.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn11, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gv_Detail_tb_PODetail.DoubleClick += new System.EventHandler(this.gv_Detail_tb_PODetail_DoubleClick);
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "货号";
            this.gridColumn11.FieldName = "Tag";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.OptionsFilter.AllowFilter = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gc_Detail_tb_PODetail
            // 
            this.gc_Detail_tb_PODetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Detail_tb_PODetail.Location = new System.Drawing.Point(2, 21);
            this.gc_Detail_tb_PODetail.MainView = this.gv_Detail_tb_PODetail;
            this.gc_Detail_tb_PODetail.Name = "gc_Detail_tb_PODetail";
            this.gc_Detail_tb_PODetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lue_Category});
            this.gc_Detail_tb_PODetail.Size = new System.Drawing.Size(693, 430);
            this.gc_Detail_tb_PODetail.TabIndex = 1;
            this.gc_Detail_tb_PODetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Detail_tb_PODetail});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_Detail_tb_PODetail);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(136, 48);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(697, 453);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "商品信息";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "类别名称";
            this.treeListColumn2.FieldName = "CategoryName";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.OptionsColumn.AllowMove = false;
            this.treeListColumn2.OptionsColumn.AllowSize = false;
            this.treeListColumn2.OptionsColumn.AllowSort = false;
            this.treeListColumn2.OptionsColumn.FixedWidth = true;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 94;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "类别编号";
            this.treeListColumn1.FieldName = "CategoryID";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Width = 68;
            // 
            // treeProductCategory
            // 
            this.treeProductCategory.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2});
            this.treeProductCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeProductCategory.Location = new System.Drawing.Point(2, 21);
            this.treeProductCategory.LookAndFeel.SkinName = "Black";
            this.treeProductCategory.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeProductCategory.Name = "treeProductCategory";
            this.treeProductCategory.OptionsBehavior.Editable = false;
            this.treeProductCategory.OptionsNavigation.EnterMovesNextColumn = true;
            this.treeProductCategory.Size = new System.Drawing.Size(132, 430);
            this.treeProductCategory.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeProductCategory);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 48);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(136, 453);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "类别";
            // 
            // chk_AllowMerge
            // 
            this.chk_AllowMerge.Location = new System.Drawing.Point(528, 12);
            this.chk_AllowMerge.Name = "chk_AllowMerge";
            this.chk_AllowMerge.Properties.Caption = "合并单元格";
            this.chk_AllowMerge.Size = new System.Drawing.Size(93, 19);
            this.chk_AllowMerge.TabIndex = 0;
            this.chk_AllowMerge.CheckedChanged += new System.EventHandler(this.chk_AllowMerge_CheckedChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txt_Search);
            this.panelControl1.Controls.Add(this.chk_AllowMerge);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(833, 48);
            this.panelControl1.TabIndex = 3;
            // 
            // ucProductQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucProductQty";
            this.Size = new System.Drawing.Size(833, 501);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Detail_tb_PODetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Detail_tb_PODetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeProductCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chk_AllowMerge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_Search;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lue_Category;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Detail_tb_PODetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.GridControl gc_Detail_tb_PODetail;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.TreeList treeProductCategory;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit chk_AllowMerge;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
