//======================================================================
//        版权所有@GarsonZhang
//        文件名 :uc_DBConfig              									
//		  .NET版本：4.0
//        创建人：GarsonZhang  QQ：382237285
//        创建日期：2015-07-24 14:55:27
//        描述 :自定义控件
//======================================================================
namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    partial class uc_SQLConfig
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_Port = new DevExpress.XtraEditors.TextEdit();
            this.txt_Pwd = new DevExpress.XtraEditors.TextEdit();
            this.txt_User = new DevExpress.XtraEditors.TextEdit();
            this.txt_Server = new DevExpress.XtraEditors.TextEdit();
            this.txt_DataBase = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Port.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_User.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Server.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DataBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(304, 127);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txt_Port);
            this.layoutControl1.Controls.Add(this.txt_Pwd);
            this.layoutControl1.Controls.Add(this.txt_User);
            this.layoutControl1.Controls.Add(this.txt_Server);
            this.layoutControl1.Controls.Add(this.txt_DataBase);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(300, 123);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_Port
            // 
            this.txt_Port.EditValue = "1433";
            this.txt_Port.Location = new System.Drawing.Point(236, 12);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(52, 20);
            this.txt_Port.StyleController = this.layoutControl1;
            this.txt_Port.TabIndex = 8;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Location = new System.Drawing.Point(51, 60);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Properties.PasswordChar = '*';
            this.txt_Pwd.Size = new System.Drawing.Size(237, 20);
            this.txt_Pwd.StyleController = this.layoutControl1;
            this.txt_Pwd.TabIndex = 6;
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(51, 36);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(237, 20);
            this.txt_User.StyleController = this.layoutControl1;
            this.txt_User.TabIndex = 5;
            // 
            // txt_Server
            // 
            this.txt_Server.Location = new System.Drawing.Point(51, 12);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Size = new System.Drawing.Size(142, 20);
            this.txt_Server.StyleController = this.layoutControl1;
            this.txt_Server.TabIndex = 4;
            // 
            // txt_DataBase
            // 
            this.txt_DataBase.Location = new System.Drawing.Point(51, 84);
            this.txt_DataBase.Name = "txt_DataBase";
            this.txt_DataBase.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.txt_DataBase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_DataBase.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "数据库")});
            this.txt_DataBase.Properties.DisplayMember = "name";
            this.txt_DataBase.Properties.NullText = "";
            this.txt_DataBase.Properties.ValueMember = "name";
            this.txt_DataBase.Size = new System.Drawing.Size(237, 20);
            this.txt_DataBase.StyleController = this.layoutControl1;
            this.txt_DataBase.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(300, 123);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem1.Control = this.txt_Server;
            this.layoutControlItem1.CustomizationFormText = "服务器";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(185, 24);
            this.layoutControlItem1.Text = "服务器";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(36, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem2.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem2.Control = this.txt_User;
            this.layoutControlItem2.CustomizationFormText = "用户名";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem2.Text = "用户名";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(36, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem3.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem3.Control = this.txt_Pwd;
            this.layoutControlItem3.CustomizationFormText = "密码";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(280, 24);
            this.layoutControlItem3.Text = "密码";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(36, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem4.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem4.Control = this.txt_DataBase;
            this.layoutControlItem4.CustomizationFormText = "数据库";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(280, 31);
            this.layoutControlItem4.Text = "数据库";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(36, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControlItem5.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem5.Control = this.txt_Port;
            this.layoutControlItem5.CustomizationFormText = "端口";
            this.layoutControlItem5.Location = new System.Drawing.Point(185, 0);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(95, 24);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(95, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(95, 24);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "端口";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(36, 14);
            // 
            // uc_SQLConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "uc_SQLConfig";
            this.Size = new System.Drawing.Size(304, 127);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Port.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_User.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Server.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DataBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txt_Pwd;
        private DevExpress.XtraEditors.TextEdit txt_User;
        private DevExpress.XtraEditors.TextEdit txt_Server;
        private DevExpress.XtraEditors.LookUpEdit txt_DataBase;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txt_Port;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}
