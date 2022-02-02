using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Dashboard
    {
        public void Run()
        {
            Menu menu = new Menu();
            int c = menu.Print();
            CustomerFactory customerFactory = new CustomerFactory();
            BaseCustomer baseCustomer = customerFactory.GetObject(c);
            if (baseCustomer != null)
            {
                baseCustomer.LogInformation();
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
        }
    }
}
