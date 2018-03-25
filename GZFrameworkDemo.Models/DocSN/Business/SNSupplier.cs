using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Models.DocSN.Business
{
    public class SNSupplier : Sys.ModelDocNo
    {
        public SNSupplier()
        {
            this.DocCode = "Supplier";
            this.DocName = "供应商编号";
            this.DocHeader = "S";
            this.Length = 4;
            this.DocType = GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Year_Month;
        }
    }
}
