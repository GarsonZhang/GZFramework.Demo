using GZFramework.DB.ModelAttribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models
{
    /// <summary>
    /// ORM模型, 数据表:dt_MyRoleAuthority
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2015-10-21 10:34
    /// </summary>
    [ModelStruct(dt_MyRoleAuthority._TableName)]
    public sealed class dt_MyRoleAuthority
    {
        public const string _TableName = "dt_MyRoleAuthority";


        [ModelPrimaryKey]
        public const string RowID = "RowID";

        /// <summary>
        /// 角色编号
        /// </summary>
        [ModelForeignKey]
        public const string RoleID = "RoleID";

        /// <summary>
        /// 权限菜单
        /// </summary>
        [ModelEditField]
        public const string FunctionID = "FunctionID";

        /// <summary>
        /// 权限值
        /// </summary>
        [ModelEditField]
        public const string Authority = "Authority";

        /// <summary>
        /// CreateUser
        /// </summary>
        [ModelEditField]
        public const string CreateUser = "CreateUser";

        /// <summary>
        /// CreateDate
        /// </summary>
        [ModelEditField]
        public const string CreateDate = "CreateDate";

        /// <summary>
        /// LastUpdateUser
        /// </summary>
        [ModelEditField]
        public const string LastUpdateUser = "LastUpdateUser";

        /// <summary>
        /// LastUpdateDate
        /// </summary>
        [ModelEditField]
        public const string LastUpdateDate = "LastUpdateDate";

    }
}
