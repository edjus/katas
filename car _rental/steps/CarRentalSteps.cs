using katas.car_rental;
using TechTalk.SpecFlow;
using Xunit;

namespace katas.Car_Rental.steps
{
    [Binding]
    public class CarRentalSteps
    {
        private string result;
        private RentDataContract rentDC = new RentDataContract();

        [Given(@"the rent date '(.*)'")]
        public void GivenTheRentDate(string rentDate)
        {
            rentDC.RentDate = rentDate;
        }
        
        [Given(@"the return date '(.*)'")]
        public void GivenTheReturnDate(string returnDate)
        {
            rentDC.ReturnDate = returnDate;
        }
        
        [Given(@"cuit number (.*)")]
        public void GivenCuitNumber(string cuit)
        {
            rentDC.Cuit = cuit;
        }
        
        [Given(@"the kind rent is '(.*)'")]
        public void GivenTheKindRentIs(string rent_type)
        {
            rentDC.Type = rent_type;
        }
        
        [Given(@"the duration rent is (.*)")]
        public void GivenTheDurationRentIs(int duration)
        {
            rentDC.Duration = duration;
        }
        
        [When(@"I pay for the rent")]
        public void WhenIPayForTheRent()
        {
            var app = new App();
            this.result = app.ProcessRent(rentDC);

        }
        
        [Then(@"the result is ""(.*)""")]
        public void ThenTheResultIs(string expectedResult)
        {
            Assert.Equal(expectedResult, this.result);
        }
    }
}