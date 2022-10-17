using System;

namespace Problem8
{
    internal class Problem8
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            MostFrequentNumber(arr);
        }

        static void MostFrequentNumber(int[] a)
        {
            int count = 0;
            int maxCount = 0;
            int number = 0;

            for(int i = 0; i < a.Length-1; i++)
            {
                count = 0;
                for (int j = 0; j < a.Length-1; j++)
                {
                    if(a[i] == a[j])
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            number = a[i];
                        }
                    }
                }
            }

            Console.WriteLine("The number " + number + " is the most frequent (occurs " + maxCount + " times)");

        }
    }
}
