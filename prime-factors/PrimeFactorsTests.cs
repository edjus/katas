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

        [Fact]
        public void PrimeFactorsOfThreeIsThree()
        {
            Assert.Equal(new List<int>() { 3 }, primeFactors.primeFactorsOf(3));
        }

        [Fact]
        public void PrimeFactorsOfFour()
        {
            Assert.Equal(new List<int>() { 2, 2 }, primeFactors.primeFactorsOf(4));
        }

        [Fact]
        public void PrimeFactorsOfSix()
        {
            Assert.Equal(new List<int>() { 2, 3 }, primeFactors.primeFactorsOf(6));
        }

        [Fact]
        public void PrimeFactorsOfEight()
        {
            Assert.Equal(new List<int>() { 3, 3 }, primeFactors.primeFactorsOf(9));
        }
    }
}