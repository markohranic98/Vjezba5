using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurzaLib
{
    public abstract class Wallet
    {
        public  double Ammount { get; set; }
        public string Currency { get; set; }
        public Wallet(double ammount, string currency)
        {
            Ammount = ammount;
            Currency = currency;
        }
        protected abstract double GetRateInHRK();

        public double CalculateValue()
        {
            return Ammount * GetRateInHRK();
        }
    }
}
