using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    class Wallet
    {
        private string ownerName;
        private int amountMoney;

        public void SetOwnerName (string name)
        {
            this.ownerName = name;
        }

        public String GetOwnerName()
        {
            return this.ownerName;
        }

        public void AddMoney(int amountMoneyToAdd)
        {
            this.amountMoney += amountMoneyToAdd;
        }

        public void WithdrawMoney(int amountMoneyToWithdraw)
        {
            this.amountMoney -= amountMoneyToWithdraw;
        }

        public int GetAmountMoney()
        {
            return this.amountMoney;
        }
    }
}
