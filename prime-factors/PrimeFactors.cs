using System;
using System.Collections.Generic;

namespace katas.prime_factors
{
    public class PrimeFactors
    {

        public List<int> primeFactorsOf(int number)
        {
            var primeFactors = new List<int>();

            for (int divisor = 2; number > 1; divisor++)
                while (number % divisor == 0)
                {
                    primeFactors.Add(divisor);
                    number /= divisor;
                }

            return primeFactors;
        }
    }
}