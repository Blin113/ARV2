using System;
using System.Collections.Generic;
using System.Text;

namespace Arv2
{
    class Circle : IShape
    {
        private double diameter;

        public Circle(double d) : base()
        {
            diameter = d;
        }

        public void AreaCalc()
        {
            double r = diameter / 2;

            double area = r*r*Math.PI;

            Console.WriteLine("area: " + area);
        }

        public void CircumferenceCalc()
        {
            double r = diameter / 2;

            double circumference = 2*r*Math.PI;

            Console.WriteLine("circumference: " + circumference);
        }
    }
}
