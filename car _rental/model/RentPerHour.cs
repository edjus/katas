using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerHour : Rent
    {
        private int hours;
        private string cuit;
        private const int PRICE_PER_HOUR = 100;
        private const string START_CUIT_COMPANY = "26";
        private double factor_discount;
        private const double DISCOUNT = 0.95;
        private const double NORMAL = 1;


        public RentPerHour(string cuit, int hours)
        {
            this.hours = hours;
            this.cuit = cuit;
        }

        public double Amount()
        {
            factor_discount = cuit.StartsWith(START_CUIT_COMPANY) ? DISCOUNT : NORMAL;

            return PRICE_PER_HOUR * hours * factor_discount;
        }
    }
}