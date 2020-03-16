using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._35_BabyAccount
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }
    public class BankAccount : IAccount
    {
        private decimal _balance = 0;
        bool IAccount.WithdrawFunds(decimal amount)
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
        private decimal _balance = 0;

        bool IAccount.WithdrawFunds(decimal amount)
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
            IAccount account = new BankAccount();
            account.PayInFunds(50);
            Console.WriteLine("Balance: {0}", account.GetBalance());

            IAccount b = new BabyAccount();
            b.PayInFunds(20);
            Console.WriteLine("Balance: {0}", b.GetBalance());
            
            Console.ReadKey();
        }
    }
}
