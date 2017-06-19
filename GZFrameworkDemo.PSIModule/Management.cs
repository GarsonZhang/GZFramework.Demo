using ClothingPSISQLite.Library;
using ClothingPSISQLite.Library.ModuleProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingPSISQLite.PSIModule
{
    public class Management : ModuleBase
    {

        public Management()
        {
            this.AddFunction(typeof(frmPO), "入库");
            this.AddFunction(typeof(frmProductInventory), "库存信息");
            this.AddFunction(typeof(frmSale), "销售");
            this.AddFunction(typeof(frmSaleReport), "销售统计");
        }
    }
}
