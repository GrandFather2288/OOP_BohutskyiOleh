using System;

namespace Problem9
{
    internal class Problem9
    {
        static void Main(string[] args)
        {
            char[] arr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] arr1 = { 's', 'o', 'f', 't', 'u', 'n', 'i' };

            IndexOfLetters(arr, arr1);
        }

        static void IndexOfLetters(char[] a, char[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (b[i] == a[j])
                    {
                        Console.WriteLine(b[i] + "->" + j);
                    }
                }
            }
        }
    }
}
