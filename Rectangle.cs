using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv2
{
    class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double w, double h) : base()
        {
            width = w;
            height = h;
        }

        public void AreaCalc()
        {
            double area = width * height;

            Console.WriteLine("area: " + area);
        }

        public void CircumferenceCalc()
        {
            double circumference = (width * 2) + (height * 2);

            Console.WriteLine("circumference: " + circumference);
        }
    }
}