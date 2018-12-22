using System;
using GameLib.IncrementingResources;
using GameLib.Upgrades;
using GameLib.Upgrades.UpgradeLogics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UpgradesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            IncrementingResource corn = new Corn();
            corn.Delta = 50;
            corn.Value = 100;
            Assert.AreEqual(corn.Value, 100);
            Assert.AreEqual(corn.Delta, 50);

            // Declare and apply upgrades
            BaseUpgradeLogic costLogic = new ValueAddUpgradeLogic(corn, -100);
            BaseUpgradeLogic benefitLogic = new DeltaMultUpgradeLogic(corn, 4);
            Upgrade u = new Upgrade(costLogic, benefitLogic);
            u.Apply();
            Assert.AreEqual(corn.Value, 0);
            Assert.AreEqual(corn.Delta, 200);

            corn.Tick();
            Assert.AreEqual(corn.Value, 200);
            Assert.AreEqual(corn.Delta, 200);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IncrementingResource corn = new Corn();
            corn.Delta = 50;
            corn.Value = 100;
            Assert.AreEqual(corn.Value, 100);
            Assert.AreEqual(corn.Delta, 50);

            // Declare and apply upgrades
            Upgrade u = new Upgrade(
                new ValueSubUpgradeLogic(corn, 100),
                new DeltaMultUpgradeLogic(corn, 4));
            u.Apply();
            Assert.AreEqual(corn.Value, 0);
            Assert.AreEqual(corn.Delta, 200);
        }
    }
}
