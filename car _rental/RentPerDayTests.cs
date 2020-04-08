using Xunit;

namespace katas.car_rental
{
    public class RentPerDayTests
    {
        [Fact]
        public void AmountPerZeroDaysIsZero()
        {
            var rent = new RentPerDay(0);

            Assert.Equal(0, rent.Amount());
        }

        [Fact]
        public void AmountPerTwoDaysIsFourThousand()
        {
            var rent = new RentPerDay(2);

            Assert.Equal(4000, rent.Amount());
        }
    }
}