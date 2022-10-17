using System;

namespace Problem9
{
    internal class Problem9
    {
        static void Main(string[] args)
        {
            double a = Double.Parse(Console.ReadLine());
            double b = Double.Parse(Console.ReadLine());
            double h = Double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;

            Console.WriteLine(area);
        }
    }
}
