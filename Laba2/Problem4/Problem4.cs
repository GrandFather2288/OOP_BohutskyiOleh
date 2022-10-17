using System;

namespace Problem4
{
    internal class Problem4
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num-1];
            int[] res = new int[num-1];

            for (int i = 2; i <= num; i++)
            {
                arr[i-2] = i;
            }

            for (int i = 0; i < num - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < num-1; i++)
            {
                if (((arr[i] > 2) && (arr[i] % 2 == 0)) || ((arr[i] > 3) && (arr[i] % 3 == 0)) || ((arr[i] > 5) && (arr[i] % 5 == 0)))
                {
                    res[i] = arr[i];
                }
            }

            for (int i = 0; i < res.Length; i++)
            {
                if (res[i] == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }

        }
    }
}
