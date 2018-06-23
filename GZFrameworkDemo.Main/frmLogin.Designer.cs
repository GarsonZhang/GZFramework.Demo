namespace GZFrameworkDemo.Main
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.chk_Accound = new System.Windows.Forms.CheckBox();
            this.btn_Login = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Pwd = new DevExpress.XtraEditors.TextEdit();
            this.txt_User = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Error = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_DataBaseList = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_User.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DataBaseList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Accound
            // 
            this.chk_Accound.AutoSize = true;
            this.chk_Accound.Location = new System.Drawing.Point(369, 176);
            this.chk_Accound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chk_Accound.Name = "chk_Accound";
            this.chk_Accound.Size = new System.Drawing.Size(108, 26);
            this.chk_Accound.TabIndex = 3;
            this.chk_Accound.Text = "记住账号";
            this.chk_Accound.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(369, 214);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(124, 68);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "登陆";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(369, 126);
            this.txt_Pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_Pwd.Properties.Appearance.Options.UseFont = true;
            this.txt_Pwd.Properties.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(250, 36);
            this.txt_Pwd.TabIndex = 2;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(369, 72);
            this.txt_User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_User.Name = "txt_User";
            this.txt_User.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_User.Properties.Appearance.Options.UseFont = true;
            this.txt_User.Size = new System.Drawing.Size(250, 36);
            this.txt_User.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(293, 130);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 29);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "密   码";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(291, 77);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 29);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "用户名";
            // 
            // txt_Error
            // 
            this.txt_Error.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_Error.Location = new System.Drawing.Point(294, 295);
            this.txt_Error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_Error.Name = "txt_Error";
            this.txt_Error.Size = new System.Drawing.Size(324, 57);
            this.txt_Error.TabIndex = 10;
            this.txt_Error.Text = "用户名或密码不正确！！";
            this.txt_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Error.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_User);
            this.panel1.Controls.Add(this.txt_Error);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.chk_Accound);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Controls.Add(this.txt_Pwd);
            this.panel1.Controls.Add(this.txt_DataBaseList);
            this.panel1.Location = new System.Drawing.Point(141, 203);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 373);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::GZFrameworkDemo.Main.Properties.Resources.full;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(4, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 250);
            this.panel2.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(294, 27);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 29);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "账套";
            // 
            // txt_DataBaseList
            // 
            this.txt_DataBaseList.Location = new System.Drawing.Point(369, 22);
            this.txt_DataBaseList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_DataBaseList.Name = "txt_DataBaseList";
            this.txt_DataBaseList.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txt_DataBaseList.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_DataBaseList.Properties.Appearance.Options.UseFont = true;
            this.txt_DataBaseList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_DataBaseList.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DBDisplayText", "账套名称")});
            this.txt_DataBaseList.Properties.DisplayMember = "DBDisplayText";
            this.txt_DataBaseList.Properties.NullText = "";
            this.txt_DataBaseList.Properties.ShowFooter = false;
            this.txt_DataBaseList.Properties.ShowHeader = false;
            this.txt_DataBaseList.Properties.ValueMember = "DBCode";
            this.txt_DataBaseList.Size = new System.Drawing.Size(250, 36);
            this.txt_DataBaseList.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(990, 850);
            this.panelControl1.TabIndex = 12;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 850);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmLogin";
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_User.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DataBaseList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Accound;
        private DevExpress.XtraEditors.SimpleButton btn_Login;
        private DevExpress.XtraEditors.TextEdit txt_Pwd;
        private DevExpress.XtraEditors.TextEdit txt_User;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label txt_Error;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit txt_DataBaseList;
    }
}