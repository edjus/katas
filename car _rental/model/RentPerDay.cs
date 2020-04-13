using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerDay : Rent
    {
        private int days;
        private string cuit;

        private double discount = 1;
        private const int PRICE_PER_DAY = 2000;
        private const string START_CUIT_COMPANY = "26";
        private const double FACTOR_DISCOUNT = 0.95;

        public RentPerDay(string cuit, int days)
        {
            this.days = days;
            this.cuit = cuit;
        }

        public int Amount()
        {
            if (cuit.Substring(0, 2).Equals(START_CUIT_COMPANY))
                discount = FACTOR_DISCOUNT;
                
            return (int)(PRICE_PER_DAY * days * discount);
        }
    }
}