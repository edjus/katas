using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class CarRental
    {
        public double CalculateAmount(Rent aRent)
        {
            return aRent.Amount();
        }
    }
}