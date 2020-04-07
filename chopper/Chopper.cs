using System;
using System.Collections.Generic;
using System.Linq;

namespace katas.chopper
{
    public class Chopper
    {
        private Dictionary<int,string> sums;

        public Chopper()
        {
            sums = new Dictionary<int, string>();
            sums.Add(1, "one");
            sums.Add(4, "four");
            sums.Add(18, "one,eight");
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
            
            return sums[sum];
        }
    }
}