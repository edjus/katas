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
        public void HourlyRent_AmountIs0whenDurationIs0()
        {
            Assert.Equal("Amount: 0", car_rental.CalculateAmount("h", 0));
        }

        [Fact]
        public void HourlyRent_AmountIs100whenDurationIs1()
        {
            Assert.Equal("Amount: 100", car_rental.CalculateAmount("h", 1));
        }

        [Fact]
        public void HourlyRent_AmountIs300whenDurationIs3()
        {
            Assert.Equal("Amount: 300", car_rental.CalculateAmount("h", 3));
        }

        [Fact]
        public void RentPerDay_AmountIs2000whenDurationIs1()
        {
            Assert.Equal("Amount: 2000", car_rental.CalculateAmount("d", 1));
        }

        [Fact]
        public void RentPerDay_AmountIs4000whenDurationIs2()
        {
            Assert.Equal("Amount: 4000", car_rental.CalculateAmount("d", 2));
        }
    }
}