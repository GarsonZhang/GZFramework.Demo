/**************************************************************************
    ====================GZFramwork【Winfrom快速开发框架】====================
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
    -- 博客地址:http://www.cnblogs.com/GarsonZhang/
 
	-- CLR版本： 4.0.30319.42000
	-- 创建时间：2018-03-25 0:07:13
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
    /// ORM模型, 数据表:dt_CommonDicData
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2018-03-25 00:07
    /// </summary>
    [ModelStruct(dt_CommonDicData._TableName)]
    public sealed class dt_CommonDicData
    {
        public const string _TableName = "dt_CommonDicData";

        /// <summary>
        /// 自增字段
        /// </summary>
        [ModelPrimaryKey]
        public const string isid = "isid";

        /// <summary>
        /// rowversion
        /// </summary>
        [ModelRowversion]
        public const string rowversion = "rowversion";

        /// <summary>
        /// 字典类型
        /// </summary>
        [ModelEditField]
        public const string DataType = "DataType";

        /// <summary>
        /// 数据编码
        /// </summary>
        [ModelEditField]
        public const string DataCode = "DataCode";

        /// <summary>
        /// 数据名称
        /// </summary>
        [ModelEditField]
        public const string DataName = "DataName";

        /// <summary>
        /// 显示索引
        /// </summary>
        [ModelEditField]
        public const string SortIndex = "SortIndex";

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
