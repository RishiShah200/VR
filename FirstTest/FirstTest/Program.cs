using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Elminster> list = new List<Elminster>();
            list.Add(new Elminster(("Elminster","Rogue")));
            list.Add(new Elminster(("Elminster", "Fighter")));
            list.Add(new Elminster(("Elminster", "Cleric")));

            foreach (Elminster el in list)
            {
                Console.WriteLine(el);
                el.AddExperience(10000);
            }

            list.ElementAt(2).AddExperience(-9500);


            foreach (Elminster el in list)
            {
                Console.WriteLine(el);
            }
        }
    }
}
