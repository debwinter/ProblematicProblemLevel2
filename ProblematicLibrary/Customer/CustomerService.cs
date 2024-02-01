using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicLibrary.Customer
{
    public static class CustomerService
    {
        public static Customer CreateCustomer(string firstName, string lastName, int age, DateTime dob)
        {
            return new Customer(firstName, lastName, age, dob);
        }

        public static void PrintCustomerData(Customer c)
        {
            Console.WriteLine($"Customer Full-Name: {c.FullName} || Age: {c.Age} || DOB: {c.Dob.ToShortDateString()}");
        }
    }
}
