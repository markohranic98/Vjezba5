using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurzaLib
{
    internal class CringeWallet : Wallet
    {
        public CringeWallet(double ammount, string currency) : base(ammount, currency)
        {
            Ammount = ammount;
            Currency = currency;
        }

        protected override double GetRateInHRK()
        {
            return ExchanceAPI.GetCringeRateInHRK(Currency);
        }
    }
}
