using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class CustomerFactory
    {
        public BaseCustomer GetObject(int choice)
        {
            switch (choice)
            {
                case (int)Options.Customer:
                    return new Customer();
                    case (int)Options.Visitor:
                    return new Visitor();
               
            }
            return null;
        }
    }
}
