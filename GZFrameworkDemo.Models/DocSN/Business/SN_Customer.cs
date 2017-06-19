using GZFrameworkDemo.Models.Sys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models.DocSN
{
    public class SN_Customer : ModelDocNo
    {
        public SN_Customer()
        {
            this.DocCode = "Customer";
            this.DocName = "¿Í»§±àºÅ";
            this.DocHeader = "C";
            this.Length = 4;
            this.DocType = GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Up;
        }
    }

}
