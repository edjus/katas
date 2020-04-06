using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace katas.prime_factors.steps
{
    public class PrimeFactorsTests
    {
        private readonly PrimeFactors primeFactors;
        private static IList<int> List(params int[] ints) => ints.Select(i => (int)i).ToList();

        public PrimeFactorsTests()
        {
            this.primeFactors = new PrimeFactors();
        }

        [Fact]
        public void PrimeFactorsOfOneIsEmpty()
        {
            Assert.Equal(List(), primeFactors.primeFactorsOf(1));
        }

        [Fact]
        public void PrimeFactorsOfTwoIsTwo()
        {
            Assert.Equal(List(2), primeFactors.primeFactorsOf(2));
        }

        [Fact]
        public void PrimeFactorsOfThreeIsThree()
        {
            Assert.Equal(List(3), primeFactors.primeFactorsOf(3));
        }

        [Fact]
        public void PrimeFactorsOfFour()
        {
            Assert.Equal(List(2, 2), primeFactors.primeFactorsOf(4));
        }

        [Fact]
        public void PrimeFactorsOfSix()
        {
            Assert.Equal(List(2, 3), primeFactors.primeFactorsOf(6));
        }

        [Fact]
        public void PrimeFactorsOfEight()
        {
            Assert.Equal(List(3, 3), primeFactors.primeFactorsOf(9));
        }
    }
}