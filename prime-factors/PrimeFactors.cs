using System;
using System.Collections.Generic;

namespace katas.prime_factors
{
    public class PrimeFactors
    {

        public List<int> primeFactorsOf(int number)
        {
            if (number == 1)
                return new List<int>();
            return new List<int>(){2};
        }
    }
}