using System;
using System.Collections.Generic;

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
            if (list.Count > 0) return "one";
            return "empty";
        }
    }
}