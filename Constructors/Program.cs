using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Wyatt");

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}