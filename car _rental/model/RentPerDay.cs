using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerDay : Rent
    {
        private int days;
        private const int PRICE_PER_DAY = 2000;

        public RentPerDay(string cuit, int days)
        {
            this.days = days;
            this.cuit = cuit;
        }

        public override double getAmount() => PRICE_PER_DAY * days * factorDiscount;

    }
}