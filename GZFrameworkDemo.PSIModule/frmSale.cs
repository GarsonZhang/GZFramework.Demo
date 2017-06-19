using ClothingPSISQLite.BusinessSQLite.Business;
using ClothingPSISQLite.Common;
using ClothingPSISQLite.Models.Business;
using ClothingPSISQLite.PSIModule.Dialog;
using GZFramework.UI.Dev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothingPSISQLite.PSIModule
{
    public partial class frmSale : GZFramework.UI.Dev.LibForm.frmBaseChild
    {
        public frmSale()
        {
            InitializeComponent();
            Library.DataBinderTools.Bound.BoundSales(txt_Sale, false, false);
            this.KeyDown += FrmSale_KeyDown;
        }



        bllSO bll;
        bllProductInventory bllpi;
        public DataSet EditData;
        private void frmSale_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Library.DataBinderTools.Bound.BoundCategory(lue_Category, false);
            bll = new bllSO();
            bllpi = new bllProductInventory();
            EditData = bll.DoGetDocData("");
            gcSummary.DataSource = EditData.Tables[tb_SODetail._TableName];
        }

        void Find()
        {
            DataTable dt = bllpi.SearchDataBarCode(txt_ProductCode.Text);
            DataRow row;
            if (dt.Rows.Count != 1)
            {
                row = Dialog.frmDialogProducQty.ShowForm(txt_ProductCode.Text, dt);
            }
            else
            {
                row = dt.Rows[0];
            }
            //DataRow row = Dialog.frmDialogProducQty.ShowForm(txt_ProductCode.Text);
            if (row != null)
            {

                var al = EditData.Tables[tb_SODetail._TableName].Select($"{tb_SODetail.BarCode}='{row[tb_ProductInventory.BarCode]}'").FirstOrDefault();
                if (al != null)
                {
                    int newQty = ConvertLib.ToInt(al[tb_SODetail.Qty]) + 1;
                    al[tb_SODetail.Qty] = newQty;
                    al[tb_SODetail.TotalAmount] = ConvertLib.ToDecimal(al[tb_SODetail.UnitPrice], 0) * newQty;
                }
                else
                {
                    DataRow dr = EditData.Tables[tb_SODetail._TableName].NewRow();
                    dr[tb_SODetail.BarCode] = row[tb_ProductInventory.BarCode];
                    dr[tb_SODetail.ItemNo] = row[tb_ProductInventory.ItemNo];
                    dr[tb_SODetail.ItemName] = row[tb_ProductInventory.ItemName];
                    dr[tb_SODetail.CategoryID] = row[tb_ProductInventory.CategoryID];
                    dr[tb_SODetail.Color] = row[tb_ProductInventory.Color];
                    dr[tb_SODetail.Size] = row[tb_ProductInventory.Size];
                    dr[tb_SODetail.Qty] = 1;
                    dr[tb_SODetail.UnitPrice] = row[tb_ProductInventory.SOPrice];
                    dr[tb_SODetail.TotalAmount] = ConvertLib.ToDecimal(row[tb_ProductInventory.SOPrice], 0) * 1;
                    EditData.Tables[tb_SODetail._TableName].Rows.Add(dr);
                    gvSummary.ClearSelection();
                    gvSummary.SelectRow(gvSummary.RowCount - 1);
                    gvSummary.FocusedRowHandle = gvSummary.RowCount - 1;
                }
                txt_ProductCode.EditValue = "";
                refreshTotalMsg();
            }

        }

        void refreshTotalMsg()
        {
            lbl_Qty.Text = $"数量：{gcQty.SummaryItem.SummaryValue}";
            lbl_TotalAmount.Text = $"售：{gcTotalAmount.SummaryItem.SummaryValue}";
        }



        //结算
        private void btn_Complete_Click(object sender, EventArgs e)
        {
            //Msg.ShowInformation("结算");
            bool validate = LibraryTools.IsNotEmpBaseEdit(txt_Sale, "销售员不能为空！");
            if (validate == false)
            {
                Msg.Warning("请检查必填项");
                return;
            }
            decimal Amount = ConvertLib.ToDecimal(gcTotalAmount.SummaryItem.SummaryValue, 0);
            decimal AmountIn = 0, AmountOut = 0;
            DialogResult result = frmDailogSalePay.ShowForm(Amount, out AmountIn, out AmountOut);
            //frmDailogSalePay frm = new Dialog.frmDailogSalePay();
            //frm.Amount = Amount;
            //DialogResult result = frm.ShowDialog();
            if (result != DialogResult.OK) return;

            DataRow row = EditData.Tables[tb_SO._TableName].Rows.Add();
            row[tb_SO.DocDate] = bll.GetServerTime();
            row[tb_SO.SaleBy] = txt_Sale.EditValue;
            row[tb_SO.TotalQty] = gcQty.SummaryItem.SummaryValue;
            row[tb_SO.TotalAmount] = row[tb_SO.TotalPrice] = Amount;
            row[tb_SO.AmountIn] = AmountIn;
            row[tb_SO.AmountOut] = AmountOut;
            foreach (DataRow dr in EditData.Tables[tb_SODetail._TableName].Rows)
            {
                dr[tb_SODetail.SaleBy] = txt_Sale.EditValue;
            }
            bool success = bll.Update(EditData);
            if (success == true)
            {
                EditData.Tables[tb_SO._TableName].Rows.Clear();
                EditData.Tables[tb_SODetail._TableName].Rows.Clear();
                EditData.AcceptChanges();
                refreshTotalMsg();
            }
        }
        //修改
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //Msg.ShowInformation("修改");
            DataRow row = gvSummary.GetFocusedDataRow();
            if (row == null) return;
            frmDialogSaleEdit.ShowForm(row);
            refreshTotalMsg();
        }
        //删除
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Msg.ShowInformation("删除");
            gvSummary.DeleteSelectedRows();
        }
        //无码销售
        private void btn_Price_Click(object sender, EventArgs e)
        {
            //Msg.ShowInformation("无码销售");
            decimal price = frmDialogPrice.ShowForm();
            if (price > 0)
            {
                DataRow row = EditData.Tables[tb_SODetail._TableName].NewRow();
                row[tb_SODetail.BarCode] = "0000";
                row[tb_SODetail.ItemNo] = "0000";
                row[tb_SODetail.ItemName] = "无码销售";
                row[tb_SODetail.UnitPrice] = price;
                row[tb_SODetail.Qty] = 1;
                row[tb_SODetail.TotalAmount] = price;
                EditData.Tables[tb_SODetail._TableName].Rows.Add(row);
                refreshTotalMsg();
                gvSummary.ClearSelection();
                gvSummary.SelectRow(gvSummary.RowCount - 1);
                gvSummary.FocusedRowHandle = gvSummary.RowCount - 1;
            }
        }
        //清空
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            //Msg.ShowInformation("清空");
            if (Msg.AskQuestion("确定要清空数据吗？") == false)
                return;
            EditData.Tables[tb_SODetail._TableName].Rows.Clear();
        }

        private void FrmSale_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    txt_ProductCode.Focus();
                    break;
                case Keys.F5:
                    btn_Complete.PerformClick();
                    break;
                case Keys.F3:
                    btn_Edit.PerformClick();
                    break;
                case Keys.F4:
                    btn_Delete.PerformClick();
                    break;
                case Keys.F7:
                    btn_Price.PerformClick();
                    break;
                case Keys.F8:
                    btn_Clear.PerformClick();
                    break;
                case Keys.Up:
                case Keys.Down:
                    gvSummary.Focus();
                    break;
                case Keys.Enter:
                    {
                        if (String.IsNullOrEmpty(txt_ProductCode.Text))
                            btn_Complete.PerformClick();
                        else
                            Find();
                    }
                    break;
                default:
                    {
                        if (txt_ProductCode.Focused == false)
                        {
                            //txt_ProductCode.Focus();

                            //keybd_event(e.KeyCode, 0, 0, 0);
                        }

                    }
                    break;
            }
        }
        [DllImport("user32.dll", EntryPoint = "keybd_event", SetLastError = true)]
        public static extern void keybd_event(Keys bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        private void txt_ProductCode_DoubleClick(object sender, EventArgs e)
        {
            Find();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelControl6.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
