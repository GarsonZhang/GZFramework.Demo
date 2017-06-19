using DevExpress.XtraEditors;
using GZPSI.Business;
using GZPSI.Common;
using GZPSI.Models;
using GZFramework.UI.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GZPSI.ReportServer;
using System.IO;

namespace GZPSI.Demo
{
    public partial class frmSample : GZFramework.UI.Dev.LibForm.frmBaseFunction
    {
        bllSamplePO bll;
        private DataSet EditData;


        public frmSample()
        {
            InitializeComponent();

            bll = new bllSamplePO();


            InitControl(txtPONO, true, false);
            InitControl(txtDocDate, true, false);
            InitControl(txtDeptID, true, false);
            InitControl(txtComopanyDate, true, false);
            InitControl(txtCreateUser, true, false);
            InitControl(txtCreateDate, true, false);
            InitControl(txtLastUpdateUser, true, false);
            InitControl(txtLastUpdateDate, true, false);
            InitDataSource("");
            txtDeptName.Properties.FormShowDialog = typeof(Dialog.frmDialogDataSearch_Dept);
            txtDeptName.Properties.OnSelectChanged += Properties_OnSelectChanged;
            txtCompanyName.Properties.FormShowDialog = typeof(Dialog.frmDialogDataSearch_Company);
            txtCompanyName.Properties.OnSelectChanged += Properties_OnSelectChanged1;

            repositoryItemSearchTextEdit1.FormShowDialog = typeof(Dialog.frmDialogDataSearch_Product);
            repositoryItemSearchTextEdit1.OnSelectChanged += RepositoryItemSearchTextEdit1_OnSelectChanged;

            LC_Edit.Leave += LC_Edit_Leave;
            gv_Detail_tb_SamplePODetail.FocusedRowChanged += Gv_Detail_tb_SamplePODetail_FocusedRowChanged;


            gv_Detail_tb_SamplePODetail.GotFocus += Gv_Detail_tb_SamplePODetail_GotFocus;

        }

