using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerHour : Rent
    {
        private int hours;
        private const int PRICE_PER_HOUR = 100;

        public RentPerHour(string cuit, int hours)
        {
            this.hours = hours;
            this.cuit = cuit;
        }

        public override double getAmount() => PRICE_PER_HOUR * hours * factorDiscount;
    }
}