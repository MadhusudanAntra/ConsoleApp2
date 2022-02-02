using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*
     * you can not inherit a constructor
     * you can not override a constructor
     * derive class constructor automatically calls the base class parameterless constructor
     */
    class Employee
    {
        //public Employee()
        //{
        //    Console.WriteLine("this is base class without parameter constructor");
        //}
        public Employee(string employerName)
        {
            Console.WriteLine("Employer Name  = "+ employerName);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
        public string Mobile { get; set; }
        protected void AddEmployee()
        {
            Console.Write("Enter Id = ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name = ");
            Name = Console.ReadLine();

            Console.Write("Enter Dept Id = ");
            DeptId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Mobile = ");
            Mobile = Console.ReadLine();
        }
        protected void PrintEmployee()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Mobile = " + Mobile);
            Console.WriteLine("DeptId  = " + DeptId);
        }
    }
    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee():base("Antra")
        {

        }
        public decimal Salary { get; set; }
        public string Benefits { get; set; }
        public void AddFullTimeEmployee()
        {
            AddEmployee();
            Console.Write("Enter Salary = ");
            Salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter benefits = ");
            Benefits = Console.ReadLine();

        }
        public void PrintFullTimeEmployee()
        {
            PrintEmployee();
            Console.WriteLine("Salary = " + Salary);
            Console.WriteLine("Benefits = " + Benefits);
        }

    }

}