        private void Gv_Detail_tb_SamplePODetail_GotFocus(object sender, EventArgs e)
        {
            gv_Detail_tb_SamplePODetail.ShowEditorByMouse();
        }


        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtDeptName.Focus();
        }
        int SaveCountSummary = 0;
        private void Gv_Detail_tb_SamplePODetail_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (EditData.Tables[tb_SamplePODetail._TableName].GetChanges() != null)
            {
                if (EditData.Tables[tb_SamplePO._TableName].Rows[0][tb_SamplePO.PONO] == DBNull.Value)//单据号码尚未生成，保存主表
                {
                    SaveSummary();
                }

                bll.UpdateDetail(EditData.Tables[tb_SamplePODetail._TableName]);
                lbl_DetailSaveCount.Text = (++SaveCountDetail).ToString() + "最后保存时间：" + DateTime.Now.ToString("HH:mm:ss");
            }
        }

        int SaveCountDetail = 0;
        private void LC_Edit_Leave(object sender, EventArgs e)
        {
            if (EditData.Tables[tb_SamplePO._TableName].GetChanges() != null)
            {
                SaveSummary();
            }
        }

        private void SaveSummary()
        {
            //还原状态
            EditData.Tables[tb_SamplePO._TableName].Rows[0].AcceptChanges();
            if (EditData.Tables[tb_SamplePO._TableName].Rows[0][tb_SamplePO.PONO] != DBNull.Value)
                EditData.Tables[tb_SamplePO._TableName].Rows[0].SetModified();
            else
                EditData.Tables[tb_SamplePO._TableName].Rows[0].SetAdded();
            bll.UpdateSummary(EditData.Tables[tb_SamplePO._TableName]);
            lbl_SummarySaveCount.Text = (++SaveCountSummary).ToString() + "最后保存时间：" + DateTime.Now.ToString("HH:mm:ss");
        }




        //加载并绑定数据
        private void InitDataSource(string DocNo)
        {
            //获得编号的数据
            EditData = bll.DoGetDocData(DocNo);
            //如果主表数据为空，新增一条数据
            if (EditData.Tables[tb_SamplePO._TableName].Rows.Count == 0)
                EditData.Tables[tb_SamplePO._TableName].Rows.Add();
            EditData.AcceptChanges();
            //绑定数据源
            ViewDataBinding.DataSource = EditData.Tables[tb_SamplePO._TableName];
            this.gc_Detail_tb_SamplePODetail.DataSource = EditData.Tables[tb_SamplePODetail._TableName];

            gv_Detail_tb_SamplePODetail.InitNewRow += Gv_Detail_tb_SamplePODetail_InitNewRow;


        }


        //新增明细的时候，自动关联单据号码
        private void Gv_Detail_tb_SamplePODetail_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gv_Detail_tb_SamplePODetail.GetDataRow(e.RowHandle)[tb_SamplePODetail.PONO] = txtPONO.EditValue;
        }







        #region 通用选择处理

        //部门选择
        private bool Properties_OnSelectChanged(BaseEdit edit, object arg)
        {
            DataRow dr = arg as DataRow;
            Library.DataBinder.SetEditorBindingValue(txtDeptName, txtDeptName.EditValue, true);
            Library.DataBinder.SetEditorBindingValue(txtDeptID, dr["DeptID"], true);
            //txtDeptID.Refresh()
            //txtDeptID.EditValue = dr["DeptID"];
            return true;
        }
        //供应商选择
        private bool Properties_OnSelectChanged1(BaseEdit edit, object arg)
        {
            Dialog.frmDialogDataSearch_Company.DataModel d = arg as Dialog.frmDialogDataSearch_Company.DataModel;
            Library.DataBinder.SetEditorBindingValue(edit, edit.EditValue, true);
            EditData.Tables[tb_SamplePO._TableName].Rows[0][tb_SamplePO.CompanyID] = d.DWBH;
            if (d.XKZYXQ > DateTime.MinValue)
                Library.DataBinder.SetEditorBindingValue(txtComopanyDate, d.XKZYXQ, true);

            return true;
        }
        //商品选择
        private bool RepositoryItemSearchTextEdit1_OnSelectChanged(BaseEdit edit, object arg)
        {
            DataRow dr = arg as DataRow;
            gv_Detail_tb_SamplePODetail.SetFocusedRowCellValue(tb_SamplePODetail.ProductID, dr["spbh"]);
            gv_Detail_tb_SamplePODetail.SetFocusedRowCellValue(tb_SamplePODetail.PreQty, dr["kc"]);
            gv_Detail_tb_SamplePODetail.CloseEditor();
            gv_Detail_tb_SamplePODetail.ValidateEditor();


            return true;
        }

        private void InitControl(TextEdit control, bool ReadOnly, bool TabStop)
        {
            control.Properties.ReadOnly = ReadOnly;
            control.TabStop = TabStop;
        }
        #endregion

        //设置窗体权限，frmBaseChild默认只有一个查看权限，增加一个保存权限，
        protected override int CustomerAuthority
        {
            get
            {
                return base.CustomerAuthority + FunctionAuthorityCommon.SaveEx + FunctionAuthorityCommon.PREVIEW;
            }
        }

        protected override void DoPreview(object sender)
        {
            //base.DoPreview(sender);
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(System.String));
            dt.Columns.Add("Name", typeof(System.String));

            dt.Rows.Add("201601", "张三！");
            dt.Rows.Add("201602", "王五表！");
            dt.Rows.Add("201603", "贺六！");
            dt.Rows.Add("201604", "星期一！");
            dt.Rows.Add("201605", "放假了！");
            dt.Rows.Add("201606", "报表打印！");
            dt.Rows.Add("201607", "测试报表！");
            string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports\\test.frx");

            RptCommonSimple r = new RptCommonSimple(this, filename, dt);
            //r.IsDesign = true;
            frmRptPreview.ShowForm(r);


            //RptCommonSimple.Instance.ShowReport(this, dt, filename);
            
            //frmDesign f = new frmDesign(filename);
            //f.ShowDialog();
        }

        //实现保存方法
        protected override void DoSave(object sender)
        {
            base.DoSave(sender);

        }

        private void gv_Detail_tb_SamplePODetail_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            //System.Diagnostics.Debug.Print("tab" + e?.Value);
            moveNext();  //向活动应用程序发送击键 注意格式：Send("{Tab}");中的{}
        }
        void moveNext()
        {
            //System.Windows.Forms.SendKeys.Send("{Tab}");  //向活动应用程序发送击键 注意格式：Send("{Tab}");中的{}
        }
    }
}
