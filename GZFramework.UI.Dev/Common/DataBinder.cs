using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using GZFramework.UI.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.Common
{
    internal class DataBinder
    {

        static DataSourceUpdateMode CustomerDataSourceUpdateMode = DataSourceUpdateMode.OnValidation;

        /// <summary>
        /// 绑定参照字段的数据源
        /// </summary>
        /// <param name="edit">参照字段输入控件</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="displayMember">显示字段</param>
        /// <param name="valueMember">取值字段</param>
        public static void BindingLookupEditDataSource(LookUpEdit edit, object dataSource, string displayMember, string valueMember)
        {
            BindingLookupEditDataSource(edit.Properties, dataSource, displayMember, valueMember);
        }


        /// <summary>
        /// 绑定表格内列参照字段的数据源
        /// </summary>
        /// <param name="edit">参照字段控件</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="displayMember">显示字段</param>
        /// <param name="valueMember">取值字段</param>
        public static void BindingLookupEditDataSource(RepositoryItemLookUpEdit edit, object dataSource, string displayMember, string valueMember)
        {
            edit.DisplayMember = displayMember;
            edit.ValueMember = valueMember;
            edit.DataSource = dataSource;
        }

        public static void BindingCheckedListBoxSource(CheckedListBoxControl edit, DataTable dataSource, string displayMember, string valueMember)
        {
            edit.DisplayMember = displayMember;
            edit.ValueMember = valueMember;
            edit.DataSource = dataSource;
        }


        public static void BindingCheckedComboBoxSource(CheckedComboBoxEdit edit, DataTable dataSource, string displayMember, string valueMember)
        {
            edit.Properties.DisplayMember = displayMember;
            edit.Properties.ValueMember = valueMember;
            edit.Properties.DataSource = null;
            edit.Properties.DataSource = dataSource;
        }

        public static void BindingCheckedComboBoxSource(RepositoryItemCheckedComboBoxEdit edit, DataTable dataSource, string displayMember, string valueMember)
        {
            edit.DisplayMember = displayMember;
            edit.ValueMember = valueMember;
            edit.DataSource = null;
            edit.DataSource = dataSource;
        }

        /// <summary>
        /// 绑定RadioGroup组控件的数据源
        /// </summary>
        /// <param name="edit">RadioGroup组控件</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingRadioEdit(RadioGroup edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();

                Binding b = new Binding("EditValue", dataSource, bindField);
                b.DataSourceUpdateMode = CustomerDataSourceUpdateMode;
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定RadioGroup组控件的数据源
        /// </summary>
        /// <param name="edit">RadioGroup组控件</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingRadioEdit(RadioGroup edit, DataTable dataSource, string displayMember, string valueMember)
        {
            foreach (DataRow dr in dataSource.Rows)
            {
                string strName = ConvertEx.ToString(dr[displayMember]);//获取名称
                string strVaule = ConvertEx.ToString(dr[valueMember]);//获取值
                DevExpress.XtraEditors.Controls.RadioGroupItem rgItem = new DevExpress.XtraEditors.Controls.RadioGroupItem()
                {
                    Description = strName,
                    Value = strVaule
                };
                edit.Properties.Items.Add(rgItem);
            }
        }

        /// <summary>
        /// 绑定输入控件的数据源
        /// </summary>
        /// <param name="ctl">支持输入功能的控件</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        /// <param name="propertyName">控件的取值属性</param>
        public static void BindingControl(Control ctl, object dataSource, string bindField, string propertyName)
        {
            try
            {
                ctl.DataBindings.Clear();
                Binding b = new Binding(propertyName, dataSource, bindField);
                b.DataSourceUpdateMode = CustomerDataSourceUpdateMode;
                ctl.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定输入控件的数据源
        /// </summary>
        /// <param name="edit">控件框</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingTextEditBase(BaseEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                b.DataSourceUpdateMode = CustomerDataSourceUpdateMode;
                edit.DataBindings.Add(b);
                b.ReadValue();
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定输入控件的数据源
        /// </summary>
        /// <param name="edit">控件框</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingTextEdit(TextEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                b.DataSourceUpdateMode = CustomerDataSourceUpdateMode;
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        public static void BindingTextEdit(TextEdit edit, object dataSource, string bindField, int rowPosition)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                b.DataSourceUpdateMode = CustomerDataSourceUpdateMode;
                edit.DataBindings.Add(b);

                //指定资料行序号
                if (rowPosition >= 0) edit.BindingContext[dataSource].Position = rowPosition;
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        ///  绑定CheckedListBox的数据源
        /// </summary>
        /// <param name="control">CheckedListBox</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingCheckedListBox(Control control, object dataSource, string bindField)
        {
            try
            {
                control.DataBindings.Clear();
                Binding b = new Binding("SelectedValue", dataSource, bindField);
                b.DataSourceUpdateMode = CustomerDataSourceUpdateMode;
                control.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定ComboBoxEdit的数据源
        /// </summary>
        /// <param name="edit">ComboBoxEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingComboEdit(ComboBoxEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                b.DataSourceUpdateMode = CustomerDataSourceUpdateMode;
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定ComboBoxEdit的数据源
        /// </summary>
        /// <param name="edit">ComboBoxEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingComboEditDataSource(ComboBoxEdit edit, DataTable dataSource, string bindField)
        {
            try
            {
                edit.Properties.Items.Clear();
                foreach (DataRow dr in dataSource.Rows)
                {
                    edit.Properties.Items.Add(dr[bindField]);
                }
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        /// <summary>
        /// 绑定ComboBoxEdit的数据源
        /// </summary>
        /// <param name="edit">ComboBoxEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingComboEditDataSource(RepositoryItemComboBox edit, DataTable dataSource, string bindField)
        {
            try
            {
                edit.Items.Clear();
                foreach (DataRow dr in dataSource.Rows)
                {
                    edit.Items.Add(dr[bindField]);
                }
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }


        /// <summary>
        /// 绑定CheckEdit的数据源
        /// </summary>
        /// <param name="edit">CheckEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingCheckEdit(CheckEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                b.DataSourceUpdateMode = CustomerDataSourceUpdateMode;
                b.NullValue = "N";
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }

        }

        /// <summary>
        /// 绑定CheckEdit的数据源
        /// </summary>
        /// <param name="edit">CheckEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingCheckedListBox(CheckedListBox edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("SelectedValue", dataSource, bindField);
                b.DataSourceUpdateMode = CustomerDataSourceUpdateMode;
                b.NullValue = "";
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }

        }


        /// <summary>
        /// 绑定图像控件的数据源
        /// </summary>
        /// <param name="edit">PictureEdit</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="bindField">取值字段</param>
        public static void BindingImageEdit(PictureEdit edit, object dataSource, string bindField)
        {
            try
            {
                edit.DataBindings.Clear();
                Binding b = new Binding("EditValue", dataSource, bindField);
                b.DataSourceUpdateMode = CustomerDataSourceUpdateMode;
                edit.DataBindings.Add(b);
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }



        /// <summary>
        /// 日期控件(DateEdit)的EditValueChanged事件.
        /// 对象内定义为Nullable<DateTime>数据类型的属性,进行数据绑定后不能将值
        /// 保存在对象内,所以实现这个方法做特殊处理
        /// </summary>
        public static void OnDateEditValueChange(object sender, EventArgs e)
        {
            try
            {
                DateEdit edit = (DateEdit)sender;
                if (edit.DataBindings.Count <= 0) return; //无绑定数据源.
                object bindingObj = edit.DataBindings[0].DataSource; //取绑定的对象.
                if (bindingObj != null)
                {
                    string bindingField = edit.DataBindings[0].BindingMemberInfo.BindingField; //取绑定的成员字段.                
                    SetValueOfObject(bindingObj, bindingField, edit.EditValue); //给对象的字段赋值
                }
            }
            catch (Exception ex) { Msg.ShowException(ex); }
        }



        /// <summary>
        /// 绑定日期选择控件(DateEdit)的EditValueChanged事件.
        /// 原因请叁考OnDateEditValueChange方法描述.
        /// </summary>        
        public static void BindingDateEditValueChangeEvent(DateEdit dateEdit)
        {
            dateEdit.EditValueChanged += new EventHandler(OnDateEditValueChange);
        }


        /// <summary>
        /// 给绑定数据源的输入控件赋值
        /// </summary>
        public static void SetEditorBindingValue(Control bindingControl, object value)
        {
            SetEditorBindingValue(bindingControl, value, false);
        }

        public static void SetEditorBindingValue(Control bindingControl, object value, bool setEditorValue)
        {
            try
            {
                object temp = null;
                if (value != DBNull.Value) temp = value;

                if (bindingControl.DataBindings.Count > 0)
                {
                    object dataSource = bindingControl.DataBindings[0].DataSource;
                    string field = bindingControl.DataBindings[0].BindingMemberInfo.BindingField;
                    if (dataSource is DataTable)
                    {
                        (dataSource as DataTable).Rows[0][field] = value;
                    }
                    else
                    {
                        SetValueOfObject(dataSource, field, value);
                    }
                }

                if (setEditorValue)
                    SetValueOfObject(bindingControl, "EditValue", value);

                bindingControl.Refresh();

            }
            catch { } //这里不用显示异常信息. 
        }




        /// <summary>
        /// 设置对象某个属性的值
        /// </summary>
        private static void SetValueOfObject(object obj, string property, object value)
        {
            try
            {
                if (obj == null) return;
                Type type = obj.GetType();
                System.Reflection.PropertyInfo[] pinfo = type.GetProperties();
                foreach (System.Reflection.PropertyInfo info in pinfo)
                {
                    if (info.Name.ToUpper() == property.ToUpper())
                    {
                        SetPropertyValue(obj, info, value);
                        break;
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// 给对象的属性赋值
        /// </summary>
        /// <param name="instance">对象实例</param>
        /// <param name="prop">属性</param>
        /// <param name="value">值</param>
        private static void SetPropertyValue(object instance, System.Reflection.PropertyInfo prop, object value)
        {
            try
            {
                if (prop == null) return;
                if (prop.PropertyType.ToString() == "System.String")
                { }
                else if (prop.PropertyType.ToString() == "System.Decimal")
                    value = Decimal.Parse(value.ToString());
                else if (prop.PropertyType.ToString() == "System.Int32")
                    value = int.Parse(value.ToString());
                else if (prop.PropertyType.ToString() == "System.Single")
                    value = Single.Parse(value.ToString());
                else if (prop.PropertyType.ToString() == "System.DateTime")
                    value = DateTime.Parse(value.ToString());
                prop.SetValue(instance, value, null);
            }
            catch { }
        }

    }
}
