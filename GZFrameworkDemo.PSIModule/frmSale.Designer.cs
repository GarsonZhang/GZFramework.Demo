namespace ClothingPSISQLite.PSIModule
{
    partial class frmSale
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Sale = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_Qty = new DevExpress.XtraEditors.LabelControl();
            this.lbl_TotalAmount = new DevExpress.XtraEditors.LabelControl();
            this.btn_Price = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Complete = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ProductCode = new DevExpress.XtraEditors.TextEdit();
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_Category = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sale.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txt_Sale);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(901, 42);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "销售员：";
            // 
            // txt_Sale
            // 
            this.txt_Sale.Location = new System.Drawing.Point(76, 12);
            this.txt_Sale.Name = "txt_Sale";
            this.txt_Sale.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Sale.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_Sale.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_Sale.Properties.NullText = "";
            this.txt_Sale.Size = new System.Drawing.Size(100, 20);
            this.txt_Sale.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(198)))), ((int)(((byte)(235)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.btn_Price);
            this.panelControl2.Controls.Add(this.btn_Clear);
            this.panelControl2.Controls.Add(this.btn_Delete);
            this.panelControl2.Controls.Add(this.btn_Edit);
            this.panelControl2.Controls.Add(this.btn_Complete);
            this.panelControl2.Controls.Add(this.txt_ProductCode);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 291);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl2.Size = new System.Drawing.Size(901, 117);
            this.panelControl2.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(155)))), ((int)(((byte)(207)))));
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(12, 74);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelControl6.Size = new System.Drawing.Size(366, 33);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "2017-05-04 14:34:34";
            // 
            // labelControl5
            // 
            this.labelControl5.AllowHtmlString = true;
            this.labelControl5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(135)))), ((int)(((byte)(205)))));
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(12, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.labelControl5.Size = new System.Drawing.Size(366, 14);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "<Color=\"red\">F2</color> 在下框中输入“商品编号”或“款号”+回车键 确认";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.lbl_Qty);
            this.panelControl3.Controls.Add(this.lbl_TotalAmount);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(523, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Padding = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.panelControl3.Size = new System.Drawing.Size(373, 107);
            this.panelControl3.TabIndex = 3;
            // 
            // lbl_Qty
            // 
            this.lbl_Qty.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(231)))), ((int)(((byte)(245)))));
            this.lbl_Qty.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(155)))), ((int)(((byte)(207)))));
            this.lbl_Qty.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Qty.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(155)))), ((int)(((byte)(207)))));
            this.lbl_Qty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_Qty.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_Qty.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbl_Qty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Qty.Location = new System.Drawing.Point(8, 69);
            this.lbl_Qty.Name = "lbl_Qty";
            this.lbl_Qty.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbl_Qty.Size = new System.Drawing.Size(357, 33);
            this.lbl_Qty.TabIndex = 1;
            this.lbl_Qty.Text = "数量：0";
            // 
            // lbl_TotalAmount
            // 
            this.lbl_TotalAmount.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(169)))), ((int)(((byte)(224)))));
            this.lbl_TotalAmount.Appearance.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalAmount.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_TotalAmount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lbl_TotalAmount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbl_TotalAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TotalAmount.Location = new System.Drawing.Point(8, 5);
            this.lbl_TotalAmount.Name = "lbl_TotalAmount";
            this.lbl_TotalAmount.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lbl_TotalAmount.Size = new System.Drawing.Size(357, 60);
            this.lbl_TotalAmount.TabIndex = 0;
            this.lbl_TotalAmount.Text = "售：0";
            // 
            // btn_Price
            // 
            this.btn_Price.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.btn_Price.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(87)))), ((int)(((byte)(133)))));
            this.btn_Price.Appearance.Options.UseBackColor = true;
            this.btn_Price.Appearance.Options.UseForeColor = true;
            this.btn_Price.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_Price.Location = new System.Drawing.Point(384, 58);
            this.btn_Price.Name = "btn_Price";
            this.btn_Price.Size = new System.Drawing.Size(75, 21);
            this.btn_Price.TabIndex = 2;
            this.btn_Price.Text = "F7 无码销售";
            this.btn_Price.Click += new System.EventHandler(this.btn_Price_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.btn_Clear.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(87)))), ((int)(((byte)(133)))));
            this.btn_Clear.Appearance.Options.UseBackColor = true;
            this.btn_Clear.Appearance.Options.UseForeColor = true;
            this.btn_Clear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_Clear.Location = new System.Drawing.Point(384, 83);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 21);
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "F8 - 清    空";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.btn_Delete.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(87)))), ((int)(((byte)(133)))));
            this.btn_Delete.Appearance.Options.UseBackColor = true;
            this.btn_Delete.Appearance.Options.UseForeColor = true;
            this.btn_Delete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_Delete.Location = new System.Drawing.Point(384, 33);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 21);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "F4 - 删    除";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.btn_Edit.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(87)))), ((int)(((byte)(133)))));
            this.btn_Edit.Appearance.Options.UseBackColor = true;
            this.btn_Edit.Appearance.Options.UseForeColor = true;
            this.btn_Edit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_Edit.Location = new System.Drawing.Point(384, 8);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 21);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "F3 - 修    改";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Complete
            // 
            this.btn_Complete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.btn_Complete.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Complete.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Complete.Appearance.Options.UseBackColor = true;
            this.btn_Complete.Appearance.Options.UseFont = true;
            this.btn_Complete.Appearance.Options.UseForeColor = true;
            this.btn_Complete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_Complete.Location = new System.Drawing.Point(293, 31);
            this.btn_Complete.Name = "btn_Complete";
            this.btn_Complete.Size = new System.Drawing.Size(85, 37);
            this.btn_Complete.TabIndex = 1;
            this.btn_Complete.Text = "F5 结算";
            this.btn_Complete.Click += new System.EventHandler(this.btn_Complete_Click);
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.EditValue = "";
            this.txt_ProductCode.Location = new System.Drawing.Point(12, 28);
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(191)))));
            this.txt_ProductCode.Properties.Appearance.BorderColor = System.Drawing.Color.Red;
            this.txt_ProductCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txt_ProductCode.Properties.Appearance.Options.UseBackColor = true;
            this.txt_ProductCode.Properties.Appearance.Options.UseBorderColor = true;
            this.txt_ProductCode.Properties.Appearance.Options.UseFont = true;
            this.txt_ProductCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txt_ProductCode.Size = new System.Drawing.Size(275, 40);
            this.txt_ProductCode.TabIndex = 0;
            this.txt_ProductCode.DoubleClick += new System.EventHandler(this.txt_ProductCode_DoubleClick);
            // 
            // gcSummary
            // 
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.Location = new System.Drawing.Point(0, 42);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lue_Category});
            this.gcSummary.Size = new System.Drawing.Size(901, 249);
            this.gcSummary.TabIndex = 2;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn10,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn5,
            this.gcQty,
            this.gcTotalAmount});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsBehavior.Editable = false;
            this.gvSummary.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSummary.OptionsSelection.MultiSelect = true;
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            this.gvSummary.OptionsView.ShowFooter = true;
            this.gvSummary.OptionsView.ShowGroupPanel = false;
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
            // gridColumn5
            // 
            this.gridColumn5.Caption = "销售价";
            this.gridColumn5.FieldName = "UnitPrice";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gridColumn5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.gridColumn5.OptionsFilter.AllowFilter = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 57;
            // 
            // gcQty
            // 
            this.gcQty.Caption = "数量";
            this.gcQty.FieldName = "Qty";
            this.gcQty.Name = "gcQty";
            this.gcQty.OptionsColumn.AllowEdit = false;
            this.gcQty.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcQty.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcQty.OptionsFilter.AllowFilter = false;
            this.gcQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", "{0}")});
            this.gcQty.Visible = true;
            this.gcQty.VisibleIndex = 7;
            this.gcQty.Width = 61;
            // 
            // gcTotalAmount
            // 
            this.gcTotalAmount.Caption = "小计";
            this.gcTotalAmount.FieldName = "TotalAmount";
            this.gcTotalAmount.Name = "gcTotalAmount";
            this.gcTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "{0:0.##}")});
            this.gcTotalAmount.Visible = true;
            this.gcTotalAmount.VisibleIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 408);
            this.Controls.Add(this.gcSummary);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "frmSale";
            this.Text = "销售";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Sale.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_Category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit txt_Sale;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Complete;
        private DevExpress.XtraEditors.TextEdit txt_ProductCode;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lue_Category;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gcQty;
        private DevExpress.XtraGrid.Columns.GridColumn gcTotalAmount;
        private DevExpress.XtraEditors.SimpleButton btn_Price;
        private DevExpress.XtraEditors.SimpleButton btn_Clear;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lbl_TotalAmount;
        private DevExpress.XtraEditors.LabelControl lbl_Qty;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Timer timer1;
    }
}