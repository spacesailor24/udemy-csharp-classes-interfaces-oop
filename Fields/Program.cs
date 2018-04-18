using System;

namespace Fields
{
    public class Order
    {
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
        }
    }
}