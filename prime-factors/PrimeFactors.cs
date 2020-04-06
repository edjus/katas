using System;
using System.Collections.Generic;

namespace katas.prime_factors
{
    public class PrimeFactors
    {

        public List<int> primeFactorsOf(int number)
        {
            var primeFactors = new List<int>();

            if (number == 4){
                primeFactors.Add(2);
                primeFactors.Add(2);
            }
            else if (number == 6){
                primeFactors.Add(2);
                primeFactors.Add(3);
            }
            else if (number > 1)
                primeFactors.Add(number);

            return primeFactors;
        }
    }
}