using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1999, 04, 05));

            Console.WriteLine(person.Age);
        }
    }
}