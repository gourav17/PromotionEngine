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
            //Creating Products
            Product product1 = new Product("A");
            Product product2 = new Product("A");
            Product product3 = new Product("A");

            
            //Product product2 = new Product("C");
            //Product product3 = new Product("D");

            //Adding products to List
            List<Product> listOfProducts = new List<Product>();
            listOfProducts.Add(product1);
            listOfProducts.Add(product2);
            listOfProducts.Add(product3);

            //Creating Order
            Order order1 = new Order(1, listOfProducts);


            //Fetching available Promotions.
            PromotionsList promotionsList = new PromotionsList();
            List<Promotion> promotions = new List<Promotion>();
            promotions = promotionsList.getPromotions();

            
            //Checking if Products in Order is eligible for Promoional Price.
            decimal finalPrice = 0M;
            foreach (Promotion prom in promotions)
            {
                finalPrice+= PromotionChecker.GetTotalPrice(order1, prom);
            }

//Final Test Results Compare
            Assert.AreEqual(130, finalPrice);




        }
    }
}
