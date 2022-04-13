using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19zadatak
{
    internal class HumiditySensor : Senzor
    {
        public HumiditySensor(string ident, string unit) : base(ident, unit)
        {
            Identifier = ident;
            Unit = unit;
        }

        public override double GetCurrentValue()
        {
            Random random = new Random();
            return random.NextDouble()*10+10; // NextDouble uzima 0-1 0 * 10 + 10 = 10
        }
    }
}
