using System;
using System.Globalization;

namespace shkolkovo
{
    class Program
    {
        static void Main(string[] args)
        {
            var dividend = TryGetDoubleNumber("divisible value");
            var divider  = TryGetDoubleNumber("divisor");

            Console.WriteLine(divider == 0 ? "You can't divide by zero!" : $"Result: {dividend / divider}");

            double TryGetDoubleNumber(string msg)
            {
                Console.Write($"Enter the {msg}: ");
                var value = Console.ReadLine().Trim().Replace(',', '.');
                var parseResult = 
                    double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out var number);

                if (parseResult == false)
                    throw new FormatException("You entered incorrect data!");

                return number;
            }
        }
    }
}
