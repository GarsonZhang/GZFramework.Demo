using GZFramework.UI.Dev.Common;
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

namespace GZFrameworkDemo.SystemManagement
{
    public partial class frmDBList : GZFramework.UI.Dev.LibForm.frmBaseChild
    {
        bllDataBaseList bll;
        public frmDBList()
        {
            InitializeComponent();
            bll = new bllDataBaseList();
        }

        private void frmDBList_Load(object sender, EventArgs e)
        {
            this.Shown += frmDBList_Shown;
        }

        void frmDBList_Shown(object sender, EventArgs e)
        {
            gc_Summary.DataSource = bll.GetTableData(sys_DataBaseList._TableName);
        }

        //新增
        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataTable data = frmDialog_DBEdit.ShowForm();
            if (data != null)
            {
                (gc_Summary.DataSource as DataTable).Rows.Add(data.Rows[0].ItemArray);
            }
        }

        //删除
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataRow dr = gv_Summary.GetFocusedDataRow();
            if (dr == null) return;
            string DBCode = ConvertLib.ToString(dr[sys_DataBaseList.DBCode]);
            bll.Delete(DBCode);
            gv_Summary.DeleteSelectedRows();
            Msg.ShowInformation("删除成功！");
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataTable dt = gc_Summary.DataSource as DataTable;
            dt.AcceptChanges();
            DataRow dr = gv_Summary.GetFocusedDataRow();
            if (dr == null) return;
            string DBName = ConvertLib.ToString(dr[sys_DataBaseList.DBDisplayText]);
            string NewDBName = ConvertLib.ToString(txt_DBName.EditValue);

            DataSet ds = new DataSet();
            try
            {
                if (DBName != NewDBName)
                {
                    dr[sys_DataBaseList.DBDisplayText] = NewDBName;
                    ds.Tables.Add(dt);
                }
                if (ucModuleTreeList1.EditData.GetChanges() != null)
                    ds.Tables.Add(ucModuleTreeList1.EditData);
                if (ds.Tables.Count > 0)
                {
                    bll.Update(ds);
                    ds.AcceptChanges();
                    Msg.ShowInformation("保存成功！");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ds.Tables.Clear();
            }
        }

        private void gv_Summary_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gv_Summary.GetFocusedDataRow();
            if (dr == null) return;
            string DBCode = ConvertLib.ToString(dr[sys_DataBaseList.DBCode]);
            string PreDBDisplayText = "";
            DataRow preRow = gv_Summary.GetDataRow(e.PrevFocusedRowHandle);
            if (preRow != null)
                PreDBDisplayText = ConvertLib.ToString(preRow[sys_DataBaseList.DBDisplayText]);
            if (Object.Equals(ucModuleTreeList1.Tag, DBCode)) return;
            else
            {
                bool Edit = ucModuleTreeList1.EditData != null &&
                    ((ucModuleTreeList1.EditData.GetChanges() != null) || !Object.Equals(PreDBDisplayText, txt_DBName.EditValue));

                if (Edit)
                {
                    if (Msg.AskQuestion("修改没有保存，确定要舍弃吗？") == false)
                    {
                        gv_Summary.FocusedRowHandle = e.PrevFocusedRowHandle;
                        return;
                    }
                }


                //获得新的一组EditData
                DataTable dt = bll.GetDBAuthority(dr[sys_DataBaseList.DBCode].ToString());
                txt_DBName.EditValue = dr[sys_DataBaseList.DBDisplayText];
                //绑定
                ucModuleTreeList1.EditData = dt;
                ucModuleTreeList1.Tag = DBCode;
            }

        }

        private void ucModuleTreeList1_AddDataRow(object sender, Library.MyControl.ucModuleTreeList.ArgsAddDataRow e)
        {
            e.Row[sys_DataBaseListAuthority.DBCode] = gv_Summary.GetFocusedDataRow()[sys_DataBaseList.DBCode];
        }
    }
}
