using System;
using System.Collections.Generic;

namespace katas.prime_factors
{
    public class PrimeFactors
    {

        public List<int> primeFactorsOf(int number)
        {
            var primeFactors = new List<int>();
            if (number == 2)
                primeFactors.Add(2);
            if (number == 3)
                primeFactors.Add(3);
            return primeFactors;
        }
    }
}