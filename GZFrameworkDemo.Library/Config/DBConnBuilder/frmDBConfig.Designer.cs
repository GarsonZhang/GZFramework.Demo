namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    partial class frmDBConfig
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
            this.txt_ProviderName = new DevExpress.XtraEditors.LookUpEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txt_DBCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tp_SQL = new DevExpress.XtraTab.XtraTabPage();
            this.uc_SQLConfig1 = new GZFrameworkDemo.Library.Config.DBConnBuilder.uc_SQLConfig();
            this.tp_SQLite = new DevExpress.XtraTab.XtraTabPage();
            this.uc_SQLiteConfig1 = new GZFrameworkDemo.Library.Config.DBConnBuilder.uc_SQLiteConfig();
            this.tp_Access = new DevExpress.XtraTab.XtraTabPage();
            this.uc_AccessConfig1 = new GZFrameworkDemo.Library.Config.DBConnBuilder.uc_AccessConfig();
            this.tp_Oracle = new DevExpress.XtraTab.XtraTabPage();
            this.uc_OracleConfig1 = new GZFrameworkDemo.Library.Config.DBConnBuilder.uc_OracleConfig();
            this.tp_Error = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tp_Start = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_OK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProviderName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DBCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tp_SQL.SuspendLayout();
            this.tp_SQLite.SuspendLayout();
            this.tp_Access.SuspendLayout();
            this.tp_Oracle.SuspendLayout();
            this.tp_Error.SuspendLayout();
            this.tp_Start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "数据库类型";
            // 
            // txt_ProviderName
            // 
            this.txt_ProviderName.Location = new System.Drawing.Point(82, 7);
            this.txt_ProviderName.Name = "txt_ProviderName";
            this.txt_ProviderName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_ProviderName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name1")});
            this.txt_ProviderName.Properties.DisplayMember = "Name";
            this.txt_ProviderName.Properties.NullText = "";
            this.txt_ProviderName.Properties.PopupSizeable = false;
            this.txt_ProviderName.Properties.ShowHeader = false;
            this.txt_ProviderName.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txt_ProviderName.Properties.ValueMember = "InvariantName";
            this.txt_ProviderName.Size = new System.Drawing.Size(216, 20);
            this.txt_ProviderName.TabIndex = 1;
            this.txt_ProviderName.EditValueChanged += new System.EventHandler(this.txt_ProviderName_EditValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txt_DBCode);
            this.panelControl1.Controls.Add(this.txt_ProviderName);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(320, 58);
            this.panelControl1.TabIndex = 2;
            // 
            // txt_DBCode
            // 
            this.txt_DBCode.Location = new System.Drawing.Point(82, 31);
            this.txt_DBCode.Name = "txt_DBCode";
            this.txt_DBCode.Size = new System.Drawing.Size(216, 20);
            this.txt_DBCode.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 34);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "数据库编号";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Enabled = false;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 58);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tp_SQL;
            this.xtraTabControl1.Size = new System.Drawing.Size(320, 163);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tp_SQL,
            this.tp_SQLite,
            this.tp_Access,
            this.tp_Oracle,
            this.tp_Error,
            this.tp_Start});
            // 
            // tp_SQL
            // 
            this.tp_SQL.Controls.Add(this.uc_SQLConfig1);
            this.tp_SQL.Name = "tp_SQL";
            this.tp_SQL.Size = new System.Drawing.Size(314, 134);
            this.tp_SQL.Text = "MSSQL";
            // 
            // uc_SQLConfig1
            // 
            this.uc_SQLConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_SQLConfig1.Location = new System.Drawing.Point(0, 0);
            this.uc_SQLConfig1.Name = "uc_SQLConfig1";
            this.uc_SQLConfig1.Size = new System.Drawing.Size(314, 134);
            this.uc_SQLConfig1.TabIndex = 0;
            // 
            // tp_SQLite
            // 
            this.tp_SQLite.Controls.Add(this.uc_SQLiteConfig1);
            this.tp_SQLite.Name = "tp_SQLite";
            this.tp_SQLite.Size = new System.Drawing.Size(314, 134);
            this.tp_SQLite.Text = "SQLite";
            // 
            // uc_SQLiteConfig1
            // 
            this.uc_SQLiteConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_SQLiteConfig1.Location = new System.Drawing.Point(0, 0);
            this.uc_SQLiteConfig1.Name = "uc_SQLiteConfig1";
            this.uc_SQLiteConfig1.Size = new System.Drawing.Size(314, 134);
            this.uc_SQLiteConfig1.TabIndex = 0;
            // 
            // tp_Access
            // 
            this.tp_Access.Controls.Add(this.uc_AccessConfig1);
            this.tp_Access.Name = "tp_Access";
            this.tp_Access.Size = new System.Drawing.Size(314, 134);
            this.tp_Access.Text = "Access";
            // 
            // uc_AccessConfig1
            // 
            this.uc_AccessConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_AccessConfig1.Location = new System.Drawing.Point(0, 0);
            this.uc_AccessConfig1.Name = "uc_AccessConfig1";
            this.uc_AccessConfig1.Size = new System.Drawing.Size(314, 134);
            this.uc_AccessConfig1.TabIndex = 0;
            // 
            // tp_Oracle
            // 
            this.tp_Oracle.Controls.Add(this.uc_OracleConfig1);
            this.tp_Oracle.Name = "tp_Oracle";
            this.tp_Oracle.Size = new System.Drawing.Size(314, 134);
            this.tp_Oracle.Text = "Oracle";
            // 
            // uc_OracleConfig1
            // 
            this.uc_OracleConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_OracleConfig1.Location = new System.Drawing.Point(0, 0);
            this.uc_OracleConfig1.Name = "uc_OracleConfig1";
            this.uc_OracleConfig1.Size = new System.Drawing.Size(314, 134);
            this.uc_OracleConfig1.TabIndex = 0;
            // 
            // tp_Error
            // 
            this.tp_Error.Controls.Add(this.labelControl2);
            this.tp_Error.Name = "tp_Error";
            this.tp_Error.Size = new System.Drawing.Size(314, 134);
            this.tp_Error.Text = "Error";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(0, 0);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(314, 134);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "没有找到对应类型的配置程序\r\n请联系管理员";
            // 
            // tp_Start
            // 
            this.tp_Start.Controls.Add(this.labelControl4);
            this.tp_Start.Name = "tp_Start";
            this.tp_Start.Size = new System.Drawing.Size(314, 134);
            this.tp_Start.Text = "Start";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(0, 0);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(314, 134);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "请选择数据库类型\r\n有问题请联系管理员\r\n";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_Exit);
            this.panelControl2.Controls.Add(this.btn_OK);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 221);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(320, 40);
            this.panelControl2.TabIndex = 4;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(181, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 30);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "取消";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(82, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 30);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "确定";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // frmDBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 261);
            this.ControlBox = false;
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "frmDBConfig";
            this.Text = "数据库配置";
            this.Load += new System.EventHandler(this.frmDBConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_ProviderName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DBCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tp_SQL.ResumeLayout(false);
            this.tp_SQLite.ResumeLayout(false);
            this.tp_Access.ResumeLayout(false);
            this.tp_Oracle.ResumeLayout(false);
            this.tp_Error.ResumeLayout(false);
            this.tp_Start.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit txt_ProviderName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tp_SQL;
        private DevExpress.XtraTab.XtraTabPage tp_SQLite;
        private DevExpress.XtraTab.XtraTabPage tp_Error;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DBConnBuilder.uc_SQLConfig uc_SQLConfig1;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.SimpleButton btn_OK;
        private DevExpress.XtraEditors.TextEdit txt_DBCode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private uc_SQLiteConfig uc_SQLiteConfig1;
        private DevExpress.XtraTab.XtraTabPage tp_Access;
        private DevExpress.XtraTab.XtraTabPage tp_Oracle;
        private uc_AccessConfig uc_AccessConfig1;
        private DevExpress.XtraTab.XtraTabPage tp_Start;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private uc_OracleConfig uc_OracleConfig1;

    }
}