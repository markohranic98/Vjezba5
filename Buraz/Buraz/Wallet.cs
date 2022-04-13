using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buraz
{
    public abstract class Wallet
    {
        public double Amount { get; set; }
        public string Currency { get; set; }

        public Wallet(double amount,string currency)
        {

        }
        protected abstract double GetRateInHRK();

        public double CalculateValue()
        {
            return Amount * GetRateInHRK();
        }
    }
}
