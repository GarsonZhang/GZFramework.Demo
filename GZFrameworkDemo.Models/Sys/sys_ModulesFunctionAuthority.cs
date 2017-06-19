using GZFramework.DB.ModelAttribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models
{
    /// <summary>
    /// ORM模型, 数据表:sys_ModulesFunctionAuthority
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2015-09-18 09:54
    /// </summary>
    [ModelStruct(sys_ModulesFunctionAuthority._TableName)]
    public sealed class sys_ModulesFunctionAuthority
    {
        public const string _TableName = "sys_ModulesFunctionAuthority";

        /// <summary>
        /// 功能ID
        /// </summary>
        [ModelEditField(true, true, false)]
        public const string FunctionID = "FunctionID";

        /// <summary>
        /// 权限值
        /// </summary>
        [ModelPrimaryKey]
        public const string AuthorityID = "AuthorityID";
       
        /// <summary>
        /// 权限名称
        /// </summary>
        [ModelEditField]
        public const string AuthorityName = "AuthorityName";

    }
}
