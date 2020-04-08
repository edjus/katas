using katas.Carrental;
using TechTalk.SpecFlow;
using Xunit;

namespace katas.Car_Rental.steps
{
    [Binding]
    public class CarRentalSteps
    {
        private string rent_type;
        private int duration;
        private string result;

        [Given(@"the rent date '(.*)'")]
        public void GivenTheRentDate(string rentDate)
        {

        }
        
        [Given(@"the return date '(.*)'")]
        public void GivenTheReturnDate(string returnDate)
        {
        }
        
        [Given(@"cuit number (.*)")]
        public void GivenCuitNumber(string cuit)
        {
        }
        
        [Given(@"the kind rent is '(.*)'")]
        public void GivenTheKindRentIs(string rent_type)
        {
            this.rent_type = rent_type;
        }
        
        [Given(@"the duration rent is (.*)")]
        public void GivenTheDurationRentIs(int duration)
        {
            this.duration = duration;
        }
        
        [When(@"I pay for the rent")]
        public void WhenIPayForTheRent()
        {
            var car_rental = new CarRental();
            this.result = car_rental.CalculateAmount(this.rent_type, this.duration);

        }
        
        [Then(@"the result is ""(.*)""")]
        public void ThenTheResultIs(string expectedResult)
        {
            Assert.Equal(expectedResult, this.result);
        }
    }
}