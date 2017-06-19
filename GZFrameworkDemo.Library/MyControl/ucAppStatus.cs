using GZFrameworkDemo.Common;
using GZFrameworkDemo.Library.MyForm;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library.MyControl
{
    [ToolboxItem(true)]
    public class ucAppStatus : LookUpEdit
    {
        //private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit fProperties;
        DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
        public ucAppStatus()
        {
            //InitializeComponent();
            this.Location = new System.Drawing.Point(797, 16);
            this.Name = "lookUpEdit1";
            this.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            this.Properties.Appearance.Options.UseFont = true;
            this.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.Properties.NullText = "未审核";
            this.Size = new System.Drawing.Size(115, 44);
            this.TabIndex = 2;
            if (Common.CheckDesingModel.IsDesingMode) return;
            Library.DataBinderTools.Bound.BoundEnumData(this, typeof(frmAppResult));
            this.EditValueChanged += UcAppStatus_EditValueChanged;
        }



        private void UcAppStatus_EditValueChanged(object sender, EventArgs e)
        {
            if (ConvertLib.ToInt(this.EditValue) == 0)
            {
                this.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(99, 99, 99);
            }
            if (ConvertLib.ToInt(this.EditValue) == -1)
            {
                this.Properties.Appearance.ForeColor = System.Drawing.Color.Brown;
            }
            if (ConvertLib.ToInt(this.EditValue) == 1)
            {
                this.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            }
            if (ConvertLib.ToInt(this.EditValue) == 2)
            {
                this.Properties.Appearance.ForeColor = System.Drawing.Color.DarkViolet;
            }
        }

        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            //this.fProperties = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // fProperties
            // 
            this.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            this.Properties.Appearance.Options.UseFont = true;
            this.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.Properties.Name = "fProperties";
            this.Properties.NullText = "未审核";
            this.Properties.ReadOnly = true;
            // 
            // ucAppStatus
            // 
            this.Size = new System.Drawing.Size(100, 44);
            ((System.ComponentModel.ISupportInitialize)(this.fProperties)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
