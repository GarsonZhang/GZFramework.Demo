using GZFramework.UI.Dev.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.LibForm
{
    public partial class frmBase : DevExpress.XtraEditors.XtraForm
    {
        public frmBase()
        {
            InitializeComponent();

            Lic.Instance.ValidateLic();
        }

        protected void DoValidate()
        {
            this.Validate();
            
            //Control c = GetFocusedControl();

            //if (c == null)
            //    return;
            //if (c is DevExpress.XtraEditors.TextBoxMaskBox)
            //    (c as DevExpress.XtraEditors.TextBoxMaskBox).OwnerEdit.DoValidate();
            //else
            //{
            //    Msg.Warning("DoValidate遇到未处理类型");
            //}

        }




        //API声明：获取当前焦点控件句柄      

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Winapi)]
        internal static extern IntPtr GetFocus();

        ///获取 当前拥有焦点的控件
        private Control GetFocusedControl()
        {
            Control focusedControl = null;
            // To get hold of the focused control:
            IntPtr focusedHandle = GetFocus();
            if (focusedHandle != IntPtr.Zero)
                //focusedControl = Control.FromHandle(focusedHandle);
                focusedControl = Control.FromChildHandle(focusedHandle);
            return focusedControl;

        }
    }
}
