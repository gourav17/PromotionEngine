using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace TestPromotionEngine
{
    [TestClass]
    public class TestPromotions
    {
        [TestMethod]
        public void TestPromotionChecker()
        {


            Assert.AreEqual(0, PromotionChecker.GetTotalPrice(string.Empty));

        }
    }
}
