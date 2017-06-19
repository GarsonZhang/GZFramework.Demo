namespace ClothingPSISQLite.PSIModule
{
    partial class frmMain
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPO = new DevExpress.XtraEditors.SimpleButton();
            this.btnProductInventory = new DevExpress.XtraEditors.SimpleButton();
            this.btnSale = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaleReport = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Size = new System.Drawing.Size(850, 408);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPO);
            this.flowLayoutPanel1.Controls.Add(this.btnProductInventory);
            this.flowLayoutPanel1.Controls.Add(this.btnSale);
            this.flowLayoutPanel1.Controls.Add(this.btnSaleReport);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(617, 222);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnPO
            // 
            this.btnPO.Location = new System.Drawing.Point(3, 3);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(92, 78);
            this.btnPO.TabIndex = 0;
            this.btnPO.Text = "入库";
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // btnProductInventory
            // 
            this.btnProductInventory.Location = new System.Drawing.Point(101, 3);
            this.btnProductInventory.Name = "btnProductInventory";
            this.btnProductInventory.Size = new System.Drawing.Size(92, 78);
            this.btnProductInventory.TabIndex = 0;
            this.btnProductInventory.Text = "库存信息";
            this.btnProductInventory.Click += new System.EventHandler(this.btnProductInventory_Click);
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(199, 3);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(92, 78);
            this.btnSale.TabIndex = 0;
            this.btnSale.Text = "销售";
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnSaleReport
            // 
            this.btnSaleReport.Location = new System.Drawing.Point(297, 3);
            this.btnSaleReport.Name = "btnSaleReport";
            this.btnSaleReport.Size = new System.Drawing.Size(92, 78);
            this.btnSaleReport.TabIndex = 0;
            this.btnSaleReport.Text = "销售统计";
            this.btnSaleReport.Click += new System.EventHandler(this.btnSaleReport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 408);
            this.Name = "frmMain";
            this.Text = "库存管理";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnPO;
        private DevExpress.XtraEditors.SimpleButton btnProductInventory;
        private DevExpress.XtraEditors.SimpleButton btnSale;
        private DevExpress.XtraEditors.SimpleButton btnSaleReport;
    }
}