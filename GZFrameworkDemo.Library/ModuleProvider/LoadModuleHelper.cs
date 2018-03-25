using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using GZFrameworkDemo.Models;
using GZFrameworkDemo.Business;
using GZFrameworkDemo.Common;
using GZFramework.UI.Dev.Module;
using GZFramework.UI.Core.Module;
using System.Drawing;

namespace GZFrameworkDemo.Library.ModuleProvider
{
    public class LoadModuleHelper
    {
        private Dictionary<string, ModuleFunction> DataFunctions { get; set; }

        private List<ModuleModel> DataModules { get; set; }

        private LoadModuleHelper()
        {
            DataFunctions = new Dictionary<string, ModuleFunction>();
            DataModules = new List<ModuleModel>();
        }

        static LoadModuleHelper _intance;
        public static LoadModuleHelper Intance
        {
            get
            {
                if (_intance == null)
                    _intance = new LoadModuleHelper();
                return _intance;
            }
        }

        /// <summary>
        /// 获得本地模块列表
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="DLLName"></param>
        /// <returns></returns>
        private ModuleFunctionsPool GetLocalAllModules()
        {
            try
            {
                ModuleFunctionsPool module = new ModuleFunctionsPool();

                string Path = AppDomain.CurrentDomain.BaseDirectory;

                List<DirectoryCatalogModel> dcs = new List<DirectoryCatalogModel>();

                foreach (string filename in DevelopmentEnvironment.lstDLL)
                {
                    dcs.Add(new DirectoryCatalogModel(Path, filename + ".dll"));
                }
                //插件目录，在app.config中配置
                string PlugPath = System.Configuration.ConfigurationManager.AppSettings["ModulePath"];
                if (!String.IsNullOrEmpty(PlugPath))
                    dcs.Add(new DirectoryCatalogModel(String.Format("{0}{1}\\", Path, PlugPath)));

                return ModuleHelper.GetLocalAllModules(dcs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 根据当前用户信息获取模块信息
        /// </summary>
        /// <returns></returns>
        public List<ModuleModel> GetModule()
        {
            DataModules.Clear();
            //CheckDesingModel.IsDebug && 
            if (Loginer.CurrentLoginer.IsSysAdmin)
                DataModules = GetModuleALL();
            else
                DataModules = GetModuleConfig();
            DataFunctions.Clear();
            foreach (var m in DataModules)
            {
                foreach (var f in m.functions)
                {
                    DataFunctions.Add(f.FunctionID, f);
                }
            }

            return DataModules;
        }
        public List<ModuleModel> GetModuleALL()
        {
            List<ModuleModel> lst = new List<ModuleModel>();
            var modules = GetLocalAllModules();


            DataSet ds = new bllModules().GetUserModules(Loginer.CurrentLoginer.Account);
            DataTable dtModules = ds.Tables[sys_Modules._TableName];
            DataTable dtModulesFun = ds.Tables[sys_ModulesFunction._TableName];


            foreach (IModule m in modules.Modules)
            {
                DataRow drModule = dtModules.Select($"{sys_Modules.ModuleID}='{m.ModuleID}'").FirstOrDefault();

                ModuleModel module = new ModuleModel()
                {
                    ModuleImg = m.ModuleImg,
                    ModuleName = m.ModuleName,
                    ModuleID = m.ModuleID,
                    Sort = -1,
                    ModuleMainType = (m is Form) ? m.GetType() : null
                };
                if (drModule != null)
                {
                    module.ModuleName = ConvertLib.ToString(drModule[sys_Modules.ModuleName]);
                    module.Sort = ConvertLib.ToInt(drModule[sys_Modules.Sort]);
                    module.IsNew = false;
                }

                foreach (ModuleFunction fun in m.FunctionCollection)
                {
                    fun.Sort = -1;
                    DataRow drFun = dtModulesFun.Select($"{sys_ModulesFunction.FunctionID}='{fun.FunctionID}'").FirstOrDefault();
                    if (drFun != null)
                    {
                        fun.FunctionName = ConvertLib.ToString(drFun[sys_ModulesFunction.FunctionName]);
                        fun.Sort = ConvertLib.ToInt(drFun[sys_ModulesFunction.Sort]);
                        byte[] imgByte = drFun[sys_ModulesFunction.Image] as byte[];
                        if (imgByte != null && imgByte.Length > 0)
                            fun.FormIcon = Common.ImageLibrary.ConvertBytesToImage(imgByte);
                        fun.IsNew = false;
                    }

                    fun.UserAuthority = GZFramework.UI.Core.FunctionAuthority.All;

                    module.functions.Add(fun);
                }
                if (module.functions.Count > 0)
                {
                    lst.Add(module);
                }
            }
            SortModule(lst);
            return lst;
        }



        private List<ModuleModel> GetModuleConfig()
        {
            List<ModuleModel> lst = new List<ModuleModel>();
            var lstModules = GetLocalAllModules();

            DataSet ds = new bllModules().GetUserModules(Loginer.CurrentLoginer.Account);
            DataTable dtModules = ds.Tables[sys_Modules._TableName];
            DataTable dtModulesFun = ds.Tables[sys_ModulesFunction._TableName];

            foreach (DataRow dr in dtModules.Rows)
            {

                var m = lstModules.Modules[dr[sys_Modules.ModuleID].ToString()];
                if (m == null) continue;

                ModuleModel module = new ModuleModel()
                {
                    ModuleImg = m.ModuleImg,
                    ModuleName = dr[sys_Modules.ModuleName] + "",
                    ModuleID = m.ModuleID,
                    Sort = ConvertLib.ToInt(dr[sys_Modules.Sort]),
                    IsNew=false,
                    ModuleMainType = (m is Form) ? m.GetType() : null
                };

                dtModulesFun.DefaultView.RowFilter = String.Format("{0}='{1}'", sys_ModulesFunction.ModuleID, dr[sys_Modules.ModuleID]);
                foreach (DataRow row in dtModulesFun.DefaultView.ToTable().Rows)
                {
                    var fun = m.FunctionCollection[row[sys_ModulesFunction.FunctionID].ToString()];
                    fun.UserAuthority = ConvertLib.ToInt(row["UserAuthority"]);
                    fun.FunctionName = ConvertLib.ToString(row[sys_ModulesFunction.FunctionName]);
                    fun.Sort = ConvertLib.ToInt(row[sys_ModulesFunction.Sort]);
                    fun.IsNew = false;
                    byte[] imgByte = row[sys_ModulesFunction.Image] as byte[];
                    if (imgByte != null && imgByte.Length > 0)
                        fun.FormIcon = Common.ImageLibrary.ConvertBytesToImage(imgByte);
                    if (fun == null) continue;
                    module.functions.Add(fun);
                }
                if (module.functions.Count > 0)
                {
                    lst.Add(module);
                }
            }
            SortModule(lst);
            return lst;
        }

        /// <summary>
        /// 模块排序
        /// </summary>
        /// <param name="lst"></param>
        private void SortModule(List<ModuleModel> lst)
        {
            lst.Sort(new Comparison<ModuleModel>(new ModulesComparison().CompareASC));
            foreach (var m in lst)
            {
                m.functions.Sort(new Comparison<ModuleFunction>(new FunctionComparison().CompareASC));
            }
        }

        /// <summary>
        /// 根据功能ID查找功能类
        /// </summary>
        /// <param name="functionID"></param>
        /// <returns></returns>
        public ModuleFunction FindFunctionByFunctionID(string functionID)
        {
            if (DataFunctions.ContainsKey(functionID))
                return DataFunctions[functionID];
            return null;
        }
        /// <summary>
        /// 判断是否有功能权限
        /// </summary>
        /// <param name="functionID"></param>
        /// <returns></returns>
        public bool HasAuthority(string functionID)
        {
            return DataFunctions.ContainsKey(functionID);
        }
        /// <summary>
        /// 判断是否有功能权限
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public bool HasAuthority(Type function)
        {
            return DataFunctions.ContainsKey(function.FullName);
        }
    }



}
