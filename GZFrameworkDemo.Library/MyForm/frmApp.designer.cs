namespace GZFrameworkDemo.Library.MyForm
{
    partial class frmApp
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_pwd = new DevExpress.XtraEditors.TextEdit();
            this.btn_Access = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Abort = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_pwd.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "密码";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(75, 12);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Properties.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(161, 20);
            this.txt_pwd.TabIndex = 1;
            // 
            // btn_Access
            // 
            this.btn_Access.Location = new System.Drawing.Point(3, 3);
            this.btn_Access.Name = "btn_Access";
            this.btn_Access.Size = new System.Drawing.Size(66, 37);
            this.btn_Access.TabIndex = 0;
            this.btn_Access.Text = "通过";
            this.btn_Access.Click += new System.EventHandler(this.btn_Access_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(75, 3);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(66, 37);
            this.btn_Stop.TabIndex = 0;
            this.btn_Stop.Text = "驳回";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(219, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(66, 37);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_Access);
            this.flowLayoutPanel1.Controls.Add(this.btn_Stop);
            this.flowLayoutPanel1.Controls.Add(this.btn_Abort);
            this.flowLayoutPanel1.Controls.Add(this.btn_Cancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(297, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_Abort
            // 
            this.btn_Abort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Abort.Location = new System.Drawing.Point(147, 3);
            this.btn_Abort.Name = "btn_Abort";
            this.btn_Abort.Size = new System.Drawing.Size(66, 37);
            this.btn_Abort.TabIndex = 0;
            this.btn_Abort.Text = "弃审";
            this.btn_Abort.Click += new System.EventHandler(this.btn_Abort_Click);
            // 
            // frmApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(297, 94);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmApp";
            this.Text = "审核";
            this.Load += new System.EventHandler(this.frmApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_pwd.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_pwd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Stop;
        private DevExpress.XtraEditors.SimpleButton btn_Access;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btn_Abort;
    }
}