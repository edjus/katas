using System;
using System.Collections.Generic;
using System.Linq;

namespace katas.chopper
{
    public class Chopper
    {
        private NumberParser numberParser;
        private const int MAX_VALUE = 99;
        private const int TOP_ONE_DIGIT = 10;
        public Chopper()
        {
            numberParser = new NumberParser();
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
            if (sum < TOP_ONE_DIGIT) return numberParser.ToString(sum);
            
            return $"{numberParser.ToString(sum/10)},{numberParser.ToString(sum%10)}";
        }
    }
}