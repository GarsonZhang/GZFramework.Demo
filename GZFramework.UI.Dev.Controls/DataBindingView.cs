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
    [Description("绑定数据视图到控件")]
    [ProvideProperty("PropertyName", typeof(Control))]
    [ProvideProperty("DataMember", typeof(Control))]
    public partial class DataBindingView : Component, IExtenderProvider
    {
        private Dictionary<Control, DataBindViewHelper> lst = null;
        BindingPropertyRelation PR;
        public DataBindingView()
        {
            InitializeComponent();
            lst = new Dictionary<Control, DataBindViewHelper>();
            PR = new BindingPropertyRelation();
        }

        public DataBindingView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            lst = new Dictionary<Control, DataBindViewHelper>();
            //Control f;
            //f.CausesValidation
            PR = new BindingPropertyRelation();
        }

        public void AddOrUpdateBindingPropertyName(Type ColType, string PropertyName)
        {
            PR.AddOrUpdateBindingPropertyName(ColType, PropertyName);
        }

        #region PropertyName
        [Category("扩展")]
        [Description("指定绑定的属性"), DefaultValue("")]
        public string GetPropertyName(Control col)
        {
            if (lst.ContainsKey(col))
            {
                return lst[col].PropertyName;

            }
            return String.Empty;
        }
        public void SetPropertyName(Control col, string PropertyName)
        {
            if (!lst.ContainsKey(col))
            {
                lst.Add(col, new DataBindViewHelper()
                {
                    PropertyName = PropertyName
                });
            }
            else
            {
                lst[col].PropertyName = PropertyName;
            }
            Validate(col);
        }
        #endregion

        #region DataMember
        [Category("扩展")]
        [Description("指定数据源的属性或列表"), DefaultValue("")]
        public string GetDataMember(Control col)
        {
            if (lst.ContainsKey(col))
            {
                return lst[col].DataMember;

            }
            return String.Empty;
        }

        public void SetDataMember(Control col, string DataMember)
        {
            if (!lst.ContainsKey(col))
            {
                lst.Add(col, new DataBindViewHelper()
                {
                    DataMember = DataMember
                });
            }
            else
            {
                lst[col].DataMember = DataMember;
            }
            Validate(col);
        }
        #endregion

        private void Validate(Control col)
        {
            if (IsEmpty(lst[col]))
                lst.Remove(col);
        }

        private bool IsEmpty(DataBindViewHelper v)
        {
            return String.IsNullOrEmpty(v.PropertyName) && String.IsNullOrEmpty(v.DataMember);
        }

        private object _DataSource;

        /// <summary>
        /// 设置绑定以后需要调用DataBind()方法，改2016年1月20日11:08:57，改为自动调用，无需重复调用
        /// </summary>
        public object DataSource
        {
            get { return _DataSource; }
            set
            {
                _DataSource = value;
                if (CheckDesingModel.IsDesingMode) return;
                //if (_DataSource != null)
                DataBind();
            }
        }

        private DataSourceUpdateMode _DataSourceUpdateMode = DataSourceUpdateMode.OnValidation;
        [Category("扩展")]
        [Description("指定绑定控件中发生更改后更新数据源的时间"), DefaultValue(DataSourceUpdateMode.OnValidation)]
        public DataSourceUpdateMode DataSourceUpdateMode { get { return _DataSourceUpdateMode; } set { _DataSourceUpdateMode = value; } }

        private void BindingControlProperty(Control col, string propertyName, object dataSource, string dataMember)
        {
            try
            {

                col.DataBindings.Clear();
                if (dataSource == null) return;
                Binding b = new Binding(propertyName, dataSource, dataMember);
                b.DataSourceUpdateMode = DataSourceUpdateMode;
                col.DataBindings.Add(b);
                b.ReadValue();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private class BindingPropertyRelation
        {
            Dictionary<Type, string> lst;
            Dictionary<string, string> datacatch;
            internal BindingPropertyRelation()
            {
                lst = new Dictionary<Type, string>();
                datacatch = new Dictionary<string, string>();
                lst.Add(typeof(BaseEdit), "EditValue");
            }

            internal void AddOrUpdateBindingPropertyName(Type ColType, string PropertyName)
            {
                if (lst.ContainsKey(ColType))
                    lst[ColType] = PropertyName;
                else
                    lst.Add(ColType, PropertyName);
            }

            internal string GetBindingPropertyName(Control col)
            {
                string PropertyName = String.Empty;
                string fullname = col.GetType().FullName;
                if (datacatch.ContainsKey(fullname)) PropertyName = datacatch[fullname];
                else
                {
                    foreach (var v in lst.Keys)
                    {

                        if (col.GetType().IsSubclassOf(v) == true)
                        {
                            PropertyName = lst[v];
                            datacatch.Add(fullname, PropertyName);
                            break;
                        }

                    }
                }
                return PropertyName;
            }
        }

        /// <summary>
        /// 绑定数据，在设置DataSource后执行
        /// </summary>
        public void DataBind()
        {
            foreach (Control col in lst.Keys)
            {
                var v = lst[col];
                if (IsEmpty(v)) continue;
                if (String.IsNullOrEmpty(v.PropertyName))
                {
                    v.PropertyName = PR.GetBindingPropertyName(col);
                }
                if (String.IsNullOrEmpty(v.PropertyName))
                {
                    throw new DataBindingEmptyPropertyNameException(col);
                }
                BindingControlProperty(col, v.PropertyName, DataSource, v.DataMember);
            }
        }

        #region IExtenderProvider 成员
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool CanExtend(object extendee)
        {
            return (extendee is Control);
        }
        #endregion
    }
    [Serializable]
    public class DataBindingEmptyPropertyNameException : ApplicationException
    {
        public DataBindingEmptyPropertyNameException(Control col)
            : base(String.Format("控件{0}没有指定要绑定数据源的属性！", col.Name)) { }
        public DataBindingEmptyPropertyNameException(Control col, Exception inner)
            : base(String.Format("控件{0}没有指定要绑定数据源的属性！", col.Name), inner) { }
        public DataBindingEmptyPropertyNameException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    public class DataBindViewHelper
    {
        public string PropertyName { get; set; }
        public string DataMember { get; set; }
    }
}
