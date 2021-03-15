using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxTestTaskLibrary
{
    public class Triangle : ShapeBase
    {
        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }
        public double Perimeter { get; private set; }
        
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            CheckExistence();
            Perimeter = Side1 + Side2 + Side3;
        }
        protected override void CheckExistence()
        {
            if (
                   Side1 <= 0
                || Side2 <= 0
                || Side3 <= 0
                || Side1 + Side2 < Side3
                || Side2 + Side3 < Side1
                || Side1 + Side3 < Side2                
              )
                throw new Exception("No such triangle exists");
        }
        public override double GetSquare()
        {
            var SemiPerimeter = Perimeter / 2;
            return Math.Sqrt(
                SemiPerimeter
                * (SemiPerimeter - Side1)
                * (SemiPerimeter - Side2)
                * (SemiPerimeter - Side3)
                );
        }
        public bool IsRightTriangle()
        {
            return (Math.Pow(Side1, 2) + Math.Pow(Side2, 2) == Math.Pow(Side3, 2))
                || (Math.Pow(Side1, 2) + Math.Pow(Side3, 2) == Math.Pow(Side2, 2))
                || (Math.Pow(Side2, 2) + Math.Pow(Side3, 2) == Math.Pow(Side1, 2));
        }
    }
}
