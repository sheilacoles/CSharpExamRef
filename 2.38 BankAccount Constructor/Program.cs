using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._38_BankAccount_Constructor
{
    public interface IAccount
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }
    public class BankAccount: IAccount
    {
        private decimal _balance;
        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }
    }
    public class BabyAccount : BankAccount, IAccount
    {
        public BabyAccount(int initialBalance) : base(initialBalance)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAccount a = new BankAccount(100);
        }
    }
}
