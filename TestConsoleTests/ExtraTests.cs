using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Tests
{
    [TestClass()]
    public class ExtraTests
    {
        [TestMethod()]
        public void HelloTest()
        {
            Assert.IsTrue(true); //HACK
        }
    }
}