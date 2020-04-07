using System.Collections.Generic;

namespace katas.chopper
{
    public class NumberParser
    {
        private Dictionary<int,string> strNumber = new Dictionary<int, string>();

        public NumberParser()
        {
            strNumber.Add(1, "one");
            strNumber.Add(2, "two");
            strNumber.Add(3, "three");
            strNumber.Add(4, "four");
            strNumber.Add(5, "five");
            strNumber.Add(6, "six");
            strNumber.Add(7, "seven");
            strNumber.Add(8, "eight");
            strNumber.Add(9, "nine");
            strNumber.Add(0, "zero");
        }

        public string ToString(int number) => strNumber[number];
    }
}