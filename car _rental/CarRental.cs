using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class CarRental
    {
        private const int PRICE_PER_HOUR = 100;
        private const int PRICE_PER_DAY = 2000;
        private const int BASE_PRICE_PER_KM = 100;
        private const int PRICE_PER_KM = 10;

        public string CalculateAmount(string type, int duration)
        {
            if (type == "k") return $"Amount: {BASE_PRICE_PER_KM + PRICE_PER_KM * duration}";

            var base_price = (type == "h") ? PRICE_PER_HOUR : PRICE_PER_DAY;

            return $"Amount: {base_price * duration}";
        }
    }
}