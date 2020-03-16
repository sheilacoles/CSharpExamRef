using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4_Typed_IComparable
{
    public interface IAccount : IComparable<IAccount>
    {
        void PayInFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }
    public class BankAccount:IAccount, IComparable<BankAccount>
    {
        private decimal balance;
        public int CompareTo(IAccount account)
        {
            //if we are being compared with a null object we are definitely after it
            if (account == null) return 1;
            //use the balance value as the basis of the comparison
            return this.balance.CompareTo(account.GetBalance());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
