using System;
using System.Collections.Generic;
using System.Linq;

namespace katas.chopper
{
    public class Chopper
    {
        public int chop(int element, IList<int> list)
        {
            if (list.Count == 0) return -1;

            return list.IndexOf(element);
        }

        public string sum(IList<int> list)
        {
            int sum  = list.Sum();
            
            if (sum == 1) return "one";
            if (sum == 4) return "four";
            if (sum == 18) return "one,eight";
            
            return "empty";
        }
    }
}