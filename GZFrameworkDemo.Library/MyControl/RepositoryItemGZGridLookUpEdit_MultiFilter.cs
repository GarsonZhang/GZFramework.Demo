//======================================================================
//        版权所有@GarsonZhang
//        文件名 :RepositoryItemGZGridLookUpEdit_MultiFilter              									
//		  .NET版本：4.0
//        创建人：GarsonZhang  QQ：382237285
//        创建日期：2015-07-25 8:30:57
//        描述 :类
//======================================================================

using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using GZFrameworkDemo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library.MyControl
{
    [UserRepositoryItem("RegisterGZGridLookUpEdit_MultiFilter")]
    [ToolboxItem(true)]
    public class RepositoryItemGZGridLookUpEdit_MultiFilter : RepositoryItemGridLookUpEdit
    {
        static RepositoryItemGZGridLookUpEdit_MultiFilter() { RegisterGZGridLookUpEdit_MultiFilter(); }

        public RepositoryItemGZGridLookUpEdit_MultiFilter()
        {
            TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            AutoComplete = false;
        }
        [Browsable(false)]
        public override DevExpress.XtraEditors.Controls.TextEditStyles TextEditStyle { get { return base.TextEditStyle; } set { base.TextEditStyle = value; } }
        public const string GZGridLookUpEditName_MultiFilter = "GZGridLookUpEdit_MultiFilter";

        public override string EditorTypeName { get { return GZGridLookUpEditName_MultiFilter; } }

        public static void RegisterGZGridLookUpEdit_MultiFilter()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(GZGridLookUpEditName_MultiFilter,
              typeof(GZGridLookUpEdit_MultiFilter), typeof(RepositoryItemGZGridLookUpEdit_MultiFilter),
              typeof(GridLookUpEditBaseViewInfo), new ButtonEditPainter(), true));
        }

        [Description("检索列，多个用|隔开")]
        public string FilterColumns
        {
            get
            {
                return (View as CustomGridViewEx).FilterColumns;
            }
            set
            {
                if (value == null)
                    (View as CustomGridViewEx).FilterColumns = value;
                else
                    (View as CustomGridViewEx).FilterColumns = value.Replace(" ", "");
            }
        }

        protected override GridView CreateViewInstance() { return new CustomGridViewEx(); }
        protected override GridControl CreateGrid() { return new CustomGridControlEx(); }
    }

    [ToolboxItem(true)]
    public class GZGridLookUpEdit_MultiFilter : GridLookUpEdit
    {
        static GZGridLookUpEdit_MultiFilter() { RepositoryItemGZGridLookUpEdit_MultiFilter.RegisterGZGridLookUpEdit_MultiFilter(); }

        public GZGridLookUpEdit_MultiFilter() : base() { Properties.View.OptionsView.ShowIndicator = false; }



        public override string EditorTypeName { get { return RepositoryItemGZGridLookUpEdit_MultiFilter.GZGridLookUpEditName_MultiFilter; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemGZGridLookUpEdit_MultiFilter Properties { get { return base.Properties as RepositoryItemGZGridLookUpEdit_MultiFilter; } }
    }



    #region GridViewEx
    public class CustomGridViewEx : GridView
    {
        public CustomGridViewEx()
            : base()
        {
            this.RowStyle += CustomGridView_RowStyle;
            this.FocusedRowChanged += CustomGridView_FocusedRowChanged;
        }


        void CustomGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if ((sender as CustomGridViewEx).FocusedRowHandle < 0)
                (sender as CustomGridViewEx).FocusedRowHandle = 0;
        }


        void CustomGridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (e.RowHandle == (sender as GridView).FocusedRowHandle)
            {
                e.Appearance.BackColor = this.PaintAppearance.FocusedRow.BackColor;
                e.Appearance.ForeColor = this.PaintAppearance.FocusedRow.ForeColor;
            }
        }

        protected internal virtual void SetGridControlAccessMetod(GridControl newControl)
        {
            SetGridControl(newControl);
        }
        public string FilterColumns
        {
            get { return ConvertLib.ToString(this.Tag); }
            set { this.Tag = value; }
        }
        protected override string OnCreateLookupDisplayFilter(string text, string displayMember)
        {
            List<CriteriaOperator> subStringOperators = new List<CriteriaOperator>();
            foreach (string sString in text.Split(' '))
            {
                //string exp = LikeData.CreateContainsPattern(sString);

                List<CriteriaOperator> columnsOperators = new List<CriteriaOperator>();
                if (String.IsNullOrEmpty(FilterColumns))
                {
                    foreach (GridColumn col in Columns)
                    {
                        if (col.Visible && col.ColumnType == typeof(string))
                            //columnsOperators.Add(new BinaryOperator(col.FieldName, exp, BinaryOperatorType.Like));
                            columnsOperators.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(col.FieldName), sString));
                    }
                }
                else
                {
                    foreach (string FieldName in FilterColumns.Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        columnsOperators.Add(new FunctionOperator(FunctionOperatorType.Contains, new OperandProperty(FieldName), sString));
                    }
                }
                subStringOperators.Add(new GroupOperator(GroupOperatorType.Or, columnsOperators));
            }
            return new GroupOperator(GroupOperatorType.And, subStringOperators).ToString();
        }

        protected override string ViewName { get { return "CustomGridView"; } }
        protected virtual internal string GetExtraFilterText { get { return ExtraFilterText; } }



    }

    public class CustomGridControlEx : GridControl
    {
        public CustomGridControlEx() : base() { }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new CustomGridInfoRegistratorEx());
        }

        protected override BaseView CreateDefaultView()
        {
            return CreateView("CustomGridView");
        }

    }

    public class CustomGridPainterEx : GridPainter
    {
        public CustomGridPainterEx(GridView view) : base(view) { }

        public virtual new CustomGridViewEx View { get { return (CustomGridViewEx)base.View; } }

        protected override void DrawRowCell(GridViewDrawArgs e, GridCellInfo cell)
        {
            cell.ViewInfo.MatchedString = View.GetExtraFilterText;
            cell.ViewInfo.UseHighlightSearchAppearance = false;
            cell.ViewInfo.MatchedStringUseContains = false;
            cell.ViewInfo.MatchedString = View.GetExtraFilterText;
            cell.State = GridRowCellState.Dirty;
            e.ViewInfo.UpdateCellAppearance(cell);



            base.DrawRowCell(e, cell);
        }

    }

    public class CustomGridInfoRegistratorEx : GridInfoRegistrator
    {
        public CustomGridInfoRegistratorEx() : base() { }
        public override BaseViewPainter CreatePainter(BaseView view) { return new CustomGridPainterEx(view as DevExpress.XtraGrid.Views.Grid.GridView); }
        public override string ViewName { get { return "CustomGridView"; } }
        public override BaseView CreateView(GridControl grid)
        {
            CustomGridViewEx view = new CustomGridViewEx();
            view.SetGridControlAccessMetod(grid);
            return view;
        }

    }
    #endregion
}
