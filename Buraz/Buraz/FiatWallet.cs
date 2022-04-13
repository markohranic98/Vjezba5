using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buraz
{
    internal class FiatWallet : Wallet
    {
        public FiatWallet(double amount, string currency) : base(amount, currency)
        {
            Amount = amount;
            Currency = currency;
        }

        protected override double GetRateInHRK()
        {
            return ExchangeAPI.GetFiatRateInHRK();
        }
    }
}
