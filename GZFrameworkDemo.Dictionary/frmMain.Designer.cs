namespace GZFrameworkDemo.Dictionary
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
            this.btnCommonDataDictNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnDocSNHeader = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Customer = new DevExpress.XtraEditors.SimpleButton();
            this.btnStoragePosition = new DevExpress.XtraEditors.SimpleButton();
            this.btnProduct = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelControl1.Size = new System.Drawing.Size(1081, 641);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCommonDataDictNew);
            this.flowLayoutPanel1.Controls.Add(this.btnDocSNHeader);
            this.flowLayoutPanel1.Controls.Add(this.btn_Customer);
            this.flowLayoutPanel1.Controls.Add(this.btnStoragePosition);
            this.flowLayoutPanel1.Controls.Add(this.btnProduct);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(17, 19);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1047, 349);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnCommonDataDictNew
            // 
            this.btnCommonDataDictNew.Location = new System.Drawing.Point(4, 5);
            this.btnCommonDataDictNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCommonDataDictNew.Name = "btnCommonDataDictNew";
            this.btnCommonDataDictNew.Size = new System.Drawing.Size(131, 123);
            this.btnCommonDataDictNew.TabIndex = 0;
            this.btnCommonDataDictNew.Text = "公共字典";
            this.btnCommonDataDictNew.Click += new System.EventHandler(this.btnCommonDataDictNew_Click);
            // 
            // btnDocSNHeader
            // 
            this.btnDocSNHeader.Location = new System.Drawing.Point(143, 5);
            this.btnDocSNHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDocSNHeader.Name = "btnDocSNHeader";
            this.btnDocSNHeader.Size = new System.Drawing.Size(131, 123);
            this.btnDocSNHeader.TabIndex = 0;
            this.btnDocSNHeader.Text = "单据管理";
            this.btnDocSNHeader.Click += new System.EventHandler(this.btnDocSNHeader_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Location = new System.Drawing.Point(282, 5);
            this.btn_Customer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(131, 123);
            this.btn_Customer.TabIndex = 0;
            this.btn_Customer.Text = "客户资料";
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btnStoragePosition
            // 
            this.btnStoragePosition.Location = new System.Drawing.Point(421, 5);
            this.btnStoragePosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStoragePosition.Name = "btnStoragePosition";
            this.btnStoragePosition.Size = new System.Drawing.Size(131, 123);
            this.btnStoragePosition.TabIndex = 1;
            this.btnStoragePosition.Text = "仓位资料";
            this.btnStoragePosition.Click += new System.EventHandler(this.btnStoragePosition_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(560, 5);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(131, 123);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "产品资料";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 641);
            this.Margin = new System.Windows.Forms.Padding(13, 20, 13, 20);
            this.Name = "frmMain";
            this.Text = "字典管理";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnCommonDataDictNew;
        private DevExpress.XtraEditors.SimpleButton btnDocSNHeader;
        private DevExpress.XtraEditors.SimpleButton btn_Customer;
        private DevExpress.XtraEditors.SimpleButton btnStoragePosition;
        private DevExpress.XtraEditors.SimpleButton btnProduct;
    }
}