using System;
using System.Collections.Generic;

namespace katas.prime_factors
{
    public class PrimeFactors
    {
        private int number;
        private List<int> primeFactors;
        private int divisor;

        public PrimeFactors(int number)
        {
            this.number = number;
        }

        public static List<int> ValueOf(int number)
        {
            return (new PrimeFactors(number)).calculate();

        }

        private List<int> calculate()
        {
            InitializeValues();
            while (CanFactorizeByDivisor())
            {
                FactorizeByDivisor();
                CalculateNextDivisor();
            }

            return primeFactors;
        }

        private bool CanFactorizeByDivisor() => number > 1;

        private void CalculateNextDivisor() => divisor++;

        private void FactorizeByDivisor()
        {
            while (number % divisor == 0)
            {
                primeFactors.Add(divisor);
                number /= divisor;
            }
        }

        private void InitializeValues()
        {
            primeFactors = new List<int>();
            divisor = 2;
        }
    }
}