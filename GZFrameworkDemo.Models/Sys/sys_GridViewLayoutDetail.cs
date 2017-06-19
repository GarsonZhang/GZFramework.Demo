
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
    /// ORM模型, 数据表:sys_GridViewLayoutDetail
    /// 由GZFramework框架代码生成器自动生成
    /// </summary>
    [ModelStruct(sys_GridViewLayoutDetail._TableName)]
    public sealed class sys_GridViewLayoutDetail
    {
        public const string _TableName = "sys_GridViewLayoutDetail";

		/// <summary>
        /// 布局ID
        /// </summary>	
		[ModelForeignKey]
		public const string LayoutID = "LayoutID";
	
		/// <summary>
        /// 字段名
        /// </summary>	
		[ModelEditField]
		public const string FileName = "FileName";
	
		/// <summary>
        /// 列名
        /// </summary>	
		[ModelEditField]
		public const string FileCaptionBK = "FileCaptionBK";
	
		/// <summary>
        /// 标题
        /// </summary>	
		[ModelEditField]
		public const string FileCaption = "FileCaption";
	
		/// <summary>
        /// 是否显示
        /// </summary>	
		[ModelEditField]
		public const string IsShow = "IsShow";
	
		/// <summary>
        /// 宽度
        /// </summary>	
		[ModelEditField]
		public const string Width = "Width";
	
		/// <summary>
        /// 文字颜色
        /// </summary>	
		[ModelEditField]
		public const string FontColor = "FontColor";
	
		/// <summary>
        /// 背景颜色
        /// </summary>	
		[ModelEditField]
		public const string BackColor = "BackColor";
	
		/// <summary>
        /// 对其方式
        /// </summary>	
		[ModelEditField]
		public const string Alignment = "Alignment";
	
		/// <summary>
        /// 统计类型
        /// </summary>	
		[ModelEditField]
		public const string SummaryType = "SummaryType";
	
		/// <summary>
        /// 显示格式
        /// </summary>	
		[ModelEditField]
		public const string SummaryFormat = "SummaryFormat";
	
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



