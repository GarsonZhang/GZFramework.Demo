/**************************************************************************
    ====================GZFramwork【Winfrom快速开发框架】====================
	-- 作者：Garson_Zhang  QQ：382237285  QQ交流群：288706356
    -- 博客地址:http://www.cnblogs.com/GarsonZhang/
 
	-- CLR版本： 4.0.30319.42000
	-- 创建时间：2016/11/21 14:04:10
	-- 创建年月：2015
**************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GZFramework.DB.ModelAttribute;

namespace GZPSI.Models
{
    /// <summary>
    /// ORM模型, 数据表:tb_SamplePO
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2016-11-21 14:04
    /// </summary>
    [ModelStruct(tb_SamplePO._TableName)]
    public sealed class tb_SamplePO
    {
        public const string _TableName = "tb_SamplePO";

        /// <summary>
        /// 自增列
        /// </summary>
        public const string isid = "isid";

        /// <summary>
        /// 采购单编号
        /// </summary>
        [ModelPrimaryKey]
        public const string PONO = "PONO";

        /// <summary>
        /// 单据日期
        /// </summary>
        [ModelEditField]
        public const string DocDate = "DocDate";

        /// <summary>
        /// 采购部门编号
        /// </summary>
        [ModelEditField]
        public const string DeptID = "DeptID";

        /// <summary>
        /// 采购部门名称
        /// </summary>
        [ModelEditField]
        public const string DeptName = "DeptName";

        /// <summary>
        /// 供应商单位
        /// </summary>
        [ModelEditField]
        public const string CompanyID = "CompanyID";

        /// <summary>
        /// 许可证有效期
        /// </summary>
        [ModelEditField]
        public const string ComopanyDate = "ComopanyDate";

        /// <summary>
        /// 供应商名称
        /// </summary>
        [ModelEditField]
        public const string CompanyName = "CompanyName";

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



    /// <summary>
    /// ORM模型, 数据表:tb_SamplePODetail
    /// GZFrameworkCodeGenerate代码生成器自动生成
    /// 时间：2016-11-21 14:04
    /// </summary>
    [ModelStruct(tb_SamplePODetail._TableName)]
    public sealed class tb_SamplePODetail
    {
        public const string _TableName = "tb_SamplePODetail";

        /// <summary>
        /// 自增列
        /// </summary>
        [ModelPrimaryKey]
        public const string isid = "isid";

        /// <summary>
        /// 单据编号
        /// </summary>
        [ModelForeignKey]
        public const string PONO = "PONO";

        /// <summary>
        /// 商品编号
        /// </summary>
        [ModelEditField]
        public const string ProductID = "ProductID";

        /// <summary>
        /// 商品名称
        /// </summary>
        [ModelEditField]
        public const string ProductName = "ProductName";

        /// <summary>
        /// 当前库存
        /// </summary>
        [ModelEditField]
        public const string PreQty = "PreQty";

        /// <summary>
        /// 采购数量
        /// </summary>
        [ModelEditField]
        public const string Qty = "Qty";

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
