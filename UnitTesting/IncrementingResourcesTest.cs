using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameLib.IncrementingResources;

namespace UnitTesting
{
    [TestClass]
    public class IncrementingResourcesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IncrementingResource corn = new Corn();
            corn.Value = 10;
            corn.Delta = 5;

            // Proc a tick
            corn.Tick();
            Assert.AreEqual(corn.Value, 15);
            Assert.AreEqual(corn.Delta, 5);
        }
    }
}
