using System;

namespace Problem10
{
    internal class Problem10
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n % 10;

            Console.WriteLine(lastDigit);

        }
    }
}
