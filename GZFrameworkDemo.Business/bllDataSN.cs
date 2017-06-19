using GZFrameworkDemo.BusinessSQLite.Base;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.BusinessSQLite
{
    public class bllDataSN : bllBase
    {
        public bllDataSN()
            : base(typeof(sys_DataSN))
        {
            DBCode = Loginer.CurrentLoginer.LoginDBCode;
        }



    }
}
