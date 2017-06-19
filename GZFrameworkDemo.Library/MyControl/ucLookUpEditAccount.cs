using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library.MyControl
{


    [ToolboxItem(true)]
    public class LookUpEditAccount : LookUpEdit
    {
        static LookUpEditAccount()
        {
            RepositoryItemLookUpEditAccount.RegisterSearchTextEdit();
        }

        public LookUpEditAccount() : base()
        {
        }



        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemLookUpEditAccount.ItemName;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemLookUpEditAccount Properties
        {
            get
            {
                return base.Properties as RepositoryItemLookUpEditAccount;
            }
        }


    }

    [UserRepositoryItem("RegisterLookUpEditAccount")]
    [ToolboxItem(true)]
    public class RepositoryItemLookUpEditAccount : RepositoryItemLookUpEdit
    {


        static RepositoryItemLookUpEditAccount()
        {
            RegisterSearchTextEdit();
        }

        public RepositoryItemLookUpEditAccount()
        {
            this.NullText = "";
            if (Common.CheckDesingModel.IsDesingMode) return;
            DataBinderTools.Bound.BoundUserName(this);
            this.ValidateOnEnterKey = true;
        }




        public const string ItemName = "LookUpEditAccount";

        public override string EditorTypeName { get { return ItemName; } }

        public static void RegisterSearchTextEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(ItemName,
              typeof(LookUpEditAccount), typeof(RepositoryItemLookUpEditAccount),
              typeof(DevExpress.XtraEditors.ViewInfo.LookUpEditViewInfo), new DevExpress.XtraEditors.Drawing.TextEditPainter(), true));

        }



    }
}
