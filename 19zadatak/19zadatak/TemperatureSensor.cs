using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19zadatak
{
    internal class TemperatureSensor : Senzor
    {
        public TemperatureSensor(string ident, string unit) : base(ident, unit)
        {
            Identifier = ident;
            Unit = unit;
        }

        public override double GetCurrentValue()
        {
            Random random = new Random();
            return random.NextDouble() * 40 + 20; 
        }
    }
}
