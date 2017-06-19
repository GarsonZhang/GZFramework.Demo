
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
    /// ORM模型, 数据表:sys_CommonSearch
    /// 由GZFramework框架代码生成器自动生成
    /// </summary>
    [ModelStruct(sys_CommonSearch._TableName)]
    public sealed class sys_CommonSearch
    {
        public const string _TableName = "sys_CommonSearch";

	
		/// <summary>
        /// 主键
        /// </summary>	
		[ModelPrimaryKey]
		public const string RowID = "RowID";
	
		/// <summary>
        /// 检索标识
        /// </summary>	
		[ModelEditField]
		public const string SearchCode = "SearchCode";
	
		/// <summary>
        /// 检所列名称
        /// </summary>	
		[ModelEditField]
		public const string strColumnName = "strColumnName";
	
		/// <summary>
        /// SQL语句
        /// </summary>	
		[ModelEditField]
		public const string strSQL = "strSQL";
	
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



