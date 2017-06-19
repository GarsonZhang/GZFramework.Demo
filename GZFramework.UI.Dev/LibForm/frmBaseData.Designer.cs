namespace GZFramework.UI.Dev.LibForm
{
    partial class frmBaseData
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
            this.tc_Data = new DevExpress.XtraTab.XtraTabControl();
            this.tp_Search = new DevExpress.XtraTab.XtraTabPage();
            this.tp_Edit = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).BeginInit();
            this.tc_Data.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Data
            // 
            this.tc_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Data.Location = new System.Drawing.Point(0, 0);
            this.tc_Data.Name = "tc_Data";
            this.tc_Data.SelectedTabPage = this.tp_Search;
            this.tc_Data.Size = new System.Drawing.Size(546, 416);
            this.tc_Data.TabIndex = 1;
            this.tc_Data.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp_Search,
            this.tp_Edit});
            // 
            // tp_Search
            // 
            this.tp_Search.Appearance.PageClient.BackColor = System.Drawing.Color.DarkRed;
            this.tp_Search.Appearance.PageClient.Options.UseBackColor = true;
            this.tp_Search.Name = "tp_Search";
            this.tp_Search.Size = new System.Drawing.Size(540, 387);
            this.tp_Search.Text = "数据查询";
            // 
            // tp_Edit
            // 
            this.tp_Edit.Name = "tp_Edit";
            this.tp_Edit.PageEnabled = false;
            this.tp_Edit.Size = new System.Drawing.Size(540, 387);
            this.tp_Edit.Text = "数据编辑";
            // 
            // frmBaseData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 416);
            this.Controls.Add(this.tc_Data);
            this.Name = "frmBaseData";
            this.Text = "数据窗体基类";
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).EndInit();
            this.tc_Data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraTab.XtraTabPage tp_Search;
        protected DevExpress.XtraTab.XtraTabPage tp_Edit;
        protected DevExpress.XtraTab.XtraTabControl tc_Data;


    }
}