using System;

namespace Problem15
{
    internal class Problem15
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double product = a * b * c;

            if (product >= 0)
            {
                Console.WriteLine("Positive");
            }
            else if (product < 0)
            {
                Console.WriteLine("Negative");
            }
        }
    }
}