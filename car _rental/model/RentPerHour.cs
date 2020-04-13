using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerHour : Rent
    {
        private int hours;
        private string cuit;
        private double discount;
        private const int PRICE_PER_HOUR = 100;
        private const string START_CUIT_COMPANY = "26";
        private const double FACTOR_DISCOUNT = 0.95;  

        public RentPerHour(string cuit, int hours)
        {
            this.hours = hours;
            this.cuit = cuit;
            this.discount = 1;
        }

        public int Amount()
        {
            if (cuit.Substring(0, 2).Equals(START_CUIT_COMPANY))
                discount = FACTOR_DISCOUNT;

            return (int) (PRICE_PER_HOUR * hours * discount);
        }
    }
}