namespace GZFrameworkDemo.SystemManagement
{
    partial class frmModuleMain
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
            this.btn_User = new DevExpress.XtraEditors.SimpleButton();
            this.btn_MyRole = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Setting = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CompanyInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btn_SystemAuthority = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.flowLayoutPanel1);
            this.panelControl1.Size = new System.Drawing.Size(474, 215);
            // 
            // btn_User
            // 
            this.btn_User.Location = new System.Drawing.Point(3, 3);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(75, 61);
            this.btn_User.TabIndex = 0;
            this.btn_User.Text = "账号管理";
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_MyRole
            // 
            this.btn_MyRole.Location = new System.Drawing.Point(84, 3);
            this.btn_MyRole.Name = "btn_MyRole";
            this.btn_MyRole.Size = new System.Drawing.Size(75, 61);
            this.btn_MyRole.TabIndex = 0;
            this.btn_MyRole.Text = "角色管理";
            this.btn_MyRole.Click += new System.EventHandler(this.btn_MyRole_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.Location = new System.Drawing.Point(165, 3);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(75, 61);
            this.btn_Setting.TabIndex = 0;
            this.btn_Setting.Text = "系统设置";
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_CompanyInfo
            // 
            this.btn_CompanyInfo.Location = new System.Drawing.Point(246, 3);
            this.btn_CompanyInfo.Name = "btn_CompanyInfo";
            this.btn_CompanyInfo.Size = new System.Drawing.Size(75, 61);
            this.btn_CompanyInfo.TabIndex = 0;
            this.btn_CompanyInfo.Text = "公司信息";
            this.btn_CompanyInfo.Click += new System.EventHandler(this.btn_CompanyInfo_Click);
            // 
            // btn_SystemAuthority
            // 
            this.btn_SystemAuthority.Location = new System.Drawing.Point(327, 3);
            this.btn_SystemAuthority.Name = "btn_SystemAuthority";
            this.btn_SystemAuthority.Size = new System.Drawing.Size(75, 61);
            this.btn_SystemAuthority.TabIndex = 0;
            this.btn_SystemAuthority.Text = "功能注册";
            this.btn_SystemAuthority.Click += new System.EventHandler(this.btn_SystemAuthority_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_User);
            this.flowLayoutPanel1.Controls.Add(this.btn_MyRole);
            this.flowLayoutPanel1.Controls.Add(this.btn_Setting);
            this.flowLayoutPanel1.Controls.Add(this.btn_CompanyInfo);
            this.flowLayoutPanel1.Controls.Add(this.btn_SystemAuthority);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(421, 72);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // frmModuleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 215);
            this.Name = "frmModuleMain";
            this.Text = "系统管理";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_User;
        private DevExpress.XtraEditors.SimpleButton btn_MyRole;
        private DevExpress.XtraEditors.SimpleButton btn_SystemAuthority;
        private DevExpress.XtraEditors.SimpleButton btn_CompanyInfo;
        private DevExpress.XtraEditors.SimpleButton btn_Setting;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}