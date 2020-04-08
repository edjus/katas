using System;
using System.Collections.Generic;

namespace katas.Carrental
{
    public class CarRental
    {
        private const int PRICE_PER_HOUR = 100;
        public string CalculateAmount(string type, int duration)
        {
            if (type == "h")
                return $"Amount: {PRICE_PER_HOUR * duration}";
            
            return "Amount: 2000";
        }
    }
}