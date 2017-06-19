
using GZFramework.UI.Core;
using GZFramework.UI.Core.Module;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GZFramework.UI.Dev.Module
{
    public partial class frmModuleMainBase : GZFramework.UI.Dev.LibForm.frmBaseChild, Core.Module.IModule
    {
        public ModuleFunctionCollection FunctionCollection { get; set; }

        Dictionary<Control, Type> ButtonMap;
        public frmModuleMainBase()
        {
            InitializeComponent();
            if (CheckDesingModel.IsDesingMode) return;
            ButtonMap = new Dictionary<Control, Type>();
            FunctionCollection = new ModuleFunctionCollection();

            //获得模块信息
            System.Reflection.Assembly s = this.GetType().Assembly;
            AssemblyModuleAttribute ModuleInfo = (AssemblyModuleAttribute)AssemblyModuleAttribute.GetCustomAttribute(s, typeof(AssemblyModuleAttribute));

            ModuleID = s.GetName().Name;
            ModuleName = ModuleInfo.ModuleName;
            ModuleImg = ModuleInfo.ModulePNGLarge;
            this.Load += FrmModuleMainBase_Load;
        }

        private void FrmModuleMainBase_Load(object sender, EventArgs e)
        {
            if (CheckDesingModel.IsDesingMode) return;
            foreach (var col in ButtonMap.Keys)
            {
                bool authority = HasAuthority(ButtonMap[col].FullName);
                SetControlAuthority(col, authority);
            }
        }
        /// <summary>
        /// 根据权限设置按钮状态
        /// </summary>
        /// <param name="col"></param>
        /// <param name="HasAuthority"></param>
        protected virtual void SetControlAuthority(Control col, bool HasAuthority)
        {
            if (HasAuthority == false)
                col.Visible = false;
        }
        /// <summary>
        /// 判断是否拥有指定功能的权限
        /// </summary>
        /// <param name="functionid"></param>
        /// <returns></returns>
        protected virtual bool HasAuthority(string functionid)
        {
            return false;
        }

        public void AddFunction(Control col, Type FormType, string Text)
        {
            FunctionCollection.AddFunction(FormType, Text);
            ButtonMap.Add(col, FormType);
        }
        public string ModuleID { get; set; }

        public string ModuleImg { get; set; }

        public string ModuleName { get; set; }

        public int Sort { get; set; }

    }
}
