using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionsList
    {
        public List<Promotion> getPromotions()
        {
            //List of Available Promotions

            Dictionary<String, int> d1 = new Dictionary<String, int>();
            d1.Add("A", 3);

            Dictionary<String, int> d2 = new Dictionary<String, int>();
            d2.Add("B", 2);

            Dictionary<String, int> d3 = new Dictionary<String, int>();
            d3.Add("C", 1);
            d3.Add("D", 1);

            List<Promotion> promotions = new List<Promotion>()
    {
        new Promotion(1, d1, 130),
        new Promotion(2, d2, 45),
        new Promotion(3, d3, 30)
    };

            return (promotions);
        }
    }
}
