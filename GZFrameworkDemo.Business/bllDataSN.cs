using GZFrameworkDemo.Business.Base;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business
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
