/**************************************************************************
    ====================GZFramwork【Winfrom快速开发框架】====================
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
    -- 博客地址:http://www.cnblogs.com/GarsonZhang/
 
	-- CLR版本： 4.0.30319.42000
	-- 创建时间：2015-10-21 10:33:53
	-- 创建年月：2015
**************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GZFramework.DB.ModelAttribute;

namespace GZFrameworkDemo.Models
{

    /// <summary>
    /// ORM模型, 数据表:dt_MyRole
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2015-10-21 10:34
    /// </summary>
    [ModelStruct(dt_MyRole._TableName)]
    public sealed class dt_MyRole
    {
        public const string _TableName = "dt_MyRole";

        /// <summary>
        /// 角色编号
        /// </summary>
        [ModelPrimaryKey]
        public const string RoleID = "RoleID";

        /// <summary>
        /// 角色名称
        /// </summary>
        [ModelEditField]
        public const string RoleName = "RoleName";

        /// <summary>
        /// 描述
        /// </summary>
        [ModelEditField]
        public const string Description = "Description";

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
