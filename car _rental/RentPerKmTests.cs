using Xunit;

namespace katas.car_rental
{
    public class RentPerKmTests
    {
        [Fact]
        public void AmountPerZeroKmIsOneHundred()
        {
            var rent = new RentPerKilometre(0);

            Assert.Equal(100, rent.Amount());
        }

        [Fact]
        public void AmountPerFourKmIsOneHundredFourty()
        {
            var rent = new RentPerKilometre(4);

            Assert.Equal(140, rent.Amount());
        }
    }
}