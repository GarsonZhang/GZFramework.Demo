
/**************************************************************************
	===============代码由GZFramework开发框架代码生成器生成===============
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
	-- 博客地址:http://www.cnblogs.com/GarsonZhang/
	-- 生成日期：2016-01-27 10:16
**************************************************************************/

using GZFramework.DB.ModelAttribute;
namespace GZFrameworkDemo.Models
{
    ///<summary>
    /// ORM模型, 数据表:sys_DataSN
    /// 由GZFramework框架代码生成器自动生成
    /// </summary>
    [ModelStruct(sys_DataSN._TableName)]
    public sealed class sys_DataSN
    {
        public const string _TableName = "sys_DataSN";
	
		/// <summary>
        /// 单据标识
        /// </summary>	
		[ModelPrimaryKey]
		public const string DocCode = "DocCode";
	
		/// <summary>
        /// 
        /// </summary>	
		[ModelEditField]
		public const string DocName = "DocName";
	
		/// <summary>
        /// 
        /// </summary>	
		[ModelEditField]
		public const string DocHeader = "DocHeader";
	
		/// <summary>
        /// 
        /// </summary>	
		[ModelEditField]
		public const string Separate = "Separate";
	
		/// <summary>
        /// 
        /// </summary>	
		[ModelEditField]
		public const string DocType = "DocType";
	
		/// <summary>
        /// 长度
        /// </summary>	
		[ModelEditField]
		public const string Length = "Length";

        /// <summary>
        /// 示例
        /// </summary>
        [ModelEditField]
        public const string Demo = "Demo";

    }
}



