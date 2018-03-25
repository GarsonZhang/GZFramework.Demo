using GZFrameworkDemo.Models.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Models.DocSN.Business
{
    public class SNProduct : ModelDocNo
    {
        public SNProduct()
        {
            this.DocCode = "Product";
            this.DocName = "产品编号";
            this.DocHeader = "P";
            this.Length = 4;
            this.DocType = GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Up;
        }

    }

    //public class SN_PO : ModelDocNo
    //{
    //    public SN_PO()
    //    {
    //        this.DocCode = "PO";
    //        this.DocName = "入库单号";
    //        this.DocHeader = "C";
    //        this.Length = 4;
    //        this.DocType = GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Year_Month;
    //    }
    //}
}
