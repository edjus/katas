using Xunit;

namespace katas.car_rental
{
    public class RentPerHourTest
    {
        private const string CUIT = "20112223336";
        private const string CUIT_COMPANY = "26112223336";
        [Fact]
        public void AmountPerZeroHoursIsZero()
        {
            var rent = new RentPerHour(CUIT, 0);
            Assert.Equal(0, rent.Amount());
        }

        [Fact]
        public void AmountPerOneHourIsOneHundred()
        {
            var rent = new RentPerHour(CUIT, 1);
            Assert.Equal(100, rent.Amount());
        }

        [Fact]
        public void AmountPerOneHourIsNinetyFiveIfIsCompany()
        {
            var rent = new RentPerHour(CUIT_COMPANY, 1);
            Assert.Equal(95, rent.Amount());
        }
    }
}