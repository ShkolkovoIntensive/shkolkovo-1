using System;

namespace shkolkovo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two numbers, then first will be divided on second ");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            
            bool success = double.TryParse(a, out double c) & double.TryParse(b, out double d);
            if (d==0)
            { Console.WriteLine("You can't divide by zero"); }
            else if (success)
                { Console.WriteLine("Result: {0}", c / d); }
            else
            { Console.WriteLine("Input the number"); }

        }
    }
}