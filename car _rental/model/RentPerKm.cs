using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    internal class RentPerKilometre
    {
        private int kilometres;
        private const int BASE_PRICE_PER_KM = 100;
        private const int PRICE_PER_KM = 10;

        public RentPerKilometre(int kilometres)
        {
            this.kilometres = kilometres;
        }

        public int Amount()
        {
            return BASE_PRICE_PER_KM + PRICE_PER_KM * kilometres;
        }
    }
}