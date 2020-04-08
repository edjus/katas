namespace katas.car_rental
{
    public class App
    {
        public string ProcessRent(string type, int duration)
        {
            var car_rental = new CarRental();

            return $"Amount: {car_rental.CalculateAmount(type, duration)}";
        }
    }
}