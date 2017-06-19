using ClothingPSISQLite.Library;
using ClothingPSISQLite.Library.ModuleProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingPSISQLite.Dictionary
{
    public class Management : ModuleBase
    {
        public Management()
        {
            //添加模块功能
            this.AddFunction(typeof(frmCommonDataDictNew), "公共字典");
            this.AddFunction(typeof(frmDocSNHeader), "单据自定义管理");
            this.AddFunction(typeof(frmProductCategory), "商品类别管理");
            this.AddFunction(typeof(frmSales), "销售员管理");
            this.AddFunction(typeof(frmSetting), "商品编码设置");
            this.AddFunction(typeof(frmMySupplier), "供应商管理");
        }
    }
}
