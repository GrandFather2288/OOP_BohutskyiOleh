using System;

namespace Problem11
{
    internal class Problem11
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCheck = number;

            int i = 0;
            while (numberCheck > 0)
            {
                i++;
                numberCheck /= 10;
            }

            int n = int.Parse(Console.ReadLine());
            int nDigit = (number / ((int)Math.Pow(10, n - 1))) % 10;

            if (i < n)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.Write(nDigit);
            }
        }
    }
}
