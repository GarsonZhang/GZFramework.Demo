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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Size = new System.Drawing.Size(757, 408);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCommonDataDictNew);
            this.flowLayoutPanel1.Controls.Add(this.btnDocSNHeader);
            this.flowLayoutPanel1.Controls.Add(this.btn_Customer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(733, 222);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnCommonDataDictNew
            // 
            this.btnCommonDataDictNew.Location = new System.Drawing.Point(3, 3);
            this.btnCommonDataDictNew.Name = "btnCommonDataDictNew";
            this.btnCommonDataDictNew.Size = new System.Drawing.Size(92, 78);
            this.btnCommonDataDictNew.TabIndex = 0;
            this.btnCommonDataDictNew.Text = "公共字典";
            this.btnCommonDataDictNew.Click += new System.EventHandler(this.btnCommonDataDictNew_Click);
            // 
            // btnDocSNHeader
            // 
            this.btnDocSNHeader.Location = new System.Drawing.Point(101, 3);
            this.btnDocSNHeader.Name = "btnDocSNHeader";
            this.btnDocSNHeader.Size = new System.Drawing.Size(92, 78);
            this.btnDocSNHeader.TabIndex = 0;
            this.btnDocSNHeader.Text = "单据管理";
            this.btnDocSNHeader.Click += new System.EventHandler(this.btnDocSNHeader_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Location = new System.Drawing.Point(199, 3);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(92, 78);
            this.btn_Customer.TabIndex = 0;
            this.btn_Customer.Text = "客户资料";
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 408);
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
    }
}