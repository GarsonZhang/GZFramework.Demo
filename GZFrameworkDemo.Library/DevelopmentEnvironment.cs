using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Library
{
    public class DevelopmentEnvironment
    {
        public static List<string> lstDLL = new List<string>();

        public const string SystemModel = "GZFrameworkDemo.SystemManagement";
        static DevelopmentEnvironment()
        {
            lstDLL.AddRange(new string[]{
            "GZFrameworkDemo.Dictionary",
            "GZFrameworkDemo.SystemManagement",
            "GZFrameworkDemo.HR",
            "GZFrameworkDemo.PSIModule",
            "DyeingFactory.Work"
            });
        }
    }
}
