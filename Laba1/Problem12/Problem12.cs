using System;

namespace Problem12
{
    internal class Problem12
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool result;

            if (n > 20 && n % 2 == 1)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Console.WriteLine(result);
        }
    }
}
