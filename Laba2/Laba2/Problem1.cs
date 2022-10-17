using System;

namespace Laba2
{
    internal class Problem1
    {

        static int SameCharactersCount (string[] a1, string[] a2)
        {
            int count1 = 0;
            int count2 = 0;
            int count = 0;

            if (a1.Length < a2.Length || a1.Length == a2.Length)
            {
                for (int i = 0; i < a1.Length; i++)
                {
                    if (a1[i] == a2[i] && a1[i] != " ")
                    {
                        count1++;
                    }
                }
                for (int i = a1.Length - 1; i >= 0; i--)
                {
                    if (a1[i] == a2[i] && a1[i] != " ")
                    {
                        count2++;
                    }
                }
            }
            else if(a1.Length > a2.Length)
            {
                for (int i = 0; i < a2.Length; i++)
                {
                    if (a2[i] == a1[i] && a2[i] != " ")
                    {
                        count1++;
                    }
                }
                for (int i = a2.Length - 1; i >= 0; i--)
                {
                    if (a2[i] == a1[i] && a2[i] != " ")
                    {
                        count2++;
                    }
                }
            }

           
            if(count1 > count2)
            {
                count = count1;
            }
            else
            {
                count = count2;
            }

            return count;
            
        }

        static void Main(string[] args)
        {
            string[] arr1 = { "hi", " ", "php", " ", "java", " ",  "csharp", " ", "sql", " ", "html", " ", "css", " ", "js" };
            string[] arr2 = { "hi", " ", "php", " ", "java", " ", "js", " ",  "softuni", " ", "nakov", " ", "java", " ", "learn" };

            Console.WriteLine(SameCharactersCount(arr1, arr2));

        }
    }
}
