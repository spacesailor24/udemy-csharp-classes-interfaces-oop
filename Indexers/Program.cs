using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Wyatt";

            Console.WriteLine(cookie["name"]);
        }
    }
}