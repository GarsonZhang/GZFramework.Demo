using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GZFrameworkDemo.Models.DocSN;
using GZFrameworkDemo.Models;

namespace GZFrameworkDemo.BusinessSQLite.Business
{
    public class bllCustomer : Base.bllBase<SN_Customer>
    {
        public bllCustomer()
            : base(typeof(Models.Business.tb_Customer))
        {
            DBCode = Loginer.CurrentLoginer.LoginDBCode;
        }
    }
}
