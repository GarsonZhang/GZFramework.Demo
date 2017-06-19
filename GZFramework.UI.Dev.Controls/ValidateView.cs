using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.Controls
{
    [Description("控件验证")]
    [ProvideProperty("ValidateType", typeof(BaseEdit))]
    [ProvideProperty("ErrorText", typeof(BaseEdit))]

    public partial class ValidateView : Component, IExtenderProvider
    {


        private Dictionary<BaseEdit, ValidateHepler> lst = null;
        public ValidateView()
        {
            InitializeComponent();
            lst = new Dictionary<BaseEdit, ValidateHepler>();
        }

        public ValidateView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            lst = new Dictionary<BaseEdit, ValidateHepler>();
        }

        #region ValidateType
        [Category("扩展")]
        [Description("控件判断验证类型"), DefaultValue(ValidateType._不判断)]
        public ValidateType GetValidateType(BaseEdit edit)
        {
            if (lst.ContainsKey(edit)) return lst[edit].ValidateType;
            else return ValidateType._不判断;
        }
        public void SetValidateType(BaseEdit edit, ValidateType _ValidateType)
        {
            if (!lst.ContainsKey(edit))
            {
                edit.ErrorIconAlignment = ErrorIconAlignment;
                lst.Add(edit, new ValidateHepler() { ValidateType = _ValidateType });
            }
            else
            {
                lst[edit].ValidateType = _ValidateType;
            }
            if (_ValidateType != ValidateType._不判断)
            {
                edit.ErrorIconAlignment = ErrorIconAlignment;
                if (CheckDesingModel.IsDesingMode)
                {
                    edit.ErrorText = "校验";
                    //edit.EditValue = "IsDesingMode";
                }
                else
                {
                    edit.ErrorText = "";
                    //edit.EditValue = "IsRun";
                }
            }
        }

        #endregion

        #region ErrorText
        [Category("扩展")]
        [Description("控件判断验证类型"), DefaultValue("")]
        public string GetErrorText(BaseEdit edit)
        {
            if (lst.ContainsKey(edit)) return lst[edit].ErrorText;
            else return String.Empty;
        }
        public void SetErrorText(BaseEdit edit, string _ErrorText)
        {
            if (!lst.ContainsKey(edit))
            {

                lst.Add(edit, new ValidateHepler() { ErrorText = _ErrorText });
            }
            else
            {
                lst[edit].ErrorText = _ErrorText;
            }
        }

        #endregion

        public bool DoValidate()
        {
            bool valite = true;
            foreach (var key in lst.Keys)
            {
                var value = lst[key];
                valite = valite & IsNotEmpBaseEdit(key, value.ErrorText, value.ValidateType);
            }

            return valite;
        }

        bool IsNotEmpBaseEdit(BaseEdit edit, string ErrorText, ValidateType Ruler)
        {
            if (edit.Visible == false) return true;
            if (Ruler == ValidateType._不判断) return true;

            bool Validate = true;
            switch (Ruler)
            {
                case ValidateType.String不等于空:
                    {
                        if (String.IsNullOrEmpty(edit.EditValue.ToString()))
                            Validate = false;
                    }; break;
                case ValidateType.Int不等于0:
                case ValidateType.Int大于0:
                case ValidateType.Int大于等于0:
                case ValidateType.Int小于0:
                case ValidateType.Int小于等于0:
                    {
                        decimal value;
                        if (Decimal.TryParse(edit.EditValue.ToString(), out value))
                            Validate = ValidateInt(value, Ruler);
                        else
                            Validate = false;
                    }; break;
            }
            if (Validate == false)
                ShowError(edit, ErrorText);
            return Validate;
        }

        private bool ValidateInt(decimal value, ValidateType Ruler)
        {
            bool success = true;
            switch (Ruler)
            {
                case ValidateType.Int不等于0:
                    {
                        success = value != 0;
                    }; break;
                case ValidateType.Int大于0:
                    {
                        success = value > 0;
                    }; break;
                case ValidateType.Int大于等于0:
                    {
                        success = value >= 0;
                    }; break;
                case ValidateType.Int小于0:
                    {
                        success = value < 0;
                    }; break;
                case ValidateType.Int小于等于0:
                    {
                        success = value <= 0;
                    }; break;
            }
            return success;
        }

        private ErrorIconAlignment _ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
        [Category("扩展")]
        [Description("指定常数来指示显示的错误图标相对于有错误的控件的位置。"), DefaultValue(ErrorIconAlignment.MiddleRight)]
        public ErrorIconAlignment ErrorIconAlignment
        {
            get { return _ErrorIconAlignment; }
            set
            {
                _ErrorIconAlignment = value;
                foreach (var c in lst.Keys)
                    c.ErrorIconAlignment = ErrorIconAlignment;
            }
        }

        void ShowError(BaseEdit edit, string ErrorText)
        {
            if (ErrorText != "")
            {
                edit.ErrorIconAlignment = ErrorIconAlignment;
                edit.ErrorText = ErrorText;

                edit.EditValueChanged -= edit_EditValueChanged;

                edit.EditValueChanged += edit_EditValueChanged;
            }
        }

        void edit_EditValueChanged(object sender, EventArgs e)
        {
            (sender as BaseEdit).ErrorText = String.Empty;
        }


        #region IExtenderProvider 成员
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool CanExtend(object extendee)
        {
            return (extendee is BaseEdit);
        }
        #endregion
    }

    internal class ValidateHepler
    {
        private ValidateType _ValidateType = ValidateType._不判断;
        public ValidateType ValidateType { get { return _ValidateType; } set { _ValidateType = value; } }

        private string _ErrorText = String.Empty;
        public string ErrorText { get { return _ErrorText; } set { _ErrorText = value; } }
    }

    public enum ValidateType
    {
        _不判断,
        String不等于空,
        Int不等于0,
        Int大于0,
        Int大于等于0,
        Int小于0,
        Int小于等于0
    }
}
