using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using Xunit;

namespace katas.prime_factors.steps
{
    [Binding]
    public class PrimeFactorSteps
    {
        private int number;
        private List<int> result;
        private PrimeFactors primeFactors;

        [Given(@"the number (.*)")]
        public void GivenTheNumber(int aNumber)
        {
            this.number = aNumber;
            primeFactors = new PrimeFactors();
        }
        
        [When(@"I generete the prime factors")]
        public void WhenIGenereteThePrimeFactors()
        {
            this.result = primeFactors.primeFactorsOf(this.number);
        }
        
        [Then(@"there is not prime factors")]
        public void ThenThereIsNoPrimeFactors()
        {
            Assert.False(result.Any());
        }

        [Then(@"the prime factor is (.*)")]
         public void ThenThePrimeFactorIs(int primeResult)
         {
             Assert.Equal(new List<int>(){primeResult}, primeFactors.primeFactorsOf(this.number));
         }
    }
}