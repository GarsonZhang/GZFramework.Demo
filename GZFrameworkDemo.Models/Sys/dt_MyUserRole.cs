/**************************************************************************
    ====================GZFramwork【Winfrom快速开发框架】====================
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
    -- 博客地址:http://www.cnblogs.com/GarsonZhang/
 
	-- CLR版本： 4.0.30319.42000
	-- 创建时间：2015-10-22 9:47:50
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
    /// ORM模型, 数据表:dt_MyUserRole
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2015-10-22 09:48
    /// </summary>
    [ModelStruct(dt_MyUserRole._TableName)]
    public sealed class dt_MyUserRole
    {
        public const string _TableName = "dt_MyUserRole";

        /// <summary>
        /// 自增字段
        /// </summary>
        [ModelPrimaryKey]
        public const string RowID = "RowID";

        /// <summary>
        /// 账号
        /// </summary>
        [ModelForeignKey]
        public const string Account = "Account";


        /// <summary>
        /// 角色编号
        /// </summary>
        [ModelEditField]
        public const string RoleID = "RoleID";

        /// <summary>
        /// 创建人
        /// </summary>
        [ModelEditField]
        public const string CreateUser = "CreateUser";

        /// <summary>
        /// 创建日期
        /// </summary>
        [ModelEditField]
        public const string CreateDate = "CreateDate";

        /// <summary>
        /// 修改人
        /// </summary>
        [ModelEditField]
        public const string LastUpdateUser = "LastUpdateUser";

        /// <summary>
        /// 修改日期
        /// </summary>
        [ModelEditField]
        public const string LastUpdateDate = "LastUpdateDate";

    }



}
