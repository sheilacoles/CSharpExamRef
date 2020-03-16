using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._58_Dictionary
{
    class Program
    {
        public class BankAccount
        {
            public int AccountNo;
            public string Name;
        }
        static void Main(string[] args)
        {
            BankAccount a1 = new BankAccount { AccountNo = 1, Name = "Rob Miles" };
            BankAccount a2 = new BankAccount { AccountNo = 2, Name = "Immy Brown" };

            Dictionary<int, BankAccount> bank = new Dictionary<int, BankAccount>();

            bank.Add(a1.AccountNo, a1);
            bank.Add(a2.AccountNo, a2);

            Console.WriteLine(bank[1]);

            if (bank.ContainsKey(2))
                Console.WriteLine("Account Located");

            Console.ReadKey();
        }
    }
}
