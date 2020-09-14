using System;
using System.Collections.Generic;
using System.Linq;

namespace EquilateralPolygon
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Square> list = new List<Square>();
            list.Add(new Square(1.0));
            list.Add(new Square(2.0));
            list.Add(new Square(6.0));
            list.Add(new Square(4.0));
            list.Add(new Square(10.0));
            list.Add(new Square(0.5));

            double sum = PerimeterSum(list);

            Console.WriteLine("The sum of all the perimeters is: {0}",sum);
            Console.WriteLine("The shape at index {0} has the largest area", LargestSquare(list));
        }

        static double PerimeterSum(List<Square> list)
        {
            double sum = 0;
            foreach(Square sq in list)
            {
                Console.WriteLine(sq.ToString());
                sum += sq.Perimeter;
            }

            return sum;
        }

        static int LargestSquare(List<Square> list)
        {
            int index = 0;
            for(int x = 0; x < list.Count - 1; x++)
            {
                if(list.ElementAt(x).Area > list.ElementAt(x + 1).Area)
                {
                    index = x;
                }
            }
            return index;
        }
    }
}
