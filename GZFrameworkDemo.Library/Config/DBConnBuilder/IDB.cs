using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace GZFrameworkDemo.Library.Config.DBConnBuilder
{
    public interface IDB
    {
        string ProviderName { get; set; }
        string GetConnectionStr();

    }
}
