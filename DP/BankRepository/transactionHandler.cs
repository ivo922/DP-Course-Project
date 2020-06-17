using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRepository
{
    internal class TransactionHandler
    {
        private static TransactionHandler _instance;

        private TransactionHandler() { }

        internal static TransactionHandler GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TransactionHandler();
            }
            return _instance;
        }
        /// <summary>
        /// Deposit funds.
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="value"></param>
        internal void Deposit(Customer customer, int value)
        {
            if (value <= 0)
            {
                throw new Exception("Invalid operation. Deposit must have a positive value.");
            }
            else
            {
                int newBalance = customer.GetBalance() + value;
                customer.SetBalance(newBalance);
                customer.Notify();
            }
        }
        /// <summary>
        /// Withdraw funds.
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="value"></param>
        internal void Withdraw(Customer customer, int value)
        {
            if (customer.GetBalance() < value)
            {
                throw new Exception("Invalid operation. Not enough funds in balance.");
            }
            else
            {
                int newBalance = customer.GetBalance() + value;
                customer.SetBalance(newBalance);
                customer.Notify();
            }
        }
    }
}
