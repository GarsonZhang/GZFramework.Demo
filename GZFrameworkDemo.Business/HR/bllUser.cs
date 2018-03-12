using GZFrameworkDemo.Business.Base;
using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business.HR
{
    public class bllUser : bllBase
    {
        public bllUser()
            : base(typeof(dt_MyUser))
        {
            DBCode = Loginer.CurrentLoginer.SystemDBCode;
        }
    }
}
