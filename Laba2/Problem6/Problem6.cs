using System;
using System.Collections.Generic;

namespace Problem6
{
    internal class Problem6
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 1, 5, 2, 2, 6, 3, 3 };

            MaxEqualElem(arr);
        }

        static void MaxEqualElem(int[] a)
        {
            int count = 0;
            int maxCount = 0;
            int number = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] == a[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        number = a[i];
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int i = 0; i <= maxCount; i++)
            {
                Console.Write(number + " ");
            }

        }

     }
 }

