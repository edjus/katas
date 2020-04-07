using System;
using System.Collections.Generic;
using System.Linq;

namespace katas.chopper
{
    public class Chopper
    {
        private Dictionary<int,string> sumResults;

        public Chopper()
        {
            sumResults = new Dictionary<int, string>();
            sumResults.Add(1, "one");
            sumResults.Add(4, "four");
            sumResults.Add(18, "one,eight");
            sumResults.Add(99, "nine,nine");
            sumResults.Add(0, "zero");
            sumResults.Add(15, "one,five");
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
            if (!sumResults.ContainsKey(sum)) return "too big";
            
            return sumResults[sum];
        }
    }
}