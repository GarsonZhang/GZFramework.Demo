using DevExpress.Utils;
using GZFrameworkDemo.Business;
using GZFrameworkDemo.Common;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library.MyControl
{
    [ToolboxItem(true)]
    public class CommonSearchEdit : DevExpress.XtraEditors.ButtonEdit
    {
        bllCommonSearch bll;
        public CommonSearchEdit()
        {
            this.Properties.Buttons.Clear();
            if (CheckDesingModel.IsDesingMode) return;
            bll = new bllCommonSearch();
            //var ebtnSet = new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph);//设置用户字段
            //ebtnSet.Caption = "设";

            //var ebtnConfig = new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph);//配置查询字段
            //ebtnConfig.Caption = "配";
            //this.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { ebtnSet, ebtnConfig });
        }

        private string _sqlFomat = "";

        public string SQL
        {
            get
            {
                return _sqlFomat;
            }
        }
        private string Code = "";
        protected override void OnLoaded()
        {
            this.Properties.Buttons.Clear();
            if (CheckDesingModel.IsDesingMode) return;
            var frm = this.FindForm();
            Code = string.Format("{0}.{1}", frm.GetType().FullName, this.Name);


            this.Properties.NullValuePromptShowForEmptyValue = true;

            this.Properties.AllowNullInput = DefaultBoolean.False;

            RefreshSearch();
            
            var ebtnSet = new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph);//设置用户字段
            ebtnSet.Caption = "设";
            this.Properties.Buttons.Add(ebtnSet);
            if (Loginer.CurrentLoginer.IsSysAdmin)
            {
                var ebtnConfig = new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph);//配置查询字段
                ebtnConfig.Caption = "配";
                this.Properties.Buttons.Add(ebtnConfig);
            }
            this.Properties.ButtonClick += Properties_ButtonClick;
        }

        private void RefreshSearch()
        {
            DataTable dt = bll.GetCommonSearchCurrentUser(Code);
            string NullValuePrompt = "", strformat = "";
            var drs = dt.Select(String.Format("{0}='Y'", sys_CommonSearchUser.Flag));
            if (drs.Length > 0)
            {
                foreach (DataRow dr in drs)
                {
                    NullValuePrompt += ("、" + dr[sys_CommonSearch.strColumnName]);
                    strformat += (" OR " + dr[sys_CommonSearch.strSQL]);
                }
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    NullValuePrompt += ("、" + dr[sys_CommonSearch.strColumnName]);
                    strformat += (" OR " + dr[sys_CommonSearch.strSQL]);
                }
            }

            if (!String.IsNullOrEmpty(NullValuePrompt))
            {
                this.Properties.NullValuePrompt = NullValuePrompt.Substring(1);
                this.ToolTip = this.Properties.NullValuePrompt;
            }
            if (!String.IsNullOrEmpty(NullValuePrompt))
                this._sqlFomat = strformat.Substring(4);
        }

        void Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "设")
            {

                bool success = frmDialog_CommonSearchSetting.ShowForm(Code);
                if (success == true)
                    RefreshSearch();
            }
            if (e.Button.Caption == "配")
            {
                frmDialog_CommonSearchConfig.ShowForm(Code);
            }
        }
    }
}
