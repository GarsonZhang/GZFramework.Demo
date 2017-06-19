
/**************************************************************************
	===============代码由GZFramework开发框架代码生成器生成===============
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
	-- 博客地址:http://www.cnblogs.com/GarsonZhang/
	-- 生成日期：2016-01-30 13:01
**************************************************************************/

using GZFramework.DB.ModelAttribute;
namespace GZFrameworkDemo.Models
{
    ///<summary>
    /// ORM模型, 数据表:sys_GridViewLayout
    /// 由GZFramework框架代码生成器自动生成
    /// </summary>
    [ModelStruct(sys_GridViewLayout._TableName)]
    public sealed class sys_GridViewLayout
    {
        public const string _TableName = "sys_GridViewLayout";

	
		/// <summary>
        /// 布局ID
        /// </summary>	
		[ModelPrimaryKey]
		public const string LayoutID = "LayoutID";
	
		/// <summary>
        /// 视图编号
        /// </summary>	
		[ModelEditField]
		public const string ViewCode = "ViewCode";
	
		/// <summary>
        /// 布局名称
        /// </summary>	
		[ModelEditField]
		public const string LayoutName = "LayoutName";
	
		/// <summary>
        /// 默认布局
        /// </summary>	
		[ModelEditField]
		public const string IsDefault = "IsDefault";
	
		/// <summary>
        /// 交替行颜色
        /// </summary>	
		[ModelEditField]
		public const string IntervalColor = "IntervalColor";
	
		/// <summary>
        /// 表头高度
        /// </summary>	
		[ModelEditField]
		public const string HeadHeight = "HeadHeight";
	
		/// <summary>
        /// 行高度
        /// </summary>	
		[ModelEditField]
		public const string RowHeight = "RowHeight";
	
		/// <summary>
        /// 水平线
        /// </summary>	
		[ModelEditField]
		public const string HorzLine = "HorzLine";
	
		/// <summary>
        /// 水平线颜色
        /// </summary>	
		[ModelEditField]
		public const string HorzLineColor = "HorzLineColor";
	
		/// <summary>
        /// 垂直线
        /// </summary>	
		[ModelEditField]
		public const string VertLine = "VertLine";
	
		/// <summary>
        /// 垂直线颜色
        /// </summary>	
		[ModelEditField]
		public const string VertLineColor = "VertLineColor";

        /// <summary>
        /// 垂直线颜色
        /// </summary>	
        [ModelEditField]
        public const string LayoutUser = "LayoutUser";

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



