using System;

namespace Problem7
{
    internal class Problem7
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 3, 4, 2, 2, 4 };

            MaxEqualIncElem(arr);
        }

        static void MaxEqualIncElem(int[] a)
        {
            int count = 0;
            int maxCount = 0;
            int number = 0;
            int index = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] + 1 == a[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = a[i];
                        index = i;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int j = index - maxCount + 1; j <= index + 1; j++)
            {
                Console.Write(a[j] + " ");
            }

        }

    }

}
