using Xunit;

namespace katas.car_rental
{
    public class RentFactoryTests
    {
        [Fact]
        public void RentFactoryReturnsRentPerHourWhenTypeIsH()
        {
            var rentDC = new RentDataContract() { Type = "h" };

            var rent = RentFactory.CreateRent(rentDC);
            Assert.IsType<RentPerHour>(rent);
        }

        [Fact]
        public void RentFactoryReturnsRentPerDayWhenTypeIsD()
        {
            var rentDC = new RentDataContract() { Type = "d" };

            var rent = RentFactory.CreateRent(rentDC);
            Assert.IsType<RentPerDay>(rent);
        }

        [Fact]
        public void RentFactoryReturnsRentPerKilometreWhenTypeIsk()
        {
            var rentDC = new RentDataContract() { Type = "k" };

            var rent = RentFactory.CreateRent(rentDC);
            Assert.IsType<RentPerKilometre>(rent);
        }
    }
}