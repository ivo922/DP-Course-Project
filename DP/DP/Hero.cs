using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Customer
    {
        private int id;
        private string name;
        private static List<string> customersList = new List<string>();

        private Customer(String name)
        {
            if (customersList.Count != 0)
            {
                this.id = customersList.Count + 1;
            }
            else
            {
                this.id = 1;
            }
            this.name = name;
            customersList.Add(this);
        }

        public void createCustomer(String name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                Customer customer = new Customer(name);
            }
            else
            {
                Console.WriteLine("Invalid name.");
            }

        }
    }
}
