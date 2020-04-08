namespace katas.car_rental
{
    public class App
    {
        public string ProcessRent(RentDataContract rentDC)
        {
            var car_rental = new CarRental();

            return $"Amount: {car_rental.CalculateAmount(rentDC)}";
        }
    }
}