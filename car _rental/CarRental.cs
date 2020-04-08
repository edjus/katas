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
            if (type == "h")
                return $"Amount: {PRICE_PER_HOUR * duration}";
            
            return $"Amount: {PRICE_PER_DAY * duration}";
        }
    }
}