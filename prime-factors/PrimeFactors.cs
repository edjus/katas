using System;
using System.Collections.Generic;

namespace katas.prime_factors
{
    public class PrimeFactors
    {

        public List<int> primeFactorsOf(int number)
        {
            var primeFactors = new List<int>();

            while (number % 2 == 0)
            {
                primeFactors.Add(2);
                number /= 2;
            }

            while (number % 3 == 0)
            {
                primeFactors.Add(3);
                number /= 3;
            }
            
            if (number > 1)
                primeFactors.Add(number);

            return primeFactors;
        }
    }
}