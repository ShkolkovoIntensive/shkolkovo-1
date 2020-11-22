using System;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a symbol: ");
            var letter = Console.Read();
            var nextLetter = (char)(letter + 1);
            Console.WriteLine($"The next character is {nextLetter}");
        }
    }
}
