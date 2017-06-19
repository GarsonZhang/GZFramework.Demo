namespace GZFrameworkDemo.Dictionary
{
    partial class frmDocSNHeader
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gc_Summary = new DevExpress.XtraGrid.GridControl();
            this.gv_Summary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcolumn_DocType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lue_DocType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lue_DocTypeCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Summary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Summary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_DocType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_DocTypeCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 75);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // gc_Summary
            // 
            this.gc_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Summary.Location = new System.Drawing.Point(0, 75);
            this.gc_Summary.MainView = this.gv_Summary;
            this.gc_Summary.Name = "gc_Summary";
            this.gc_Summary.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lue_DocType,
            this.lue_DocTypeCustomer});
            this.gc_Summary.Size = new System.Drawing.Size(622, 467);
            this.gc_Summary.TabIndex = 2;
            this.gc_Summary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Summary});
            this.gc_Summary.Click += new System.EventHandler(this.gc_Summary_Click);
            // 
            // gv_Summary
            // 
            this.gv_Summary.ColumnPanelRowHeight = 35;
            this.gv_Summary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gcolumn_DocType,
            this.gridColumn5,
            this.gridColumn6});
            this.gv_Summary.GridControl = this.gc_Summary;
            this.gv_Summary.Name = "gv_Summary";
            this.gv_Summary.OptionsView.ColumnAutoWidth = false;
            this.gv_Summary.OptionsView.ShowGroupPanel = false;
            this.gv_Summary.RowHeight = 35;
            this.gv_Summary.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gv_Summary_CustomRowCellEdit);
            this.gv_Summary.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gv_Summary_CellValueChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "名称";
            this.gridColumn1.FieldName = "DocName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "单据头";
            this.gridColumn2.FieldName = "DocHeader";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "分隔符";
            this.gridColumn3.FieldName = "Separate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gcolumn_DocType
            // 
            this.gcolumn_DocType.Caption = "单据类型";
            this.gcolumn_DocType.FieldName = "DocType";
            this.gcolumn_DocType.Name = "gcolumn_DocType";
            this.gcolumn_DocType.Visible = true;
            this.gcolumn_DocType.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "单据长度";
            this.gridColumn5.FieldName = "Length";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "案例";
            this.gridColumn6.FieldName = "Demo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // lue_DocType
            // 
            this.lue_DocType.AutoHeight = false;
            this.lue_DocType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_DocType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name")});
            this.lue_DocType.DisplayMember = "name";
            this.lue_DocType.Name = "lue_DocType";
            this.lue_DocType.ValueMember = "value";
            // 
            // lue_DocTypeCustomer
            // 
            this.lue_DocTypeCustomer.AutoHeight = false;
            this.lue_DocTypeCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_DocTypeCustomer.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name")});
            this.lue_DocTypeCustomer.DisplayMember = "name";
            this.lue_DocTypeCustomer.Name = "lue_DocTypeCustomer";
            this.lue_DocTypeCustomer.ValueMember = "value";
            // 
            // frmDocSNHeader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 542);
            this.Controls.Add(this.gc_Summary);
            this.Controls.Add(this.panel1);
            this.Name = "frmDocSNHeader";
            this.Text = "单据自定义管理";
            this.Load += new System.EventHandler(this.frmDocSNHeader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Summary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Summary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_DocType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_DocTypeCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gc_Summary;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Summary;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gcolumn_DocType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lue_DocType;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lue_DocTypeCustomer;
    }
}