using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Rishi","brown",5000);
            p.LastName = "Shah";
            p.YearsAlive = 10;
            Console.WriteLine(p.YearsAlive);
        }
    }
}


//Delegates. Save arraylist into method.