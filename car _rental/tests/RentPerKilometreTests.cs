using Xunit;

namespace katas.car_rental
{
    public class RentPerKmTests
    {
        private const string CUIT = "20112223336";
        private const string CUIT_COMPANY = "26112223336";

        [Fact]
        public void AmountPerZeroKmIsOneHundred()
        {
            var rent = new RentPerKilometre(CUIT, 0);

            Assert.Equal(100, rent.Amount());
        }

        [Fact]
        public void AmountPerFourKmIsOneHundredFourty()
        {
            var rent = new RentPerKilometre(CUIT, 4);

            Assert.Equal(140, rent.Amount());
        }

        [Fact]
        public void AmountPerKmWithoutKmIsNinetyFiveIfIsCompany()
        {
            var rent = new RentPerKilometre(CUIT_COMPANY, 0);

            Assert.Equal(95, rent.Amount());
        }
    }
}