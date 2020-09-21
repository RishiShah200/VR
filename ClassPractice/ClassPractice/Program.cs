using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string, string)> list = new List<(string, string)>();
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Enter a first and last name with a space: ");
                string[] name = Console.ReadLine().Split(" ");
                list.Add((name[0], name[1]));
            }

            foreach((string,string) tuple in list)
            {
                Console.WriteLine(tuple);
            }

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            for(int x = 0; x < list.Count; x++)
            {
                dictionary.Add(x, list.ElementAt(x).Item1);
            }

            foreach(KeyValuePair<int,string> pair in dictionary)
            {
                Console.WriteLine(pair);
            }
        }
    }
}
