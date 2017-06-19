namespace GZFramework.UI.Dev.LibForm
{
    partial class frmBaseDataBusiness
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
            this.pan_Summary = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tp_Search.SuspendLayout();
            this.tp_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).BeginInit();
            this.tc_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tp_Search
            // 
            this.tp_Search.Appearance.PageClient.BackColor = System.Drawing.Color.DarkRed;
            this.tp_Search.Appearance.PageClient.Options.UseBackColor = true;
            this.tp_Search.Controls.Add(this.panelControl1);
            this.tp_Search.Size = new System.Drawing.Size(951, 587);
            // 
            // tp_Edit
            // 
            this.tp_Edit.Controls.Add(this.pan_Summary);
            this.tp_Edit.Size = new System.Drawing.Size(951, 587);
            // 
            // tc_Data
            // 
            this.tc_Data.Size = new System.Drawing.Size(957, 616);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(951, 106);
            this.panelControl1.TabIndex = 0;
            // 
            // pan_Summary
            // 
            this.pan_Summary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_Summary.Location = new System.Drawing.Point(0, 0);
            this.pan_Summary.Name = "pan_Summary";
            this.pan_Summary.Size = new System.Drawing.Size(951, 587);
            this.pan_Summary.TabIndex = 1;
            // 
            // frmBaseDataBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 616);
            this.Name = "frmBaseDataBusiness";
            this.Text = "数据字典";
            this.tp_Search.ResumeLayout(false);
            this.tp_Edit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tc_Data)).EndInit();
            this.tc_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraEditors.XtraScrollableControl pan_Summary;
        protected DevExpress.XtraEditors.PanelControl panelControl1;



    }
}