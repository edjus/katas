using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerHour : Rent
    {
        private int hours;
        private const int PRICE_PER_HOUR = 100;

        public RentPerHour(int hours)
        {
            this.hours = hours;
        }

        public int Amount()
        {
            return PRICE_PER_HOUR * hours;
        }
    }
}