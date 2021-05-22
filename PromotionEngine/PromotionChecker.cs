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

              

            

            //get count of promoted products from promotion
            int ppc = prom.ProductInfo.Sum(cp => cp.Value);

         



            while (copp >= ppc)
            {
            

                finalPrice += prom.PromotionPrice;
                

                copp -= ppc;
            }
            
            return  finalPrice;
        }

     
    }
}
