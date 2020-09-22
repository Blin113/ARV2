using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv2
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape obj;

            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Circle");

            string Choice = Console.ReadLine();
            Console.Clear();

            switch (Choice)
            {
                case "1":
                    Console.WriteLine("insert width:");
                    double width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height:");
                    double height = double.Parse(Console.ReadLine());

                    obj = new Rectangle(width, height);

                    obj.AreaCalc();
                    obj.CircumferenceCalc();

                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                case "2":
                    Console.WriteLine("insert width:");
                    width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height:");
                    height = double.Parse(Console.ReadLine());

                    obj = new Triangle(width, height);

                    obj.AreaCalc();
                    obj.CircumferenceCalc();

                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                case "3":
                    Console.WriteLine("insert diameter:");
                    double diameter = double.Parse(Console.ReadLine());

                    obj = new Circle(diameter);

                    obj.AreaCalc();
                    obj.CircumferenceCalc();

                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                default:
                    Console.WriteLine("try again");
                    Main(null);
                    break;

            }

        }
    }
}