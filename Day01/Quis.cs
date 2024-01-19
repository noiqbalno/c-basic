using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class Quis
    {
        public static void Satu()
        {
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }



            for (int k = 0; k < n; k++)
            {
                for (int l = n; l >= 0; l--)
                {
                    if (l > k)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void Dua()
        {
            Console.Write("Input jumlah baris piramid: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int k = 0; k < n; k++)
            {
                for (int l = n; l >= 0; l--)
                {
                    if (l > k)
                    {
                        Console.Write(l - k);
                    }
                    else
                    {
                        Console.Write("");
                    }

                }
                for (int l = 0; l < n; l++)
                {
                    if (l > k)
                    {
                        Console.Write(l - k + 1);
                    }

                }
                Console.WriteLine();
            }
        }

        public static void Tiga(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if(MathCase.IsPrimeNumber(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void Empat(int n)
        {
            for (int i = 1; i <= n / 2; i++)
            {
                if(n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void Lima(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                { 
                    if(j % 2 != 0)
                    {
                        Console.Write(i);
                    } else
                    {
                        Console.Write(n-i + 1);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Enam(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                   if(j % 2 == 0 && i % 2 != 0)
                    {
                        Console.Write(j);
                    } else
                    {
                        if(i % 2 == 0 && j % 2 !=0)
                        {
                            Console.Write(j);
                        } else
                        {
                            Console.Write("-");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Tujuh(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                        
                }
                if (sum == i)
                {
                    Console.WriteLine(i + " ");
                }
                    
            }

        }

        public static bool Delapan(int n)
        {
            int length = n.ToString().Length;
            string strN = n.ToString();

            for (int i = 0; i < length; i++)
            {
                if (strN[i] != strN[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }


    }
}
