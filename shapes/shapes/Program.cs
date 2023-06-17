using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare all shapes
            float width1 = 2;
            float height1 = 8;

            float width2 = 3;
            float height2 = 3;

            // print the details of each shape
            PrintShape("Shape 1", width1, height1);
            PrintShape("Shape 1", width2, height2);
        }
            static void PrintShape(string name, float width, float height)
        {
            Console.WriteLine(name);
            Console.WriteLine($"      Area: {width * height}");
            Console.WriteLine($"      Perimeter: {2 * width + 2  * height}");
        }
    }
}
