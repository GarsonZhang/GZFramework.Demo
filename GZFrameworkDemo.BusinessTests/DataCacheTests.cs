using Microsoft.VisualStudio.TestTools.UnitTesting;
using GZFrameworkDemo.BusinessSQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.BusinessSQLite.Tests
{
    [TestClass()]
    public class DataCacheTests
    {
        [TestMethod()]
        public void testTest()
        {
            DataCache.Cache.LoadCatch();
            Assert.Fail();
        }
    }
}