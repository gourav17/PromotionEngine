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

            Product product1 = new Product();
            Order order1 = new Order(1,product1);
          


            Assert.AreEqual(0, PromotionChecker.GetTotalPrice(string.Empty));

        }
    }
}
