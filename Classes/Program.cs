using System;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string introduceTo)
        {
            Console.WriteLine("Hi {0}, I am {1}", introduceTo, Name);
        }

        // Declaring this method as static, allows us to directly call this
        // method WITHOUT having to instanciate an instance
        public static Person Parse(string str)
        {
            var person = new Person();

            person.Name = str;

            return person;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var person2 = Person.Parse("John"); // Notice how Parse can be called on the Person class itsself

            person.Name = "Cindy";
            person.Introduce("John");
            
            person2.Introduce("Cindy");
        }
    }
}