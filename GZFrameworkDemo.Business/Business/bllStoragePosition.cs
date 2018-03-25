using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business.Business
{
    public class bllStoragePosition : Base.bllBase
    {
        public bllStoragePosition() : base(typeof(Models.Business.dt_Data_StoragePosition))
        {
            DBCode = Models.Loginer.CurrentLoginer.LoginDBCode;
        }

        public override DataTable Search(Dictionary<string, object> parameters)
        {
            return base.Search(parameters);
        }
    }
}
