using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurzaLib
{
    internal class TradingAccount
    {
        public string AccountNo { get; set; }
        public List<Wallet> WalletList = new List<Wallet>();

        public TradingAccount(string accountNo)
        {
            AccountNo = accountNo;
        }

        public double CalculateTotalValue()
        {
            double totalValue = 0;
            foreach (var item in WalletList)
            {
                totalValue += item.CalculateValue();
            }
            return totalValue;
        }
    }
}
