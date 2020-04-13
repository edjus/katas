using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerDay : Rent
    {
        private int days;
        private string cuit;
        private const int PRICE_PER_DAY = 2000;
        private const string START_CUIT_COMPANY = "26";
        private double factor_discount;
        private const double DISCOUNT = 0.95;
        private const double NORMAL = 1;

        public RentPerDay(string cuit, int days)
        {
            this.days = days;
            this.cuit = cuit;
        }

        public double Amount()
        {
            factor_discount = cuit.StartsWith(START_CUIT_COMPANY) ? DISCOUNT : NORMAL;
            
            return PRICE_PER_DAY * days * factor_discount;
        }
    }
}