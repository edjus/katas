using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerDay : Rent
    {
        private int days;
        private const int PRICE_PER_DAY = 2000;
        private const string START_CUIT_COMPANY = "26";
        private const double DISCOUNT = 0.95;
        private const double NORMAL = 1;

        public RentPerDay(string cuit, int days)
        {
            this.days = days;
            this.cuit = cuit;
        }

        public override double Amount()
        {
            factorDiscount = cuit.StartsWith(START_CUIT_COMPANY) ? DISCOUNT : NORMAL;
            
            return PRICE_PER_DAY * days * factorDiscount;
        }
    }
}