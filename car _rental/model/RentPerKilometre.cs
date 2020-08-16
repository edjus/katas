using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class RentPerKilometre : Rent
    {
        private int kilometres;
        private const int BASE_PRICE_PER_KM = 100;
        private const int PRICE_PER_KM = 10;

        public RentPerKilometre(string cuit, int kilometres)
        {
            this.kilometres = kilometres;
            this.cuit = cuit;
        }

        public override double getAmount() => (BASE_PRICE_PER_KM + PRICE_PER_KM * kilometres) * factorDiscount;
    }
}