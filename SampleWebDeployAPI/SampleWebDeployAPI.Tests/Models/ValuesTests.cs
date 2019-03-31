using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleWebDeployAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWebDeployAPI.Models.Tests
{
    [TestClass()]
    public class ValuesTests
    {
        [TestMethod()]
        public void calculateValuesTest()
        {
            Assert.IsTrue(Values.calculateValues(4, 5) == 9);
        }

        [TestMethod()]
        public void calculateValuesTest1()
        {
            Assert.IsFalse(Values.calculateValues(9,0)==10);
        }
    }
}