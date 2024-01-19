using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day02
{
    internal class QuisArray
    {
        public static void SoalSatu(string str)
        {
            List<char> same = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }

                if (count > 0 && !same.Contains(str[i]))
                {
                    same.Add(str[i]);
                }
            }

            foreach (char c in same)
            {
                Console.Write(c);
            }
        }

        public static void SoalDua(string str)
        {
            string[] text = str.Split(' ');
            
            for (int i = 0;i < text.Length;i++)
            {
                string currentText = text[i];

                for (int j = 0; j < text[i].Length; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(currentText[j].ToString().ToUpper());
                    } else
                    {
                        Console.Write(currentText[j]);
                    }
                }
                Console.Write(" ");
            }
        }

        public static void SoalTiga(string[] str, string except)
        {
            string[] text = str;

            for (int i = 0; i < text.Length; i++)
            {
                string currentText = text[i];

                for (int j = 0; j < text[i].Length; j++)
                {
                    if (j == 0)
                    {
                        if(currentText != except)
                        {
                            Console.Write(currentText[j].ToString().ToUpper());
                        } else
                        {
                            Console.Write(currentText[j]);
                        }
                    }
                    else
                    {
                        Console.Write(currentText[j]);
                    }
                }
                Console.Write(" ");
            }
        }

        public static bool SoalEmpat(string str)
        {
            string newStr = str;
            int countL = 0;
            int countR = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (newStr[i].ToString() == "(".ToString())
                {
                    countL++;
                }
                if (newStr[i].ToString() == ")".ToString())
                {
                    countR++;
                }
            }

            if (countL != countR)
            {
                return false;
            }

            return true;
        }

        public static void SoalLima(int[] numbers)
        {
            int min = 0;
            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"{min}, {max}");
        }

        public static void SoalEnamMin(int[] numbers, int minI, int maxI)
        {
            int iResult = minI;
            int min = numbers[minI];

            for (int i = 0; i < numbers.Length; i++)
            {
                if(i >= minI && i <= maxI)
                {
                    if (numbers[i] < min) { 
                        min = numbers[i];
                        iResult = i;
                    }
                }
            }

            Console.WriteLine($"{min}, {iResult}");
        }

        public static void SoalEnamMax(int[] numbers, int minI, int maxI)
        {
            int iResult = maxI;
            int max = numbers[maxI];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i >= minI && i <= maxI)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                        iResult = i;
                    }
                }
            }

            Console.WriteLine($"{max}, {iResult}");
        }

        public static void SoalTujuh(int[] numbers)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0;i < numbers.Length;i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even.Add(numbers[i]);
                }
                if (numbers[i] % 2 != 0)
                {
                    odd.Add(numbers[i]);
                }
            }

            foreach (int i in even)
            {
                Console.Write(i + " ");
            }
            foreach (var i in odd)
            {
                Console.Write(i + " ");
            }
        }

        public static void SoalDelapan(int[] numbers)
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                if (numbers[i] < 9)
                {
                    numbers[i] += 1;
                    break;
                }
                else
                {
                    numbers[i] = 0;
                }
            }

            if (numbers[0] == 0)
            {
                int[] newNumbers = new int[numbers.Length + 1];
                newNumbers[0] = 1;

                foreach (var item in newNumbers)
                {
                    Console.Write(item + " ");
                }
            } else
            {
                foreach (var item in numbers)
                {
                    Console.Write(item + " ");
                }
            }

        }

        public static void SoalSembilan(int[] numbers, int rotate)
        {
            int currentI = 0;
            int[] numbersTwo = new int[numbers.Length];

            for (int i = rotate; i < numbers.Length; i++)
            {
                numbersTwo[currentI] = numbers[i];
                currentI++;
            }

            for (int i = 0; i < rotate; i++)
            {
                numbersTwo[currentI] = numbers[i];
                currentI++;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbersTwo[i] + " ");
            }
        }

        public static void DisplayArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }


    }
}
