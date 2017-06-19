using ClothingPSISQLite.Library;
using ClothingPSISQLite.Library.ModuleProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingPSISQLite.SystemManagement
{

    public class Management : Module
    {
        public Management()
        {
            //this.AddFunction(typeof(frmMyUser), "账号管理");
            //this.AddFunction(typeof(frmMyRole), "角色管理");
            //this.AddFunction(typeof(frmRibbonStyle), "Ribbon设置");
            //this.AddFunction(typeof(frmSetting), "系统设置");
            //this.AddFunction(typeof(frmCompanyInfo), "公司信息");
            //this.AddFunction(typeof(frmSystemAuthority), "功能注册");

            FunctionCollection = new ModuleFunctionCollection();

            //获得模块信息
            System.Reflection.Assembly s = this.GetType().Assembly;
            AssemblyModuleAttribute ModuleInfo = (AssemblyModuleAttribute)AssemblyModuleAttribute.GetCustomAttribute(s, typeof(AssemblyModuleAttribute));

            ModuleID = s.GetName().Name;
            ModuleName = ModuleInfo.ModuleName;
            ModuleImg = ModuleInfo.ModulePNGLarge;
        }

        public void AddFunction(Type FormType, string Text)
        {
            FunctionCollection.AddFunction(FormType, Text);
        }

        public void ShowModuleMain()
        {
            
        }

        public ModuleFunctionCollection FunctionCollection { get; set; }

        public string ModuleID { get; set; }

        public string ModuleImg { get; set; }

        public string ModuleName { get; set; }

        public int Sort { get; set; }
    }
}
