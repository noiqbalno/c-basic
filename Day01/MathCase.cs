using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class MathCase
    {
        public static void SetLocalVariable()
        {
            //primitive data type
            int population = 10_000;
            double weight = 1.99;
            decimal price = 4.99M;
            long myId = 1L;

            string fruit = "Orange";
            char letter = 'A';
            bool isGraduated = true;
        }
        public static void ShowMultiplePrint()
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Dotnet");

            //02
            Console.WriteLine("code academy" + "bootcamp .net");

            Console.WriteLine("Code Academy \n Cool Dotnet");

            //03 verbatim
            Console.WriteLine(@"Bootcamp .Net with
                Code academy
            ");

            //04
            Console.WriteLine("Temperature di sentul tanggal {0}, suhu: {1} celcius", DateTime.Today, 20.0);

            Console.WriteLine($"Today is : {0}", DateTime.Today);
        }

        public static void FizzBuzz(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} Fizz Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        //case 4 : input bilangan 3 digit lalu konversi ke dollar
        //    input : 750000, output : $50=10, $10=0, $5=1

        public static void ATM()
        {
            int digit1, digit2, digit3, sisa;

            Console.WriteLine("Enter money: ");
            int money = Convert.ToInt32(Console.ReadLine());

            digit1 = money / 50_000;
            sisa = money % 50_000;

            digit2 = sisa / 10_000;
            sisa = sisa % 10_000;

            digit3 = sisa / 5_000;
            sisa = sisa % 5_000;

            Console.WriteLine($"50={digit1} $10={digit2} $5={digit3} sisa={sisa}");
        }

        public static bool IsPrimeNumber(int n)
        {
            for (int i = 2; i <= n/2; i++)
            {
                if(n% i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Fibonacchi(int n)
        {
            int first, second, fibo;

            first = 0;
            second = 1;

            for (int i = 0; i < n; i++)
            {
                fibo = first + second;
                first = second;
                second = fibo;

                Console.WriteLine($"{fibo} ");
            }
        }
     }
}
