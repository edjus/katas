using System;
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

        [Given(@"the number (.*)")]
        public void GivenTheNumber(int aNumber)
        {
            this.number = aNumber;
        }

        [When(@"I generete the prime factors")]
        public void WhenIGenereteThePrimeFactors()
        {
            this.result = PrimeFactors.ValueOf(this.number);
        }

        [Then(@"there is not prime factors")]
        public void ThenThereIsNoPrimeFactors()
        {
            Assert.False(result.Any());
        }

        [Then(@"the prime factor is (.*)")]
        public void ThenThePrimeFactorIs(int primeResult)
        {
            Assert.Equal(new List<int>() { primeResult }, this.result);
        }

        [Then(@"the prime factors are (.*)")]
        public void ThenThePrimeFactorsAre(string strPrimeFactors)
        {
            Assert.Equal(StringToListInt(strPrimeFactors), this.result);
        }

        private List<int> StringToListInt(string strPrimeFactors) => strPrimeFactors.Split(',').Select(int.Parse).ToList();
    }
}