using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._39_IComparable
{
    public interface IAccount
    {
        decimal GetBalance();
    } 
    public interface IComparable
    {
        int CompareTo(object obj);
    }
    public class BankAccount:IAccount, IComparable
    {
        protected decimal _balance = 0;

        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        decimal IAccount.GetBalance()
        {
            return _balance;
        }

        public int CompareTo(object obj)
        {
            //if we are being compared to a null object we are definitely after it
            if (obj == null) return 1;

            //convert the object reference into an account reference
            IAccount account = obj as IAccount;

            //as generates null if the conversion fails
            if (account == null)
                throw new ArgumentException("Object is not an account");

            //use the balance value as the basis of the comparison
            return this._balance.CompareTo(account.GetBalance());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create 20 accounts with random balances
            List<IAccount> accounts = new List<IAccount>();
            Random rand = new Random(1);
            for(int i=0;i<20; i++)
            {
                IAccount account = new BankAccount(rand.Next(0, 10000));
                accounts.Add(account);
            }
            //sort the accounts
            accounts.Sort();
            //display the sorted accounts
            foreach(IAccount account in accounts)
            {
                Console.WriteLine(account.GetBalance());
            }
            Console.ReadKey();
        }
    }
}
