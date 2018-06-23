namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    partial class frmDBConfigNew
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_DBCode = new System.Windows.Forms.TextBox();
            this.txt_ProviderName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_Sql = new System.Windows.Forms.TabPage();
            this.ucEx_SQLConfig1 = new GZFrameworkDemo.Library.Config.DBConnBuilder.controls.ucEx_SQLConfig();
            this.tp_Sqlite = new System.Windows.Forms.TabPage();
            this.ucEx_SQLite1 = new GZFrameworkDemo.Library.Config.DBConnBuilder.controls.ucEx_SQLite();
            this.tp_Access = new System.Windows.Forms.TabPage();
            this.ucEx_AccessConfig1 = new GZFrameworkDemo.Library.Config.DBConnBuilder.controls.ucEx_AccessConfig();
            this.tp_Oracle = new System.Windows.Forms.TabPage();
            this.ucEx_OracleConfig1 = new GZFrameworkDemo.Library.Config.DBConnBuilder.controls.ucEx_OracleConfig();
            this.tp_Error = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tp_Start = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tp_Sql.SuspendLayout();
            this.tp_Sqlite.SuspendLayout();
            this.tp_Access.SuspendLayout();
            this.tp_Oracle.SuspendLayout();
            this.tp_Error.SuspendLayout();
            this.tp_Start.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库类型";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_DBCode);
            this.panel1.Controls.Add(this.txt_ProviderName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 96);
            this.panel1.TabIndex = 1;
            // 
            // txt_DBCode
            // 
            this.txt_DBCode.Location = new System.Drawing.Point(124, 50);
            this.txt_DBCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DBCode.Name = "txt_DBCode";
            this.txt_DBCode.Size = new System.Drawing.Size(247, 28);
            this.txt_DBCode.TabIndex = 2;
            // 
            // txt_ProviderName
            // 
            this.txt_ProviderName.FormattingEnabled = true;
            this.txt_ProviderName.Location = new System.Drawing.Point(124, 10);
            this.txt_ProviderName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ProviderName.Name = "txt_ProviderName";
            this.txt_ProviderName.Size = new System.Drawing.Size(247, 26);
            this.txt_ProviderName.TabIndex = 1;
            this.txt_ProviderName.SelectedIndexChanged += new System.EventHandler(this.txt_ProviderName_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "数据库编号";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_OK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(590, 70);
            this.panel2.TabIndex = 2;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(213, 16);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(112, 36);
            this.btn_Cancel.TabIndex = 5001;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(50, 16);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(112, 36);
            this.btn_OK.TabIndex = 500;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_Sql);
            this.tabControl1.Controls.Add(this.tp_Sqlite);
            this.tabControl1.Controls.Add(this.tp_Access);
            this.tabControl1.Controls.Add(this.tp_Oracle);
            this.tabControl1.Controls.Add(this.tp_Error);
            this.tabControl1.Controls.Add(this.tp_Start);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 96);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 226);
            this.tabControl1.TabIndex = 3;
            // 
            // tp_Sql
            // 
            this.tp_Sql.Controls.Add(this.ucEx_SQLConfig1);
            this.tp_Sql.Location = new System.Drawing.Point(4, 28);
            this.tp_Sql.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Sql.Name = "tp_Sql";
            this.tp_Sql.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Sql.Size = new System.Drawing.Size(582, 194);
            this.tp_Sql.TabIndex = 0;
            this.tp_Sql.Text = "MSSQL";
            this.tp_Sql.UseVisualStyleBackColor = true;
            // 
            // ucEx_SQLConfig1
            // 
            this.ucEx_SQLConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEx_SQLConfig1.Location = new System.Drawing.Point(4, 4);
            this.ucEx_SQLConfig1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ucEx_SQLConfig1.Name = "ucEx_SQLConfig1";
            this.ucEx_SQLConfig1.Size = new System.Drawing.Size(574, 186);
            this.ucEx_SQLConfig1.TabIndex = 4;
            // 
            // tp_Sqlite
            // 
            this.tp_Sqlite.Controls.Add(this.ucEx_SQLite1);
            this.tp_Sqlite.Location = new System.Drawing.Point(4, 28);
            this.tp_Sqlite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Sqlite.Name = "tp_Sqlite";
            this.tp_Sqlite.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Sqlite.Size = new System.Drawing.Size(582, 194);
            this.tp_Sqlite.TabIndex = 1;
            this.tp_Sqlite.Text = "SQLite";
            this.tp_Sqlite.UseVisualStyleBackColor = true;
            // 
            // ucEx_SQLite1
            // 
            this.ucEx_SQLite1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEx_SQLite1.Location = new System.Drawing.Point(4, 4);
            this.ucEx_SQLite1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ucEx_SQLite1.Name = "ucEx_SQLite1";
            this.ucEx_SQLite1.Size = new System.Drawing.Size(574, 186);
            this.ucEx_SQLite1.TabIndex = 5;
            // 
            // tp_Access
            // 
            this.tp_Access.Controls.Add(this.ucEx_AccessConfig1);
            this.tp_Access.Location = new System.Drawing.Point(4, 28);
            this.tp_Access.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Access.Name = "tp_Access";
            this.tp_Access.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Access.Size = new System.Drawing.Size(582, 193);
            this.tp_Access.TabIndex = 2;
            this.tp_Access.Text = "Access";
            this.tp_Access.UseVisualStyleBackColor = true;
            // 
            // ucEx_AccessConfig1
            // 
            this.ucEx_AccessConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEx_AccessConfig1.Location = new System.Drawing.Point(4, 4);
            this.ucEx_AccessConfig1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ucEx_AccessConfig1.Name = "ucEx_AccessConfig1";
            this.ucEx_AccessConfig1.Size = new System.Drawing.Size(574, 185);
            this.ucEx_AccessConfig1.TabIndex = 6;
            // 
            // tp_Oracle
            // 
            this.tp_Oracle.Controls.Add(this.ucEx_OracleConfig1);
            this.tp_Oracle.Location = new System.Drawing.Point(4, 28);
            this.tp_Oracle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Oracle.Name = "tp_Oracle";
            this.tp_Oracle.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Oracle.Size = new System.Drawing.Size(582, 193);
            this.tp_Oracle.TabIndex = 3;
            this.tp_Oracle.Text = "Oracle";
            this.tp_Oracle.UseVisualStyleBackColor = true;
            // 
            // ucEx_OracleConfig1
            // 
            this.ucEx_OracleConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEx_OracleConfig1.Location = new System.Drawing.Point(4, 4);
            this.ucEx_OracleConfig1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ucEx_OracleConfig1.Name = "ucEx_OracleConfig1";
            this.ucEx_OracleConfig1.Size = new System.Drawing.Size(574, 185);
            this.ucEx_OracleConfig1.TabIndex = 7;
            // 
            // tp_Error
            // 
            this.tp_Error.Controls.Add(this.label3);
            this.tp_Error.Location = new System.Drawing.Point(4, 28);
            this.tp_Error.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Error.Name = "tp_Error";
            this.tp_Error.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Error.Size = new System.Drawing.Size(582, 193);
            this.tp_Error.TabIndex = 4;
            this.tp_Error.Text = "Error";
            this.tp_Error.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(574, 185);
            this.label3.TabIndex = 0;
            this.label3.Text = "没有找到对应类型的配置程序\r\n请联系管理员";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tp_Start
            // 
            this.tp_Start.Controls.Add(this.label4);
            this.tp_Start.Location = new System.Drawing.Point(4, 28);
            this.tp_Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Start.Name = "tp_Start";
            this.tp_Start.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Start.Size = new System.Drawing.Size(582, 193);
            this.tp_Start.TabIndex = 5;
            this.tp_Start.Text = "Start";
            this.tp_Start.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(574, 185);
            this.label4.TabIndex = 1;
            this.label4.Text = "请选择数据库类型\r\n有问题请联系管理员\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDBConfigNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 392);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDBConfigNew";
            this.Text = "数据库配置";
            this.Load += new System.EventHandler(this.frmDBConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tp_Sql.ResumeLayout(false);
            this.tp_Sqlite.ResumeLayout(false);
            this.tp_Access.ResumeLayout(false);
            this.tp_Oracle.ResumeLayout(false);
            this.tp_Error.ResumeLayout(false);
            this.tp_Start.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DBCode;
        private System.Windows.Forms.ComboBox txt_ProviderName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_Sql;
        private System.Windows.Forms.TabPage tp_Sqlite;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_OK;
        private controls.ucEx_SQLConfig ucEx_SQLConfig1;
        private controls.ucEx_SQLite ucEx_SQLite1;
        private System.Windows.Forms.TabPage tp_Access;
        private System.Windows.Forms.TabPage tp_Oracle;
        private System.Windows.Forms.TabPage tp_Error;
        private System.Windows.Forms.TabPage tp_Start;
        private controls.ucEx_AccessConfig ucEx_AccessConfig1;
        private controls.ucEx_OracleConfig ucEx_OracleConfig1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}