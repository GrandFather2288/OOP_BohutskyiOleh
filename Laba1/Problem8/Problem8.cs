using System;

namespace Problem8
{
    internal class Problem8
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double average = (Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c)) / 3;

            Console.WriteLine(average);
        }
    }
}
