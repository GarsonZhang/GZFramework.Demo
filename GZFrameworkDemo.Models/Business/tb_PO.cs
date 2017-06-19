/**************************************************************************
    ====================GZFramwork【Winfrom快速开发框架】====================
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
    -- 博客地址:http://www.cnblogs.com/GarsonZhang/
 
	-- CLR版本： 4.0.30319.42000
	-- 创建时间：2017/5/20 22:53:47
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
    /// ORM模型, 数据表:tb_PO
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2017-05-20 22:54
    /// </summary>
    [ModelStruct(tb_PO._TableName)]
    public sealed class tb_PO
    {
        public const string _TableName = "tb_PO";

        /// <summary>
        /// 自增列
        /// </summary>
        public const string isid = "isid";

        /// <summary>
        /// 单据号码
        /// </summary>
        [ModelPrimaryKey]
        public const string DocNo = "DocNo";

        /// <summary>
        /// 单据日期
        /// </summary>
        [ModelEditField]
        public const string DocDate = "DocDate";
        
        /// <summary>
        /// 客户
        /// </summary>
        [ModelEditField]
        public const string CustomerCode = "CustomerCode";

        /// <summary>
        /// 总重量
        /// </summary>
        [ModelEditField]
        public const string TotalWT = "TotalWT";

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
        /// 修改人
        /// </summary>
        [ModelEditField]
        public const string LastUpdateUser = "LastUpdateUser";

        /// <summary>
        /// 修改时间
        /// </summary>
        [ModelEditField]
        public const string LastUpdateDate = "LastUpdateDate";

    }



    /// <summary>
    /// ORM模型, 数据表:tb_PODetail
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2017-05-20 22:54
    /// </summary>
    [ModelStruct(tb_PODetail._TableName)]
    public sealed class tb_PODetail
    {
        public const string _TableName = "tb_PODetail";

        /// <summary>
        /// 自增列
        /// </summary>
        [ModelPrimaryKey]
        public const string isid = "isid";

        /// <summary>
        /// 单据号码
        /// </summary>
        [ModelForeignKey]
        public const string DocNo = "DocNo";

        /// <summary>
        /// 规格
        /// </summary>
        [ModelEditField]
        public const string WoolSpec = "WoolSpec";

        /// <summary>
        /// 重量
        /// </summary>
        [ModelEditField]
        public const string WT = "WT";

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
        /// 修改人
        /// </summary>
        [ModelEditField]
        public const string LastUpdateUser = "LastUpdateUser";

        /// <summary>
        /// 修改时间
        /// </summary>
        [ModelEditField]
        public const string LastUpdateDate = "LastUpdateDate";

    }




}
