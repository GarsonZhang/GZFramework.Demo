using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using GZPSI.Library.SearchTextEdit;
using System;
using System.ComponentModel;

namespace GZPSI.Library.MyControls
{
    [ToolboxItem(true)]
    public class SearchTextEdit : TextEdit
    {
        static SearchTextEdit()
        {
            RepositoryItemSearchTextEdit.RegisterSearchTextEdit();
        }

        public SearchTextEdit() : base()
        {
            if (Common.CheckDesingModel.IsDesingMode) return;
            KeyDown += SearchTextEdit_KeyDown;
            this.Validated += SearchTextEdit_Validated;
            this.Properties.ValidateOnEnterKey = true;
        }

        public string bkEditValue;
        private void SearchTextEdit_Validated(object sender, EventArgs e)
        {
            if (bkEditValue != this.Text)
            {
                this.Text = bkEditValue;
            }
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
                return RepositoryItemSearchTextEdit.ItemName;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemSearchTextEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemSearchTextEdit;
            }
        }


    }

    [UserRepositoryItem("RegisterSearchTextEdit")]
    [ToolboxItem(true)]
    public class RepositoryItemSearchTextEdit : RepositoryItemTextEdit
    {


        /// <summary>
        /// 选择
        /// </summary>
        public event OnSelectChangedHandle OnSelectChanged;

        private bool _movetonext = true;
        [DefaultValue(true)]
        public bool FocuseMoveToNext { get { return _movetonext; } set { _movetonext = value; } }

        public bool OpenDataDialog(BaseEdit sender)
        {

            if (this.FormShowDialog != null)
            {
                using (frmDialogDataSearchBase frm = (frmDialogDataSearchBase)Activator.CreateInstance(this.FormShowDialog))
                {
                    frm.SearchCode = Convert.ToString(sender.EditValue);
                    frm.OwnerEdit = sender;
                    frm.OnSelectChanged += OnSelectChanged;
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK && FocuseMoveToNext)
                        System.Windows.Forms.SendKeys.Send("{Tab}");  //向活动应用程序发送击键 注意格式：Send("{Tab}");中的{}

                }
            }
            return true;
        }


        object GetProperty(object obj, string PropertyName)
        {
            var p = obj.GetType().GetProperty(PropertyName);
            return p.GetValue(obj, null);
        }

        static RepositoryItemSearchTextEdit()
        {
            RegisterSearchTextEdit();
        }

        public RepositoryItemSearchTextEdit()
        {
            Console.WriteLine("初始化:RepositoryItemSearchTextEdit");
            if (Common.CheckDesingModel.IsDesingMode) return;
            KeyDown += RepositoryItemSearchTextEdit_KeyDown;
            this.ValidateOnEnterKey = true;
        }





        private void RepositoryItemSearchTextEdit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                e.Handled = OpenDataDialog(sender as BaseEdit);
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




        public const string ItemName = "SearchTextEditValue";

        public override string EditorTypeName { get { return ItemName; } }

        public static void RegisterSearchTextEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(ItemName,
              typeof(SearchTextEdit), typeof(RepositoryItemSearchTextEdit),
              typeof(TextEditViewInfo), new TextEditPainter(), true));

        }



        public Type FormShowDialog { get; set; }

    }

}
