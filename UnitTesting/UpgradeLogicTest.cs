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
        public void TestDeltaMultUpgradeLogic()
        {
            UpgradeLogic = new DeltaMultUpgradeLogic(Corn, 10);
            UpgradeLogic.ApplyLogic();
            Assert.AreEqual(Corn.Value, 100);
            Assert.AreEqual(Corn.Delta, 20 * 10);
            Assert.AreEqual(UpgradeLogic.ToString(), "Gain x10 to Corn growth");
        }

        [TestMethod]
        public void TestValueAddUpgradeLogic()
        {
            UpgradeLogic = new ValueAddUpgradeLogic(Corn, 10);
            UpgradeLogic.ApplyLogic();
            Assert.AreEqual(Corn.Value, 110);
            Assert.AreEqual(Corn.Delta, 20);
            Assert.AreEqual(UpgradeLogic.ToString(), "Gain 10 Corn");
        }

        [TestMethod]
        public void TestValueSubUpgradeLogic()
        {
            UpgradeLogic = new ValueSubUpgradeLogic(Corn, 10);
            UpgradeLogic.ApplyLogic();
            Assert.AreEqual(Corn.Value, 90);
            Assert.AreEqual(Corn.Delta, 20);
            Assert.AreEqual(UpgradeLogic.ToString(), "Lose 10 Corn");
        }

        [TestMethod]
        public void TestNullUpgradeLogic()
        {
            UpgradeLogic = new NullUpgradeLogic();
            UpgradeLogic.ApplyLogic();
            Assert.AreEqual(Corn.Value, 100);
            Assert.AreEqual(Corn.Delta, 20);
            Assert.AreEqual(UpgradeLogic.ToString(), "");
        }

    }
}
