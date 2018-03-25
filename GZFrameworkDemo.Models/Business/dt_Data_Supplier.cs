/**************************************************************************
    ====================GZFramwork【Winfrom快速开发框架】====================
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
    -- 博客地址:http://www.cnblogs.com/GarsonZhang/
 
	-- CLR版本： 4.0.30319.42000
	-- 创建时间：2018-03-25 23:01:30
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
    /// ORM模型, 数据表:dt_Data_Supplier
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2018-03-25 23:01
    /// </summary>
    [ModelStruct(dt_Data_Supplier._TableName)]
    public sealed class dt_Data_Supplier
    {
        public const string _TableName = "dt_Data_Supplier";

        /// <summary>
        /// 自增列
        /// </summary>
        public const string isid = "isid";

        /// <summary>
        /// 供应商
        /// </summary>
        [ModelPrimaryKey]
        public const string SupplierID = "SupplierID";

        /// <summary>
        /// 供应商名称
        /// </summary>
        [ModelEditField]
        public const string SupplierName = "SupplierName";

        /// <summary>
        /// 助记码
        /// </summary>
        [ModelEditField]
        public const string ZJM = "ZJM";

        /// <summary>
        /// 供应商地址
        /// </summary>
        [ModelEditField]
        public const string SupplierAddress = "SupplierAddress";

        /// <summary>
        /// 联系人
        /// </summary>
        [ModelEditField]
        public const string Contacts = "Contacts";

        /// <summary>
        /// 联系电话
        /// </summary>
        [ModelEditField]
        public const string Phone = "Phone";

        /// <summary>
        /// 备注
        /// </summary>
        [ModelEditField]
        public const string Remark = "Remark";

        /// <summary>
        /// 状态
        /// </summary>
        [ModelEditField]
        public const string Status = "Status";

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
