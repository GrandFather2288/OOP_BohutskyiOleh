using System;
using System.Linq;

namespace Problem2
{
    internal class Problem2
    {
        static int Rotate(int[] arr)
        {
            int last = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                last = arr[arr.Length - 1];
            }

            for(int i = arr.Length-1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = last;

            return arr[arr.Length-1];
        }

        static void Main(string[] args)
        {
            int[] arr1 = new int[] {3, 2, 4, -1};
            int[] sum = new int[] {0, 0, 0, 0};

            Console.Write("Count of rotations: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Array: ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < k; i++)
            {
                Rotate(arr1);
                Console.Write("Rotated[" + (i+1) + "]: ");
                for (int l = 0; l < arr1.Length; l++)
                {
                    Console.Write(arr1[l] + " ");
                }
                for (int j = 0; j < arr1.Length; j++)
                {
                    sum[j] += arr1[j];
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Sum: ");

            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
