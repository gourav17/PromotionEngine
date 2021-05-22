using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System.Collections.Generic;
using System.Linq;

namespace TestPromotionEngine
{
    [TestClass]
    public class TestPromotions
    {
        [TestMethod]
        public void TestPromotionChecker()
        {

            Product product1 = new Product("A");

            List<Product> listOfProducts = new List<Product>();
            listOfProducts.Add(product1);

            Order order1 = new Order(1, listOfProducts);
          


            Assert.AreEqual(0, PromotionChecker.GetTotalPrice(string.Empty));

        }
    }
}
