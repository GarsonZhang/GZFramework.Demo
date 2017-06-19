namespace GZFrameworkDemo.Library.MyControl
{
    partial class GridControlTools
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Import = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Delete = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_MovePre = new DevExpress.XtraEditors.SimpleButton();
            this.btn_MoveLast = new DevExpress.XtraEditors.SimpleButton();
            this.btn_MoveFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btn_MoveNext = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Import);
            this.flowLayoutPanel1.Controls.Add(this.btn_Add);
            this.flowLayoutPanel1.Controls.Add(this.btn_Delete);
            this.flowLayoutPanel1.Controls.Add(this.panelControl1);
            this.flowLayoutPanel1.Controls.Add(this.btn_Save);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(943, 43);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(3, 3);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 35);
            this.btn_Import.TabIndex = 4;
            this.btn_Import.Text = "导入";
            // 
            // btn_Add
            // 
            this.btn_Add.Appearance.BackColor = System.Drawing.Color.Red;
            this.btn_Add.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.btn_Add.Appearance.BorderColor = System.Drawing.Color.Red;
            this.btn_Add.Appearance.Options.UseBackColor = true;
            this.btn_Add.Appearance.Options.UseBorderColor = true;
            this.btn_Add.Location = new System.Drawing.Point(84, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 35);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "新增";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(165, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 35);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "删除选中";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btn_MovePre);
            this.panelControl1.Controls.Add(this.btn_MoveLast);
            this.panelControl1.Controls.Add(this.btn_MoveFirst);
            this.panelControl1.Controls.Add(this.btn_MoveNext);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(248, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(328, 41);
            this.panelControl1.TabIndex = 3;
            // 
            // btn_MovePre
            // 
            this.btn_MovePre.Location = new System.Drawing.Point(86, 3);
            this.btn_MovePre.Name = "btn_MovePre";
            this.btn_MovePre.Size = new System.Drawing.Size(75, 35);
            this.btn_MovePre.TabIndex = 2;
            this.btn_MovePre.Text = "向前";
            // 
            // btn_MoveLast
            // 
            this.btn_MoveLast.Location = new System.Drawing.Point(248, 3);
            this.btn_MoveLast.Name = "btn_MoveLast";
            this.btn_MoveLast.Size = new System.Drawing.Size(75, 35);
            this.btn_MoveLast.TabIndex = 2;
            this.btn_MoveLast.Text = "最后";
            // 
            // btn_MoveFirst
            // 
            this.btn_MoveFirst.Location = new System.Drawing.Point(5, 3);
            this.btn_MoveFirst.Name = "btn_MoveFirst";
            this.btn_MoveFirst.Size = new System.Drawing.Size(75, 35);
            this.btn_MoveFirst.TabIndex = 2;
            this.btn_MoveFirst.Text = "第一";
            // 
            // btn_MoveNext
            // 
            this.btn_MoveNext.Location = new System.Drawing.Point(167, 3);
            this.btn_MoveNext.Name = "btn_MoveNext";
            this.btn_MoveNext.Size = new System.Drawing.Size(75, 35);
            this.btn_MoveNext.TabIndex = 2;
            this.btn_MoveNext.Text = "向后";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(579, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 35);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "保存";
            // 
            // GridControlTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1500, 43);
            this.MinimumSize = new System.Drawing.Size(0, 43);
            this.Name = "GridControlTools";
            this.Size = new System.Drawing.Size(943, 43);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraEditors.SimpleButton btn_Delete;
        private DevExpress.XtraEditors.SimpleButton btn_MoveFirst;
        private DevExpress.XtraEditors.SimpleButton btn_MovePre;
        private DevExpress.XtraEditors.SimpleButton btn_MoveNext;
        private DevExpress.XtraEditors.SimpleButton btn_MoveLast;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Import;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
    }
}
