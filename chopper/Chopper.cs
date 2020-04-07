using System;
using System.Collections.Generic;
using System.Linq;

namespace katas.chopper
{
    public class Chopper
    {
        private Dictionary<int,string> numbers;
        private const int MAX_VALUE = 99;
        private const int TOP_ONE_DIGIT = 10;
        public Chopper()
        {
            numbers = new Dictionary<int, string>();
            numbers.Add(1, "one");
            numbers.Add(4, "four");
            numbers.Add(8, "eight");
            numbers.Add(9, "nine");
            numbers.Add(0, "zero");
            numbers.Add(5, "five");
        }
        public int chop(int element, IList<int> list)
        {
            if (list.Count == 0) return -1;

            return list.IndexOf(element);
        }

        public string sum(IList<int> list)
        {
            if (list.Count == 0) return "empty";
            int sum  = list.Sum();
            if (sum > MAX_VALUE) return "too big";
            if (sum < TOP_ONE_DIGIT) return numbers[sum];
            
            
            return numbers[sum/10] + "," + numbers[sum%10];
        }
    }
}