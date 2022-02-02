using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*
     *  abstract method:-
     *  1. abstract method is method which does not have any implementation. it is defined by
     *   the derived class.
     *  2. abstract method is by default virtual so don't use virutal keyword with it
     *  3. if there is abstract method in the class then the class must be abstract too.
     *  
     *  abstract class
     *   abstract class is a base class which must be inherited by another class.
     *   abstract class can have both abstract and non abstract method (concrete)
     *   abstract class can not be instantiated
     *   abstract class can have constructor, it is called by the derived class constructor
     *   abstract class can have variables, fields and properties.
     *   abstract class supports only single inheritance.
     */
   abstract class BaseCustomer
    {
        public BaseCustomer()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public  abstract void LogInformation();
        public void Demo()
        {
            Console.WriteLine("This is demo method");
        }
        
    }
    class Customer : BaseCustomer
    {
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }

        public override void LogInformation()
        {
            Console.Write("Enter Id = ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name = ");
            Name = Console.ReadLine();

            Console.Write("Enter mobile = ");
            Mobile = Console.ReadLine();
            Console.Write("Enter Total = ");
            TotalAmount = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Discount = ");
            Discount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Net payable = " + (TotalAmount - Discount));
        }
    }
    class Visitor : BaseCustomer
    {
        public string ReasonNotToBuy { get; set; }
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the store");
        }
        public override void LogInformation()
        {
            Console.Write("Enter Id = ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name = ");
            Name = Console.ReadLine();

            Console.Write("Enter mobile = ");
            Mobile = Console.ReadLine();
            Console.Write("Enter reason = ");
            ReasonNotToBuy = Console.ReadLine();
        }
    }
 
}
