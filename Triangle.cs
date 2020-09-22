using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv2
{
    class Triangle : IShape
    {
        private double width;
        private double height;

        public Triangle(double w, double h) : base()
        {
            width = w;
            height = h;
        }

        public void AreaCalc()
        {
            double area = (width * height) / 2;

            Console.WriteLine("area: " + area);
        }

        public void CircumferenceCalc()
        {
            double x = (width * width) + (height * height);

            double hyp = Math.Sqrt(x);

            double circumference = width + height + hyp;

            Console.WriteLine("circumference: " + circumference);
        }
    }
}
