using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRepository
{
    public static class Bank
    {
        static TransactionHandler th = TransactionHandler.GetInstance();

        /// <summary>
        /// Adds a BalanceObserver to the customer.
        /// </summary>
        /// <param name="c">Customer object</param>
        public static void SetBalanceObserver(Customer c)
        {
            BalanceObserver o = new BalanceObserver();
            //c.Attach<BalanceObserver>(o);
            c.Attach<BalanceObserver>();
        }

        /// <summary>
        /// Removes a BalanceObserver from the customer.
        /// </summary>
        /// <param name="c">Customer object</param>
        public static void RemoveBalanceObserver(Customer c)
        {
            c.Detach<BalanceObserver>();
        }

        /// <summary>
        /// Returns a new instance of the Customer class.
        /// </summary>
        /// <param name="name">Name of the customer</param>
        /// <returns>Customer</returns>
        public static Customer NewCustomer(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Invalid name.");
            }
            else
            {
                Customer c = new Customer(name);
                return c;
            }
        }

        /// <summary>
        /// Deposits funds.
        /// </summary>
        /// <param name="c">Customer object</param>
        /// <param name="value">Integer value</param>
        public static void Deposit(Customer c, int value)
        {
            th.Deposit(c, value);
        }
        /// <summary>
        /// Withdraw funds.
        /// </summary>
        /// <param name="c">Customer object</param>
        /// <param name="value">Integer value</param>
        public static void Withdraw(Customer c, int value)
        {
            th.Withdraw(c, value);
        }
    }
}
