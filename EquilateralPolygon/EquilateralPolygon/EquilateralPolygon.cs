using System;
using System.Collections.Generic;
using System.Text;

namespace EquilateralPolygon
{
    public class EquilateralPolygon
    {

        public int Sides { get; set; }
        public double SideLength { get; set; }

        public EquilateralPolygon(int sides, double sideLength)
        {
            Sides = sides;
            SideLength = sideLength;
        }

    }

    class Square : EquilateralPolygon
    {
        public double Area
        {
            get
            {
                return SideLength * SideLength;
            }
        }

        public double Perimeter
        {
            get
            {
                return 4.0 * SideLength;
            }
        }
        public Square(double sideLength)
            :base(4,sideLength)
        {}

        public override string ToString()
        {
            return String.Format("Sides: {0}, Side Length: {1}, Area: {2}, Perimeter {3}", Sides, SideLength, Area, Perimeter);
        }


    }
    
}
