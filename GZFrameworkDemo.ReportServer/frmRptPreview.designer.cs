namespace GZFrameworkDemo.ReportServer
{
    partial class frmRptPreview
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
            this.previewControl1 = new FastReport.Preview.PreviewControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Design = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // previewControl1
            // 
            this.previewControl1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.previewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewControl1.Font = new System.Drawing.Font("宋体", 9F);
            this.previewControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            this.previewControl1.Location = new System.Drawing.Point(0, 58);
            this.previewControl1.Name = "previewControl1";
            this.previewControl1.Size = new System.Drawing.Size(746, 415);
            this.previewControl1.TabIndex = 0;
            this.previewControl1.ToolbarVisible = false;
            this.previewControl1.UIStyle = FastReport.Utils.UIStyle.VisualStudio2005;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Design);
            this.panelControl1.Controls.Add(this.btn_Print);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(746, 58);
            this.panelControl1.TabIndex = 1;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(12, 12);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(83, 36);
            this.btn_Print.TabIndex = 0;
            this.btn_Print.Text = "打印";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Design
            // 
            this.btn_Design.Location = new System.Drawing.Point(111, 12);
            this.btn_Design.Name = "btn_Design";
            this.btn_Design.Size = new System.Drawing.Size(83, 36);
            this.btn_Design.TabIndex = 0;
            this.btn_Design.Text = "设计";
            this.btn_Design.Click += new System.EventHandler(this.btn_Design_Click);
            // 
            // frmRptPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 473);
            this.Controls.Add(this.previewControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmRptPreview";
            this.Text = "报表预览";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FastReport.Preview.PreviewControl previewControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Design;
        private DevExpress.XtraEditors.SimpleButton btn_Print;
    }
}