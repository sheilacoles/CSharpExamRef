using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _2._56_LINQ_Components
{
    class Program
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



        static void Main(string[] args)
        {
            Assembly thisAssembly = Assembly.GetExecutingAssembly();

            var AccountTypes = from type in thisAssembly.GetTypes()
                where typeof(IAccount).IsAssignableFrom(type) && !type.IsInterface
                select type;

            //Assembly bankTypes = Assembly.Load("BankTypes.dll");

            foreach (Type t in AccountTypes)
                Console.WriteLine(t.ToString());

            Console.ReadKey();

        }
    }
}
