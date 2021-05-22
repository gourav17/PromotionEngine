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

            
            //Product product4 = new Product("C");
            //Product product5 = new Product("D");

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

        [TestMethod]
        public void TestPromotionChecker2()
        {
            //Creating Products
          

            Product product1 = new Product("C");
            Product product2 = new Product("D");

            //Adding products to List
            List<Product> listOfProducts = new List<Product>();
            listOfProducts.Add(product1);
            listOfProducts.Add(product2);
            

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
                finalPrice += PromotionChecker.GetTotalPrice(order1, prom);
            }

            //Final Test Results Compare
            Assert.AreEqual(30, finalPrice);




        }


        [TestMethod]
        public void TestPromotionChecker3()
        {
            //Creating Products


            Product product1 = new Product("A");
            Product product2 = new Product("B");
            Product product3 = new Product("C");
            Product product4 = new Product("D");

            //Adding products to List Scenario A
            List<Product> listOfProductsA = new List<Product>();
            listOfProductsA.Add(product1); 
            listOfProductsA.Add(product2);
            listOfProductsA.Add(product3);


            //Creating Order
            Order ScenarioA = new Order(1, listOfProductsA);



            //Adding products to List Scenario B
            List<Product> listOfProductsB = new List<Product>();
            // 5 * A
            listOfProductsB.Add(product1);
            listOfProductsB.Add(product1);
            listOfProductsB.Add(product1);
            listOfProductsB.Add(product1);
            listOfProductsB.Add(product1);

            /// 5 * B
            listOfProductsB.Add(product2);
            listOfProductsB.Add(product2);
            listOfProductsB.Add(product2);
            listOfProductsB.Add(product2);
            listOfProductsB.Add(product2);

            //1 * C
            listOfProductsB.Add(product3);


            //Creating Order
            Order ScenarioB = new Order(2, listOfProductsB);


            //Fetching available Promotions.
            PromotionsList promotionsList = new PromotionsList();
            List<Promotion> promotions = new List<Promotion>();
            promotions = promotionsList.getPromotions();


            //Checking if Products in Order is eligible for Promoional Price.
            decimal finalPriceA = 0M;
            foreach (Promotion prom in promotions)
            {
                finalPriceA += PromotionChecker.GetTotalPrice(ScenarioA, prom);
            }

            decimal origpriceA = ScenarioA.Products.Sum(x => x.Price);

            //Final Test Results Compare Scenario A
            Assert.AreEqual(100, origpriceA-finalPriceA);


            decimal finalPriceB = 0M;
            foreach (Promotion prom in promotions)
            {
                finalPriceB += PromotionChecker.GetTotalPrice(ScenarioB, prom);
            }



            decimal origpriceB = ScenarioB.Products.Sum(x => x.Price);
           

            //Final Test Results Compare Scenario A
      //      Assert.AreEqual(370, origpriceB - finalPriceB);




        }

        [TestMethod]
        public void TestPromotionChecker4()
        {
            //Creating Products


            Product product1 = new Product("A");
            Product product2 = new Product("B");
            Product product3 = new Product("C");
            Product product4 = new Product("D");

            //Adding products to List Scenario C
            List<Product> listOfProductsB = new List<Product>();
            // 3 * A
            listOfProductsB.Add(product1);
            listOfProductsB.Add(product1);
            listOfProductsB.Add(product1);
            

            /// 5 * B
            listOfProductsB.Add(product2);
            listOfProductsB.Add(product2);
            listOfProductsB.Add(product2);
            listOfProductsB.Add(product2);
            listOfProductsB.Add(product2);

            //1 * C
            listOfProductsB.Add(product3);

            //1 * D
            listOfProductsB.Add(product4);

            //Creating Order
            Order ScenarioC = new Order(3, listOfProductsB);


            //Fetching available Promotions.
            PromotionsList promotionsList = new PromotionsList();
            List<Promotion> promotions = new List<Promotion>();
            promotions = promotionsList.getPromotions();


            //Checking if Products in Order is eligible for Promoional Price.
            decimal finalPriceA = 0M;
            foreach (Promotion prom in promotions)
            {
                finalPriceA += PromotionChecker.GetTotalPrice(ScenarioC, prom);
            }

            decimal origpriceA = ScenarioC.Products.Sum(x => x.Price);

            //Final Test Results Compare Scenario A
            Assert.AreEqual(280, origpriceA - finalPriceA);





        }
    }
}
