namespace ClothingPSISQLite.PSIModule.Dialog
{
    partial class frmDailogSalePay
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIn = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOut = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOut.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "应付款RMB：";
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = "250";
            this.txtAmount.Location = new System.Drawing.Point(86, 71);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.txtAmount.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtAmount.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtAmount.Properties.Appearance.Options.UseBackColor = true;
            this.txtAmount.Properties.Appearance.Options.UseBorderColor = true;
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.Properties.Appearance.Options.UseForeColor = true;
            this.txtAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtAmount.Properties.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(194, 42);
            this.txtAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "收款RMB：";
            // 
            // txtIn
            // 
            this.txtIn.EditValue = "0";
            this.txtIn.Location = new System.Drawing.Point(86, 170);
            this.txtIn.Name = "txtIn";
            this.txtIn.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtIn.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtIn.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtIn.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtIn.Properties.Appearance.Options.UseBackColor = true;
            this.txtIn.Properties.Appearance.Options.UseBorderColor = true;
            this.txtIn.Properties.Appearance.Options.UseFont = true;
            this.txtIn.Properties.Appearance.Options.UseForeColor = true;
            this.txtIn.Properties.Appearance.Options.UseTextOptions = true;
            this.txtIn.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtIn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtIn.Size = new System.Drawing.Size(194, 42);
            this.txtIn.TabIndex = 2;
            this.txtIn.EditValueChanged += new System.EventHandler(this.txtIn_EditValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(297, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 250);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(308, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "找零RMB：";
            // 
            // txtOut
            // 
            this.txtOut.EditValue = "250";
            this.txtOut.Location = new System.Drawing.Point(362, 71);
            this.txtOut.Name = "txtOut";
            this.txtOut.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.txtOut.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtOut.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.txtOut.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtOut.Properties.Appearance.Options.UseBackColor = true;
            this.txtOut.Properties.Appearance.Options.UseBorderColor = true;
            this.txtOut.Properties.Appearance.Options.UseFont = true;
            this.txtOut.Properties.Appearance.Options.UseForeColor = true;
            this.txtOut.Properties.Appearance.Options.UseTextOptions = true;
            this.txtOut.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtOut.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtOut.Properties.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(194, 42);
            this.txtOut.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(159)))), ((int)(((byte)(12)))));
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(357, 163);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 49);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "确定";
            this.simpleButton1.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(159)))), ((int)(((byte)(12)))));
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton2.Location = new System.Drawing.Point(459, 163);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 49);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "取消";
            this.simpleButton2.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmDailogSalePay
            // 
            this.AcceptButton = this.simpleButton1;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.simpleButton2;
            this.ClientSize = new System.Drawing.Size(574, 264);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmDailogSalePay";
            this.Text = "结算";
            this.Load += new System.EventHandler(this.frmDailogSalePay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOut.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtIn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtOut;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}