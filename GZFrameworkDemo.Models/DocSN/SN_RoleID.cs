using GZFrameworkDemo.Models.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Models.DocSN
{
    public class SN_RoleID : ModelDocNo
    {
        public SN_RoleID()
        {
            this.DocCode = "RoleID";
            this.DocName = "角色编号";
            this.DocHeader = "R";
            this.Separate = "-";
            this.Length = 3;
            this.DocType = GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Up;
        }
    }

    public class SN_RoleIDDB : ModelDocNo
    {
        public SN_RoleIDDB()
        {
            this.DocCode = "RoleIDDB";
            this.DocName = "角色编号";
            this.DocHeader = "";
            this.Separate = "-";
            this.Length = 3;
            this.DocType = GZFrameworkDemo.Models.DocSN.GenerateDocSNRule.Custom;
        }
    }
}
