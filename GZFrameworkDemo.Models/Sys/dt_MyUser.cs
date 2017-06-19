/**************************************************************************
    ====================GZFramwork【Winfrom快速开发框架】====================
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
    -- 博客地址:http://www.cnblogs.com/GarsonZhang/
 
	-- CLR版本： 4.0.30319.42000
	-- 创建时间：2015-09-18 9:52:57
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
    /// ORM模型, 数据表:dt_MyUser
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2015-09-18 09:54
    /// </summary>
    [ModelStruct(dt_MyUser._TableName)]
    public sealed class dt_MyUser
    {
        public const string _TableName = "dt_MyUser";

        /// <summary>
        /// 账号
        /// </summary>
        [ModelPrimaryKey]
        public const string Account = "Account";

        /// <summary>
        /// 密码
        /// </summary>
        [ModelEditField]
        public const string Password = "Password";

        /// <summary>
        /// 名称
        /// </summary>
        [ModelEditField]
        public const string UserName = "UserName";

        /// <summary>
        /// 电话
        /// </summary>
        [ModelEditField]
        public const string Phone = "Phone";

        /// <summary>
        /// Email
        /// </summary>
        [ModelEditField]
        public const string Email = "Email";

        /// <summary>
        /// 是否是管理员
        /// </summary>
        [ModelEditField]
        public const string IsSysAdmain = "IsSysAdmain";

        /// <summary>
        /// 锁定
        /// </summary>
        [ModelEditField]
        public const string IsSysLock = "IsSysLock";
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
