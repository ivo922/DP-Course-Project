using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRepository
{
    internal class BalanceObserver : IObserver
    {
        public void Update(int balance)
        {
            Console.WriteLine("New balance is {0}.", balance);
        }
    }
}
