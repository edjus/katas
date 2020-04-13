using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerKilometre : Rent
    {
        private int kilometres;
        private string cuit;
        private double discount = 1;
        private const int BASE_PRICE_PER_KM = 100;
        private const int PRICE_PER_KM = 10;
        private const string START_CUIT_COMPANY = "26";
        private const double FACTOR_DISCOUNT = 0.95;  


        public RentPerKilometre(string cuit, int kilometres)
        {
            this.kilometres = kilometres;
            this.cuit = cuit;
        }

        public int Amount()
        {
            if (cuit.Substring(0, 2).Equals(START_CUIT_COMPANY))
                discount = FACTOR_DISCOUNT;

            return (int) ((BASE_PRICE_PER_KM + PRICE_PER_KM * kilometres) * discount);
        }
    }
}