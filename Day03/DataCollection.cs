using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    internal class DataCollection
    {
        public static void InitList()
        {
            var alfabet = new List<string> { "A", "B", "C", "D", "E" };
            alfabet.Add("F");
            alfabet.AddRange(new[] { "G, H", "I"});
            alfabet.Insert(0, "a");
            alfabet.InsertRange(3, new[] { "X", "Y" });

            foreach (var item in alfabet)
            {
                Console.Write(item + " ");
            }

            var number = new List<int>() { 2, 5, 7, 11, 13, 17, 23 };

            number.Add(1);
            number.Remove(1);
            number.Add(10);
            number.Add(12);

            number.RemoveAll(number => number % 2 == 0);

            //find element
            var lessThan10 = number.Find(e => e < 10);
        }

        public static void InitStack()
        {
            //var numbers = new Stack<new int[] { 1, 2, 3 } >;
        }

        public static void InitDictionary()
        {
            var pl = new Dictionary<int, string>();
            pl.Add(1, "C#");
            pl.Add(2, "Java");

            var pl2 = new Dictionary<int, string>()
            {
                {1, "Oracle" },
                {2, "Sql Server" },
                {3, "MySql" }
            };

            pl2.TryAdd(3, "Postgres");
            pl[3] = "Postgresql";
            foreach (var item in pl2)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        public static void InitHashSet()
        {
            HashSet<int> numbers = new HashSet<int>() { 1, 2, 4, 5, 6, 7};
            numbers.Add(5);
            numbers.Add(10);

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
