using GZFrameworkDemo.Models.Sys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models.DocSN
{
    public class SN_PO : ModelDocNo
    {
        public SN_PO()
        {
            this.DocCode = "PO";
            this.DocName = "Èë¿âµ¥ºÅ";
            this.DocHeader = "C";
            this.Length = 4;
            this.DocType = GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Year_Month;
        }
    }

}
