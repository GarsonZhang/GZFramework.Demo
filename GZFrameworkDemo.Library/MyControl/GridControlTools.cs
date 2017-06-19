using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using GZFrameworkDemo.Common;

namespace GZFrameworkDemo.Library.MyControl
{
    public partial class GridControlTools : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler Customer_DoImport;

        public event HandledEventHandler Customer_BeforeAdd;
        public event EventHandler Customer_AfterAdd;

        public event HandledEventHandler Customer_BeforeDelete;
        public event EventHandler Customer_AfterDelete;

        public event HandledEventHandler Customer_BeforeMoveFirst;
        public event EventHandler Customer_AfterMoveFirst;


        public event HandledEventHandler Customer_BeforeMovePrev;
        public event EventHandler Customer_AfterMovePrev;

        public event HandledEventHandler Customer_BeforeMoveNex;
        public event EventHandler Customer_AfterMoveNex;

        public event HandledEventHandler Customer_BeforeMoveLast;
        public event EventHandler Customer_AfterMoveLast;

        public event EventHandler Customer_Save;

        private RepositoryItemGridControlTools _properties;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public RepositoryItemGridControlTools Properties { get { return _properties; } }

        //public ColumnView View { get; set; }

        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        //public GridControlToolsButtons Buttons { get; set; }

        private ColumnView View { get { return _properties.View; } }

        public GridControlTools()
        {
            //TextEdit edit;

            InitializeComponent();
            this.Load += GridControlTools_Load;
            _properties = new RepositoryItemGridControlTools();
            _properties.Buttons = new GridControlToolsButtons()
            {
                Tools_Import = btn_Import,
                Tools_Add = btn_Add,
                Tools_Delete = btn_Delete,
                Tools_MoveFirst = btn_MoveFirst,
                Tools_MovePre = btn_MovePre,
                Tools_MoveNext = btn_MoveNext,
                Tools_MoveLast = btn_MoveLast,
                Tools_Save = btn_Save
            };
        }



        void GridControlTools_Load(object sender, EventArgs e)
        {
            btn_Import.Click += Customer_DoImport;

            btn_Add.Click += btn_Add_Click;
            btn_Delete.Click += btn_Delete_Click;

            btn_MoveFirst.Click += btn_MoveFirst_Click;
            btn_MovePre.Click += btn_MovePre_Click;
            btn_MoveNext.Click += btn_MoveNext_Click;
            btn_MoveLast.Click += btn_MoveLast_Click;
            btn_Save.Click += btn_Save_Click;



            btn_Delete.GotFocus += btn_Delete_Warning;
            btn_Delete.LostFocus += btn_Delete_Normal;
            btn_Delete.MouseEnter += btn_Delete_Warning;

            btn_Delete.MouseLeave += btn_Delete_Normal;

        }


        void btn_Delete_Warning(object sender, EventArgs e)
        {
            (sender as SimpleButton).Appearance.ForeColor = Color.Red;
            (sender as SimpleButton).Appearance.Font = new Font((sender as SimpleButton).Appearance.Font, FontStyle.Bold);
        }
        void btn_Delete_Normal(object sender, EventArgs e)
        {
            if ((sender as SimpleButton).Focused == false)
            {
                (sender as SimpleButton).Appearance.ForeColor = btn_Import.Appearance.ForeColor; ;
                (sender as SimpleButton).Appearance.Font = btn_Import.Appearance.Font;
            }
        }

        void btn_MoveLast_Click(object sender, EventArgs e)
        {
            HandCallInit(Customer_BeforeMoveLast, Customer_AfterMoveLast,
                  new EventHandler(delegate
                  {
                      DataTableMoveTools.DataRowMoveLast(View.GetFocusedDataRow());
                      View.MoveLast();
                  }));
        }

        void btn_MoveNext_Click(object sender, EventArgs e)
        {
            HandCallInit(Customer_BeforeMoveNex, Customer_AfterMoveNex,
              new EventHandler(delegate
              {
                  DataTableMoveTools.DataRowMoveNext(View.GetFocusedDataRow());
                  View.MoveNext();
              }));
        }

        void btn_MovePre_Click(object sender, EventArgs e)
        {
            HandCallInit(Customer_BeforeMovePrev, Customer_AfterMovePrev,
              new EventHandler(delegate
                    {
                        DataTableMoveTools.DataRowMovePrev(View.GetFocusedDataRow());
                        View.MovePrev();
                    }));
        }

        void btn_MoveFirst_Click(object sender, EventArgs e)
        {
            HandCallInit(Customer_BeforeMoveFirst, Customer_AfterMoveFirst,
                new EventHandler(delegate
                {
                    DataTableMoveTools.DataRowMoveFirst(View.GetFocusedDataRow());
                    View.MoveFirst();
                }));
        }

        void btn_Add_Click(object sender, EventArgs e)
        {
            HandCall(Customer_BeforeAdd, Customer_AfterAdd, new EventHandler(delegate { View.AddNewRow(); }));
        }
        void btn_Delete_Click(object sender, EventArgs e)
        {
            HandCall(Customer_BeforeDelete, Customer_AfterDelete, new EventHandler(delegate { View.DeleteSelectedRows(); }));
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            HandEvent(Customer_Save);
        }

        void HandCall(HandledEventHandler BeforeHandle, EventHandler AfterHandle, EventHandler callBack)
        {
            HandledEventArgs args = new HandledEventArgs();
            HandEvent(BeforeHandle, args);
            if (args.Handled == true) return;
            callBack(null, null);
            HandEvent(AfterHandle);
        }
        void HandCallInit(HandledEventHandler BeforeHandle, EventHandler AfterHandle, EventHandler callBack)
        {
            HandledEventArgs args = new HandledEventArgs();
            HandEvent(BeforeHandle, args);
            if (args.Handled == true) return;
            View.BeginInit();
            callBack(null, null);
            View.EndInit();
            HandEvent(AfterHandle);
        }

        void HandEvent(HandledEventHandler sender, HandledEventArgs e)
        {
            sender?.Invoke(View, e);

        }
        void HandEvent(EventHandler sender)
        {
            sender?.Invoke(View, null);
        }

    }
}
