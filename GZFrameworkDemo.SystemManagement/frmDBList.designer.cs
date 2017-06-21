namespace GZFrameworkDemo.SystemManagement
{
    partial class frmDBList
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
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Edit = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Summary = new DevExpress.XtraGrid.GridControl();
            this.gv_Summary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucModuleTreeList1 = new Library.MyControl.ucModuleTreeList();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_DBName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Summary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Summary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucModuleTreeList1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DBName.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btn_Delete);
            this.panelControl1.Controls.Add(this.btn_Add);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(279, 53);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(122, 12);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(66, 32);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(38, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(66, 32);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "新增";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(77, 12);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(66, 32);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "保存";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // gc_Summary
            // 
            this.gc_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Summary.Location = new System.Drawing.Point(0, 53);
            this.gc_Summary.MainView = this.gv_Summary;
            this.gc_Summary.Name = "gc_Summary";
            this.gc_Summary.Size = new System.Drawing.Size(279, 505);
            this.gc_Summary.TabIndex = 1;
            this.gc_Summary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Summary});
            // 
            // gv_Summary
            // 
            this.gv_Summary.ColumnPanelRowHeight = 35;
            this.gv_Summary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gv_Summary.GridControl = this.gc_Summary;
            this.gv_Summary.Name = "gv_Summary";
            this.gv_Summary.OptionsView.ColumnAutoWidth = false;
            this.gv_Summary.OptionsView.ShowGroupPanel = false;
            this.gv_Summary.RowHeight = 35;
            this.gv_Summary.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Summary_FocusedRowChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "账套名称";
            this.gridColumn1.FieldName = "DBDisplayText";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 78;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "服务器";
            this.gridColumn2.FieldName = "DBServer";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "数据库名";
            this.gridColumn3.FieldName = "DBName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 99;
            // 
            // ucModuleTreeList1
            // 
            this.ucModuleTreeList1.AllowCheck = true;
            this.ucModuleTreeList1.DataSourceType = Library.MyControl.ucModuleTreeList.DataType.所有系统模块;
            this.ucModuleTreeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucModuleTreeList1.EditData = null;
            this.ucModuleTreeList1.Location = new System.Drawing.Point(0, 98);
            this.ucModuleTreeList1.Name = "ucModuleTreeList1";
            this.ucModuleTreeList1.Size = new System.Drawing.Size(264, 460);
            this.ucModuleTreeList1.TabIndex = 2;
            this.ucModuleTreeList1.AddDataRow += new Library.MyControl.ucModuleTreeList.AddDataRowHandler(this.ucModuleTreeList1_AddDataRow);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucModuleTreeList1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(284, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 558);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_DBName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 45);
            this.panel2.TabIndex = 4;
            // 
            // txt_DBName
            // 
            this.txt_DBName.Location = new System.Drawing.Point(77, 14);
            this.txt_DBName.Name = "txt_DBName";
            this.txt_DBName.Size = new System.Drawing.Size(140, 20);
            this.txt_DBName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "账套名称";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Edit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 53);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gc_Summary);
            this.panel4.Controls.Add(this.panelControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 558);
            this.panel4.TabIndex = 4;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(279, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(5, 558);
            this.splitterControl1.TabIndex = 5;
            this.splitterControl1.TabStop = false;
            // 
            // splitterControl2
            // 
            this.splitterControl2.Location = new System.Drawing.Point(548, 0);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(5, 558);
            this.splitterControl2.TabIndex = 6;
            this.splitterControl2.TabStop = false;
            // 
            // frmDBList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 558);
            this.Controls.Add(this.splitterControl2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.panel4);
            this.Name = "frmDBList";
            this.Text = "系统账套管理";
            this.Load += new System.EventHandler(this.frmDBList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Summary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Summary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucModuleTreeList1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DBName.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_Summary;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Summary;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Edit;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private Library.MyControl.ucModuleTreeList ucModuleTreeList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txt_DBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
    }
}