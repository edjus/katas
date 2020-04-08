using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class CarRental
    {
        public int CalculateAmount(RentDataContract rentDC)
        {
            int amount = 0;

            if (rentDC.Type == "h")
                amount = (new RentPerHour(rentDC.Duration)).Amount();
            if (rentDC.Type == "d")
                amount = (new RentPerDay(rentDC.Duration)).Amount();
            if (rentDC.Type == "k")
                amount = (new RentPerKilometre(rentDC.Duration)).Amount();

            return amount;
        }
    }
}