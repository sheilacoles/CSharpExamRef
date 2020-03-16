using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._37_Base_Method
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
    //stop overriding using sealed
    public sealed class BabyAccount : BankAccount, IAccount
    {
        public override bool WithdrawFunds(decimal amount)
        {
            if (amount > 10)
                return false;
            else
                return base.WithdrawFunds(amount);
        }
        //Replacing a method in a base class by creating a "new" method in the child class
        //public new bool WithdrawFunds(decimal amount)     
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
