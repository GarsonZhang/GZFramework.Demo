using DevExpress.XtraEditors;
using GZFrameworkDemo.Library.MyControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.SearchTextEdit
{
    public delegate bool OnSelectChangedHandle(BaseEdit sender, object SelectObj);
    public partial class frmDialogDataSearchBase : GZFramework.UI.Dev.LibForm.frmBaseDialog
    {
        public frmDialogDataSearchBase()
        {
            InitializeComponent();
        }

        public string SearchCode { get; set; }
        public SearchButtonEdit OwnerEdit { get; set; }
        public virtual void CloseForm()
        {
            DialogResult = DialogResult.Cancel;
        }

        protected virtual bool ValidateObject(object obj)
        {
            return true;
        }

        //确定
        private void btn_OK_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        //选择
        protected void doSelect()
        {
            if (ValidateForSelect() == false) return;
            object eidtvalue = null;
            bool success;
            object o = GetSelect(out eidtvalue, out success);
            if (success == false) return;
            success = ValidateObject(o);
            if (success == false) return;
            if (OnSelectChanged != null)
            {
                if (OwnerEdit != null)
                {
                    OwnerEdit.BK = true;
                    OwnerEdit.BK1 = eidtvalue + "";
                    OwnerEdit.EditValue = eidtvalue;
                }
                success = OnSelectChanged(OwnerEdit, o);
                if (success == false) return;
            }
            DialogResult = DialogResult.OK;

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            SetFocus();
        }

        protected virtual void SetFocus()
        {
        }
        /// <summary>
        /// 验证是否选择内容
        /// </summary>
        /// <returns></returns>
        protected virtual bool ValidateForSelect()
        {
            return true;
        }

        //取消
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public event OnSelectChangedHandle OnSelectChanged;

        /// <summary>
        /// 获得选中数据源
        /// </summary>
        /// <returns></returns>
        public virtual object GetSelect(out object EditValue, out bool success)
        {
            success = true;
            EditValue = null;
            return null;
        }




    }
}
