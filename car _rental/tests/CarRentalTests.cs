using Xunit;

namespace katas.car_rental
{
    public class CarRentalTests
    {
        private CarRental carRental;
        private RentDataContract rentDC;
        public CarRentalTests()
        {
            carRental = new CarRental();
            rentDC = new RentDataContract();
        }

        [Fact]
        public void HourlyRent_AmountIs0whenDurationIs0()
        {
            rentDC.Type = "h";
            rentDC.Duration = 0;
            rentDC.Cuit = "20112223336";

            Assert.Equal(0, carRental.CalculateAmount(RentFactory.CreateRent(rentDC)));
        }

        [Fact]
        public void HourlyRent_AmountIs100whenDurationIs1()
        {
            rentDC.Type = "h";
            rentDC.Duration = 1;
            rentDC.Cuit = "20112223336";

            Assert.Equal(100, carRental.CalculateAmount(RentFactory.CreateRent(rentDC)));
        }

        [Fact]
        public void HourlyRent_AmountIs300whenDurationIs3()
        {
            rentDC.Type = "h";
            rentDC.Duration = 3;
            rentDC.Cuit = "20112223336";

            Assert.Equal(300, carRental.CalculateAmount(RentFactory.CreateRent(rentDC)));
        }

        [Fact]
        public void RentPerDay_AmountIs2000whenDurationIs1()
        {
            rentDC.Type = "d";
            rentDC.Duration = 1;
            rentDC.Cuit = "20112223336";

            Assert.Equal(2000, carRental.CalculateAmount(RentFactory.CreateRent(rentDC)));
        }

        [Fact]
        public void RentPerDay_AmountIs4000whenDurationIs2()
        {
            rentDC.Type = "d";
            rentDC.Duration = 2;
            rentDC.Cuit = "20112223336";

            Assert.Equal(4000, carRental.CalculateAmount(RentFactory.CreateRent(rentDC)));
        }

        [Fact]
        public void RentPerKm_AmountIs100whenDurationIs0()
        {
            rentDC.Type = "k";
            rentDC.Duration = 0;
            rentDC.Cuit = "20112223336";

            Assert.Equal(100, carRental.CalculateAmount(RentFactory.CreateRent(rentDC)));
        }

        [Fact]
        public void RentPerKm_AmountIs110whenDurationIs1()
        {
            rentDC.Type = "k";
            rentDC.Duration = 1;
            rentDC.Cuit = "20112223336";

            Assert.Equal(110, carRental.CalculateAmount(RentFactory.CreateRent(rentDC)));
        }
    }
}