
/**************************************************************************
	===============代码由GZFramework开发框架代码生成器生成===============
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
	-- 博客地址:http://www.cnblogs.com/GarsonZhang/
	-- 生成日期：2016-01-29 11:10
**************************************************************************/

using GZFramework.DB.ModelAttribute;
namespace GZFrameworkDemo.Models
{
    ///<summary>
    /// ORM模型, 数据表:sys_CommonSearchUser
    /// 由GZFramework框架代码生成器自动生成
    /// </summary>
    [ModelStruct(sys_CommonSearchUser._TableName)]
    public sealed class sys_CommonSearchUser
    {
        public const string _TableName = "sys_CommonSearchUser";

        /// <summary>
        /// 主键
        /// </summary>	
        [ModelEditField]
        public const string Account = "Account";

        /// <summary>
        /// 主键
        /// </summary>	
        [ModelEditField]
        public const string RowID = "RowID";

        /// <summary>
        /// 配置
        /// </summary>	
        [ModelEditField]
        public const string Flag = "Flag";

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



