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
        private static IDatabase _logindb;
        public static IDatabase LoginDB
        {
            get
            {
                if (_logindb == null)
                    _logindb = DataBaseFactoryEx.CreateDataBase(Loginer.CurrentLoginer.LoginDBCode);
                return _logindb;
            }
        }
    }
}
