namespace ClothingPSISQLite.PSIModule.Dialog
{
    partial class frmDialogProducQty
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_Detail_tb_PODetail = new DevExpress.XtraGrid.GridControl();
            this.gv_Detail_tb_PODetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_Category = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeProductCategory = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txt_Search = new DevExpress.XtraEditors.TextEdit();
            this.chk_AllowMerge = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_IN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Detail_tb_PODetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Detail_tb_PODetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeProductCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_AllowMerge.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Cancel);
            this.panelControl1.Controls.Add(this.btn_OK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 360);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(862, 58);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(390, 6);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 44);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(284, 6);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 44);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(862, 360);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gc_Detail_tb_PODetail);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(138, 50);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(722, 308);
            this.groupControl2.TabIndex = 8;
            this.groupControl2.Text = "商品信息";
            // 
            // gc_Detail_tb_PODetail
            // 
            this.gc_Detail_tb_PODetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Detail_tb_PODetail.Location = new System.Drawing.Point(2, 21);
            this.gc_Detail_tb_PODetail.MainView = this.gv_Detail_tb_PODetail;
            this.gc_Detail_tb_PODetail.Name = "gc_Detail_tb_PODetail";
            this.gc_Detail_tb_PODetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lue_Category});
            this.gc_Detail_tb_PODetail.Size = new System.Drawing.Size(718, 285);
            this.gc_Detail_tb_PODetail.TabIndex = 1;
            this.gc_Detail_tb_PODetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Detail_tb_PODetail});
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
            // lue_Category
            // 
            this.lue_Category.AutoHeight = false;
            this.lue_Category.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_Category.Name = "lue_Category";
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
            this.gridColumn8.Width = 71;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeProductCategory);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(2, 50);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(136, 308);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "类别";
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
            this.treeProductCategory.Size = new System.Drawing.Size(132, 285);
            this.treeProductCategory.TabIndex = 2;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "类别编号";
            this.treeListColumn1.FieldName = "CategoryID";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Width = 68;
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
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_IN);
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.txt_Search);
            this.panelControl3.Controls.Add(this.chk_AllowMerge);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Margin = new System.Windows.Forms.Padding(0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(858, 48);
            this.panelControl3.TabIndex = 6;
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(175, 11);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Properties.NullValuePrompt = "输入货号或名称";
            this.txt_Search.Properties.ShowNullValuePromptWhenFocused = true;
            this.txt_Search.Size = new System.Drawing.Size(197, 20);
            this.txt_Search.TabIndex = 1;
            // 
            // chk_AllowMerge
            // 
            this.chk_AllowMerge.Location = new System.Drawing.Point(528, 12);
            this.chk_AllowMerge.Name = "chk_AllowMerge";
            this.chk_AllowMerge.Properties.Caption = "合并单元格";
            this.chk_AllowMerge.Size = new System.Drawing.Size(93, 19);
            this.chk_AllowMerge.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(693, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Ctrl多选";
            // 
            // btn_IN
            // 
            this.btn_IN.Location = new System.Drawing.Point(741, 5);
            this.btn_IN.Name = "btn_IN";
            this.btn_IN.Size = new System.Drawing.Size(75, 32);
            this.btn_IN.TabIndex = 3;
            this.btn_IN.Text = "补货/进货";
            // 
            // frmDialogProducQty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 418);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDialogProducQty";
            this.Text = "产品列表";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Detail_tb_PODetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Detail_tb_PODetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeProductCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Search.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chk_AllowMerge.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTreeList.TreeList treeProductCategory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Search;
        private DevExpress.XtraEditors.CheckEdit chk_AllowMerge;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gc_Detail_tb_PODetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Detail_tb_PODetail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lue_Category;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_IN;
    }
}