using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using GZFramework.UI.Core;
using GZFrameworkDemo.Library.SearchTextEdit;
using System;
using System.ComponentModel;
using DevExpress.XtraEditors.Controls;

namespace GZFrameworkDemo.Library.MyControls
{
    [ToolboxItem(true)]
    public class SearchButtonEdit : ButtonEdit
    {

        static SearchButtonEdit()
        {
            RepositoryItemSearchButtonEdit.RegisterSearchTextEdit();
        }

        public SearchButtonEdit() : base()
        {

            if (Common.CheckDesingModel.IsDesingMode) return;
            KeyDown += SearchTextEdit_KeyDown;
            this.Properties.ValidateOnEnterKey = true;
            this.Validating += RepositoryItemSearchButtonEdit_Validating;
            this.EditValueChanging += RepositoryItemSearchButtonEdit_EditValueChanging;
        }


        private void RepositoryItemSearchButtonEdit_Validating(object sender, CancelEventArgs e)
        {
            
            string value = (sender as BaseEdit).EditValue + "";
            if (value != BK1)
            {
                if (this.Properties.AllowCustomerValue == true)
                {
                    this.Properties.SetSelectNull(sender as SearchButtonEdit);
                    return;
                }
                else
                    (sender as BaseEdit).EditValue = BK1;
            }
        }

        public bool BK = false;
        public string BK1 = "";
        private void RepositoryItemSearchButtonEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {
            System.Diagnostics.Debug.Print("Validating_EditValueChanging:" + (sender as BaseEdit).EditValue);
            if (BK == false)
            {
                BK1 = (sender as BaseEdit).EditValue + "";
                BK = true;
            }
            System.Diagnostics.Debug.Print("Validating_BKValue:" + BK1);

        }


        protected override void OnLoaded()
        {
            base.OnLoaded();

            this.Properties.NullValuePromptShowForEmptyValue = true;

            this.Properties.AllowNullInput = DefaultBoolean.False;

        }


        private void SearchTextEdit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                this.Properties.OpenDataDialog(this);
        }



        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemSearchButtonEdit.ItemName;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemSearchButtonEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemSearchButtonEdit;
            }
        }
    }

    [UserRepositoryItem("RegisterSearchButtonEdit")]
    [ToolboxItem(true)]
    public class RepositoryItemSearchButtonEdit : RepositoryItemButtonEdit
    {

        /// <summary>
        /// 选择
        /// </summary>
        public event OnSelectChangedHandle OnSelectChanged;

        private bool _movetonext = true;
        [DefaultValue(true)]
        public bool FocuseMoveToNext { get { return _movetonext; } set { _movetonext = value; } }

        [Description("是否允许自定义值")]
        public bool AllowCustomerValue { get; set; }
        public bool OpenDataDialog(SearchButtonEdit sender)
        {

            if (this.FormShowDialog != null)
            {
                using (frmDialogDataSearchBase frm = (frmDialogDataSearchBase)Activator.CreateInstance(this.FormShowDialog))
                {
                    frm.SearchCode = Convert.ToString(sender.EditValue);
                    frm.OwnerEdit = sender;
                    frm.OnSelectChanged += OnSelectChanged;

                    this.Tag = sender.EditValue;
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK && FocuseMoveToNext)
                        System.Windows.Forms.SendKeys.Send("{Tab}");  //向活动应用程序发送击键 注意格式：Send("{Tab}");中的{}

                }
            }
            return true;


        }
        public override void Assign(RepositoryItem item)
        {

            //System.Diagnostics.Debug.Print("Assign[this.Tag]:" + this.OwnerEdit.EditValue);
            base.Assign(item);
            (this.OwnerEdit as SearchButtonEdit).BK = false;
            (this.OwnerEdit as SearchButtonEdit).BK1 = "";

        }


        static RepositoryItemSearchButtonEdit()
        {
            RegisterSearchTextEdit();
        }

        public RepositoryItemSearchButtonEdit()
        {
            this.Buttons.Clear();
            var ebtnSet = new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)
            {
                Caption = "选",
                Tag = "select"
            };//设置用户字段
            this.Buttons.Add(ebtnSet);

            this.ButtonClick += RepositoryItemSearchButtonEdit_ButtonClick;

            if (Common.CheckDesingModel.IsDesingMode) return;
            KeyDown += RepositoryItemSearchTextEdit_KeyDown;
            this.ValidateOnEnterKey = true;

            this.Validating += RepositoryItemSearchButtonEdit_Validating;
            this.EditValueChanging += RepositoryItemSearchButtonEdit_EditValueChanging;
        }

        private void RepositoryItemSearchButtonEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {
            SearchButtonEdit col = (sender as SearchButtonEdit);
            if (col.BK == false)
            {
                col.BK1 = (sender as BaseEdit).EditValue + "";
                col.BK = true;
            }
        }

        private void RepositoryItemSearchButtonEdit_Validating(object sender, CancelEventArgs e)
        {

            SearchButtonEdit col = (sender as SearchButtonEdit);

            string value = col.EditValue + "";
            if (value != col.BK1)
            {
                if (this.AllowCustomerValue == true)
                {
                    SetSelectNull(col);
                    return;
                }
                else
                    (sender as BaseEdit).EditValue = col.BK1;
            }
        }

        internal void SetSelectNull(SearchButtonEdit col)
        {
            OnSelectChanged?.Invoke(col, null);
        }
        private void RepositoryItemSearchButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if ("select".Equals(e.Button.Tag))
            {
                this.OpenDataDialog(sender as SearchButtonEdit);
                //bool success = frmDialog_CommonSearchSetting.ShowForm(Code);
                //if (success == true)
                //    RefreshSearch();
            }
        }

        private void RepositoryItemSearchTextEdit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                e.Handled = OpenDataDialog(sender as SearchButtonEdit);
            }
        }



        GZFramework.UI.Dev.LibForm.frmBaseDialog FormDialog
        {
            get
            {
                if (FormShowDialog == null) return null;
                return (GZFramework.UI.Dev.LibForm.frmBaseDialog)Activator.CreateInstance(FormShowDialog);
            }
        }




        public const string ItemName = "SearchButtonEditValue";

        public override string EditorTypeName { get { return ItemName; } }

        public static void RegisterSearchTextEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(ItemName,
              typeof(SearchButtonEdit), typeof(RepositoryItemSearchButtonEdit),
              typeof(ButtonEditViewInfo), new ButtonEditPainter(), true));


        }



        public Type FormShowDialog { get; set; }

    }

}
