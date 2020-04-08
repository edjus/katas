using System;
using System.Collections.Generic;

namespace katas.Carrental
{
    public class CarRental
    {
        public string GetImport(string type, int duration)
        {
            if (duration == 1) return "Importe: 100";

            return "Importe: 0";
        }
    }
}