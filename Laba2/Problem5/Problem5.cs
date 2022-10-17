using System;

namespace Problem5
{
    internal class Problem5
    {
        static void Main(string[] args)
        {
            char[] arr1 = { 'p', 'e', 't', 'e', 'r' };
            char[] arr2 = { 'a', 'n', 'n', 'i', 'e' };

            Compare(arr1, arr2);
        }

        static void Compare(char[] a, char[] b)
        {
            int n;
            int sameChar = 0;

            //length check
            if(a.Length > b.Length)
            {
                n = b.Length;
            }
            else if(a.Length < b.Length)
            {
                n = a.Length;
            }
            else
            {
                n = a.Length;
            }

                for (int i = 0; i < n; i++)
                {
                    if (a[i] == b[i])
                    {
                        sameChar++;
                    }
                    else
                    {
                        if (a[i] < b[i])
                        {
                            for (int j = 0; j < a.Length; j++)
                            {
                                Console.Write(a[j]);
                            }

                            Console.WriteLine();

                            for (int j = 0; j < b.Length; j++)
                            {
                                Console.Write(b[j]);
                            }
                        }
                        else
                        {
                            for (int j = 0; j < b.Length; j++)
                            {
                                Console.Write(b[j]);
                            }

                            Console.WriteLine();

                            for (int j = 0; j < a.Length; j++)
                            {
                                Console.Write(a[j]);
                            }
                        }
                        break;
                    }
                }

                if (sameChar == n)
                {
                    if (a.Length == n)
                    {
                        for (int j = 0; j < a.Length; j++)
                        {
                            Console.Write(a[j]);
                        }

                        Console.WriteLine();

                        for (int j = 0; j < b.Length; j++)
                        {
                            Console.Write(b[j]);
                        }
                    }
                    else if (b.Length == n)
                    {
                        for (int j = 0; j < b.Length; j++)
                        {
                            Console.Write(b[j]);
                        }

                        Console.WriteLine();

                        for (int j = 0; j < a.Length; j++)
                        {
                            Console.Write(a[j]);
                        }
                    }
                }
        }

    }
}
