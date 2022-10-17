using System;

namespace Problem10
{
    internal class Problem10
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3, 4, 2 };

            int number = 2;

            PairsByDifference(arr, number);
        }

        static void PairsByDifference(int[] a, int n)
        {
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for(int j=0; j < a.Length; j++)
                {
                    if(a[i] + n == a[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
