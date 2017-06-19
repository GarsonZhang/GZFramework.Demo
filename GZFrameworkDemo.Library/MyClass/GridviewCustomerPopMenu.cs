using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using GZFrameworkDemo.Library.MyControl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.MyClass
{
    public class GridViewAddPopupMenuBase
    {

        public event EventHandler DoEvent;
        string MenuName;
        protected GridView _View;

        public PopModel PopType;

        public GridViewAddPopupMenuBase(GridView View, string cMenuName)
        {
            //GridViewAddPopupMenuBase gb = new GridViewAddPopupMenuBase();

            this.MenuName = cMenuName;
            _View = View;

            View.PopupMenuShowing += new PopupMenuShowingEventHandler(Create_NewCellItem);
        }
        Image Img = null;
        public GridViewAddPopupMenuBase(GridView View, string cMenuName, Image image)
        {
            //GridViewAddPopupMenuBase gb = new GridViewAddPopupMenuBase();

            this.MenuName = cMenuName;
            _View = View;
            Img = image;
            View.PopupMenuShowing += new PopupMenuShowingEventHandler(Create_NewCellItem);
        }
        void Create_NewCellItem(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                bool Add = false;
                switch (PopType)
                {
                    case PopModel.完全:
                        {
                            Add = true;
                        } break;
                    case PopModel.编辑状态:
                        {
                            Add = ((GridView)sender).OptionsBehavior.Editable == true;
                        } break;
                    case PopModel.查看状态:
                        {
                            Add = ((GridView)sender).OptionsBehavior.Editable == false;
                        } break;
                    case PopModel.当前列编辑状态:
                        {
                            Add = e.HitInfo.InRowCell && e.HitInfo.Column.OptionsColumn.AllowEdit == true;
                        } break;
                    case PopModel.当前列查看状态:
                        {
                            Add = e.HitInfo.InRowCell && e.HitInfo.Column.OptionsColumn.AllowEdit == false;
                        } break;
                }
                if (Add == true)
                    e.Menu.Items.Add(CreateNewMenuItem((GridView)sender, e.HitInfo.RowHandle, e.HitInfo.Column));


            }
        }

        public enum PopModel
        {
            完全 = 0,
            编辑状态,
            查看状态,
            当前列编辑状态,
            当前列查看状态
        }

        DXMenuItem CreateNewMenuItem(GridView view, int rowHandle, GridColumn column)
        {
            DXMenuItem copyitem = new DXMenuItem(MenuName.Replace("[Caption]", column.Caption.Replace("\r\n", "")),
                new EventHandler(DoEvent), Img);
            copyitem.Tag = column;
            return copyitem;

        }
    }

 




    public class GridViewCreateNewCellItem : GridViewAddPopupMenuBase
    {
        #region 添加复制Cell菜单
        public GridViewCreateNewCellItem(GridView View)
            : base(View, "清除[Caption]")
        {
            this.DoEvent += DoClear;
            this.PopType = PopModel.当前列编辑状态;
        }

        private void DoClear(object sender, EventArgs e)
        {
            if (_View.OptionsBehavior.Editable == false) return;
            GridColumn col = (GridColumn)((DXMenuItem)sender).Tag;
            col.View.SetRowCellValue(col.View.FocusedRowHandle, col, DBNull.Value);
        }


        #endregion
    }

    public class GridViewExport : GridViewAddPopupMenuBase
    {
        #region 添加复制Cell菜单
        string MSheetName = "";
        public GridViewExport(GridView View, string SheetName)
            : base(View, "导出到Excel")
        {
            this.DoEvent += DoExport;
            MSheetName = SheetName;
            this.PopType = PopModel.查看状态;
        }

        private void DoExport(object sender, EventArgs e)
        {


            SaveFileDialog sd = new SaveFileDialog();
            sd.AddExtension = true;
            sd.DefaultExt = "xls";
            sd.Filter = " XLS(*.xls)|*.xls";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                XlsExportOptions options = new XlsExportOptions();
                options.TextExportMode = TextExportMode.Text;
                options.SheetName = MSheetName;

                _View.ExportToXls(sd.FileName, options);
                //_View.OptionsPrint
                //GridOptionsPrint

            }
        }


        #endregion
    }

    public class GridViewPrint : GridViewAddPopupMenuBase
    {
        #region 添加复制Cell菜单
        string headtext = "";
        public GridViewPrint(GridView View, string HeadText)
            : base(View, "预览打印")
        {
            this.DoEvent += DoPrint;
            headtext = HeadText;
            this.PopType = PopModel.查看状态;
        }

        private void DoPrint(object sender, EventArgs e)
        {

            PrintingSystem printingSystem1 = new PrintingSystem();
            PrintableComponentLink printableComponentLink1 = new PrintableComponentLink();

            // Add the link to the printing system's collection of links.
            printingSystem1.Links.AddRange(new object[] { printableComponentLink1 });

            // Assign a control to be printed by this link.
            printableComponentLink1.Component = _View.GridControl;

            PageHeaderFooter phf = printableComponentLink1.PageHeaderFooter as PageHeaderFooter;

            //设置页眉
            phf.Header.Content.Clear();
            phf.Header.Content.AddRange(new string[] { "", headtext, "" });
            phf.Header.Font = new System.Drawing.Font("宋体", 14, System.Drawing.FontStyle.Bold);
            phf.Header.LineAlignment = BrickAlignment.Center;

            _View.OptionsPrint.PrintHeader = false;

            // Set the paper orientation to Landscape.
            printableComponentLink1.Landscape = true;

            //显示打印预览
            printableComponentLink1.ShowPreview();
            //直接打印
            //  printableComponentLink1.PrintDlg();



            //_View.OptionsPrint.PrintHeader = false;

            //_View.ShowPrintPreview();

            return;


            //GridOptionsPrint

        }
    }


        #endregion
}


