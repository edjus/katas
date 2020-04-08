using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerHour
    {
        private int duration;
        private const int PRICE_PER_HOUR = 100;

        public RentPerHour(int duration)
        {
            this.duration = duration;
        }

        public int Amount()
        {
            return PRICE_PER_HOUR * duration;
        }
    }
}