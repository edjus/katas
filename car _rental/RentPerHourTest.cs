using Xunit;

namespace katas.car_rental
{
    public class RentPerHourTest
    {
        [Fact]
        public void AmountPerZeroHoursIsZero()
        {
            var rent = new RentPerHour(0);
            Assert.Equal(0, rent.Amount());
        }

        [Fact]
        public void AmountPerOneHourIsOneHundred()
        {
            var rent = new RentPerHour(1);
            Assert.Equal(100, rent.Amount());
        }
    }
}