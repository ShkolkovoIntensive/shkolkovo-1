using System;
namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());


           
            int D = b * b - 4 * a * c;
            
            if (D<0)
                { Console.WriteLine("No roots"); }
            else if (D==0)
                {
                double x = -1 * b / (2 * a);
                Console.WriteLine("Root x = {0}", x);
            }
            else
            { 
                    double x1 = (-1 * b  + Math.Sqrt(D))/(2*a);
                    double x2 = (-1 * b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("First root x1 = {0}; Second root x2 = {1}", x1, x2); 
            } 

        }
    }
}
