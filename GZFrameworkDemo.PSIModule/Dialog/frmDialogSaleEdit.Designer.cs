namespace ClothingPSISQLite.PSIModule.Dialog
{
    partial class frmDialogSaleEdit
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtRemark = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtUnitPrice = new DevExpress.XtraEditors.TextEdit();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarCode = new DevExpress.XtraEditors.LabelControl();
            this.txtItemNo = new DevExpress.XtraEditors.LabelControl();
            this.txtItemName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Cancel);
            this.panelControl1.Controls.Add(this.btn_OK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(5, 265);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(257, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(135, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(66, 29);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(45, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(66, 29);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "确定";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.txtRemark);
            this.panelControl2.Controls.Add(this.txtTotalAmount);
            this.panelControl2.Controls.Add(this.txtUnitPrice);
            this.panelControl2.Controls.Add(this.txtQty);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(5, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(257, 265);
            this.panelControl2.TabIndex = 2;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(101, 222);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtRemark.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtRemark.Properties.Appearance.Options.UseBackColor = true;
            this.txtRemark.Properties.Appearance.Options.UseFont = true;
            this.txtRemark.Size = new System.Drawing.Size(100, 26);
            this.txtRemark.TabIndex = 4;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(101, 187);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTotalAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotalAmount.Properties.Appearance.Options.UseFont = true;
            this.txtTotalAmount.Properties.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 26);
            this.txtTotalAmount.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(101, 152);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtUnitPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtUnitPrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtUnitPrice.Properties.Appearance.Options.UseFont = true;
            this.txtUnitPrice.Properties.DisplayFormat.FormatString = "f";
            this.txtUnitPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUnitPrice.Properties.EditFormat.FormatString = "f";
            this.txtUnitPrice.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUnitPrice.Properties.Mask.EditMask = "f";
            this.txtUnitPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 26);
            this.txtUnitPrice.TabIndex = 2;
            this.txtUnitPrice.EditValueChanged += new System.EventHandler(this.txtUnitPrice_EditValueChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(101, 117);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtQty.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtQty.Properties.Appearance.Options.UseBackColor = true;
            this.txtQty.Properties.Appearance.Options.UseFont = true;
            this.txtQty.Properties.Mask.EditMask = "d";
            this.txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQty.Size = new System.Drawing.Size(100, 26);
            this.txtQty.TabIndex = 1;
            this.txtQty.EditValueChanged += new System.EventHandler(this.txtQty_EditValueChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl1);
            this.panelControl3.Controls.Add(this.txtBarCode);
            this.panelControl3.Controls.Add(this.txtItemNo);
            this.panelControl3.Controls.Add(this.txtItemName);
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(257, 100);
            this.panelControl3.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(10, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "商品编号：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBarCode.Location = new System.Drawing.Point(85, 12);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(7, 16);
            this.txtBarCode.TabIndex = 0;
            this.txtBarCode.Text = "0";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtItemNo.Location = new System.Drawing.Point(85, 41);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(7, 16);
            this.txtItemNo.TabIndex = 0;
            this.txtItemNo.Text = "0";
            // 
            // txtItemName
            // 
            this.txtItemName.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtItemName.Location = new System.Drawing.Point(85, 70);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(7, 16);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.Text = "0";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(10, 41);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 17);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "商品货号：";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(10, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(75, 17);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "商品名称：";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Location = new System.Drawing.Point(9, 225);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(86, 19);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "备       注：";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Location = new System.Drawing.Point(10, 191);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(85, 19);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "单价合计：";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Location = new System.Drawing.Point(9, 155);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(86, 19);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "单       价：";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(9, 120);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 19);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "数       量：";
            // 
            // frmDialogSaleEdit
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(267, 305);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDialogSaleEdit";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Text = "修销售商品信息";
            this.Load += new System.EventHandler(this.frmDialogSaleEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl txtBarCode;
        private DevExpress.XtraEditors.LabelControl txtItemNo;
        private DevExpress.XtraEditors.LabelControl txtItemName;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.TextEdit txtQty;
        private DevExpress.XtraEditors.TextEdit txtRemark;
        private DevExpress.XtraEditors.TextEdit txtTotalAmount;
        private DevExpress.XtraEditors.TextEdit txtUnitPrice;
    }
}