using System;
using System.Collections.Generic;
using System.Linq;

namespace GZFrameworkDemo.Models.DocSN
{
    public enum GenerateDocSNRule
    {
        //年 = 0,
        //年_月 = 1,
        //年_月_日 = 2,
        //直接递增 = 3,
        //自定义生成标记 = 4
        Year = 0,
        Year_Month = 1,
        Year_Month_Day = 2,
        Up = 3,
        Custom = 4
    }
}
