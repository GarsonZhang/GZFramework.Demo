namespace GZFrameworkDemo.SystemManagement
{
    partial class frmSystemAuthority
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.btn_Load = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.toolMenu_Edit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.Size = new System.Drawing.Size(400, 408);
            this.treeList1.TabIndex = 0;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(423, 12);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 53);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "加载模块";
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(423, 80);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 54);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "提交";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenu_Edit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // toolMenu_Edit
            // 
            this.toolMenu_Edit.Name = "toolMenu_Edit";
            this.toolMenu_Edit.Size = new System.Drawing.Size(100, 22);
            this.toolMenu_Edit.Text = "修改";
            // 
            // frmSystemAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 408);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.treeList1);
            this.Name = "frmSystemAuthority";
            this.Text = "权限预览";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.SimpleButton btn_Load;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolMenu_Edit;
    }
}