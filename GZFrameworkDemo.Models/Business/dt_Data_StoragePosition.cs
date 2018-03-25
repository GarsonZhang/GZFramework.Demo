/**************************************************************************
    ====================GZFramwork【Winfrom快速开发框架】====================
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
    -- 博客地址:http://www.cnblogs.com/GarsonZhang/
 
	-- CLR版本： 4.0.30319.42000
	-- 创建时间：2018-03-25 18:13:18
	-- 创建年月：2015
**************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GZFramework.DB.ModelAttribute;

namespace GZFrameworkDemo.Models.Business
{
    /// <summary>
    /// ORM模型, 数据表:dt_Data_StoragePosition
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2018-03-25 18:13
    /// </summary>
    [ModelStruct(dt_Data_StoragePosition._TableName)]
    public sealed class dt_Data_StoragePosition
    {
        public const string _TableName = "dt_Data_StoragePosition";

        /// <summary>
        /// 自增列
        /// </summary>
        public const string isid = "isid";

        /// <summary>
        /// 资料编号
        /// </summary>
        [ModelPrimaryKey]
        public const string SPID = "SPID";

        /// <summary>
        /// 仓库标识
        /// </summary>
        [ModelEditField]
        public const string Storage = "Storage";

        /// <summary>
        /// 仓位标识
        /// </summary>
        [ModelEditField]
        public const string Position = "Position";

        /// <summary>
        /// 备注
        /// </summary>
        [ModelEditField]
        public const string Remark = "Remark";

        /// <summary>
        /// 创建人
        /// </summary>
        [ModelEditField]
        public const string CreateUser = "CreateUser";

        /// <summary>
        /// 创建时间
        /// </summary>
        [ModelEditField]
        public const string CreateDate = "CreateDate";

        /// <summary>
        /// 最后修改人
        /// </summary>
        [ModelEditField]
        public const string LastUpdateUser = "LastUpdateUser";

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [ModelEditField]
        public const string LastUpdateDate = "LastUpdateDate";

    }




}
