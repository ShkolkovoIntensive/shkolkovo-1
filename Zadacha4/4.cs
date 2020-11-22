using System;
namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = TryGetNumber("A");
            var b = TryGetNumber("B");
            var c = TryGetNumber("C");

            // Лучше сделать свой Exception.
            if (a == 0) throw new Exception("The coefficient A cannot be zero in a quadratic equation.");

            var d = b * b - 4 * a * c;

            if (d <= 0)
            {
                var x = -b / (2.0 * a);
                Console.WriteLine(d < 0 ? "No roots." : $"X = {x}.");
            }
            else
            {
                var x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                var x2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                Console.WriteLine($"X1 = {x1}.\nX2 = {x2}.");
            }

            int TryGetNumber(string msg)
            {
                Console.Write($"Enter the coefficient {msg}: ");
                var value = Console.ReadLine();

                if (int.TryParse(value, out var number) == false)
                    throw new FormatException("You entered incorrect data!");

                return number;
            }
        }
    }
}
