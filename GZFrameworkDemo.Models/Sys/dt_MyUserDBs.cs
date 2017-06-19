using GZFramework.DB.ModelAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Models
{
    ///<summary>
    /// ORM模型, 数据表:dt_MyUserDBs
    /// 由GZFramework框架代码生成器自动生成
    /// </summary>
    [ModelStruct(dt_MyUserDBs._TableName)]
    public sealed class dt_MyUserDBs
    {
        public const string _TableName = "dt_MyUserDBs";

        /// <summary>
        /// 自增字段
        /// </summary>	
        [ModelPrimaryKey]
        public const string isid = "isid";

        /// <summary>
        /// 账号
        /// </summary>	
        [ModelForeignKey]
        public const string Account = "Account";

        /// <summary>
        /// 账套标识
        /// </summary>	
        [ModelEditField]
        public const string DBCode = "DBCode";

        /// <summary>
        /// 锁定
        /// </summary>	
        [ModelEditField]
        public const string IsDBLock = "IsDBLock";

        /// <summary>
        /// 是否是管理员
        /// </summary>	
        [ModelEditField]
        public const string IsDBAdmin = "IsDBAdmin";

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
