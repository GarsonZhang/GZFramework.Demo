using GZFrameworkDemo.Business.Base;
using GZFrameworkDemo.Models;
using GZFrameworkDemo.Models.DocSN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business
{
    public class bllRole : bllBase<SN_RoleID>
    {
        public bllRole()
            : base(typeof(dt_MyRole), typeof(dt_MyRoleAuthority))
        {
            DBCode = Loginer.CurrentLoginer.SystemDBCode;
        }

        public override bool Update(DataSet ds)
        {
            if (ds.Tables.Contains(dt_MyRole._TableName))
            {
                //string DBCode = ds.Tables[0].Rows[0][dt_MyRole.DBCode].ToString();

                (dal as dalCommon).DocSNProvider.CustomerSeed = "R";
                (dal as dalCommon).DocSNProvider.DocHeader = "R";
            }
            return base.Update(ds);
        }


    }


    public class bllRoleDB : bllBase<SN_RoleIDDB>
    {
        public bllRoleDB()
            : base(typeof(dt_MyRole), typeof(dt_MyRoleAuthority))
        {
            DBCode = Loginer.CurrentLoginer.SystemDBCode;
        }

        public override bool Update(DataSet ds)
        {
            if (ds.Tables.Contains(dt_MyRole._TableName))
            {
                (dal as dalCommon).DocSNProvider.CustomerSeed = "R";
                (dal as dalCommon).DocSNProvider.DocHeader = "R";
            }
            return base.Update(ds);
        }


    }
}
