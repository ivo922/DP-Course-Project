using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankRepository;

namespace DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer ivan = Bank.NewCustomer("Ivan Ivanov");
            Bank.SetBalanceObserver(ivan);
            Bank.Deposit(ivan, 1000);
            Bank.RemoveBalanceObserver(ivan);
            Bank.Deposit(ivan, 1000);
            Bank.SetBalanceObserver(ivan);
            Bank.Deposit(ivan, 100);
        }
    }
}
