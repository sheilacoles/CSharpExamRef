using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3_Protected_Access
{
    class BankAccount
    {
        protected decimal _accountBalance = 0;

        public void PayInFunds(decimal amountToPayIn)
        {
            _accountBalance = _accountBalance + amountToPayIn;
        }
        public virtual bool WithdrawFunds(decimal amountToWithdraw)
        {
            if (amountToWithdraw > _accountBalance)
                return false;

            _accountBalance = _accountBalance - amountToWithdraw;
            return true;
        }
        public decimal GetBalance()
        {
            return _accountBalance;
        }
    }

    class OverdraftAccount : BankAccount
    {
        decimal overdraftLimit = 100;
        public override bool WithdrawFunds(decimal amountToWithdraw)
        {
            if (amountToWithdraw > _accountBalance + overdraftLimit)
                return false;
            _accountBalance = _accountBalance - amountToWithdraw;
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
