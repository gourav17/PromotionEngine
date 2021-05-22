using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class PromotionChecker
    {
        //returns PromotionID and count of promotions
        public static decimal GetTotalPrice(Order ord, Promotion prom)
        {
            decimal finalPrice = 0M;
            //get count of promoted products in order
            var copp = ord.Products
                .GroupBy(x => x.Id)
                .Where(grp => prom.ProductInfo.Any(y => grp.Key == y.Key && grp.Count() >= y.Value))
                .Select(grp => grp.Count())
                .Sum();



            //  var actualPrice = copp * ord.Products

            //get count of promoted products from promotion
            int ppc = prom.ProductInfo.Sum(cp => cp.Value);

         

            decimal actualPrice =  GetActualPrice(ord.Products);


            while (copp >= ppc)
            {
            

                finalPrice += prom.PromotionPrice;
                

                copp -= ppc;
            }
            
            return actualPrice - finalPrice;
        }

        //Need to improve
        private static decimal GetActualPrice(List<Product> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
}
