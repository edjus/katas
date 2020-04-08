namespace katas.car_rental
{
    public class App
    {
        public string ProcessRent(RentDataContract rentDC)
        {
            var car_rental = new CarRental();
            var rent = RentFactory.CreateRent(rentDC);

            return $"Amount: {car_rental.CalculateAmount(rent)}";
        }
    }
}