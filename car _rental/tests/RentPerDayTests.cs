using Xunit;

namespace katas.car_rental
{
    public class RentPerDayTests
    {
        private const string CUIT = "20112223336";
        private const string CUIT_COMPANY = "26112223336";

        [Fact]
        public void AmountPerZeroDaysIsZero()
        {
            var rent = new RentPerDay(CUIT, 0);

            Assert.Equal(0, rent.Amount());
        }

        [Fact]
        public void AmountPerTwoDaysIsFourThousand()
        {
            var rent = new RentPerDay(CUIT, 2);

            Assert.Equal(4000, rent.Amount());
        }

        [Fact]
        public void AmountPerOneDayIsOneThousandNineHundredIfIsCuitCompany()
        {
            var rent = new RentPerDay(CUIT_COMPANY, 1);

            Assert.Equal(1900, rent.Amount());
        }
    }
}