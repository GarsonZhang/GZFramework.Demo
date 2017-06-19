using GZFramework.DB.ModelAttribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models
{
    /// <summary>
    /// ORM模型, 数据表:sys_Modules
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2015-09-18 09:54
    /// </summary>
    [ModelStruct(sys_Modules._TableName)]
    public sealed class sys_Modules
    {
        public const string _TableName = "sys_Modules";


        /// <summary>
        /// 模块ID
        /// </summary>
        [ModelPrimaryKey]
        public const string ModuleID = "ModuleID";


        /// <summary>
        /// 模块名称
        /// </summary>
        [ModelEditField]
        public const string ModuleName = "ModuleName";

        /// <summary>
        /// 排序
        /// </summary>
        [ModelEditField]
        public const string Sort = "Sort";


    }
}
