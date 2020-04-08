using Xunit;

namespace katas.Carrental
{
    public class CarRentalTests
    {
        private CarRental car_rental;
        public CarRentalTests()
        {
            car_rental = new CarRental();
        }

        [Fact]
        public void HourlyRent_ImportIs0whenDurationIs0()
        {
            Assert.Equal("Importe: 0", car_rental.GetImport("h", 0));
        }
        
    }
}