namespace katas.car_rental
{
    public class RentFactory
    {
        public static RentPerHour CreateRent(RentDataContract rentDC)
        {
            return new RentPerHour(rentDC.Duration);
        }
    }
}