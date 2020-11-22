using System;

namespace shkolkovo
{
    class Program
    {
        static void Main()
        {
            Console.Write("Write your name: ");             
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");
        }
    }
}
