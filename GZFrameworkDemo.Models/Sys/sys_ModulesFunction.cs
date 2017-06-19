using GZFramework.DB.ModelAttribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models
{
    /// <summary>
    /// ORM模型, 数据表:sys_ModulesFunction
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2015-09-18 09:54
    /// </summary>
    [ModelStruct(sys_ModulesFunction._TableName)]
    public sealed class sys_ModulesFunction
    {
        public const string _TableName = "sys_ModulesFunction";

        /// <summary>
        /// 模块ID
        /// </summary>
        [ModelForeignKey]
        public const string ModuleID = "ModuleID";

        /// <summary>
        /// 功能ID
        /// </summary>
        [ModelPrimaryKey]
        public const string FunctionID = "FunctionID";

       

        /// <summary>
        /// 功能名称
        /// </summary>
        [ModelEditField]
        public const string FunctionName = "FunctionName";

        [ModelEditField]
        public const string Sort = "Sort";
        

    }
}
