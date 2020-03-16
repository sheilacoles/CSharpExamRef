using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._36_Overridden_WithdrawFunds
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }
    public class BankAccount : IAccount
    {
        protected decimal _balance = 0;

        public virtual bool WithdrawFunds(decimal amount)
        {
            if (_balance < amount)
                return false;
            _balance = _balance - amount;
            return true;
        }
        void IAccount.PayInFunds(decimal amount)
        {
            _balance = _balance + amount;
        }
        decimal IAccount.GetBalance()
        {
            return _balance;
        }
    }
    public class BabyAccount : BankAccount, IAccount
    {
        public override bool WithdrawFunds(decimal amount)
        {
            if (amount > 10)
                return false;
            if (_balance < amount)
                return false;
            _balance = _balance - amount;
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
