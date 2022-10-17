using System;

namespace Problem3
{
    internal class Problem3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int count = (arr.Length/2)/2;
            int[] start = new int[] { 0, 0 };
            int[] end = new int[] { 0, 0 };
            int[] startAndEnd = new int[] { 0, 0, 0, 0 };
            int[] middle = new int[] { 0, 0, 0, 0 };
            int[] sum = new int[] { 0, 0, 0, 0 };

            for (int i = 0; i < count; i++)
            {
                start[i] = arr[i];
            }

            for (int i = middle.Length + start.Length; i < arr.Length; i++)
            {
                end[i-6] = arr[i];
            }

            for (int j = count-1, i = 0; i < count; i++, j--)
            {
                startAndEnd[i] = start[j];
            }

            for (int j = 0, i = count-1; i >= 0; i--, j++)
            {
                startAndEnd[i+count] = end[j];
            }

            for (int i = count; i < arr.Length - count; i++)
            {
                middle[i-count] = arr[i];
            }

            for (int i=0; i < sum.Length; i++)
            {
                sum[i] = startAndEnd[i] + middle[i];
            }

            for (int i = 0; i < startAndEnd.Length; i++)
            {
                Console.Write(sum[i] + " ");
            }


        }
    }
}
