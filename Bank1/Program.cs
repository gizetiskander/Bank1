using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.id = "103";
            account.Ballance = 2000;
            Console.WriteLine(account.Ballance);
        }
    }
}
