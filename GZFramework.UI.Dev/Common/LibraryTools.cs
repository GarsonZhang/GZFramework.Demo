/**************************************************************************
	-- 作者：Garson_Zhang
	-- CLR版本： 4.0.30319.34209
	-- 命名空间名称：GZFrameworkLibrary
	-- 文件名：LibraryTools
	-- 时间：2015-01-30 17:36:02
	-- 创建年月：2015
	-- 描述：尚未编写描述

**************************************************************************/

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using GZFramework.UI.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.Common
{
    public class LibraryTools
    {
        public static void DoBindingEditorPanel(Control editorPanel, DataTable dataSource, string head)
        {
            string fieldName = "";
            int length = head.Length;

            try
            {
                for (int i = 0; i <= editorPanel.Controls.Count - 1; i++)
                {
                    if (String.IsNullOrEmpty(editorPanel.Controls[i].Name)) continue;
                    if (editorPanel.Controls[i] is BaseEdit)
                    {
                        BaseEdit edit = editorPanel.Controls[i] as BaseEdit;
                        if (edit.Name.Substring(0, length) == head)
                        {
                            fieldName = edit.Name.Substring(length, edit.Name.Length - length);
                            DataBinder.BindingTextEditBase(edit, dataSource, fieldName);
                        }
                        continue;
                    }

                    if (editorPanel.Controls[i] is CheckEdit)
                    {
                        CheckEdit edit = editorPanel.Controls[i] as CheckEdit;
                        if (edit.Name.Substring(0, length) == head)
                        {
                            fieldName = edit.Name.Substring(length, edit.Name.Length - length);
                            DataBinder.BindingCheckEdit(edit, dataSource, fieldName);

                        }
                        continue;
                    }

                    if (editorPanel.Controls[i].Controls.Count > 0)
                    {
                        DoBindingEditorPanel(editorPanel.Controls[i], dataSource, head);
                        continue;
                    }

                }
            }
            catch (Exception ex)
            {
                Msg.Warning(String.Format("字段:{0}\r\n{1}", fieldName, ex.Message));
            }
        }

        public static void DoBindingEditorPanel(Control editorPanel, DataRow dataSource, string head)
        {
            string fieldName = "";
            int length = head.Length;

            try
            {
                for (int i = 0; i <= editorPanel.Controls.Count - 1; i++)
                {

                    if (editorPanel.Controls[i] is BaseEdit)
                    {
                        BaseEdit edit = editorPanel.Controls[i] as BaseEdit;
                        if (edit.Name.Substring(0, length) == head)
                        {
                            fieldName = edit.Name.Substring(length, edit.Name.Length - length);
                            DataBinder.BindingTextEditBase(edit, dataSource, fieldName);
                        }
                        continue;
                    }

                    if (editorPanel.Controls[i] is CheckEdit)
                    {
                        CheckEdit edit = editorPanel.Controls[i] as CheckEdit;
                        if (edit.Name.Substring(0, length) == head)
                        {
                            fieldName = edit.Name.Substring(length, edit.Name.Length - length);
                            DataBinder.BindingCheckEdit(edit, dataSource, fieldName);

                        }
                        continue;
                    }


                    if (editorPanel.Controls[i].Controls.Count > 0)
                    {
                        DoBindingEditorPanel(editorPanel.Controls[i], dataSource, head);
                        continue;
                    }

                }
            }
            catch (Exception ex)
            {
                Msg.Warning(String.Format("字段:{0}\r\n{1}", fieldName, ex.Message));
            }
        }

        /// <summary>
        /// 设置控件状态.ReadOnly or Enable = false/true
        /// </summary>
        public static void SetControlAccessable(Control control, bool value)
        {
            try
            {
                if (control is Label) return;
                if (control is LabelControl) return;
                if (control is ControlNavigator) return;

                if (control is UserControl)
                {
                    (control as UserControl).Enabled = value;
                    return;
                }
                if (control is BaseButton)
                {
                    (control as BaseStyleControl).Enabled = value;
                    return;
                }
                if (control is BaseEdit)
                {
                    (control as BaseEdit).Properties.ReadOnly = !value;
                    return;
                }
                if (control is TreeList)
                {
                    (control as TreeList).OptionsBehavior.Editable = value;
                    return;
                }
                if (control is GridControl)
                {
                    foreach (BaseView v in (control as GridControl).Views)
                    {
                        if (v is ColumnView)
                        {
                            (v as ColumnView).OptionsBehavior.Editable = value;
                        }
                        if (v is CardView)
                            (v as CardView).OptionsBehavior.Editable = value;
                    }

                }


                if (control.Controls.Count > 0)
                {
                    foreach (Control c in control.Controls)
                        SetControlAccessable(c, value);
                }

                Type type = control.GetType();

                //PropertyInfo info = null;

                #region Old

                //PropertyInfo[] infos = type.GetProperties();
                //foreach (PropertyInfo info in infos)
                //{
                //    if (info.Name == "ReadOnly")//ReadOnly
                //    {
                //        info.SetValue(control, !value, null);
                //        return;
                //    }
                //    if (info.Name == "Properties")//Properties.ReadOnly
                //    {
                //        object o = info.GetValue(control, null);
                //        if (o is RepositoryItem)
                //        {
                //            ((RepositoryItem)o).ReadOnly = !value;
                //        }
                //        if ((o is RepositoryItemButtonEdit) && (((RepositoryItemButtonEdit)o).Buttons.Count > 0))
                //            ((RepositoryItemButtonEdit)o).Buttons[0].Enabled = value;
                //        if ((o is RepositoryItemDateEdit) && (((RepositoryItemDateEdit)o).Buttons.Count > 0))
                //            ((RepositoryItemDateEdit)o).Buttons[0].Enabled = value;
                //        return;
                //    }
                //    if (info.Name == "Views")//OptionsBehavior.Editable
                //    {
                //        object o = info.GetValue(control, null);
                //        if (null == o) return;
                //        foreach (object view in (GridControlViewCollection)o)
                //        {
                //            if (view is ColumnView)
                //                ((ColumnView)view).OptionsBehavior.Editable = value;
                //        }
                //        return;
                //    }

                //}

                #endregion
            }
            catch (Exception ex)
            {
                Msg.ShowException(ex);
            }
        }

        public static void SetViewEditable(ColumnView View, bool value)
        {
            View.OptionsBehavior.Editable = value;
        }

        /// <summary>
        /// 设置Grid自定义按钮(Add,Insert,Delete)状态
        /// </summary>
        public static void SetNavigatorButtonsEnable(GridControl gridControl, bool value)
        {

            //设置自带按钮
            foreach (NavigatorButton btn in gridControl.EmbeddedNavigator.Buttons.ButtonCollection) btn.Enabled = value;

            //设置按钮
            foreach (NavigatorCustomButton btn in gridControl.EmbeddedNavigator.Buttons.CustomButtons) btn.Enabled = value;


        }

        /// <summary>
        /// 设置GridNavigatorButtons可见
        /// </summary>
        public static void SetNavigatorButtonsVisable(GridControl gridControl, bool value)
        {

            //设置自带按钮
            foreach (NavigatorButton btn in gridControl.EmbeddedNavigator.Buttons.ButtonCollection) btn.Visible = value;

            //设置按钮
            foreach (NavigatorCustomButton btn in gridControl.EmbeddedNavigator.Buttons.CustomButtons) btn.Visible = value;


        }

        public static void SetEditorBindingValue(Control edit, object value)
        {
            ////edit.EditValue = value;
            if (edit.DataBindings.Count > 0)
            {
                DataSourceUpdateMode bk = edit.DataBindings[0].DataSourceUpdateMode;
                if (bk != DataSourceUpdateMode.OnPropertyChanged)
                {

                    edit.DataBindings[0].DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
                    edit.GetType().GetProperty(edit.DataBindings[0].PropertyName).SetValue(edit, value, null);
                    edit.DataBindings[0].DataSourceUpdateMode = bk;
                    
                }
                else
                    edit.GetType().GetProperty(edit.DataBindings[0].PropertyName).SetValue(edit, value, null);


            }
        }


        public static void DoClearPanel(Control editorPanel)
        {
            try
            {
                for (int i = 0; i <= editorPanel.Controls.Count - 1; i++)
                {

                    if (editorPanel.Controls[i] is BaseEdit)
                        (editorPanel.Controls[i] as BaseEdit).EditValue = "";

                    else if (editorPanel.Controls[i].Controls.Count > 0)
                        DoClearPanel(editorPanel.Controls[i]);
                }
            }
            catch (Exception ex)
            {
                Msg.Warning(ex.Message);
            }
        }


        public enum IntRuler
        {
            不判断,
            大于0,
            小于0,
            不能等于0
        }

        public static bool IsNotEmpBaseEdit(BaseEdit edit, string ErrorText = "", IntRuler Ruler = IntRuler.大于0)
        {
            if (edit.Visible == false) return true;

            if ((edit.EditValue is Int32 || edit.EditValue is Decimal) && Ruler != IntRuler.不判断)
            {
                bool tmp = false;
                switch (Ruler)
                {
                    case IntRuler.大于0: tmp = ConvertEx.ToDecimal(edit.EditValue) > 0; break;
                    case IntRuler.不能等于0: tmp = ConvertEx.ToDecimal(edit.EditValue) != 0; break;
                    case IntRuler.小于0: tmp = ConvertEx.ToDecimal(edit.EditValue) < 0; break;
                }
                if (tmp == false)
                {
                    edit.ErrorIconAlignment = ErrorIconAlignment.MiddleRight;
                    edit.ErrorText = ErrorText;

                    edit.EditValueChanged -= edit_EditValueChanged;

                    edit.EditValueChanged += edit_EditValueChanged;
                    return tmp;
                }
            }


            if (String.IsNullOrEmpty(ConvertEx.ToString(edit.EditValue)))
            {
                if (ErrorText != "")
                {

                    edit.ErrorIconAlignment = System.Windows.Forms.ErrorIconAlignment.MiddleRight;
                    edit.ErrorText = ErrorText;

                    edit.EditValueChanged -= edit_EditValueChanged;

                    edit.EditValueChanged += edit_EditValueChanged;
                }
                return false;
            }
            return true;
        }

        static void edit_EditValueChanged(object sender, EventArgs e)
        {
            (sender as BaseEdit).ErrorText = String.Empty;
        }



    }


}
