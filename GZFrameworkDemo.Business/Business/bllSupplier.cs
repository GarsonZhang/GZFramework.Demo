using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business.Business
{
    public class bllSupplier : Base.bllBase<Models.DocSN.Business.SNSupplier>
    {
        public bllSupplier() : base(typeof(Models.Business.dt_Data_Supplier))
        {
            DBCode = Models.Loginer.CurrentLoginer.LoginDBCode;
        }
    }
}
