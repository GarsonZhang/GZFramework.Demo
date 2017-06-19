using GZFrameworkDemo.Common;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFrameworkDemo.Library.MyClass
{
    public class Tools_VerificationEditValue
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="edit"></param>
        /// <param name="EmpErrorText">空值时提醒</param>
        /// <param name="EIA">ErrorIcon显示位置</param>
        /// <returns>不为空返回Ture，空返回false</returns>
        public static bool VerificationNotEmpEditValue(BaseEdit edit, string EmpErrorText, ErrorIconAlignment EIA = ErrorIconAlignment.MiddleRight)
        {
            if (edit.Visible == false) return true;
            if (String.IsNullOrEmpty(ConvertLib.ToString(edit.EditValue)))
            {
                if (EmpErrorText != "")
                {
                    edit.ErrorText = EmpErrorText;
                    edit.ErrorIconAlignment = EIA;
                }
                return false;
            }
            return true;

        }
        public static bool VerificationNotEmpEditValue(BaseEdit edit)
        {
            if (String.IsNullOrEmpty(ConvertLib.ToString(edit.EditValue)))
            {
                return false;
            }
            return true;

        }
        public static bool VerificationEmpEditValue(BaseEdit edit)
        {
            if (String.IsNullOrEmpty(ConvertLib.ToString(edit.EditValue)))
            {
                return true;
            }
            return false;

        }
    }
}
