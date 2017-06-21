using GZFrameworkDemo.Business;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.MyControl
{
    public partial class frmDialog_CommonSearchConfig : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {

        public static bool ShowForm(string Code)
        {
            frmDialog_CommonSearchConfig frm = new frmDialog_CommonSearchConfig();
            frm.Code = Code;
            return frm.ShowDialog() == DialogResult.OK;
        }

        bllCommonSearch bll;

        public string Code { get; set; }

        public frmDialog_CommonSearchConfig()
        {
            InitializeComponent();
            bll = new bllCommonSearch();
        }

        DataTable DataSource;
        private void frmDialog_CommonSearchConfig_Load(object sender, EventArgs e)
        {
            DataSource = bll.GetCommonSearch(Code);
            gridControl1.DataSource = DataSource;
        }



        
        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (String.IsNullOrEmpty(ConvertLib.ToString(e.Value)))
            {
                e.Valid = false;
                e.ErrorText = gridView1.FocusedColumn.Caption + "不能为空！";
            }
        }
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            bool V = true;

            foreach (DevExpress.XtraGrid.Columns.GridColumn column in view.Columns)
            {
                if (String.IsNullOrEmpty(view.GetFocusedRowCellDisplayText(column)))
                {
                    view.SetColumnError(column, column.Caption + "不能为空!");
                    V = V & false;
                }
            }
            e.Valid = V;
        }
        //新增
        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataRow dr = DataSource.Rows.Add();
            dr[sys_CommonSearch.RowID] = Guid.NewGuid().ToString().Replace("-", "");
            dr[sys_CommonSearch.SearchCode] = Code;
        }
        //删除
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteSelectedRows();
        }

        //保存
        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool success = !gridView1.HasColumnErrors & gridView1.ValidateEditor();
            if (success == false) return;
            if (DataSource.GetChanges() == null)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                if (bll.UpdateCommonSearch(DataSource) == true)
                    this.DialogResult = DialogResult.OK;
            }
        }
        //取消
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}
