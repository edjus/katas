namespace katas.car_rental
{
    public class RentFactory
    {
        public static Rent CreateRent(RentDataContract rentDC)
        {
            if (rentDC.Type == "h")
                return new RentPerHour(rentDC.Cuit, rentDC.Duration);

            if (rentDC.Type == "d")
                return new RentPerDay(rentDC.Cuit, rentDC.Duration);

            return new RentPerKilometre(rentDC.Cuit, rentDC.Duration); 
        }
    }
}