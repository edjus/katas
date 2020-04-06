using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace katas.prime_factors.steps
{
    public class PrimeFactorsTests
    {
        private readonly PrimeFactors primeFactors;

        public PrimeFactorsTests()
        {
            this.primeFactors = new PrimeFactors();
        }

        [Fact]
        public void PrimeFactorsOfOneIsEmpty()
        {
            Assert.False(primeFactors.primeFactorsOf(1).Any());
        }

        [Fact]
        public void PrimeFactorsOfTwoIsTwo()
        {
            Assert.Equal(new List<int>() { 2 }, primeFactors.primeFactorsOf(2));
        }
    }
}