using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19zadatak
{
    public abstract class Senzor
    {
        public string Identifier { get; set; }
        public string Unit { get; set; }

        public Senzor(string ident, string unit)
        {
            Identifier = ident;
            Unit = unit;
        }

        public abstract double GetCurrentValue();
    }
}
