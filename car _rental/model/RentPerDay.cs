using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerDay : Rent
    {
        private int days;
        private string cuit;
        private const int PRICE_PER_DAY = 2000;
        public RentPerDay(string cuit, int days)
        {
            this.days = days;
            this.cuit = cuit;
        }

        public int Amount()
        {
            return PRICE_PER_DAY * days;
        }
    }
}