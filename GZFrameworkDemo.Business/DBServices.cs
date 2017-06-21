using GZFrameworkDemo.Models;
using GZDBHelper;
using GZFramework.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business
{
    public class DBServices
    {
        private static IDatabase _db;
        public static IDatabase DB
        {
            get
            {
                if (_db == null)
                    _db = DataBaseFactoryEx.CreateDataBase(Loginer.CurrentLoginer.SystemDBCode);
                return _db;
            }
        }
    }
}
