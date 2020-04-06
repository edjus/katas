using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace katas.prime_factors.steps
{
    public class PrimeFactorsTests
    {
        private static IList<int> List(params int[] ints) => ints.Select(i => (int)i).ToList();


        [Fact]
        public void PrimeFactorsOfOneIsEmpty()
        {
            Assert.Equal(List(), PrimeFactors.ValueOf(1));
        }

        [Fact]
        public void PrimeFactorsOfTwoIsTwo()
        {
            Assert.Equal(List(2), PrimeFactors.ValueOf(2));
        }

        [Fact]
        public void PrimeFactorsOfThreeIsThree()
        {
            Assert.Equal(List(3), PrimeFactors.ValueOf(3));
        }

        [Fact]
        public void PrimeFactorsOfFour()
        {
            Assert.Equal(List(2, 2), PrimeFactors.ValueOf(4));
        }

        [Fact]
        public void PrimeFactorsOfSix()
        {
            Assert.Equal(List(2, 3), PrimeFactors.ValueOf(6));
        }

        [Fact]
        public void PrimeFactorsOfEight()
        {
            Assert.Equal(List(3, 3), PrimeFactors.ValueOf(9));
        }
    }
}