
/**************************************************************************
	===============代码由GZFramework开发框架代码生成器生成===============
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
	-- 博客地址:http://www.cnblogs.com/GarsonZhang/
	-- 生成日期：2016-01-23 08:38
**************************************************************************/

using GZFramework.DB.ModelAttribute;
namespace GZFrameworkDemo.Models
{
    ///<summary>
    /// ORM模型, 数据表:sys_DataBaseList
    /// 由GZFramework框架代码生成器自动生成
    /// </summary>
    [ModelStruct(sys_DataBaseList._TableName)]
    public sealed class sys_DataBaseList
    {
        public const string _TableName = "sys_DataBaseList";

        /// <summary>
        /// 自增字段
        /// </summary>	
        public const string isid = "isid";

        /// <summary>
        /// 数据库标识
        /// </summary>	
        [ModelPrimaryKey]
        public const string DBCode = "DBCode";

        /// <summary>
        /// 数据库类型
        /// </summary>
        [ModelEditField]
        public const string DBProviderName = "DBProviderName";

        /// <summary>
        /// 数据库描述
        /// </summary>
        [ModelEditField]
        public const string DBDisplayText = "DBDisplayText";

        /// <summary>
        /// 服务器地址
        /// </summary>	
        [ModelEditField]
        public const string DBServer = "DBServer";

        /// <summary>
        /// 数据库名
        /// </summary>	
        [ModelEditField]
        public const string DBName = "DBName";




        /// <summary>
        /// 链接字符串
        /// </summary>	
        [ModelEditField]
        public const string DBConnection = "DBConnection";

    }
}



