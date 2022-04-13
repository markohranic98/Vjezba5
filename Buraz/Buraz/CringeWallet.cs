using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buraz
{
    internal class CringeWallet : Wallet
    {
        public CringeWallet(double amount, string currency) : base(amount, currency)
        {
        }

        protected override double GetRateInHRK()
        {
            return 0;
        }
    }
}
