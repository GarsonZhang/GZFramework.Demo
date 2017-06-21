using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GZFrameworkDemo.Models.DocSN;
using GZFrameworkDemo.Models;

namespace GZFrameworkDemo.Business.Business
{
    public class bllPO : Base.bllBase<SN_PO>
    {
        public bllPO() : base(typeof(Models.Business.tb_PO), typeof(Models.Business.tb_PODetail))
        {
            DBCode = Loginer.CurrentLoginer.LoginDBCode;
        }
    }
}
