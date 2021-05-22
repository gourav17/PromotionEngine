using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Total number of Products");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine().ToUpper();
                Product p = new Product(type);
                products.Add(p);
            }

            Order order1 = new Order(1, products);
            PromotionsList promotionsList = new PromotionsList();

            List<Promotion> promotions = new List<Promotion>();
            promotions = promotionsList.getPromotions();

            List<decimal> promoprices = promotions
           .Select(promo => PromotionChecker.GetTotalPrice(order1, promo))
           .ToList();

            decimal origprice = order1.Products.Sum(x => x.Price);
            decimal promoprice = promoprices.Sum();

            //Console.WriteLine($"OrderID: {ord.OrderID} => Original price: {origprice.ToString("0.00")} | Rebate: {promoprice.ToString("0.00")} | Final price: {(origprice - promoprice).ToString("0.00")}");

            Console.WriteLine("OrderID: " + order1.OrderID + "=> Original price: " + origprice.ToString("0.00") + " | Special Discount: " + promoprice.ToString("0.00") + " | Please Pay: " + (origprice - promoprice).ToString("0.00"));
        

    }
    }
}
