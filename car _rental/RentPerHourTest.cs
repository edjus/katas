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
    }
}