using System;
using System.Collections.Generic;

namespace katas.chopper
{
    public class Chopper
    {
        public int chop(int v, IList<int> list)
        {
            if (list.Count > 0) return 0;
            
            return -1;
        }
    }
}