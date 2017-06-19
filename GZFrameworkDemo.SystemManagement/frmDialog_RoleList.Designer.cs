namespace GZFrameworkDemo.SystemManagement
{
    partial class frmDialog_RoleList
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
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            this.gcSummary = new DevExpress.XtraGrid.GridControl();
            this.gvSummary = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Cancel);
            this.panelControl1.Controls.Add(this.btn_OK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 421);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(357, 67);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(202, 14);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 41);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(76, 14);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 41);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "确定";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // gcSummary
            // 
            this.gcSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSummary.Location = new System.Drawing.Point(0, 0);
            this.gcSummary.MainView = this.gvSummary;
            this.gcSummary.Name = "gcSummary";
            this.gcSummary.Size = new System.Drawing.Size(357, 421);
            this.gcSummary.TabIndex = 1;
            this.gcSummary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSummary});
            // 
            // gvSummary
            // 
            this.gvSummary.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gvSummary.GridControl = this.gcSummary;
            this.gvSummary.Name = "gvSummary";
            this.gvSummary.OptionsBehavior.Editable = false;
            this.gvSummary.OptionsFind.AlwaysVisible = true;
            this.gvSummary.OptionsFind.FindMode = DevExpress.XtraEditors.FindMode.Always;
            this.gvSummary.OptionsFind.ShowClearButton = false;
            this.gvSummary.OptionsFind.ShowCloseButton = false;
            this.gvSummary.OptionsFind.ShowFindButton = false;
            this.gvSummary.OptionsSelection.CheckBoxSelectorColumnWidth = 25;
            this.gvSummary.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSummary.OptionsSelection.MultiSelect = true;
            this.gvSummary.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvSummary.OptionsView.ColumnAutoWidth = false;
            this.gvSummary.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn3.Caption = "备注";
            this.gridColumn3.FieldName = "Description";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 154;
            // 
            // frmDialog_RoleList
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(357, 488);
            this.Controls.Add(this.gcSummary);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDialog_RoleList";
            this.Text = "角色选择";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gcSummary;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSummary;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
    }
}