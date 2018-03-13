using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business.Dictionary
{
    public class bllUser : Base.bllBase
    {
        public bllUser()
            : base(typeof(Models.dt_MyUser))//设置主表ORM模型
        {
            //设置模型所在数据库
            DBCode = Models.Loginer.CurrentLoginer.SystemDBCode;
        }
    }
}
