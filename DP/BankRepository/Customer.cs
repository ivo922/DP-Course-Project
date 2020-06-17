using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRepository
{
    public class Customer
    {
        internal List<IObserver> observersList = new List<IObserver>();

        private string name;
        private int balance;
        internal Customer(string name)
        {
            this.name = name;
            balance = 0;
        }
        /// <summary>
        /// Gets the current balance.
        /// </summary>
        /// <returns></returns>
        internal int GetBalance()
        {
            return balance;
        }
        /// <summary>
        /// Sets the balance to a given value.
        /// </summary>
        /// <param name="value"></param>
        internal void SetBalance(int value)
        {
            if (value < 0)
            {
                throw new Exception("Invalid operation. Balance can't be a negative value.");
            }
            else
            {
                balance = value;
            }
        }
        /// <summary>
        /// Attaches an observer of the given type. If an observer of that type exists, does nothing.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal void Attach<T>() where T : new()
        {
            bool isTExists = false;
            foreach (IObserver item in observersList)
            {
                if (item is T)
                {
                    isTExists = true;
                    break;
                }
            }
            if (!isTExists)
            {
                observersList.Add((IObserver)new T());
            }
        }

        /// <summary>
        /// Detaches an observer from the object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        internal void Detach<T>()
        {
            foreach (IObserver item in observersList)
            {
                if (item is T)
                {
                    observersList.Remove(item);
                    break;
                }
            }
        }
        /// <summary>
        /// Updates all observers.
        /// </summary>
        internal void Notify()
        {
            foreach (BalanceObserver o in observersList)
            {
                o.Update(this.balance);
            }
        }
    }
}
