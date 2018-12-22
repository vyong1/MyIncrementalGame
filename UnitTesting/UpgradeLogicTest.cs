﻿using System;
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
            Assert.AreEqual(UpgradeLogic.ToString(), "Gain x10 to Corn growth");
        }

        [TestMethod]
        public void TestValueAdd()
        {
            UpgradeLogic = new ValueAddUpgradeLogic(Corn, 10);
            UpgradeLogic.ApplyLogic();
            Assert.AreEqual(Corn.Value, 110);
            Assert.AreEqual(UpgradeLogic.ToString(), "Gain 10 Corn");
        }

        [TestMethod]
        public void TestValueSub()
        {
            UpgradeLogic = new ValueSubUpgradeLogic(Corn, 10);
            UpgradeLogic.ApplyLogic();
            Assert.AreEqual(Corn.Value, 90);
            Assert.AreEqual(UpgradeLogic.ToString(), "Lose 10 Corn");
        }

    }
}
