using System;
using System.Collections.Generic;

namespace katas.Carrental
{
    public class CarRental
    {
        private const int PRICE_PER_HOUR = 100;
        private const int PRICE_PER_DAY = 2000;
        public string CalculateAmount(string type, int duration)
        {
            if (type == "k") return "Amount: 100";
            
            var base_price = (type == "h") ? PRICE_PER_HOUR : PRICE_PER_DAY; 

            return $"Amount: {base_price * duration}";
        }
    }
}