using GZFrameworkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.BusinessSQLite
{
    public class bllData_CompanyInfo : Base.bllBase
    {
        public bllData_CompanyInfo() :
            base(typeof(Models.dt_Data_CompanyInfo))
        {
            DBCode = Loginer.CurrentLoginer.LoginDBCode;
        }

    }
}
