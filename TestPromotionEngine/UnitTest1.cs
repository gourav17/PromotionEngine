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
            Product product2 = new Product("A");
            Product product3 = new Product("A");

            
            //Product product2 = new Product("C");
            //Product product3 = new Product("D");

            List<Product> listOfProducts = new List<Product>();
            listOfProducts.Add(product1);
            listOfProducts.Add(product2);
            listOfProducts.Add(product3);

            Order order1 = new Order(1, listOfProducts);

            PromotionsList promotionsList = new PromotionsList();

            List<Promotion> promotions = new List<Promotion>();
            promotions = promotionsList.getPromotions();

            
            decimal finalPrice = 0M;
            foreach (Promotion prom in promotions)
            {
                finalPrice+= PromotionChecker.GetTotalPrice(order1, prom);
            }

            Assert.AreEqual(130, finalPrice);




        }
    }
}
