
/**************************************************************************
	===============代码由GZFramework开发框架代码生成器生成===============
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
	-- 博客地址:http://www.cnblogs.com/GarsonZhang/
	-- 生成日期：2016-01-23 16:21
**************************************************************************/

using GZFramework.DB.ModelAttribute;
namespace GZFrameworkDemo.Models
{
    ///<summary>
    /// ORM模型, 数据表:sys_DataBaseListAuthority
    /// 由GZFramework框架代码生成器自动生成
    /// </summary>
    [ModelStruct(sys_DataBaseListAuthority._TableName)]
    public sealed class sys_DataBaseListAuthority
    {
        public const string _TableName = "sys_DataBaseListAuthority";
	
		/// <summary>
        /// isid
        /// </summary>	
		[ModelPrimaryKey]
		public const string isid = "isid";
	
		/// <summary>
        /// 账套标识
        /// </summary>	
		[ModelForeignKey]
		public const string DBCode = "DBCode";
	
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



