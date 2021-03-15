using System;
using System.Collections.Generic;
using System.Text;

namespace MindboxTestTaskLibrary
{
    public class Circle : ShapeBase
    {
        private const double PI = Math.PI;
        public double Radius { get; private set; }
        public Circle (double radius)
        {
            Radius = radius;
            CheckExistence();
        }
        protected override void CheckExistence()
        {
            if (Radius < 0) throw new Exception("No such circle exists");
        }
        public override double GetSquare()
        {
            return PI * Math.Pow(Radius,2);
        }
    }
}
