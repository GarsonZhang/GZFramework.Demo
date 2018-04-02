/**************************************************************************
    ====================GZFramwork【Winfrom快速开发框架】====================
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
    -- 博客地址:http://www.cnblogs.com/GarsonZhang/
 
	-- CLR版本： 4.0.30319.42000
	-- 创建时间：2017-05-03 11:35:59
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
    /// ORM模型, 数据表:dt_Data_CompanyInfo
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2017-05-03 11:36
    /// </summary>
    [ModelStruct(dt_Data_CompanyInfo._TableName)]
    public sealed class dt_Data_CompanyInfo
    {
        public const string _TableName = "dt_Data_CompanyInfo";

        /// <summary>
        /// 自增列
        /// </summary>
        [ModelPrimaryKey]
        public const string isid = "isid";

        /// <summary>
        /// 公司名称
        /// </summary>
        [ModelEditField]
        public const string CompanyName = "CompanyName";

        /// <summary>
        /// 地址
        /// </summary>
        [ModelEditField]
        public const string CompanyAddress = "CompanyAddress";

        /// <summary>
        /// 电话
        /// </summary>
        [ModelEditField]
        public const string Phone = "Phone";

        /// <summary>
        /// 手机
        /// </summary>
        [ModelEditField]
        public const string Mobile = "Mobile";

        /// <summary>
        /// 传真
        /// </summary>
        [ModelEditField]
        public const string Fax = "Fax";

        /// <summary>
        /// 对公账号
        /// </summary>
        [ModelEditField]
        public const string PublicAccount = "PublicAccount";

        /// <summary>
        /// 对公账号公司名称
        /// </summary>
        [ModelEditField]
        public const string PublicName = "PublicName";

        /// <summary>
        /// 对公账号开户行
        /// </summary>
        [ModelEditField]
        public const string PublicBackInfo = "PublicBackInfo";

        /// <summary>
        /// 私人账号
        /// </summary>
        [ModelEditField]
        public const string PrivateAccount = "PrivateAccount";

        /// <summary>
        /// 私人账号开户行
        /// </summary>
        [ModelEditField]
        public const string PrivateBankName = "PrivateBankName";

        /// <summary>
        /// 私人账号姓名
        /// </summary>
        [ModelEditField]
        public const string PrivateName = "PrivateName";

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
