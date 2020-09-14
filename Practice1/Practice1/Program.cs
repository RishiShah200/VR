using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> myList = MakeList();
            var myTuple = AverageAndTotalNums(myList);
            Console.WriteLine("Average of List: {0} \nTotal Nums: {1}", myTuple.Item1, myTuple.Item2);
            FindLongestString();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Math", "Dentler");
            dictionary.Add("Language", "Kostovny");
            dictionary.Add("Computer Science", "Schiff");
            dictionary.Add("Economics", "Galaro");
            dictionary.Add("Gym", "Webb");
            dictionary.Add("English", "Lehre");

            WhatSubjects(dictionary);
            


        }

        public static List<int> MakeList()
        {

            List<int> list = new List<int>();
            int x = 0;
            while (list.Count < 500)
            {
                if (x % 2 == 0 && x % 3 == 0)
                {
                    if (x % 10 != 0)
                    {
                        list.Add(x);
                    }
                }
                x++;
            }
            return list;
        }

        public static (double,int) AverageAndTotalNums(List<int> list)
        {
            int totalNums = 0;
            double average = 0.0;
            int sum = 0;
            foreach (int number in list)
            {
                sum += number;
                totalNums++;
            }
            average = sum / (double)totalNums;

            return (average, totalNums);
        }

        public static List<(string,int)> FindLongestString()
        {
            Console.WriteLine("Enter a string: ");
            string stringOne = Console.ReadLine();

            Console.WriteLine("Enter a string: ");
            string stringTwo = Console.ReadLine();

            Console.WriteLine("Enter a string: ");
            string stringThree = Console.ReadLine();

            Console.WriteLine("Enter a string: ");
            string stringFour = Console.ReadLine();

            List<string> myList = new List<string>();
            myList.Add(stringOne);
            myList.Add(stringTwo);
            myList.Add(stringThree);
            myList.Add(stringFour);

            int longestStringLength = myList.ElementAt(0).Length;
            int index = 0;

            for(int x = 0; x < myList.Count; x++)
            {
                if(myList.ElementAt(x).Length > longestStringLength)
                {
                    longestStringLength = myList.ElementAt(x).Length;
                    index = x;
                }
            }

            string longestString = myList.ElementAt(index);

            myList.RemoveAt(index);

            int secondLongestStringLength = myList.ElementAt(0).Length;
            int anotherIndex = 0;

            for (int x = 0; x < myList.Count; x++)
            {
                if (myList.ElementAt(x).Length > secondLongestStringLength)
                {
                    secondLongestStringLength = myList.ElementAt(x).Length;
                    anotherIndex = x;
                }
            }

            string secondLongestString = myList.ElementAt(anotherIndex);


            List<(string,int)> finalList = new List<(string, int)>();

            finalList.Add((longestString, longestStringLength));
            finalList.Add((secondLongestString, secondLongestStringLength));

            for(int x = 0; x < finalList.Count; x++)
            {
                Console.WriteLine(finalList[x]);
            }

            return finalList;


        }

        public static List<string> WhatSubjects(Dictionary<string,string> dictionary)
        {
            string mathTeacher = "";
            string englishTeacher = "";
            string scienceTeacher = "";

            List<string> teacherList = new List<string>();

            foreach (KeyValuePair<string, string> entry in dictionary)
            {
                if (entry.Key.Equals("Math"))
                {
                    dictionary.TryGetValue("Math", out mathTeacher);
                }

                if (entry.Key.Equals("English"))
                {
                    dictionary.TryGetValue("English", out englishTeacher);
                }

                if (entry.Key.Equals("Science"))
                {
                    dictionary.TryGetValue("Science", out scienceTeacher);
                }
            }

            if(!mathTeacher.Equals(""))
                teacherList.Add(mathTeacher);
            if (!scienceTeacher.Equals(""))
                teacherList.Add(scienceTeacher);
            if (!englishTeacher.Equals(""))
                teacherList.Add(englishTeacher);

            foreach(string element in teacherList)
            {
                Console.WriteLine(element);
            }

            return teacherList;

        }


    }
}
