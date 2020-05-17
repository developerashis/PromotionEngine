using PromotionEngine.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine.Lib.Strategy
{
    public class CombineFixedPromotionStrategy : FixedPromotionStartegy
    {
        public CombineFixedPromotionStrategy(List<CartItem> carts, int noOfItemsCombineTo, decimal fixedPrice) : base(carts, noOfItemsCombineTo, fixedPrice)
        {
        }
        public override decimal Calculate()
        {
            decimal totalPrice = 0.0m;

            return totalPrice;
        }
    }
}
