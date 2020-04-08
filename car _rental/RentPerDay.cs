using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerDay
    {
        private int days;
        private const int PRICE_PER_DAY = 2000;
        public RentPerDay(int days)
        {
            this.days = days;
        }

        public int Amount()
        {
            return PRICE_PER_DAY * days;
        }
    }
}