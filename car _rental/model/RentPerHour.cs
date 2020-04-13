using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerHour : Rent
    {
        private int hours;
        private string cuit;
        private const int PRICE_PER_HOUR = 100;

        public RentPerHour(string cuit, int hours)
        {
            this.hours = hours;
            this.cuit = cuit;
        }

        public int Amount()
        {
            if (cuit.Substring(0, 2) == "26")
                return (int) (PRICE_PER_HOUR * hours * 0.95);
            return PRICE_PER_HOUR * hours;
        }
    }
}