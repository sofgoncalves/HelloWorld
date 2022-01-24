using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.WriteLine($"Hello {name}.");
        }
    }
}
