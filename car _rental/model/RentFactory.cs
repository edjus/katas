namespace katas.car_rental
{
    public class RentFactory
    {
        public static Rent CreateRent(RentDataContract rentDC)
        {
            if (rentDC.Type == "h")
                return new RentPerHour(rentDC.Duration);

            return new RentPerDay(rentDC.Duration);
        }
    }
}