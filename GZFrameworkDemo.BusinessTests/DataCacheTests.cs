using Microsoft.VisualStudio.TestTools.UnitTesting;
using GZFrameworkDemo.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GZFrameworkDemo.Business.Tests
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