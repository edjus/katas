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
            Assert.Equal("Amount: 0", car_rental.CalculateAmount("h", 0));
        }

        [Fact]
        public void HourlyRent_ImportIs100whenDurationIs1()
        {
            Assert.Equal("Amount: 100", car_rental.CalculateAmount("h", 1));
        }

        [Fact]
        public void HourlyRent_ImportIs300whenDurationIs3()
        {
            Assert.Equal("Amount: 300", car_rental.CalculateAmount("h", 3));
        }
        
    }
}