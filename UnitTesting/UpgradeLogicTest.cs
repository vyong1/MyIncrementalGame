using System;
using GameLib.IncrementingResources;
using GameLib.Upgrades;
using GameLib.Upgrades.UpgradeLogics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UpgradeLogicTest
    {
        private IncrementingResource Corn { get; set; }

        private BaseUpgradeLogic UpgradeLogic { get; set; }

        [TestInitialize]
        public void TestSetup()
        {
            Corn = new Corn();
            Corn.Value = 100;
            Corn.Delta = 20;
        }

        [TestMethod]
        public void TestDeltaMult()
        {
            UpgradeLogic = new DeltaMultUpgradeLogic(Corn, 10);
            UpgradeLogic.ApplyLogic();
            Assert.AreEqual(Corn.Delta, 20 * 10);
        }

        [TestMethod]
        public void TestValueAdd()
        {
            UpgradeLogic = new ValueAddUpgradeLogic(Corn, 10);
            UpgradeLogic.ApplyLogic();
            Assert.AreEqual(Corn.Value, 110);
        }

        [TestMethod]
        public void TestValueSub()
        {
            UpgradeLogic = new ValueSubUpgradeLogic(Corn, 10);
            UpgradeLogic.ApplyLogic();
            Assert.AreEqual(Corn.Value, 90);
        }

    }
}
