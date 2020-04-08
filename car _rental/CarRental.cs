using System;
using System.Collections.Generic;

namespace katas.car_rental
{
    public class CarRental
    {
        public string CalculateAmount(string type, int duration)
        {
            int amount = 0;

            if (type == "h")
                amount = (new RentPerHour(duration)).Amount();
            if (type == "d")
                amount = (new RentPerDay(duration)).Amount();
            if (type == "k")
                amount = (new RentPerKilometre(duration)).Amount();

            return $"Amount: {amount}";
        }
    }
}