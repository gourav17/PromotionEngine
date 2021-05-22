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

            
            PromotionEngine.Order order1 = new PromotionEngine.Order();
            

            Assert.AreEqual(0, PromotionChecker.GetTotalPrice(string.Empty));

        }
    }
}
